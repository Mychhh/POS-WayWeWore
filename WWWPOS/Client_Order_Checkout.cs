using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS
{
    public partial class Client_Order_Checkout : Form
    {
        ClientControl.UserControl_ViewCart viewCart = new ClientControl.UserControl_ViewCart();
        public Client_Order_Checkout()
        {
            InitializeComponent();
        }

        private void Client_Order_Checkout_Load(object sender, EventArgs e)
        {
            PanelControl.Controls.Clear();
            PanelControl.Controls.Add(viewCart);
            viewCart.Dock = DockStyle.Fill;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
