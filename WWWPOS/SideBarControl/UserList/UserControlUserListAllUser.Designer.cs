namespace WWWPOS.SideBarControl.UserList
{
    partial class UserControlUserListAllUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Admin = new System.Windows.Forms.Label();
            this.dataGridAdmin = new System.Windows.Forms.DataGridView();
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.wayweworeDataSet = new WWWPOS.wayweworeDataSet();
            this.wayweworeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.accountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registeratDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wayweworeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wayweworeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(16, 4);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(70, 24);
            this.Admin.TabIndex = 0;
            this.Admin.Text = "Admin";
            // 
            // dataGridAdmin
            // 
            this.dataGridAdmin.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIdDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.registeratDataGridViewTextBoxColumn});
            this.dataGridAdmin.DataSource = this.accountBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAdmin.Location = new System.Drawing.Point(20, 31);
            this.dataGridAdmin.Name = "dataGridAdmin";
            this.dataGridAdmin.Size = new System.Drawing.Size(656, 146);
            this.dataGridAdmin.TabIndex = 1;
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIdDataGridViewTextBoxColumn1,
            this.fullNameDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn1,
            this.userTypeDataGridViewTextBoxColumn1,
            this.registeratDataGridViewTextBoxColumn1});
            this.dataGridCustomer.DataSource = this.accountBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCustomer.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCustomer.Location = new System.Drawing.Point(20, 217);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.Size = new System.Drawing.Size(656, 146);
            this.dataGridCustomer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer";
            // 
            // wayweworeDataSet
            // 
            this.wayweworeDataSet.DataSetName = "wayweworeDataSet";
            this.wayweworeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wayweworeDataSetBindingSource
            // 
            this.wayweworeDataSetBindingSource.DataSource = this.wayweworeDataSet;
            this.wayweworeDataSetBindingSource.Position = 0;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "account";
            this.accountBindingSource.DataSource = this.wayweworeDataSetBindingSource;
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
            // accountBindingSource1
            // 
            this.accountBindingSource1.DataMember = "account";
            this.accountBindingSource1.DataSource = this.wayweworeDataSetBindingSource;
            // 
            // accountIdDataGridViewTextBoxColumn1
            // 
            this.accountIdDataGridViewTextBoxColumn1.DataPropertyName = "Account_Id";
            this.accountIdDataGridViewTextBoxColumn1.HeaderText = "Account_Id";
            this.accountIdDataGridViewTextBoxColumn1.Name = "accountIdDataGridViewTextBoxColumn1";
            this.accountIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            this.fullNameDataGridViewTextBoxColumn1.DataPropertyName = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn1.HeaderText = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            this.passwordDataGridViewTextBoxColumn1.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn1.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            // 
            // userTypeDataGridViewTextBoxColumn1
            // 
            this.userTypeDataGridViewTextBoxColumn1.DataPropertyName = "User_Type";
            this.userTypeDataGridViewTextBoxColumn1.HeaderText = "User_Type";
            this.userTypeDataGridViewTextBoxColumn1.Name = "userTypeDataGridViewTextBoxColumn1";
            // 
            // registeratDataGridViewTextBoxColumn1
            // 
            this.registeratDataGridViewTextBoxColumn1.DataPropertyName = "Register_at";
            this.registeratDataGridViewTextBoxColumn1.HeaderText = "Register_at";
            this.registeratDataGridViewTextBoxColumn1.Name = "registeratDataGridViewTextBoxColumn1";
            // 
            // UserControlUserListAllUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridAdmin);
            this.Controls.Add(this.Admin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlUserListAllUser";
            this.Size = new System.Drawing.Size(732, 461);
            this.Load += new System.EventHandler(this.UserControlUserListAllUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wayweworeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wayweworeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.DataGridView dataGridAdmin;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registeratDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.BindingSource wayweworeDataSetBindingSource;
        private wayweworeDataSet wayweworeDataSet;
        private wayweworeDataSetTableAdapters.accountTableAdapter accountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn registeratDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource accountBindingSource1;
    }
}
