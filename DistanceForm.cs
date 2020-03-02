using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CustomerSupplierDistance
{
    public partial class DistanceForm : Form
    {
        List<Point> customers = new List<Point>();
        List<Point> suppliers = new List<Point>();

        //Array of colors that represent the suppliers
        Color[] lineColors = { Color.Red, Color.Teal, Color.SaddleBrown, Color.MediumOrchid, Color.LawnGreen };

        public DistanceForm()
        {
            InitializeComponent();

            distanceChart.Legends[1].Title = "Legend";

            customerListBox.Items.Add("Suppliers");
            CreateFirstLegendItem();
        }
        /// <summary>
        /// Calculates the distance between a supplier and all of the customers. The customer that is closest to the supplier 
        /// will be added to that customer's respective series
        /// </summary>
        /// <param name="supplierX">the suggested supplier's X value</param>
        /// <param name="supplierY">the suggested supplier's Y value</param>
        private void CalculateDistance(Point customer)
        {
            double shortestDistance = double.MaxValue;

            int seriesIndex = 0;
            double customerX = customer.X;
            double customerY = customer.Y;
            double supplierX;
            double supplierY;

            for (int i = 0; i < suppliers.Count; i++)
            {
                supplierX = suppliers[i].X;
                supplierY = suppliers[i].Y;

                double distance = 0;
                if (supplierX > customerX) //determines distance customer point has to supplier
                    distance = Math.Abs(Math.Sqrt(Math.Pow((supplierX - customerX), 2) + Math.Pow((supplierY - customerY), 2)));
                else if (supplierX <= customerX)
                    distance = Math.Abs(Math.Sqrt(Math.Pow((customerX - supplierX), 2) + Math.Pow((customerY - supplierY), 2)));

                if (distance < shortestDistance)
                {
                    shortestDistance = distance;
                    seriesIndex = i;
                }
            }

            supplierX = suppliers[seriesIndex].X;
            supplierY = suppliers[seriesIndex].Y;

            //Draws points and lines
            distanceChart.Series[seriesIndex].Points.AddXY(customerX, customerY);

            distanceChart.Series.Add(customer.Name);

            distanceChart.Series[distanceChart.Series.Count - 1].Points.AddXY(supplierX, supplierY);

            distanceChart.Series[distanceChart.Series.Count - 1].Points.AddXY(customerX, customerY);

            distanceChart.Series[customer.Name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            distanceChart.Series[customer.Name].Color = lineColors[seriesIndex];

            distanceChart.ChartAreas[0].AxisX.ScaleView.ZoomReset(0);
            distanceChart.ChartAreas[0].AxisY.ScaleView.ZoomReset(0);



        }

        /// <summary>
        /// Test if customer's name and coordinates are unique
        /// </summary>
        /// <param name="name">Suggested name</param>
        /// <returns>If the point is valid</returns>
        private bool PointValid(Point point)
        {

            foreach (Point p in customers)
            {
                if (point.Name == p.Name)
                {
                    errorLabel.Text = "Company name is taken";
                    return false;
                }

                if (point.X == p.X && p.Y == point.Y)
                {
                    errorLabel.Text = "Coordinates taken";
                }

            }


            foreach (Point p in suppliers)
            {
                if (point.Name == p.Name)
                {
                    errorLabel.Text = "Company name is taken";
                    return false;
                }

                if (point.X == p.X && p.Y == point.Y)
                {
                    errorLabel.Text = "Coordinates taken";
                }

            }
            
            return true;
        }
        /// <summary>
        /// Adds a supplier or customer to the chart
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void addButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "No Errors";
            
            RecalculateValues(xTextBox);
            RecalculateValues(yTextBox);

            try
            {
                if (xTextBox.Text != "" && yTextBox.Text != "")
                {
                    double x = double.Parse(xTextBox.Text);
                    double y = double.Parse(yTextBox.Text);

                    if (customerRadioButton.Checked)
                    {
                        //Adds customer to the chart
                        Point customer = new Point(x, y, nameTextBox.Text);
                        if (distanceChart.Series.Count > 0 && PointValid(customer) && customers.Count <= 100)
                        {
                            customers.Add(customer);
                            customerListBox.Items.Add(customer.Name);
                            CalculateDistance(customer);
                        }

                        else
                            errorLabel.Text = "Cannot add customer. Check instructions.";

                    }

                    else if (supplierRadioButton.Checked)
                    {
                        Point supplier = new Point(x, y, nameTextBox.Text);

                        if (nameTextBox.Text != "" && PointValid(supplier) && suppliers.Count <= 5)
                        {
                            //Clear chart properties
                            distanceChart.Series.Clear();
                            distanceChart.Legends[1].CustomItems.Clear();
                           
                            CreateFirstLegendItem();

                            
                            suppliers.Add(supplier);


                            for (int i = 0; i < suppliers.Count; i++) //add all suppliers
                            {
                                string name = suppliers[i].Name;

                                distanceChart.Series.Add(name);
                                distanceChart.Series[name].Points.AddXY(suppliers[i].X, suppliers[i].Y);

                                distanceChart.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                                distanceChart.Series[name].BorderWidth = 500;
                                distanceChart.Series[name].Points[0].BorderWidth = 1000000000;

                                distanceChart.Series[name].Color = Color.Blue;

                                distanceChart.Series[name].Points[0].Color = lineColors[i];

                                LegendItem item = new LegendItem();
                                item.Color = lineColors[i];
                                item.BorderColor = lineColors[i];
                                item.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleLeft);
                                item.Cells.Add(LegendCellType.Text, name, ContentAlignment.MiddleCenter);

                                distanceChart.Legends[1].CustomItems.Add(item);

                            }
                            //Calculate distance for each customer to see what supplier they get
                            foreach (Point c in customers)
                                CalculateDistance(c);

                        }
                    }

                }

            }
            catch (Exception ex)
            {
                errorLabel.Text = "Please enter a valid value";
            }

        }
        /// <summary>
        /// Creates the first item in the legend that will show suppliers
        /// </summary>
        public void CreateFirstLegendItem()
        {
            LegendItem item = new LegendItem();
            item.Color = Color.Blue;
            item.BorderColor = Color.Blue;
            item.Cells.Add(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleLeft);
            item.Cells.Add(LegendCellType.Text, "Customers", ContentAlignment.MiddleCenter);
            distanceChart.Legends[1].CustomItems.Add(item);
        }
        /// <summary>
        /// Handles a textbox. Does not allow any non-numeric numbers.
        /// Additionally, only allows one decimal place in a proper position.
        /// Sets the values of x and y if it is handled
        /// </summary>
        /// <param name="e">the keypress eveent</param>
        /// <param name="textBox">The text box that the event occurs</param>
        /// <param name="sender">Sender</param>
        /// <returns>if the </returns>
        public bool HandleTextBox(KeyPressEventArgs e, TextBox textBox, object sender)
        {
            // Digits only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // One decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            return e.Handled;

        }
        /// <summary>
        /// Event handler for yTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = HandleTextBox(e, yTextBox, sender);
            if (!e.Handled)
                RecalculateValues(yTextBox);

        }
        /// <summary>
        /// Event handler for xTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = HandleTextBox(e, xTextBox, sender);
            if (!e.Handled)
                RecalculateValues(xTextBox);
        }
        /// <summary>
        /// Takes any value above 500, and makes it 500
        /// </summary>
        /// <param name="textBox"></param>
        public void RecalculateValues(TextBox textBox)
        {
            double num;
            if (double.TryParse(textBox.Text, out num))
            {

                if (num > 500)
                {
                    textBox.Text = "";
                    textBox.Text = "500";
                }


            }
        }


    }
}

