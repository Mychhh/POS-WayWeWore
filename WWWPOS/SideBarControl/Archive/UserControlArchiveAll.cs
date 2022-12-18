using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.SideBarControl.UserList;

namespace WWWPOS.SideBarControl.Archive
{
    public partial class UserControlArchiveAll : UserControl
    {
        public UserControlArchiveAll()
        {
            InitializeComponent();
        }
        //method for refresh
        public void ArchiveRefreshOnRestore()
        {
            UserControlArchiveAll UC_ArchiveAll = new UserControlArchiveAll();

            Controls.Clear();
            Controls.Add(UC_ArchiveAll);
            UC_ArchiveAll.Dock = DockStyle.Fill;
        }

        public static string user_ID, product_ID;
        private void UserControlArchiveAll_Load(object sender, EventArgs e)
        {
            loadData LD = new loadData();
            LD.userArchive(dataGrid_ArchiveUserAll, "Inactive");
            LD.ProductArchive(dataGrid_ArchiveProductALL, "Inactive");
        }
        //User
        private void dataGrid_ArchiveUserAll_SelectionChanged(object sender, EventArgs e)
        {
            int row = dataGrid_ArchiveUserAll.CurrentRow.Index;
            user_ID = dataGrid_ArchiveUserAll[0, row].Value.ToString();
        }

        //Product
        private void dataGrid_ArchiveProductALL_SelectionChanged(object sender, EventArgs e)
        {
            int row = dataGrid_ArchiveProductALL.CurrentRow.Index;
            product_ID = dataGrid_ArchiveProductALL[0, row].Value.ToString();
        }

        //User Restore
        private void dataGrid_ArchiveUserAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGrid_ArchiveUserAll.Columns[e.ColumnIndex].Name;

            if (colName == "restoreUser")
            {
                DataBase DB = new DataBase();
                DB.SetStatusUser("Active", Int32.Parse(user_ID));

                ArchiveRefreshOnRestore();
            }
        }

        //Product Restore
        private void dataGrid_ArchiveProductALL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGrid_ArchiveProductALL.Columns[e.ColumnIndex].Name;

            if (colName == "restoreProduct")
            {
                DataBase DB = new DataBase();
                DB.SetStatusProducts("Active", Int32.Parse(product_ID));

                ArchiveRefreshOnRestore();
            }
        }

    }
}
