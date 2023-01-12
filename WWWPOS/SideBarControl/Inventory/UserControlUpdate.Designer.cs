namespace WWWPOS.SideBarControl.Inventory
{
    partial class UserControlUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUpdate));
            this.txtBox_productID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.product_Image = new System.Windows.Forms.PictureBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.txtBox_Stocks = new System.Windows.Forms.TextBox();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBox_Color = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Size = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_ProductType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_ProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_UpdateProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_productID
            // 
            resources.ApplyResources(this.txtBox_productID, "txtBox_productID");
            this.txtBox_productID.Name = "txtBox_productID";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // product_Image
            // 
            this.product_Image.BackColor = System.Drawing.Color.LightGray;
            this.product_Image.BackgroundImage = global::WWWPOS.Properties.Resources.image;
            resources.ApplyResources(this.product_Image, "product_Image");
            this.product_Image.Name = "product_Image";
            this.product_Image.TabStop = false;
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.btn_Browse.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Browse, "btn_Browse");
            this.btn_Browse.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // rtb_Description
            // 
            resources.ApplyResources(this.rtb_Description, "rtb_Description");
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.TextChanged += new System.EventHandler(this.rtb_Description_TextChanged);
            this.rtb_Description.Enter += new System.EventHandler(this.rtb_Description_Enter);
            this.rtb_Description.Leave += new System.EventHandler(this.rtb_Description_Leave);
            // 
            // txtBox_Stocks
            // 
            resources.ApplyResources(this.txtBox_Stocks, "txtBox_Stocks");
            this.txtBox_Stocks.Name = "txtBox_Stocks";
            this.txtBox_Stocks.TextChanged += new System.EventHandler(this.txtBox_Stocks_TextChanged);
            this.txtBox_Stocks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Stocks_KeyPress);
            // 
            // txtBox_Price
            // 
            resources.ApplyResources(this.txtBox_Price, "txtBox_Price");
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.TextChanged += new System.EventHandler(this.txtBox_Price_TextChanged);
            this.txtBox_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Price_KeyPress);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtBox_Color
            // 
            resources.ApplyResources(this.txtBox_Color, "txtBox_Color");
            this.txtBox_Color.Name = "txtBox_Color";
            this.txtBox_Color.TextChanged += new System.EventHandler(this.txtBox_Color_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // comboBox_Size
            // 
            this.comboBox_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox_Size, "comboBox_Size");
            this.comboBox_Size.FormattingEnabled = true;
            this.comboBox_Size.Items.AddRange(new object[] {
            resources.GetString("comboBox_Size.Items"),
            resources.GetString("comboBox_Size.Items1"),
            resources.GetString("comboBox_Size.Items2"),
            resources.GetString("comboBox_Size.Items3")});
            this.comboBox_Size.Name = "comboBox_Size";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // comboBox_ProductType
            // 
            this.comboBox_ProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox_ProductType, "comboBox_ProductType");
            this.comboBox_ProductType.FormattingEnabled = true;
            this.comboBox_ProductType.Items.AddRange(new object[] {
            resources.GetString("comboBox_ProductType.Items"),
            resources.GetString("comboBox_ProductType.Items1")});
            this.comboBox_ProductType.Name = "comboBox_ProductType";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtBox_ProductName
            // 
            resources.ApplyResources(this.txtBox_ProductName, "txtBox_ProductName");
            this.txtBox_ProductName.Name = "txtBox_ProductName";
            this.txtBox_ProductName.TextChanged += new System.EventHandler(this.txtBox_ProductName_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btn_UpdateProduct
            // 
            this.btn_UpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(116)))));
            resources.ApplyResources(this.btn_UpdateProduct, "btn_UpdateProduct");
            this.btn_UpdateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateProduct.ForeColor = System.Drawing.Color.Black;
            this.btn_UpdateProduct.Name = "btn_UpdateProduct";
            this.btn_UpdateProduct.UseVisualStyleBackColor = false;
            this.btn_UpdateProduct.Click += new System.EventHandler(this.btn_UpdateProduct_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // UserControlUpdate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.txtBox_productID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.product_Image);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.rtb_Description);
            this.Controls.Add(this.txtBox_Stocks);
            this.Controls.Add(this.txtBox_Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBox_Color);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Size);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_ProductType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_ProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_UpdateProduct);
            this.Controls.Add(this.label1);
            this.Name = "UserControlUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.product_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtBox_productID;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.PictureBox product_Image;
        private System.Windows.Forms.Button btn_Browse;
        public System.Windows.Forms.RichTextBox rtb_Description;
        public System.Windows.Forms.TextBox txtBox_Stocks;
        public System.Windows.Forms.TextBox txtBox_Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtBox_Color;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBox_Size;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBox_ProductType;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtBox_ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_UpdateProduct;
        private System.Windows.Forms.Label label1;
    }
}
