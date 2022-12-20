using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.ClientControl
{
    public partial class UserControl_ClientCart : UserControl
    {
        public UserControl_ClientCart()
        {
            InitializeComponent();
        }

        private void btn_BrowseProduct_Click(object sender, EventArgs e)
        {
            Form_ClientLandingPage clientForm = new Form_ClientLandingPage();
            UserControl_ClientViewProduct UC_ClientViewProduct = new UserControl_ClientViewProduct();

            clientForm.panel_MainClient.Controls.Clear();
            clientForm.panel_MainClient.Controls.Add(UC_ClientViewProduct);
            UC_ClientViewProduct.Dock = DockStyle.Fill;
        }
    }
}
