namespace WWWPOS.SideBarControl
{
    partial class UserControlInventory
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
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.lbl_Inventory = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_User);
            this.panel1.Controls.Add(this.btn_Product);
            this.panel1.Controls.Add(this.lbl_Inventory);
            this.panel1.Location = new System.Drawing.Point(25, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 82);
            this.panel1.TabIndex = 19;
            // 
            // btn_User
            // 
            this.btn_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.btn_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_User.ForeColor = System.Drawing.Color.White;
            this.btn_User.Location = new System.Drawing.Point(604, 18);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(141, 46);
            this.btn_User.TabIndex = 3;
            this.btn_User.Text = "Edit Product";
            this.btn_User.UseVisualStyleBackColor = false;
            // 
            // btn_Product
            // 
            this.btn_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.btn_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Product.Location = new System.Drawing.Point(767, 18);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(141, 46);
            this.btn_Product.TabIndex = 1;
            this.btn_Product.Text = "Delete Product";
            this.btn_Product.UseVisualStyleBackColor = false;
            // 
            // lbl_Inventory
            // 
            this.lbl_Inventory.AutoSize = true;
            this.lbl_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inventory.Location = new System.Drawing.Point(16, 28);
            this.lbl_Inventory.Name = "lbl_Inventory";
            this.lbl_Inventory.Size = new System.Drawing.Size(118, 29);
            this.lbl_Inventory.TabIndex = 1;
            this.lbl_Inventory.Text = "Inventory";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(437, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UserControlInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlInventory";
            this.Size = new System.Drawing.Size(976, 655);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Label lbl_Inventory;
        private System.Windows.Forms.Button button1;
    }
}
