namespace WWWPOS.SideBarControl
{
    partial class UserControlArchive
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
            this.lbl_Archive = new System.Windows.Forms.Label();
            this.panel_Archive = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_User);
            this.panel1.Controls.Add(this.btn_Product);
            this.panel1.Controls.Add(this.lbl_Archive);
            this.panel1.Location = new System.Drawing.Point(25, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 82);
            this.panel1.TabIndex = 18;
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
            this.btn_User.Text = "User";
            this.btn_User.UseVisualStyleBackColor = false;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
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
            this.btn_Product.Text = "Product";
            this.btn_Product.UseVisualStyleBackColor = false;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // lbl_Archive
            // 
            this.lbl_Archive.AutoSize = true;
            this.lbl_Archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Archive.Location = new System.Drawing.Point(16, 28);
            this.lbl_Archive.Name = "lbl_Archive";
            this.lbl_Archive.Size = new System.Drawing.Size(99, 29);
            this.lbl_Archive.TabIndex = 1;
            this.lbl_Archive.Text = "Archive";
            // 
            // panel_Archive
            // 
            this.panel_Archive.Location = new System.Drawing.Point(25, 117);
            this.panel_Archive.Name = "panel_Archive";
            this.panel_Archive.Size = new System.Drawing.Size(932, 517);
            this.panel_Archive.TabIndex = 19;
            // 
            // UserControlArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Archive);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UserControlArchive";
            this.Size = new System.Drawing.Size(976, 655);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Label lbl_Archive;
        public System.Windows.Forms.Panel panel_Archive;
    }
}
