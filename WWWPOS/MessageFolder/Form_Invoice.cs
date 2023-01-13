using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.ClientControl.ClientCart;

namespace WWWPOS.MessageFolder
{
    public partial class Form_Invoice : Form
    {
        public Form_Invoice()
        {
            InitializeComponent();
        }

        private void btn_Okay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
