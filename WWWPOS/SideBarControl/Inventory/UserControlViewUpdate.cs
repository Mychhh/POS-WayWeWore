using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Reflection;

namespace WWWPOS.SideBarControl.Inventory
{
    public partial class UserControlViewUpdate : UserControl
    {

        public UserControlViewUpdate()
        {
            InitializeComponent();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            UserControlInventory UCI = new UserControlInventory();
            UserControlUpdate UC_Update = new UserControlUpdate();

            UCI.panel_Inventory.Controls.Remove(this);
            UCI.panel_Inventory.Controls.Clear();
            UCI.panel_Inventory.Controls.Add(UC_Update);
            UC_Update.Dock = DockStyle.Fill;

            //if (!UCI.panel_Inventory.Controls.Contains(UC_Update))
            //{

            //    UCI.panel_Inventory.Controls.Add(UC_Update);
            //}

            Console.WriteLine("I am here");
        }
    }
}
