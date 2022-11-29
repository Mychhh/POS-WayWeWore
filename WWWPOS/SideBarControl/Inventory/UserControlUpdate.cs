using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.SideBarControl.Inventory
{
    public partial class UserControlUpdate : UserControl
    {
        public UserControlUpdate()
        {
            InitializeComponent();
        }

        private void UserControlUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btn_ViewAllProduct_Click_1(object sender, EventArgs e)
        {
            UserControlViewUpdate UC_ViewUpdate = new UserControlViewUpdate();

            Controls.Clear();
            Controls.Add(UC_ViewUpdate);
            UC_ViewUpdate.Dock = DockStyle.Fill;
        }

        //public void remove()
        //{
        //    UserControlInventory UC_Inventory = new UserControlInventory();

        //    UC_Inventory.panel_Inventory.Controls.Clear();
        //    Controls.Clear();
        //}

        private void btn_Save_Click(object sender, EventArgs e)
        {
            UserControlRead UC_Read = new UserControlRead();

            Controls.Clear();
            Controls.Add(UC_Read);
            UC_Read.Dock = DockStyle.Fill;
        }
    }
}
