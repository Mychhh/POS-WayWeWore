namespace WWWPOS.SideBarControl.UserList
{
    partial class UserControlOrder
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
            this.btn_Pending = new System.Windows.Forms.Button();
            this.btn_Success = new System.Windows.Forms.Button();
            this.lbl_Inventory = new System.Windows.Forms.Label();
            this.panel_Order = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Pending);
            this.panel1.Controls.Add(this.btn_Success);
            this.panel1.Controls.Add(this.lbl_Inventory);
            this.panel1.Location = new System.Drawing.Point(25, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 82);
            this.panel1.TabIndex = 21;
            // 
            // btn_Pending
            // 
            this.btn_Pending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.btn_Pending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pending.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Pending.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pending.ForeColor = System.Drawing.Color.White;
            this.btn_Pending.Location = new System.Drawing.Point(603, 22);
            this.btn_Pending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Pending.Name = "btn_Pending";
            this.btn_Pending.Size = new System.Drawing.Size(141, 46);
            this.btn_Pending.TabIndex = 4;
            this.btn_Pending.Text = "Pending";
            this.btn_Pending.UseVisualStyleBackColor = false;
            this.btn_Pending.Click += new System.EventHandler(this.btn_Pending_Click);
            // 
            // btn_Success
            // 
            this.btn_Success.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.btn_Success.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Success.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Success.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Success.ForeColor = System.Drawing.Color.White;
            this.btn_Success.Location = new System.Drawing.Point(761, 22);
            this.btn_Success.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Success.Name = "btn_Success";
            this.btn_Success.Size = new System.Drawing.Size(141, 46);
            this.btn_Success.TabIndex = 3;
            this.btn_Success.Text = "Success";
            this.btn_Success.UseVisualStyleBackColor = false;
            this.btn_Success.Click += new System.EventHandler(this.btn_Success_Click);
            // 
            // lbl_Inventory
            // 
            this.lbl_Inventory.AutoSize = true;
            this.lbl_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inventory.Location = new System.Drawing.Point(16, 28);
            this.lbl_Inventory.Name = "lbl_Inventory";
            this.lbl_Inventory.Size = new System.Drawing.Size(94, 29);
            this.lbl_Inventory.TabIndex = 1;
            this.lbl_Inventory.Text = "Orders";
            // 
            // panel_Order
            // 
            this.panel_Order.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Order.Location = new System.Drawing.Point(25, 115);
            this.panel_Order.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Order.Name = "panel_Order";
            this.panel_Order.Size = new System.Drawing.Size(932, 484);
            this.panel_Order.TabIndex = 22;
            // 
            // UserControlOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Order);
            this.Name = "UserControlOrder";
            this.Size = new System.Drawing.Size(976, 613);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Pending;
        private System.Windows.Forms.Button btn_Success;
        private System.Windows.Forms.Label lbl_Inventory;
        public System.Windows.Forms.Panel panel_Order;
    }
}
