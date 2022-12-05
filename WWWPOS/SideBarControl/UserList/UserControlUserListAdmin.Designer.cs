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
            this.dataGrid_Admin = new System.Windows.Forms.DataGridView();
            this.Admin = new System.Windows.Forms.Label();
            this.wayweworeDataSet = new WWWPOS.wayweworeDataSet();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new WWWPOS.wayweworeDataSetTableAdapters.accountTableAdapter();
            this.accountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registeratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wayweworeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Admin
            // 
            this.dataGrid_Admin.AutoGenerateColumns = false;
            this.dataGrid_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Admin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIdDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.registeratDataGridViewTextBoxColumn});
            this.dataGrid_Admin.DataSource = this.accountBindingSource;
            this.dataGrid_Admin.Location = new System.Drawing.Point(20, 34);
            this.dataGrid_Admin.Name = "dataGrid_Admin";
            this.dataGrid_Admin.Size = new System.Drawing.Size(656, 331);
            this.dataGrid_Admin.TabIndex = 5;
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
            // wayweworeDataSet
            // 
            this.wayweworeDataSet.DataSetName = "wayweworeDataSet";
            this.wayweworeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "account";
            this.accountBindingSource.DataSource = this.wayweworeDataSet;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // accountIdDataGridViewTextBoxColumn
            // 
            this.accountIdDataGridViewTextBoxColumn.DataPropertyName = "Account_Id";
            this.accountIdDataGridViewTextBoxColumn.HeaderText = "Account_Id";
            this.accountIdDataGridViewTextBoxColumn.Name = "accountIdDataGridViewTextBoxColumn";
            this.accountIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "User_Type";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "User_Type";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            // 
            // registeratDataGridViewTextBoxColumn
            // 
            this.registeratDataGridViewTextBoxColumn.DataPropertyName = "Register_at";
            this.registeratDataGridViewTextBoxColumn.HeaderText = "Register_at";
            this.registeratDataGridViewTextBoxColumn.Name = "registeratDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wayweworeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGrid_Admin;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registeratDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private wayweworeDataSet wayweworeDataSet;
        private wayweworeDataSetTableAdapters.accountTableAdapter accountTableAdapter;
    }
}
