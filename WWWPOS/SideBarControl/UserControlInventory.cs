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
    public partial class UserControlInventory : UserControl
    {
        //Initialized Inventory UserControl
        Inventory.UserControlRead UC_Read =  new Inventory.UserControlRead();
        Inventory.UserControlCreate UC_Create = new Inventory.UserControlCreate();

        public UserControlInventory()
        {
            InitializeComponent();
        }

        private void UserControlInventory_Load(object sender, EventArgs e)
        {
            //panel_Inventory.Controls.Clear();
            panel_Inventory.Controls.Add(UC_Read);
            UC_Read.Dock = DockStyle.Fill;
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            panel_Inventory.Controls.Clear();
            panel_Inventory.Controls.Add(UC_Create);
            UC_Create.Dock = DockStyle.Fill;
        }
    }
}
