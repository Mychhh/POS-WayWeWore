namespace WWWPOS.SideBarControl.UserList
{
    partial class UserControlUserListAdmin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUserListAdmin));
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wayweworeDataSet = new WWWPOS.wayweworeDataSet();
            this.Admin = new System.Windows.Forms.Label();
            this.accountTableAdapter = new WWWPOS.wayweworeDataSetTableAdapters.accountTableAdapter();
            this.dataGrid_Admin = new System.Windows.Forms.DataGridView();
            this.Account_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Register_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_User = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete_User = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wayweworeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Admin)).BeginInit();
            this.SuspendLayout();
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "account";
            this.accountBindingSource.DataSource = this.wayweworeDataSet;
            // 
            // wayweworeDataSet
            // 
            this.wayweworeDataSet.DataSetName = "wayweworeDataSet";
            this.wayweworeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(16, 7);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(70, 24);
            this.Admin.TabIndex = 4;
            this.Admin.Text = "Admin";
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // dataGrid_Admin
            // 
            this.dataGrid_Admin.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Admin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Admin.ColumnHeadersHeight = 35;
            this.dataGrid_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_Admin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account_ID,
            this.Full_Name,
            this.Email,
            this.Password,
            this.Phone,
            this.Column1,
            this.User_Type,
            this.Register_at,
            this.edit_User,
            this.delete_User});
            this.dataGrid_Admin.EnableHeadersVisualStyles = false;
            this.dataGrid_Admin.Location = new System.Drawing.Point(20, 34);
            this.dataGrid_Admin.Name = "dataGrid_Admin";
            this.dataGrid_Admin.RowHeadersVisible = false;
            this.dataGrid_Admin.Size = new System.Drawing.Size(656, 331);
            this.dataGrid_Admin.TabIndex = 8;
            this.dataGrid_Admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Admin_CellContentClick);
            this.dataGrid_Admin.SelectionChanged += new System.EventHandler(this.dataGrid_Admin_SelectionChanged);
            // 
            // Account_ID
            // 
            this.Account_ID.HeaderText = "Account_ID";
            this.Account_ID.Name = "Account_ID";
            // 
            // Full_Name
            // 
            this.Full_Name.HeaderText = "Name";
            this.Full_Name.Name = "Full_Name";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Address";
            this.Column1.Name = "Column1";
            // 
            // User_Type
            // 
            this.User_Type.HeaderText = "User_Type";
            this.User_Type.Name = "User_Type";
            // 
            // Register_at
            // 
            this.Register_at.HeaderText = "Register_at";
            this.Register_at.Name = "Register_at";
            // 
            // edit_User
            // 
            this.edit_User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit_User.HeaderText = "";
            this.edit_User.Image = ((System.Drawing.Image)(resources.GetObject("edit_User.Image")));
            this.edit_User.Name = "edit_User";
            this.edit_User.Width = 5;
            // 
            // delete_User
            // 
            this.delete_User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete_User.HeaderText = "";
            this.delete_User.Image = ((System.Drawing.Image)(resources.GetObject("delete_User.Image")));
            this.delete_User.Name = "delete_User";
            this.delete_User.Width = 5;
            // 
            // UserControlUserListAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGrid_Admin);
            this.Controls.Add(this.Admin);
            this.Name = "UserControlUserListAdmin";
            this.Size = new System.Drawing.Size(732, 429);
            this.Load += new System.EventHandler(this.UserControlUserListAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wayweworeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private wayweworeDataSet wayweworeDataSet;
        private wayweworeDataSetTableAdapters.accountTableAdapter accountTableAdapter;
        private System.Windows.Forms.DataGridView dataGrid_Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Register_at;
        private System.Windows.Forms.DataGridViewImageColumn edit_User;
        private System.Windows.Forms.DataGridViewImageColumn delete_User;
    }
}
