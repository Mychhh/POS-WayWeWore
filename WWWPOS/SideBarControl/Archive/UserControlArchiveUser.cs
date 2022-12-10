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
    public partial class UserControlArchiveUser : UserControl
    {
        public UserControlArchiveUser()
        {
            InitializeComponent();
        }

        private void UserControlArchiveUser_Load(object sender, EventArgs e)
        {
            loadData LD = new loadData();
            LD.userArchive(dataGrid_ArchiveUser, "DEL");
        }
        public static string user_ID;
        private void dataGrid_ArchiveUser_SelectionChanged(object sender, EventArgs e)
        {
            int row = dataGrid_ArchiveUser.CurrentRow.Index;
            user_ID = dataGrid_ArchiveUser[0, row].Value.ToString();
        }
        private void dataGrid_ArchiveUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGrid_ArchiveUser.Columns[e.ColumnIndex].Name;

            if (colName == "restore")
            {
                DataBase DB = new DataBase();
                DB.setStatusUser("nDEL", user_ID);
            }
        }

        
    }
}
