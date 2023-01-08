namespace WWWPOS.SideBarControl.Inventory
{
    partial class UserControlCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_ProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_ProductType = new System.Windows.Forms.ComboBox();
            this.comboBox_Size = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Color = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.txtBox_Stocks = new System.Windows.Forms.TextBox();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.product_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.product_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add new product";
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(165)))));
            this.btn_AddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddProduct.ForeColor = System.Drawing.Color.White;
            this.btn_AddProduct.Location = new System.Drawing.Point(489, 398);
            this.btn_AddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(384, 39);
            this.btn_AddProduct.TabIndex = 10;
            this.btn_AddProduct.Text = "Add Product";
            this.btn_AddProduct.UseVisualStyleBackColor = false;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product name";
            // 
            // txtBox_ProductName
            // 
            this.txtBox_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_ProductName.Location = new System.Drawing.Point(489, 68);
            this.txtBox_ProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_ProductName.Name = "txtBox_ProductName";
            this.txtBox_ProductName.Size = new System.Drawing.Size(384, 28);
            this.txtBox_ProductName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Product type";
            // 
            // comboBox_ProductType
            // 
            this.comboBox_ProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ProductType.FormattingEnabled = true;
            this.comboBox_ProductType.Items.AddRange(new object[] {
            "T-Shirts",
            "Shorts"});
            this.comboBox_ProductType.Location = new System.Drawing.Point(489, 124);
            this.comboBox_ProductType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_ProductType.Name = "comboBox_ProductType";
            this.comboBox_ProductType.Size = new System.Drawing.Size(384, 30);
            this.comboBox_ProductType.TabIndex = 14;
            // 
            // comboBox_Size
            // 
            this.comboBox_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Size.FormattingEnabled = true;
            this.comboBox_Size.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Extra Large"});
            this.comboBox_Size.Location = new System.Drawing.Point(489, 182);
            this.comboBox_Size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Size.Name = "comboBox_Size";
            this.comboBox_Size.Size = new System.Drawing.Size(384, 30);
            this.comboBox_Size.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Size";
            // 
            // txtBox_Color
            // 
            this.txtBox_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Color.Location = new System.Drawing.Point(489, 240);
            this.txtBox_Color.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_Color.Name = "txtBox_Color";
            this.txtBox_Color.Size = new System.Drawing.Size(384, 28);
            this.txtBox_Color.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(485, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(485, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Stocks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Price";
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Price.Location = new System.Drawing.Point(489, 295);
            this.txtBox_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(384, 28);
            this.txtBox_Price.TabIndex = 23;
            // 
            // txtBox_Stocks
            // 
            this.txtBox_Stocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Stocks.Location = new System.Drawing.Point(489, 352);
            this.txtBox_Stocks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_Stocks.Name = "txtBox_Stocks";
            this.txtBox_Stocks.Size = new System.Drawing.Size(384, 28);
            this.txtBox_Stocks.TabIndex = 24;
            // 
            // rtb_Description
            // 
            this.rtb_Description.Location = new System.Drawing.Point(48, 304);
            this.rtb_Description.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(404, 132);
            this.rtb_Description.TabIndex = 25;
            this.rtb_Description.Text = "Description";
            this.rtb_Description.Enter += new System.EventHandler(this.rtb_Description_Enter);
            this.rtb_Description.Leave += new System.EventHandler(this.rtb_Description_Leave);
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.btn_Browse.FlatAppearance.BorderSize = 0;
            this.btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.Location = new System.Drawing.Point(353, 268);
            this.btn_Browse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(100, 28);
            this.btn_Browse.TabIndex = 26;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // product_Image
            // 
            this.product_Image.BackColor = System.Drawing.Color.LightGray;
            this.product_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.product_Image.Location = new System.Drawing.Point(48, 43);
            this.product_Image.Margin = new System.Windows.Forms.Padding(4);
            this.product_Image.Name = "product_Image";
            this.product_Image.Size = new System.Drawing.Size(405, 210);
            this.product_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.product_Image.TabIndex = 28;
            this.product_Image.TabStop = false;
            // 
            // UserControlCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlCreate";
            this.Size = new System.Drawing.Size(932, 483);
            ((System.ComponentModel.ISupportInitialize)(this.product_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_ProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_ProductType;
        private System.Windows.Forms.ComboBox comboBox_Size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Color;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBox_Price;
        private System.Windows.Forms.TextBox txtBox_Stocks;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.PictureBox product_Image;
    }
}
