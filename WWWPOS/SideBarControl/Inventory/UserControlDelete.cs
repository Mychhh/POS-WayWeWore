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
    public partial class UserControlDelete : UserControl
    {
        public UserControlDelete()
        {
            InitializeComponent();
        }

        private void UserControlDelete_Load(object sender, EventArgs e)
        {
            loadData LD = new loadData();
            LD.selectProduct(tableLayoutPanel, "panelDelete");
        }

    }
}
