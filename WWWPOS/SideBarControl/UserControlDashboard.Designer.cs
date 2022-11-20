namespace WWWPOS.SideBarControl
{
    partial class UserControlDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(161)))), ((int)(((byte)(55)))));
            this.panel12.Location = new System.Drawing.Point(345, 163);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(290, 136);
            this.panel12.TabIndex = 47;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.panel11.Location = new System.Drawing.Point(23, 163);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(290, 136);
            this.panel11.TabIndex = 45;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(74)))), ((int)(((byte)(217)))));
            this.panel10.Location = new System.Drawing.Point(665, 14);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(290, 136);
            this.panel10.TabIndex = 48;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(167)))), ((int)(((byte)(52)))));
            this.panel9.Location = new System.Drawing.Point(345, 14);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(290, 136);
            this.panel9.TabIndex = 46;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(174)))), ((int)(((byte)(242)))));
            this.panel8.Location = new System.Drawing.Point(23, 14);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(290, 136);
            this.panel8.TabIndex = 44;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 322);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(932, 320);
            this.chart1.TabIndex = 49;
            this.chart1.Text = "chart1";
            // 
            // UserControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.chart1);
            this.Name = "UserControlDashboard";
            this.Size = new System.Drawing.Size(976, 655);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
