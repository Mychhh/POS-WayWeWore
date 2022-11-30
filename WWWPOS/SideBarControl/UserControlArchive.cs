using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.SideBarControl
{
    public partial class UserControlArchive : UserControl
    {
        public UserControlArchive()
        {
            InitializeComponent();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            Archive.UserControlArchiveUser UC_User = new Archive.UserControlArchiveUser();

            panel_Archive.Controls.Clear();
            panel_Archive.Controls.Add(UC_User);
            UC_User.Dock = DockStyle.Fill;

        }

        private void btn_Product_Click(object sender, EventArgs e)
        {

            Archive.UserControlArchiveProduct UC_Product = new Archive.UserControlArchiveProduct();

            panel_Archive.Controls.Clear();
            panel_Archive.Controls.Add(UC_Product);
            UC_Product.Dock = DockStyle.Fill;
        }
    }
}
