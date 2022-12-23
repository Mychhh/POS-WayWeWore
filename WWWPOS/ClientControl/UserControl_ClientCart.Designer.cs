namespace WWWPOS.ClientControl
{
    partial class UserControl_ClientCart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_BrowseProduct = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_TotalCart = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_ProductCart = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_ClientCartProduct = new System.Windows.Forms.Panel();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.cmb_Color = new System.Windows.Forms.ComboBox();
            this.lbl_ProductQty = new System.Windows.Forms.Label();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.cmb_ProductSize = new System.Windows.Forms.ComboBox();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.lbl_ProductDescription = new System.Windows.Forms.Label();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.picBox_ProductPicture = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel_ProductCart.SuspendLayout();
            this.panel_ClientCartProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(56, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(13, 49, 13, 49);
            this.panel2.Size = new System.Drawing.Size(181, 40);
            this.panel2.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 7);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Shopping Cart";
            // 
            // btn_BrowseProduct
            // 
            this.btn_BrowseProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(116)))));
            this.btn_BrowseProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BrowseProduct.FlatAppearance.BorderSize = 0;
            this.btn_BrowseProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BrowseProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowseProduct.Location = new System.Drawing.Point(1188, 16);
            this.btn_BrowseProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BrowseProduct.Name = "btn_BrowseProduct";
            this.btn_BrowseProduct.Size = new System.Drawing.Size(175, 40);
            this.btn_BrowseProduct.TabIndex = 1;
            this.btn_BrowseProduct.Text = "Browse Products";
            this.btn_BrowseProduct.UseVisualStyleBackColor = false;
            this.btn_BrowseProduct.Click += new System.EventHandler(this.btn_BrowseProduct_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(165)))));
            this.panel4.Controls.Add(this.lbl_TotalCart);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(56, 545);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1307, 63);
            this.panel4.TabIndex = 11;
            // 
            // lbl_TotalCart
            // 
            this.lbl_TotalCart.ForeColor = System.Drawing.Color.White;
            this.lbl_TotalCart.Location = new System.Drawing.Point(153, 15);
            this.lbl_TotalCart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotalCart.Name = "lbl_TotalCart";
            this.lbl_TotalCart.Size = new System.Drawing.Size(100, 39);
            this.lbl_TotalCart.TabIndex = 30;
            this.lbl_TotalCart.Text = "$ 1,100";
            this.lbl_TotalCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(793, 15);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(481, 39);
            this.button9.TabIndex = 29;
            this.button9.Text = "Pay";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(24, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 39);
            this.label15.TabIndex = 27;
            this.label15.Text = "Total Price : ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_ProductCart
            // 
            this.flowLayoutPanel_ProductCart.AutoScroll = true;
            this.flowLayoutPanel_ProductCart.Controls.Add(this.panel_ClientCartProduct);
            this.flowLayoutPanel_ProductCart.Location = new System.Drawing.Point(56, 83);
            this.flowLayoutPanel_ProductCart.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_ProductCart.Name = "flowLayoutPanel_ProductCart";
            this.flowLayoutPanel_ProductCart.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.flowLayoutPanel_ProductCart.Size = new System.Drawing.Size(1307, 440);
            this.flowLayoutPanel_ProductCart.TabIndex = 10;
            // 
            // panel_ClientCartProduct
            // 
            this.panel_ClientCartProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(165)))));
            this.panel_ClientCartProduct.Controls.Add(this.btn_DeleteProduct);
            this.panel_ClientCartProduct.Controls.Add(this.lbl_Category);
            this.panel_ClientCartProduct.Controls.Add(this.cmb_Color);
            this.panel_ClientCartProduct.Controls.Add(this.lbl_ProductQty);
            this.panel_ClientCartProduct.Controls.Add(this.btn_Plus);
            this.panel_ClientCartProduct.Controls.Add(this.cmb_ProductSize);
            this.panel_ClientCartProduct.Controls.Add(this.btn_Minus);
            this.panel_ClientCartProduct.Controls.Add(this.lbl_ProductDescription);
            this.panel_ClientCartProduct.Controls.Add(this.lbl_ProductPrice);
            this.panel_ClientCartProduct.Controls.Add(this.picBox_ProductPicture);
            this.panel_ClientCartProduct.Location = new System.Drawing.Point(10, 5);
            this.panel_ClientCartProduct.Margin = new System.Windows.Forms.Padding(0, 5, 35, 5);
            this.panel_ClientCartProduct.Name = "panel_ClientCartProduct";
            this.panel_ClientCartProduct.Size = new System.Drawing.Size(591, 213);
            this.panel_ClientCartProduct.TabIndex = 0;
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.BackColor = System.Drawing.Color.Black;
            this.btn_DeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteProduct.FlatAppearance.BorderSize = 0;
            this.btn_DeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteProduct.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_DeleteProduct.Location = new System.Drawing.Point(559, 6);
            this.btn_DeleteProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(25, 25);
            this.btn_DeleteProduct.TabIndex = 60;
            this.btn_DeleteProduct.Text = "X";
            this.btn_DeleteProduct.UseVisualStyleBackColor = false;
            // 
            // lbl_Category
            // 
            this.lbl_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(116)))));
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(340, 40);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.lbl_Category.Size = new System.Drawing.Size(111, 28);
            this.lbl_Category.TabIndex = 59;
            this.lbl_Category.Text = "Category";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Color
            // 
            this.cmb_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Color.FormattingEnabled = true;
            this.cmb_Color.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Green",
            "Violet",
            "Orange",
            "Black",
            "White"});
            this.cmb_Color.Location = new System.Drawing.Point(407, 85);
            this.cmb_Color.Name = "cmb_Color";
            this.cmb_Color.Size = new System.Drawing.Size(175, 26);
            this.cmb_Color.TabIndex = 58;
            // 
            // lbl_ProductQty
            // 
            this.lbl_ProductQty.BackColor = System.Drawing.Color.Silver;
            this.lbl_ProductQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductQty.Location = new System.Drawing.Point(490, 40);
            this.lbl_ProductQty.Name = "lbl_ProductQty";
            this.lbl_ProductQty.Size = new System.Drawing.Size(47, 28);
            this.lbl_ProductQty.TabIndex = 56;
            this.lbl_ProductQty.Text = "1";
            this.lbl_ProductQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Plus
            // 
            this.btn_Plus.BackColor = System.Drawing.Color.Transparent;
            this.btn_Plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Plus.FlatAppearance.BorderSize = 0;
            this.btn_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Plus.Location = new System.Drawing.Point(540, 34);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(41, 38);
            this.btn_Plus.TabIndex = 54;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = false;
            // 
            // cmb_ProductSize
            // 
            this.cmb_ProductSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_ProductSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ProductSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProductSize.FormattingEnabled = true;
            this.cmb_ProductSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Extra Large"});
            this.cmb_ProductSize.Location = new System.Drawing.Point(216, 85);
            this.cmb_ProductSize.Name = "cmb_ProductSize";
            this.cmb_ProductSize.Size = new System.Drawing.Size(175, 26);
            this.cmb_ProductSize.TabIndex = 57;
            // 
            // btn_Minus
            // 
            this.btn_Minus.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minus.FlatAppearance.BorderSize = 0;
            this.btn_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minus.Location = new System.Drawing.Point(459, 35);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(25, 31);
            this.btn_Minus.TabIndex = 55;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = false;
            // 
            // lbl_ProductDescription
            // 
            this.lbl_ProductDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_ProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductDescription.Location = new System.Drawing.Point(216, 125);
            this.lbl_ProductDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ProductDescription.Name = "lbl_ProductDescription";
            this.lbl_ProductDescription.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbl_ProductDescription.Size = new System.Drawing.Size(362, 50);
            this.lbl_ProductDescription.TabIndex = 53;
            this.lbl_ProductDescription.Text = "Item Description Lorem Ipsum Dolor Sit amet Goblok Kontol Blah Blah Blah Akirents" +
    "n Omsim";
            this.lbl_ProductDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(116)))));
            this.lbl_ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductPrice.Location = new System.Drawing.Point(217, 40);
            this.lbl_ProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.lbl_ProductPrice.Size = new System.Drawing.Size(111, 28);
            this.lbl_ProductPrice.TabIndex = 52;
            this.lbl_ProductPrice.Text = "500";
            this.lbl_ProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox_ProductPicture
            // 
            this.picBox_ProductPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_ProductPicture.Image = global::WWWPOS.Properties.Resources.Images;
            this.picBox_ProductPicture.InitialImage = null;
            this.picBox_ProductPicture.Location = new System.Drawing.Point(7, 10);
            this.picBox_ProductPicture.Name = "picBox_ProductPicture";
            this.picBox_ProductPicture.Size = new System.Drawing.Size(197, 196);
            this.picBox_ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_ProductPicture.TabIndex = 51;
            this.picBox_ProductPicture.TabStop = false;
            // 
            // UserControl_ClientCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowLayoutPanel_ProductCart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_BrowseProduct);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl_ClientCart";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1421, 631);
            this.Load += new System.EventHandler(this.UserControl_ClientCart_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel_ProductCart.ResumeLayout(false);
            this.panel_ClientCartProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProductPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_BrowseProduct;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_TotalCart;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ProductCart;
        private System.Windows.Forms.Button btn_DeleteProduct;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.ComboBox cmb_Color;
        private System.Windows.Forms.Label lbl_ProductQty;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.ComboBox cmb_ProductSize;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Label lbl_ProductDescription;
        public System.Windows.Forms.Panel panel_ClientCartProduct;
        private System.Windows.Forms.PictureBox picBox_ProductPicture;
        private System.Windows.Forms.Label lbl_ProductPrice;
    }
}
