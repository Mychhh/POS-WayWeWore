using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.SideBarControl.Archive
{
    public partial class UserControlArchiveAll : UserControl
    {
        public UserControlArchiveAll()
        {
            InitializeComponent();
        }
        public static string user_ID, product_ID;
        private void UserControlArchiveAll_Load(object sender, EventArgs e)
        {
            loadData LD = new loadData();
            LD.userArchive(dataGrid_ArchiveUserAll, "DEL");
            LD.ProductArchive(dataGrid_ArchiveProductALL, "DEL");
        }
        private void dataGrid_ArchiveUserAll_SelectionChanged(object sender, EventArgs e)
        {
            int row = dataGrid_ArchiveUserAll.CurrentRow.Index;
            user_ID = dataGrid_ArchiveUserAll[0, row].Value.ToString();
        }

        private void dataGrid_ArchiveUserAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGrid_ArchiveUserAll.Columns[e.ColumnIndex].Name;

            if (colName == "restore")
            {
                DataBase DB = new DataBase();
                DB.SetStatusUser("nDEL", Int32.Parse(user_ID));
            }
        }

        private void dataGrid_ArchiveProductALL_SelectionChanged(object sender, EventArgs e)
        {
            int row = dataGrid_ArchiveProductALL.CurrentRow.Index;
            product_ID = dataGrid_ArchiveProductALL[0, row].Value.ToString();
        }

        private void dataGrid_ArchiveProductALL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGrid_ArchiveProductALL.Columns[e.ColumnIndex].Name;

            if (colName == "restore")
            {
                DataBase DB = new DataBase();
                DB.SetStatusProducts("nDEL", Int32.Parse(product_ID));
            }
        }
    }
}
