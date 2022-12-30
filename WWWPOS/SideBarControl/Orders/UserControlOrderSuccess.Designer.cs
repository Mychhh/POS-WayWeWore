namespace WWWPOS.SideBarControl.Orders
{
    partial class UserControlOrderSuccess
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
            this.Admin = new System.Windows.Forms.Label();
            this.flPanel_SuccessOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(33, 15);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(194, 29);
            this.Admin.TabIndex = 10;
            this.Admin.Text = "Success orders";
            // 
            // flPanel_SuccessOrders
            // 
            this.flPanel_SuccessOrders.Location = new System.Drawing.Point(38, 47);
            this.flPanel_SuccessOrders.Name = "flPanel_SuccessOrders";
            this.flPanel_SuccessOrders.Size = new System.Drawing.Size(860, 388);
            this.flPanel_SuccessOrders.TabIndex = 11;
            // 
            // UserControlOrderSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flPanel_SuccessOrders);
            this.Controls.Add(this.Admin);
            this.Name = "UserControlOrderSuccess";
            this.Size = new System.Drawing.Size(932, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.FlowLayoutPanel flPanel_SuccessOrders;
    }
}
