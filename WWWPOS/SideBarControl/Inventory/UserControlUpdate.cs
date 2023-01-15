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

namespace WWWPOS.SideBarControl.Inventory
{
    public partial class UserControlUpdate : UserControl
    {
        public UserControlUpdate()
        {
            InitializeComponent();
        }

        private void btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            //UserControlViewUpdate UC_ViewUpdate = new UserControlViewUpdate();
            //UC_ViewUpdate.flowLayoutPanel.Controls.Clear();

            //Class_LoadData LD = new Class_LoadData();
            //LD.selectProduct(UC_ViewUpdate.flowLayoutPanel, "panelEdit");


            DataBase DB = new DataBase();

            //int productID = Int32.Parse(txtBox_productID.Text);
            //double productPrice = Double.Parse(txtBox_Price.Text);
            //int productStock = Int32.Parse(txtBox_Stocks.Text);

            DB.UpdateProducts(Convert.ToInt32(txtBox_productID.Text), comboBox_ProductType.Text, txtBox_ProductName.Text,
                              txtBox_Color.Text, Convert.ToDouble(txtBox_Price.Text), Convert.ToInt32(txtBox_Stocks.Text),
                              comboBox_Size.Text, rtb_Description.Text);

            DataBase.message = "";

            //This close and add new form
            Form_AdminHome form_AdminHome = new Form_AdminHome();
            WWWPOS.Form_AdminHome.ActiveForm.Hide();
            DataBase.fromWhat = "InventoryUpdate";
            form_AdminHome.ShowDialog();

        }

        public static string imageURL = null;
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FileName.Contains(".jfif") || ofd.FileName.Contains(".JFIF") ||
                        ofd.FileName.Contains(".png") || ofd.FileName.Contains(".PNG") ||
                        ofd.FileName.Contains(".gif") || ofd.FileName.Contains(".GIF") ||
                        ofd.FileName.Contains(".webp") || ofd.FileName.Contains(".WEBP") ||
                        ofd.FileName.Contains(".svg") || ofd.FileName.Contains(".SVG") ||
                        ofd.FileName.Contains(".jpeg") || ofd.FileName.Contains(".JPEG")
                       )
                    {
                        imageURL = ofd.FileName;
                        product_Image.Image = Image.FromFile(ofd.FileName);
                    }
                    else
                    {
                        SuccessMessageDialogue sas = new SuccessMessageDialogue("Invalid File");
                        sas.ShowDialog();
                    }
                }
            }
        }

        private void rtb_Description_Enter(object sender, EventArgs e)
        {
            if (rtb_Description.Text == "Description")
            {
                rtb_Description.Text = "";
            }

        }

        private void rtb_Description_Leave(object sender, EventArgs e)
        {
            if (rtb_Description.Text == "")
            {
                rtb_Description.Text = "Description";
            }
        }

        //Forms Validation 
        ErrorMessageDialogue errorMessageDialogue = new ErrorMessageDialogue("Maximum input reached");

        private void txtBox_ProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_ProductName.TextLength > 20)
            {
                errorMessageDialogue.ShowDialog();
                txtBox_ProductName.Text = txtBox_ProductName.Text.Remove(20);
            }
        }

        private void txtBox_Color_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_Color.TextLength > 15)
            {
                errorMessageDialogue.ShowDialog();
                txtBox_Color.Text = txtBox_Color.Text.Remove(15);
            }
        }

        private void txtBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void txtBox_Stocks_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void rtb_Description_TextChanged(object sender, EventArgs e)
        {
            if (rtb_Description.TextLength > 50)
            {
                errorMessageDialogue.ShowDialog();
                rtb_Description.Text = rtb_Description.Text.Remove(50);
            }
        }

        private void txtBox_Price_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_Price.Text.Length > 7)
            {
                errorMessageDialogue.ShowDialog();
                txtBox_Price.Text = txtBox_Price.Text.Remove(7);
            }
        }

        private void txtBox_Stocks_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_Stocks.Text.Length > 7)
            {
                errorMessageDialogue.ShowDialog();
                txtBox_Stocks.Text = txtBox_Stocks.Text.Remove(7);
            }
        }
    }
}
