using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.MessageFolder
{
    public partial class SuccessMessageDialogue : Form
    {
        public SuccessMessageDialogue(string successMessage)
        {
            InitializeComponent();
            SuccessMessage = successMessage;
        }
        public string SuccessMessage
        {
            get => lbl_SuccessMessage.Text;
            set => lbl_SuccessMessage.Text = value;
        }
        private void SuccessMessageDialogue_Load(object sender, EventArgs e)
        {
            lbl_SuccessMessage.Location = new Point((this.ClientSize.Width - lbl_SuccessMessage.Width) / 2, (this.ClientSize.Height - lbl_SuccessMessage.Height) / 2);
        }
        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Alright_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
