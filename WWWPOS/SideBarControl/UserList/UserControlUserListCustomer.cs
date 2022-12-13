using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.Modal;

namespace WWWPOS.SideBarControl.UserList
{
    public partial class UserControlUserListCustomer : UserControl
    {
        public UserControlUserListCustomer()
        {
            InitializeComponent();
        }

        public static string user_ID, user_Name, user_Email, user_Password, user_Phone, user_Address, user_Type;
        Update_Delete UP = new Update_Delete();
        private void dataGridCustomer_SelectionChanged(object sender, EventArgs e)
        {
            int row = dataGridCustomer.CurrentRow.Index;

            user_ID = dataGridCustomer[0, row].Value.ToString();
            user_Name = dataGridCustomer[1, row].Value.ToString();
            user_Email = dataGridCustomer[2, row].Value.ToString();
            user_Password = dataGridCustomer[3, row].Value.ToString();
            user_Phone = dataGridCustomer[4, row].Value.ToString();
            user_Address = dataGridCustomer[5, row].Value.ToString();
            user_Type = dataGridCustomer[7, row].Value.ToString();
        }

       
        private void dataGridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridCustomer.Columns[e.ColumnIndex].Name;

            if(colName == "edit_User")
            {
                UP.txt_AccountID.Text = user_ID;
                UP.txt_Name.Text = user_Name;
                UP.txt_Email.Text = user_Email;
                UP.txt_Password.Text = user_Password;
                UP.txt_Number.Text = user_Phone;
                UP.txt_Address.Text = user_Address;
                UP.txt_UserType.Text = user_Type;
                UP.ShowDialog();


            }
            else if(colName == "delete_User")
            {
                DataBase DB = new DataBase();
                DB.SetStatusUser("Inactive", Int32.Parse(user_ID));
            }


        }

        private void UserControlUserListCustomer_Load(object sender, EventArgs e)
        {
            loadData LD = new loadData();
            LD.userRecords(dataGridCustomer, "Client", "nDEL");
        }
    }
}
