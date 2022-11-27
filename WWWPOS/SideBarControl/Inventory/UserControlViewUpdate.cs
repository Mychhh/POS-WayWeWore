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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            UserControlUpdate UC_Update = new UserControlUpdate();

            Controls.Clear();
            Controls.Add(UC_Update);
            UC_Update.Dock = DockStyle.Fill;
        }
    }
}
