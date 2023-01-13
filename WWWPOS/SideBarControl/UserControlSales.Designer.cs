namespace WWWPOS.SideBarControl
{
    partial class UserControlSales
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.cmbDateRange = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SalesReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Controls.Add(this.cmb_Category);
            this.panel8.Controls.Add(this.cmbDateRange);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(25, 18);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(932, 82);
            this.panel8.TabIndex = 25;
            // 
            // cmb_Category
            // 
            this.cmb_Category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Items.AddRange(new object[] {
            "All Items",
            "T-Shirt",
            "Short"});
            this.cmb_Category.Location = new System.Drawing.Point(451, 18);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(221, 33);
            this.cmb_Category.TabIndex = 4;
            this.cmb_Category.DropDownClosed += new System.EventHandler(this.cmb_Category_DropDownClosed);
            // 
            // cmbDateRange
            // 
            this.cmbDateRange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDateRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDateRange.FormattingEnabled = true;
            this.cmbDateRange.Items.AddRange(new object[] {
            "All Time",
            "Last 7 Days",
            "Last Month",
            "Last 4 Months",
            "Last Year"});
            this.cmbDateRange.Location = new System.Drawing.Point(688, 18);
            this.cmbDateRange.Name = "cmbDateRange";
            this.cmbDateRange.Size = new System.Drawing.Size(221, 33);
            this.cmbDateRange.TabIndex = 3;
            this.cmbDateRange.DropDownClosed += new System.EventHandler(this.cmbDateRange_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales Report";
            // 
            // SalesReport
            // 
            this.SalesReport.BackColor = System.Drawing.Color.Gainsboro;
            this.SalesReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(174)))), ((int)(((byte)(242)))));
            chartArea2.Name = "Shit";
            chartArea2.ShadowColor = System.Drawing.Color.Empty;
            this.SalesReport.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.ShadowColor = System.Drawing.Color.Empty;
            this.SalesReport.Legends.Add(legend2);
            this.SalesReport.Location = new System.Drawing.Point(25, 107);
            this.SalesReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalesReport.Name = "SalesReport";
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            series2.BackSecondaryColor = System.Drawing.Color.IndianRed;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.ChartArea = "Shit";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            series2.Legend = "Legend1";
            series2.Name = "Sales Report";
            series2.ShadowColor = System.Drawing.Color.Empty;
            this.SalesReport.Series.Add(series2);
            this.SalesReport.Size = new System.Drawing.Size(932, 492);
            this.SalesReport.TabIndex = 50;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Sales";
            title2.ShadowColor = System.Drawing.Color.Black;
            this.SalesReport.Titles.Add(title2);
            // 
            // UserControlSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.SalesReport);
            this.Controls.Add(this.panel8);
            this.Name = "UserControlSales";
            this.Size = new System.Drawing.Size(976, 613);
            this.Load += new System.EventHandler(this.UserControlSales_Load);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDateRange;
        private System.Windows.Forms.ComboBox cmb_Category;
        public System.Windows.Forms.DataVisualization.Charting.Chart SalesReport;
    }
}
