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
        public static string user_ID;
        private void UserControlArchiveAll_Load(object sender, EventArgs e)
        {
            loadData LD = new loadData();
            LD.userArchive(dataGrid_ArchiveUserAll, "DEL");
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
                DB.setStatusUser("nDEL", user_ID);
            }
        }
    }
}
