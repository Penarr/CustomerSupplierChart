namespace CustomerSupplierDistance
{
    partial class DistanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.errorLabel = new System.Windows.Forms.Label();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.customerRadioButton = new System.Windows.Forms.RadioButton();
            this.supplierRadioButton = new System.Windows.Forms.RadioButton();
            this.distanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.controlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(15, 354);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(51, 13);
            this.errorLabel.TabIndex = 1;
            this.errorLabel.Text = "No Errors";
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.yTextBox);
            this.controlGroupBox.Controls.Add(this.xTextBox);
            this.controlGroupBox.Controls.Add(this.label2);
            this.controlGroupBox.Controls.Add(this.label1);
            this.controlGroupBox.Controls.Add(this.addButton);
            this.controlGroupBox.Controls.Add(this.nameLabel);
            this.controlGroupBox.Controls.Add(this.nameTextBox);
            this.controlGroupBox.Controls.Add(this.customerRadioButton);
            this.controlGroupBox.Controls.Add(this.supplierRadioButton);
            this.controlGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.controlGroupBox.Location = new System.Drawing.Point(8, 127);
            this.controlGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.controlGroupBox.Size = new System.Drawing.Size(201, 224);
            this.controlGroupBox.TabIndex = 3;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Controls";
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(116, 84);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(72, 23);
            this.yTextBox.TabIndex = 9;
            this.yTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yTextBox_KeyPress);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(116, 38);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(72, 23);
            this.xTextBox.TabIndex = 8;
            this.xTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y-Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "X-Value:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(56, 181);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 30);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Point";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(33, 108);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(36, 127);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(117, 23);
            this.nameTextBox.TabIndex = 2;
            // 
            // customerRadioButton
            // 
            this.customerRadioButton.AutoSize = true;
            this.customerRadioButton.Location = new System.Drawing.Point(20, 64);
            this.customerRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.customerRadioButton.Name = "customerRadioButton";
            this.customerRadioButton.Size = new System.Drawing.Size(86, 21);
            this.customerRadioButton.TabIndex = 1;
            this.customerRadioButton.TabStop = true;
            this.customerRadioButton.Text = "Customer";
            this.customerRadioButton.UseVisualStyleBackColor = true;
            // 
            // supplierRadioButton
            // 
            this.supplierRadioButton.AutoSize = true;
            this.supplierRadioButton.Location = new System.Drawing.Point(20, 26);
            this.supplierRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.supplierRadioButton.Name = "supplierRadioButton";
            this.supplierRadioButton.Size = new System.Drawing.Size(78, 21);
            this.supplierRadioButton.TabIndex = 0;
            this.supplierRadioButton.TabStop = true;
            this.supplierRadioButton.Text = "Supplier";
            this.supplierRadioButton.UseVisualStyleBackColor = true;
            // 
            // distanceChart
            // 
            this.distanceChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.AxisX.Interval = 50D;
            chartArea4.AxisX.Maximum = 500D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.ScaleView.Zoomable = false;
            chartArea4.AxisX2.ScaleView.Zoomable = false;
            chartArea4.AxisY.Interval = 50D;
            chartArea4.AxisY.Maximum = 500D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.AxisY.ScaleView.Zoomable = false;
            chartArea4.AxisY2.ScaleView.Zoomable = false;
            chartArea4.Name = "ChartArea1";
            this.distanceChart.ChartAreas.Add(chartArea4);
            this.distanceChart.Dock = System.Windows.Forms.DockStyle.Right;
            legend7.Enabled = false;
            legend7.Name = "supplierLegend";
            legend7.Title = "Suppliers";
            legend8.Name = "Legend2";
            this.distanceChart.Legends.Add(legend7);
            this.distanceChart.Legends.Add(legend8);
            this.distanceChart.Location = new System.Drawing.Point(213, 0);
            this.distanceChart.Margin = new System.Windows.Forms.Padding(2);
            this.distanceChart.Name = "distanceChart";
            this.distanceChart.Size = new System.Drawing.Size(978, 619);
            this.distanceChart.TabIndex = 4;
            this.distanceChart.Text = "Customers\' Suppliers";
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.Enabled = false;
            this.infoRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.infoRichTextBox.Location = new System.Drawing.Point(-1, 0);
            this.infoRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.Size = new System.Drawing.Size(212, 125);
            this.infoRichTextBox.TabIndex = 5;
            this.infoRichTextBox.Text = "Information: Please enter a supplier before a customer. Each supplier/customer mu" +
    "st have a unique name and unique coordinates. Limit of 5 suppliers and 100 custo" +
    "mers.";
            // 
            // customerListBox
            // 
            this.customerListBox.Enabled = false;
            this.customerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.ItemHeight = 16;
            this.customerListBox.Location = new System.Drawing.Point(-1, 382);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(212, 244);
            this.customerListBox.TabIndex = 6;
            // 
            // DistanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 619);
            this.Controls.Add(this.customerListBox);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.distanceChart);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.controlGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DistanceForm";
            this.Text = "Customer Supplier Distance";
            this.controlGroupBox.ResumeLayout(false);
            this.controlGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.RadioButton customerRadioButton;
        private System.Windows.Forms.RadioButton supplierRadioButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart distanceChart;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox customerListBox;
    }
}

