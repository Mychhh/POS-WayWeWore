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
    public partial class UserControlCreate : UserControl
    {
        public UserControlCreate()
        {
            InitializeComponent();
        }

        DataBase DB = new DataBase();
     
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
        public static string imageURL = null;
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FileName.Contains(".jfif") || ofd.FileName.Contains(".JFIF") || 
                        ofd.FileName.Contains(".png") || ofd.FileName.Contains(".PNG") ||
                        ofd.FileName.Contains(".gif") || ofd.FileName.Contains(".GIF") ||
                        ofd.FileName.Contains(".webp") || ofd.FileName.Contains(".WEBP") ||
                        ofd.FileName.Contains(".svg") || ofd.FileName.Contains(".SVG") || 
                        ofd.FileName.Contains(".jpg") || ofd.FileName.Contains(".JPG") || 
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
        private void btn_AddProduct_Click(object sender, EventArgs e)
        {

            if (txtBox_ProductName.Text.Length == 0 || comboBox_ProductType.Text == "" || comboBox_Size.Text == "" || txtBox_Color.Text.Length == 0 || txtBox_Price.Text.Length == 0 || txtBox_Stocks.Text.Length == 0 || rtb_Description.Text.Length == 0)
            {
                ErrorMessageDialogue errorMessageDialogue = new ErrorMessageDialogue("Fill out required fields");
                errorMessageDialogue.ShowDialog();
            }
            else if (imageURL != null && !(txtBox_ProductName.Text.Length == 0 || comboBox_ProductType.Text == "" || comboBox_Size.Text == "" || txtBox_Color.Text.Length == 0 || txtBox_Price.Text.Length == 0 || txtBox_Stocks.Text.Length == 0 || rtb_Description.Text.Length == 0))
            {
                double product_Price = Double.Parse(txtBox_Price.Text);
                int product_Stock = Int32.Parse(txtBox_Stocks.Text);

                DB.AddProdducts(txtBox_ProductName.Text, txtBox_Color.Text, product_Price, product_Stock, comboBox_ProductType.Text, comboBox_Size.Text, imageURL, rtb_Description.Text);
            }
            else if (imageURL == null)
            {
                ErrorMessageDialogue errorMessageDialogue = new ErrorMessageDialogue("Please select an Image");
                errorMessageDialogue.ShowDialog();
            }
            //DB.AddProdducts(txtBox_ProductName.Text, txtBox_Color.Text, product_Price, product_Stock, comboBox_ProductType.Text, comboBox_Size.Text, imageURL, rtb_Description.Text);

            if (DataBase.message == "Success")
            {
                UserControlRead UC_Read = new UserControlRead();

                Controls.Clear();
                UC_Read.BackColor = Color.Transparent;
                Controls.Add(UC_Read);
                UC_Read.Dock = DockStyle.Fill;
            }

        }

        //Forms Validation 
        ErrorMessageDialogue errorMessageDialogue = new ErrorMessageDialogue("Maximum Text Reached");
        private void txtBox_ProductName_TextChanged(object sender, EventArgs e)
        {
            if(txtBox_ProductName.TextLength > 20)
            {
                errorMessageDialogue.ShowDialog();
                txtBox_ProductName.Text = txtBox_ProductName.Text.Remove(19);
            }
        }

        private void rtb_Description_TextChanged(object sender, EventArgs e)
        {
            if (rtb_Description.TextLength > 50)
            {
                errorMessageDialogue.ShowDialog();
                rtb_Description.Text = rtb_Description.Text.Remove(49);
            }
        }

        private void txtBox_Color_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_Color.TextLength > 15)
            {
                errorMessageDialogue.ShowDialog();
                txtBox_Color.Text = txtBox_Color.Text.Remove(14);
            }
        }

        private void txtBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) &&  ch != Convert.ToChar(Keys.Delete))
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
