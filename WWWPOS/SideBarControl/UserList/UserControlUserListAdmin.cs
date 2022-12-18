using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.SideBarControl.UserList
{
    public partial class UserControlUserListAdmin : UserControl
    {
        public UserControlUserListAdmin()
        {
            InitializeComponent();
        }
        public static string user_ID, user_Name, user_Email, user_Password, user_Phone, user_Address, user_Type;
        UserControl_UpdateForm UP = new UserControl_UpdateForm();
        private void UserControlUserListAdmin_Load(object sender, EventArgs e)
        {
            loadData LD = new loadData();
            LD.userRecords(dataGrid_Admin, "Admin", "Active");
        }

        private void dataGrid_Admin_SelectionChanged(object sender, EventArgs e)
        {
            int row = dataGrid_Admin.CurrentRow.Index;
            user_ID = dataGrid_Admin[0, row].Value.ToString();
            user_Name = dataGrid_Admin[1, row].Value.ToString();
            user_Email = dataGrid_Admin[2, row].Value.ToString();
            user_Password = dataGrid_Admin[3, row].Value.ToString();
            user_Phone = dataGrid_Admin[4, row].Value.ToString();
            user_Address = dataGrid_Admin[5, row].Value.ToString();
            user_Type = dataGrid_Admin[7, row].Value.ToString();
           
        }
        private void dataGrid_Admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGrid_Admin.Columns[e.ColumnIndex].Name;
            if (colName == "edit_Admin")
            {
                UP.txt_AccountID.Text = user_ID;
                UP.txt_Name.Text = user_Name;
                UP.txt_Email.Text = user_Email;
                UP.txt_Password.Text = user_Password;
                UP.txt_Number.Text = user_Phone;
                UP.txt_Address.Text = user_Address;
                UP.txt_UserType.Text = user_Type;

                Controls.Clear();
                Controls.Add(UP);
                UP.Dock = DockStyle.Fill;
            }
            else if (colName == "delete_Admin")
            {
                DataBase DB = new DataBase();
                DB.SetStatusUser("Inactive", Int32.Parse(user_ID));

                UserControlUserListAdmin UC_UserListAdmin = new UserControlUserListAdmin();

                Controls.Clear();
                Controls.Add(UC_UserListAdmin);
                UC_UserListAdmin.Dock = DockStyle.Fill;
            }
        }
    }
}
