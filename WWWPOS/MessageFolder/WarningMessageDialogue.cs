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
    public partial class WarningMessageDialogue : Form
    {
        public WarningMessageDialogue(string warningMessage)
        {
            InitializeComponent();
            WarningMessage = warningMessage;

        }
        public string WarningMessage
        {
            get => lbl_WarningMessage.Text;
            set => lbl_WarningMessage.Text = value;
        }
        private void WarningMessageDialogue_Load(object sender, EventArgs e)
        {
            lbl_WarningMessage.Location = new Point((this.ClientSize.Width - lbl_WarningMessage.Width) / 2, (this.ClientSize.Height - lbl_WarningMessage.Height) / 2);
        }

        private void btn_Alright_Click(object sender, EventArgs e)
        {
            DataBase.message = "continue";
            this.Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
