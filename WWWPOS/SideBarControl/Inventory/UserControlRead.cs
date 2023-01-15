using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.SideBarControl.Products;

namespace WWWPOS.SideBarControl.Inventory
{
    public partial class UserControlRead : UserControl
    {
        public UserControlRead()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
        }

        private void UserControlRead_Load(object sender, EventArgs e)
        {
            Class_LoadData LD = new Class_LoadData();
            LD.selectProduct(flowLayoutPanel, "panelView");
            this.BackColor = Color.Transparent;
        }
    }
}

