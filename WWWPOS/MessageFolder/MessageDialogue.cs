using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.ErrorMessage
{
    public partial class MessageDialogue : Form
    {
        public MessageDialogue(string errorMessage)
        {
            InitializeComponent();
            ErrorMessage  = errorMessage;
        }

        public string ErrorMessage
        {
            get => lbl_ErrorMessage.Text;
            set => lbl_ErrorMessage.Text = value;
        }

        private void ClientMaximumQty_Load(object sender, EventArgs e)
        {
            //Centers the error message
            lbl_ErrorMessage.Location = new Point((this.ClientSize.Width - lbl_ErrorMessage.Width) / 2, (this.ClientSize.Height - lbl_ErrorMessage.Height) / 2);
        }

        private void btn_Alright_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
