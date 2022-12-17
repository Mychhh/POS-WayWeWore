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
            this.txtBox_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_productID.Location = new System.Drawing.Point(343, 52);
            this.txtBox_productID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_productID.Name = "txtBox_productID";
            this.txtBox_productID.Size = new System.Drawing.Size(289, 24);
            this.txtBox_productID.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 84;
            this.label7.Text = "Product ID";
            // 
            // product_Image
            // 
            this.product_Image.BackColor = System.Drawing.Color.LightGray;
            this.product_Image.BackgroundImage = global::WWWPOS.Properties.Resources.image;
            this.product_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.product_Image.Location = new System.Drawing.Point(14, 49);
            this.product_Image.Name = "product_Image";
            this.product_Image.Size = new System.Drawing.Size(304, 203);
            this.product_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.product_Image.TabIndex = 82;
            this.product_Image.TabStop = false;
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.btn_Browse.FlatAppearance.BorderSize = 0;
            this.btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.Location = new System.Drawing.Point(243, 258);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 81;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // rtb_Description
            // 
            this.rtb_Description.Location = new System.Drawing.Point(14, 290);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(304, 108);
            this.rtb_Description.TabIndex = 80;
            this.rtb_Description.Text = "Description";
            this.rtb_Description.Enter += new System.EventHandler(this.rtb_Description_Enter);
            this.rtb_Description.Leave += new System.EventHandler(this.rtb_Description_Leave);
            // 
            // txtBox_Stocks
            // 
            this.txtBox_Stocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Stocks.Location = new System.Drawing.Point(344, 329);
            this.txtBox_Stocks.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Stocks.Name = "txtBox_Stocks";
            this.txtBox_Stocks.Size = new System.Drawing.Size(289, 24);
            this.txtBox_Stocks.TabIndex = 79;
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Price.Location = new System.Drawing.Point(344, 283);
            this.txtBox_Price.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(289, 24);
            this.txtBox_Price.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 77;
            this.label6.Text = "Stocks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(341, 263);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 18);
            this.label8.TabIndex = 76;
            this.label8.Text = "Price";
            // 
            // txtBox_Color
            // 
            this.txtBox_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Color.Location = new System.Drawing.Point(344, 238);
            this.txtBox_Color.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Color.Name = "txtBox_Color";
            this.txtBox_Color.Size = new System.Drawing.Size(289, 24);
            this.txtBox_Color.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 74;
            this.label5.Text = "Color";
            // 
            // comboBox_Size
            // 
            this.comboBox_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Size.FormattingEnabled = true;
            this.comboBox_Size.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Extra Large"});
            this.comboBox_Size.Location = new System.Drawing.Point(344, 191);
            this.comboBox_Size.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Size.Name = "comboBox_Size";
            this.comboBox_Size.Size = new System.Drawing.Size(289, 25);
            this.comboBox_Size.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 72;
            this.label4.Text = "Size";
            // 
            // comboBox_ProductType
            // 
            this.comboBox_ProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ProductType.FormattingEnabled = true;
            this.comboBox_ProductType.Items.AddRange(new object[] {
            "T-Shirts",
            "Shorts"});
            this.comboBox_ProductType.Location = new System.Drawing.Point(344, 144);
            this.comboBox_ProductType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_ProductType.Name = "comboBox_ProductType";
            this.comboBox_ProductType.Size = new System.Drawing.Size(289, 25);
            this.comboBox_ProductType.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 70;
            this.label3.Text = "Product type";
            // 
            // txtBox_ProductName
            // 
            this.txtBox_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_ProductName.Location = new System.Drawing.Point(344, 98);
            this.txtBox_ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_ProductName.Name = "txtBox_ProductName";
            this.txtBox_ProductName.Size = new System.Drawing.Size(289, 24);
            this.txtBox_ProductName.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "Product name";
            // 
            // btn_UpdateProduct
            // 
            this.btn_UpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(165)))));
            this.btn_UpdateProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_UpdateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateProduct.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateProduct.Location = new System.Drawing.Point(344, 366);
            this.btn_UpdateProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UpdateProduct.Name = "btn_UpdateProduct";
            this.btn_UpdateProduct.Size = new System.Drawing.Size(288, 32);
            this.btn_UpdateProduct.TabIndex = 67;
            this.btn_UpdateProduct.Text = "UpdateProduct";
            this.btn_UpdateProduct.UseVisualStyleBackColor = false;
            this.btn_UpdateProduct.Click += new System.EventHandler(this.btn_UpdateProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Update Product";
            // 
            // UserControlUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Size = new System.Drawing.Size(678, 447);
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
