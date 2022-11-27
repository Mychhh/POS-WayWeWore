using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using WWWPOS.SideBarControl.Inventory;

namespace WWWPOS.SideBarControl
{
    public partial class UserControlInventory : UserControl
    {
        //Initialized Inventory UserControl
        Inventory.UserControlRead UC_Read =  new Inventory.UserControlRead();
        Inventory.UserControlCreate UC_Create = new Inventory.UserControlCreate();
        Inventory.UserControlViewUpdate UC_ViewUpdate = new Inventory.UserControlViewUpdate();
        Inventory.UserControlDelete UC_Delete = new Inventory.UserControlDelete();

        public UserControlInventory()
        {
            InitializeComponent();
        }

        private void UserControlInventory_Load(object sender, EventArgs e)
        {
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            panel_Inventory.Controls.Clear();
            panel_Inventory.Controls.Add(UC_Create);
            UC_Create.Dock = DockStyle.Fill;
        }

        private void btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            panel_Inventory.Controls.Clear();
            panel_Inventory.Controls.Add(UC_ViewUpdate);
            UC_ViewUpdate.Dock = DockStyle.Fill;
        }
        
        private void btn_DeleteProduct_Click_1(object sender, EventArgs e)
        {
            panel_Inventory.Controls.Clear();
            panel_Inventory.Controls.Add(UC_Delete);
            UC_Delete.Dock = DockStyle.Fill;
        }

    }
}
