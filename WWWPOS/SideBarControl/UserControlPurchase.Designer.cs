namespace WWWPOS.SideBarControl
{
    partial class UserControlPurchase
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Short = new System.Windows.Forms.Button();
            this.btn_Tshirt = new System.Windows.Forms.Button();
            this.lbl_PurchaseHistory = new System.Windows.Forms.Label();
            this.panel_Purchase = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Short);
            this.panel1.Controls.Add(this.btn_Tshirt);
            this.panel1.Controls.Add(this.lbl_PurchaseHistory);
            this.panel1.Location = new System.Drawing.Point(25, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 82);
            this.panel1.TabIndex = 0;
            // 
            // btn_Short
            // 
            this.btn_Short.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.btn_Short.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Short.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Short.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Short.ForeColor = System.Drawing.Color.White;
            this.btn_Short.Location = new System.Drawing.Point(761, 18);
            this.btn_Short.Name = "btn_Short";
            this.btn_Short.Size = new System.Drawing.Size(141, 46);
            this.btn_Short.TabIndex = 3;
            this.btn_Short.Text = "Shorts";
            this.btn_Short.UseVisualStyleBackColor = false;
            this.btn_Short.Click += new System.EventHandler(this.btn_Short_Click);
            // 
            // btn_Tshirt
            // 
            this.btn_Tshirt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.btn_Tshirt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tshirt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Tshirt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tshirt.ForeColor = System.Drawing.Color.White;
            this.btn_Tshirt.Location = new System.Drawing.Point(594, 18);
            this.btn_Tshirt.Name = "btn_Tshirt";
            this.btn_Tshirt.Size = new System.Drawing.Size(141, 46);
            this.btn_Tshirt.TabIndex = 2;
            this.btn_Tshirt.Text = "T-Shirts";
            this.btn_Tshirt.UseVisualStyleBackColor = false;
            this.btn_Tshirt.Click += new System.EventHandler(this.btn_Tshirt_Click);
            // 
            // lbl_PurchaseHistory
            // 
            this.lbl_PurchaseHistory.AutoSize = true;
            this.lbl_PurchaseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurchaseHistory.Location = new System.Drawing.Point(16, 28);
            this.lbl_PurchaseHistory.Name = "lbl_PurchaseHistory";
            this.lbl_PurchaseHistory.Size = new System.Drawing.Size(210, 29);
            this.lbl_PurchaseHistory.TabIndex = 1;
            this.lbl_PurchaseHistory.Text = "Purchase History";
            // 
            // panel_Purchase
            // 
            this.panel_Purchase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Purchase.Location = new System.Drawing.Point(25, 107);
            this.panel_Purchase.Name = "panel_Purchase";
            this.panel_Purchase.Size = new System.Drawing.Size(932, 492);
            this.panel_Purchase.TabIndex = 21;
            // 
            // UserControlPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel_Purchase);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlPurchase";
            this.Size = new System.Drawing.Size(976, 613);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_PurchaseHistory;
        private System.Windows.Forms.Button btn_Short;
        private System.Windows.Forms.Button btn_Tshirt;
        public System.Windows.Forms.Panel panel_Purchase;
    }
}
