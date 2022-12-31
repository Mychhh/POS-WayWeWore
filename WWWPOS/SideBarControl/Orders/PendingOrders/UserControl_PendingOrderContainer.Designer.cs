namespace WWWPOS.SideBarControl.Orders.PendingOrders
{
    partial class UserControl_PendingOrderContainer
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
            this.lbl_OrderNumber = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_OrderNumber
            // 
            this.lbl_OrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_OrderNumber.Location = new System.Drawing.Point(8, 5);
            this.lbl_OrderNumber.Name = "lbl_OrderNumber";
            this.lbl_OrderNumber.Size = new System.Drawing.Size(215, 33);
            this.lbl_OrderNumber.TabIndex = 0;
            this.lbl_OrderNumber.Text = "Order Number";
            this.lbl_OrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserControl_PendingOrderContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_OrderNumber);
            this.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Name = "UserControl_PendingOrderContainer";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(830, 194);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_OrderNumber;
        private System.Windows.Forms.Button button1;
    }
}
