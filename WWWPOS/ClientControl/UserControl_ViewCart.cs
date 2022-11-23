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
    public partial class UserControl_ViewCart : UserControl
    {

        public UserControl_ViewCart()
        {
            InitializeComponent();
        }

        private void btn_BrowseProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client client = new Client();
            client.ShowDialog();
     

        }
    }
}
