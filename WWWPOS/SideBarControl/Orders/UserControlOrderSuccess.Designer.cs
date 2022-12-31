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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlOrderSuccess));
            this.Admin = new System.Windows.Forms.Label();
            this.dataGridAdmin = new System.Windows.Forms.DataGridView();
            this.Account_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Register_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_Admin = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete_Admin = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmin)).BeginInit();
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
            // dataGridAdmin
            // 
            this.dataGridAdmin.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAdmin.ColumnHeadersHeight = 35;
            this.dataGridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account_ID,
            this.Full_Name,
            this.Email,
            this.Password,
            this.Phone,
            this.Column1,
            this.userStatus,
            this.userType,
            this.Register_at,
            this.edit_Admin,
            this.delete_Admin});
            this.dataGridAdmin.EnableHeadersVisualStyles = false;
            this.dataGridAdmin.Location = new System.Drawing.Point(38, 47);
            this.dataGridAdmin.Name = "dataGridAdmin";
            this.dataGridAdmin.RowHeadersVisible = false;
            this.dataGridAdmin.RowHeadersWidth = 51;
            this.dataGridAdmin.Size = new System.Drawing.Size(860, 388);
            this.dataGridAdmin.TabIndex = 12;
            // 
            // Account_ID
            // 
            this.Account_ID.HeaderText = "Account_ID";
            this.Account_ID.MinimumWidth = 6;
            this.Account_ID.Name = "Account_ID";
            this.Account_ID.Width = 125;
            // 
            // Full_Name
            // 
            this.Full_Name.HeaderText = "Name";
            this.Full_Name.MinimumWidth = 6;
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Address";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // userStatus
            // 
            this.userStatus.HeaderText = "User_Status";
            this.userStatus.MinimumWidth = 6;
            this.userStatus.Name = "userStatus";
            this.userStatus.Width = 125;
            // 
            // userType
            // 
            this.userType.HeaderText = "User_Type";
            this.userType.MinimumWidth = 6;
            this.userType.Name = "userType";
            this.userType.Width = 125;
            // 
            // Register_at
            // 
            this.Register_at.HeaderText = "Register_at";
            this.Register_at.MinimumWidth = 6;
            this.Register_at.Name = "Register_at";
            this.Register_at.Width = 125;
            // 
            // edit_Admin
            // 
            this.edit_Admin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit_Admin.HeaderText = "Edit";
            this.edit_Admin.Image = ((System.Drawing.Image)(resources.GetObject("edit_Admin.Image")));
            this.edit_Admin.MinimumWidth = 6;
            this.edit_Admin.Name = "edit_Admin";
            this.edit_Admin.Width = 38;
            // 
            // delete_Admin
            // 
            this.delete_Admin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete_Admin.HeaderText = "Delete";
            this.delete_Admin.Image = ((System.Drawing.Image)(resources.GetObject("delete_Admin.Image")));
            this.delete_Admin.MinimumWidth = 6;
            this.delete_Admin.Name = "delete_Admin";
            this.delete_Admin.Width = 55;
            // 
            // UserControlOrderSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridAdmin);
            this.Controls.Add(this.Admin);
            this.Name = "UserControlOrderSuccess";
            this.Size = new System.Drawing.Size(932, 449);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.DataGridView dataGridAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn userType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Register_at;
        private System.Windows.Forms.DataGridViewImageColumn edit_Admin;
        private System.Windows.Forms.DataGridViewImageColumn delete_Admin;
    }
}
