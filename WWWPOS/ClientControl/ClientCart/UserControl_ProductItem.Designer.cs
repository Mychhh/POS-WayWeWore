namespace WWWPOS.ClientControl.ClientCart
{
    partial class UserControl_ProductItem
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
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.lbl_Qty = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtotal.ForeColor = System.Drawing.Color.White;
            this.lbl_Subtotal.Location = new System.Drawing.Point(322, 6);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(40, 18);
            this.lbl_Subtotal.TabIndex = 5;
            this.lbl_Subtotal.Text = "5000";
            this.lbl_Subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Qty
            // 
            this.lbl_Qty.AutoSize = true;
            this.lbl_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qty.ForeColor = System.Drawing.Color.White;
            this.lbl_Qty.Location = new System.Drawing.Point(202, 5);
            this.lbl_Qty.Name = "lbl_Qty";
            this.lbl_Qty.Size = new System.Drawing.Size(26, 18);
            this.lbl_Qty.TabIndex = 4;
            this.lbl_Qty.Text = "X2";
            this.lbl_Qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.ForeColor = System.Drawing.Color.White;
            this.lbl_ProductName.Location = new System.Drawing.Point(3, 6);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(88, 18);
            this.lbl_ProductName.TabIndex = 3;
            this.lbl_ProductName.Text = "Bing Chilling";
            this.lbl_ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl_ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.lbl_Qty);
            this.Controls.Add(this.lbl_ProductName);
            this.Name = "UserControl_ProductItem";
            this.Size = new System.Drawing.Size(390, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbl_ProductName;
        public System.Windows.Forms.Label lbl_Qty;
        public System.Windows.Forms.Label lbl_Subtotal;
    }
}
