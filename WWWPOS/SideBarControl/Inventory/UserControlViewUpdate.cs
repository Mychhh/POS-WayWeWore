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
        //UserControlInventory UCI = new UserControlInventory();
        //UserControlUpdate UC_Update =  new UserControlUpdate();

        public UserControlViewUpdate()
        {
            InitializeComponent();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            UserControlInventory UCI = new UserControlInventory();
            UserControlUpdate UC_Update = new UserControlUpdate();
            //UserControlViewUpdate UC_ViewUpdate = new UserControlViewUpdate();

            //typeof(UserControlInventory).GetMethod("panel_Inventory", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(new UserControlInventory(), null);

            this.Hide();
            UCI.panel_Inventory.Controls.Clear();
            UCI.panel_Inventory.Controls.Add(UC_Update);
            UC_Update.Dock = DockStyle.Fill;
            //UCI.panel_Inventory.Controls.Remove(UC_ViewUpdate);

            Console.WriteLine("I am here");

            //Console.WriteLine("I am here");
        }
    }
}
