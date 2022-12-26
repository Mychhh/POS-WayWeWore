using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            UserControlViewUpdate UC_ViewUpdate = new UserControlViewUpdate();
            UC_ViewUpdate.flowLayoutPanel.Controls.Clear();

            Class_LoadData LD = new Class_LoadData();
            LD.selectProduct(UC_ViewUpdate.flowLayoutPanel, "panelEdit");


            DataBase DB = new DataBase();

            int productID = Int32.Parse(txtBox_productID.Text);
            double productPrice = Double.Parse(txtBox_Price.Text);
            int productStock = Int32.Parse(txtBox_Stocks.Text);

            DB.UpdateProducts(productID, comboBox_ProductType.Text, txtBox_ProductName.Text, txtBox_Color.Text, productPrice, productStock, comboBox_Size.Text, rtb_Description.Text);

        }

        public static string imageURL = null;
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageURL = ofd.FileName;
                    product_Image.Image = Image.FromFile(ofd.FileName);
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
    }
}
