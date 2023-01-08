namespace WWWPOS.SideBarControl.UserList
{
    partial class UserControlUserListCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUserListCustomer));
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wayweworeDataSet = new WWWPOS.wayweworeDataSet();
            this.Admin = new System.Windows.Forms.Label();
            this.accountTableAdapter = new WWWPOS.wayweworeDataSetTableAdapters.accountTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.Account_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Register_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_Client = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete_Client = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wayweworeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
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
            this.Admin.Size = new System.Drawing.Size(125, 29);
            this.Admin.TabIndex = 6;
            this.Admin.Text = "Customer";
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.DataPropertyName = "Account_Id";
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::WWWPOS.Properties.Resources.pen_removebg_preview;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.DataPropertyName = "Account_Id";
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::WWWPOS.Properties.Resources.del;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCustomer.ColumnHeadersHeight = 35;
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account_ID,
            this.Full_Name,
            this.Email,
            this.Password,
            this.Phone,
            this.Column1,
            this.userStatus,
            this.userType,
            this.Register_at,
            this.edit_Client,
            this.delete_Client});
            this.dataGridCustomer.EnableHeadersVisualStyles = false;
            this.dataGridCustomer.Location = new System.Drawing.Point(17, 42);
            this.dataGridCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.RowHeadersVisible = false;
            this.dataGridCustomer.RowHeadersWidth = 51;
            this.dataGridCustomer.Size = new System.Drawing.Size(895, 423);
            this.dataGridCustomer.TabIndex = 7;
            this.dataGridCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomer_CellContentClick);
            this.dataGridCustomer.SelectionChanged += new System.EventHandler(this.dataGridCustomer_SelectionChanged);
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
            // edit_Client
            // 
            this.edit_Client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit_Client.HeaderText = "Edit";
            this.edit_Client.Image = ((System.Drawing.Image)(resources.GetObject("edit_Client.Image")));
            this.edit_Client.MinimumWidth = 6;
            this.edit_Client.Name = "edit_Client";
            this.edit_Client.Width = 42;
            // 
            // delete_Client
            // 
            this.delete_Client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete_Client.HeaderText = "Delete";
            this.delete_Client.Image = ((System.Drawing.Image)(resources.GetObject("delete_Client.Image")));
            this.delete_Client.MinimumWidth = 6;
            this.delete_Client.Name = "delete_Client";
            this.delete_Client.Width = 61;
            // 
            // UserControlUserListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridCustomer);
            this.Controls.Add(this.Admin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlUserListCustomer";
            this.Size = new System.Drawing.Size(932, 482);
            this.Load += new System.EventHandler(this.UserControlUserListCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wayweworeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private wayweworeDataSet wayweworeDataSet;
        private wayweworeDataSetTableAdapters.accountTableAdapter accountTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn userType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Register_at;
        private System.Windows.Forms.DataGridViewImageColumn edit_Client;
        private System.Windows.Forms.DataGridViewImageColumn delete_Client;
    }
}
