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
    public partial class UserControlArchiveProduct : UserControl
    {
        public UserControlArchiveProduct()
        {
            InitializeComponent();
        }

        private void UserControlArchiveProduct_Load(object sender, EventArgs e)
        {
            loadData LD = new loadData();
            LD.ProductArchive(dataGrid_ArchiveProduct, "Inactive");

        }
        public static string user_ID;
        private void dataGrid_ArchiveProduct_SelectionChanged(object sender, EventArgs e)
        {
            int row = dataGrid_ArchiveProduct.CurrentRow.Index;
            user_ID = dataGrid_ArchiveProduct[0, row].Value.ToString();
        }

        private void dataGrid_ArchiveProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGrid_ArchiveProduct.Columns[e.ColumnIndex].Name;

            if (colName == "restoreProduct")
            {
                DataBase DB = new DataBase();
                DB.SetStatusProducts("Active", Int32.Parse(user_ID));

                UserControlArchiveProduct userControlArchiveProduct = new UserControlArchiveProduct();

                Controls.Clear();
                Controls.Add(userControlArchiveProduct);
                userControlArchiveProduct.Dock = DockStyle.Fill;
            }
        }
    }
}
