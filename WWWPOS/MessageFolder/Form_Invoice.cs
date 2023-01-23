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
        //Printing
        Bitmap BitmapToPrint;
        private void CaptureFormShot()
        {
            BitmapToPrint = new Bitmap(flowLayoutPanel.Width, flowLayoutPanel.Height);
            this.DrawToBitmap(BitmapToPrint, new Rectangle(0, 0, flowLayoutPanel.Width, flowLayoutPanel.Height));
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle m = new Rectangle(0, 0, flowLayoutPanel.Width, flowLayoutPanel.Height);
            e.Graphics.DrawImage(BitmapToPrint, m);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            CaptureFormShot();
            printPreviewDialog1.ShowDialog();

            DataBase DB = new DataBase();
            DB.ActivityLog("PrintInvoice");
        }

    }
}
