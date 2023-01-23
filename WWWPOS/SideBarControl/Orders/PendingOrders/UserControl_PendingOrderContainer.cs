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
            OrderNumberWithoutSign = ordernumber;
        }

        public int OrderNumber
        {
            get => Int32.Parse(lbl_OrderNumber.Text);
            set => lbl_OrderNumber.Text = "Order Number : " + value + "";
        }
        public int OrderNumberWithoutSign { get; set; }

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
            WarningMessageDialogue warningMessageDialogue = new WarningMessageDialogue("Complete this Orders?");
            warningMessageDialogue.ShowDialog();

            if (DataBase.message == "continue")
            {
                DataBase.message = "";

                //SuccessMessageDialogue successMessageDialogue = new SuccessMessageDialogue("Order marked as Success");
                //successMessageDialogue.ShowDialog();

                //Updates the order status
                DataBase DB = new DataBase();
                DB.OrderSuccess(OrderNumberWithoutSign);
                
                DB.InvoiceCashier(OrderNumberWithoutSign);

                //Deduct Product stocks
                DB.DeductProductStock(OrderNumberWithoutSign);

                Form_AdminHome form_AdminHome = new Form_AdminHome();
                Form_AdminHome.ActiveForm.Dispose();
                DataBase.fromWhat = "OrdersDelete";
                form_AdminHome.ShowDialog();

            }
        }

        private void btn_MarkAsFailed_Click(object sender, EventArgs e)
        {
            WarningMessageDialogue warningMessageDialogue = new WarningMessageDialogue("Remove this Orders?");
            warningMessageDialogue.ShowDialog();

            if (DataBase.message == "continue")
            {
                DataBase.message = "";

                SuccessMessageDialogue successMessageDialogue = new SuccessMessageDialogue("Order succesfully removed");
                successMessageDialogue.ShowDialog();

                DataBase DB = new DataBase();
                DB.RemoveOrders(OrderNumberWithoutSign);

                Form_AdminHome form_AdminHome = new Form_AdminHome();
                Form_AdminHome.ActiveForm.Dispose();
                DataBase.fromWhat = "OrdersDelete";
                form_AdminHome.ShowDialog();

            }
        }
    }
}
