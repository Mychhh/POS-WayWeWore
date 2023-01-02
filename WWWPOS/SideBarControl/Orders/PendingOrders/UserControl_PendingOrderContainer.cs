using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.ErrorMessage;
using WWWPOS.MessageFolder;

namespace WWWPOS.SideBarControl.Orders.PendingOrders
{
    public partial class UserControl_PendingOrderContainer : UserControl
    {
        public UserControl_PendingOrderContainer(int ordernumber)
        {
            InitializeComponent();

            OrderNumber = ordernumber;
        }

        public int OrderNumber
        {
            get => Int32.Parse(lbl_OrderNumber.Text);
            set => lbl_OrderNumber.Text = "Order Number : " + value + "";
        }

        private void btn_Compute_Click(object sender, EventArgs e)
        {

            if (txtBox_ClientPay.Text == "")
            {
                ErrorMessageDialogue errorMessageDialogue = new ErrorMessageDialogue("No amount");
                errorMessageDialogue.ShowDialog();
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtBox_ClientPay.Text, @"^[a-zA-Z]+$"))
            {
                ErrorMessageDialogue errorMessageDialogue = new ErrorMessageDialogue("Only numbers is Allowed");
                errorMessageDialogue.ShowDialog();
            }
            else if (Convert.ToInt32(txtBox_ClientPay.Text) < Convert.ToInt32(lbl_OrderTotal.Text))
            {
                ErrorMessageDialogue errorMessageDialogue = new ErrorMessageDialogue("Payment is less than the total cost");
                errorMessageDialogue.ShowDialog();
            }
            else
            {
                lbl_Change.Text = (Convert.ToInt32(txtBox_ClientPay.Text) - Convert.ToInt32(lbl_OrderTotal.Text)).ToString();
            }
        }

        private void btn_MarkAsSuccess_Click(object sender, EventArgs e)
        {
        }

        private void btn_MarkAsFailed_Click(object sender, EventArgs e)
        {

        }
    }
}
