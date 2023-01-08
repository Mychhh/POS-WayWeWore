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
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Register_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_Admin = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete_Admin = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.Admin.Location = new System.Drawing.Point(21, 9);
            this.Admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(86, 29);
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
            this.Column2,
            this.UserType,
            this.Register_at,
            this.edit_Admin,
            this.delete_Admin});
            this.dataGrid_Admin.EnableHeadersVisualStyles = false;
            this.dataGrid_Admin.Location = new System.Drawing.Point(18, 42);
            this.dataGrid_Admin.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_Admin.Name = "dataGrid_Admin";
            this.dataGrid_Admin.RowHeadersVisible = false;
            this.dataGrid_Admin.RowHeadersWidth = 51;
            this.dataGrid_Admin.Size = new System.Drawing.Size(893, 425);
            this.dataGrid_Admin.TabIndex = 8;
            this.dataGrid_Admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Admin_CellContentClick);
            this.dataGrid_Admin.SelectionChanged += new System.EventHandler(this.dataGrid_Admin_SelectionChanged);
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
            // Column2
            // 
            this.Column2.HeaderText = "User_Status";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // UserType
            // 
            this.UserType.HeaderText = "User_Type";
            this.UserType.MinimumWidth = 6;
            this.UserType.Name = "UserType";
            this.UserType.Width = 125;
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
            this.edit_Admin.Width = 42;
            // 
            // delete_Admin
            // 
            this.delete_Admin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete_Admin.HeaderText = "Delete";
            this.delete_Admin.Image = ((System.Drawing.Image)(resources.GetObject("delete_Admin.Image")));
            this.delete_Admin.MinimumWidth = 6;
            this.delete_Admin.Name = "delete_Admin";
            this.delete_Admin.Width = 61;
            // 
            // UserControlUserListAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGrid_Admin);
            this.Controls.Add(this.Admin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlUserListAdmin";
            this.Size = new System.Drawing.Size(932, 482);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Register_at;
        private System.Windows.Forms.DataGridViewImageColumn edit_Admin;
        private System.Windows.Forms.DataGridViewImageColumn delete_Admin;
    }
}
