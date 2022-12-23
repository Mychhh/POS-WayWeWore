using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.ClientControl.ClientCart
{
    public partial class Form_ClientCart : Form
    {
        public Form_ClientCart()
        {
            InitializeComponent();
        }

        private void btn_BrowseProduct_Click(object sender, EventArgs e)
        {
            this.Close();

            Form_ClientLandingPage clientForm = new Form_ClientLandingPage();
            clientForm.ShowDialog();
        }
    }
}
