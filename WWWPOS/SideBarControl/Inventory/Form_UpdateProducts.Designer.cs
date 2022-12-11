namespace WWWPOS.SideBarControl.Inventory
{
    partial class Form_UpdateProducts
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txtBox_productID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // product_Image
            // 
            this.product_Image.BackColor = System.Drawing.Color.LightGray;
            this.product_Image.BackgroundImage = global::WWWPOS.Properties.Resources.image;
            this.product_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.product_Image.Location = new System.Drawing.Point(12, 59);
            this.product_Image.Name = "product_Image";
            this.product_Image.Size = new System.Drawing.Size(304, 203);
            this.product_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.product_Image.TabIndex = 62;
            this.product_Image.TabStop = false;
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.btn_Browse.FlatAppearance.BorderSize = 0;
            this.btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.Location = new System.Drawing.Point(241, 268);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 61;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // rtb_Description
            // 
            this.rtb_Description.Location = new System.Drawing.Point(12, 300);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(304, 108);
            this.rtb_Description.TabIndex = 60;
            this.rtb_Description.Text = "Description";
            this.rtb_Description.Enter += new System.EventHandler(this.rtb_Description_Enter);
            this.rtb_Description.Leave += new System.EventHandler(this.rtb_Description_Leave);
            // 
            // txtBox_Stocks
            // 
            this.txtBox_Stocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Stocks.Location = new System.Drawing.Point(342, 339);
            this.txtBox_Stocks.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Stocks.Name = "txtBox_Stocks";
            this.txtBox_Stocks.Size = new System.Drawing.Size(289, 24);
            this.txtBox_Stocks.TabIndex = 59;
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Price.Location = new System.Drawing.Point(342, 293);
            this.txtBox_Price.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(289, 24);
            this.txtBox_Price.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 319);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 57;
            this.label6.Text = "Stocks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(339, 273);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 18);
            this.label8.TabIndex = 56;
            this.label8.Text = "Price";
            // 
            // txtBox_Color
            // 
            this.txtBox_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Color.Location = new System.Drawing.Point(342, 248);
            this.txtBox_Color.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Color.Name = "txtBox_Color";
            this.txtBox_Color.Size = new System.Drawing.Size(289, 24);
            this.txtBox_Color.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 54;
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
            this.comboBox_Size.Location = new System.Drawing.Point(342, 201);
            this.comboBox_Size.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Size.Name = "comboBox_Size";
            this.comboBox_Size.Size = new System.Drawing.Size(289, 25);
            this.comboBox_Size.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Size";
            // 
            // comboBox_ProductType
            // 
            this.comboBox_ProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ProductType.FormattingEnabled = true;
            this.comboBox_ProductType.Items.AddRange(new object[] {
            "T-Shirts",
            "Shorts"});
            this.comboBox_ProductType.Location = new System.Drawing.Point(342, 154);
            this.comboBox_ProductType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_ProductType.Name = "comboBox_ProductType";
            this.comboBox_ProductType.Size = new System.Drawing.Size(289, 25);
            this.comboBox_ProductType.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Product type";
            // 
            // txtBox_ProductName
            // 
            this.txtBox_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_ProductName.Location = new System.Drawing.Point(342, 108);
            this.txtBox_ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_ProductName.Name = "txtBox_ProductName";
            this.txtBox_ProductName.Size = new System.Drawing.Size(289, 24);
            this.txtBox_ProductName.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 48;
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
            this.btn_UpdateProduct.Location = new System.Drawing.Point(342, 376);
            this.btn_UpdateProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UpdateProduct.Name = "btn_UpdateProduct";
            this.btn_UpdateProduct.Size = new System.Drawing.Size(288, 32);
            this.btn_UpdateProduct.TabIndex = 47;
            this.btn_UpdateProduct.Text = "UpdateProduct";
            this.btn_UpdateProduct.UseVisualStyleBackColor = false;
            this.btn_UpdateProduct.Click += new System.EventHandler(this.btn_UpdateProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Update Product";
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(633, 9);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(33, 36);
            this.btn_Exit.TabIndex = 63;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txtBox_productID
            // 
            this.txtBox_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_productID.Location = new System.Drawing.Point(341, 62);
            this.txtBox_productID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_productID.Name = "txtBox_productID";
            this.txtBox_productID.Size = new System.Drawing.Size(289, 24);
            this.txtBox_productID.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(338, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Product ID";
            // 
            // Form_UpdateProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 447);
            this.Controls.Add(this.txtBox_productID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Exit);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_UpdateProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_UpdateProducts";
            ((System.ComponentModel.ISupportInitialize)(this.product_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btn_Exit;
        public System.Windows.Forms.PictureBox product_Image;
        public System.Windows.Forms.TextBox txtBox_productID;
        private System.Windows.Forms.Label label7;
    }
}