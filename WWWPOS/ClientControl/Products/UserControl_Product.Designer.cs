namespace WWWPOS.ClientControl.Products
{
    partial class UserControl_Product
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
            this.btn_Buy = new System.Windows.Forms.Button();
            this.btn_AddToCart = new System.Windows.Forms.Button();
            this.lbl_ProductStocks = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_ProductQty = new System.Windows.Forms.Label();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.lbl_ProductDescription = new System.Windows.Forms.Label();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.cmb_ProductSize = new System.Windows.Forms.ComboBox();
            this.picBox_ProductPicture = new System.Windows.Forms.PictureBox();
            this.cmb_Color = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Buy
            // 
            this.btn_Buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.btn_Buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buy.FlatAppearance.BorderSize = 0;
            this.btn_Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buy.ForeColor = System.Drawing.Color.White;
            this.btn_Buy.Location = new System.Drawing.Point(154, 426);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(134, 30);
            this.btn_Buy.TabIndex = 32;
            this.btn_Buy.Text = "Buy";
            this.btn_Buy.UseVisualStyleBackColor = false;
            // 
            // btn_AddToCart
            // 
            this.btn_AddToCart.BackColor = System.Drawing.Color.White;
            this.btn_AddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddToCart.FlatAppearance.BorderSize = 0;
            this.btn_AddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddToCart.Location = new System.Drawing.Point(13, 426);
            this.btn_AddToCart.Name = "btn_AddToCart";
            this.btn_AddToCart.Size = new System.Drawing.Size(135, 30);
            this.btn_AddToCart.TabIndex = 31;
            this.btn_AddToCart.Text = "Add Cart";
            this.btn_AddToCart.UseVisualStyleBackColor = false;
            this.btn_AddToCart.Click += new System.EventHandler(this.btn_AddToCart_Click);
            // 
            // lbl_ProductStocks
            // 
            this.lbl_ProductStocks.AutoSize = true;
            this.lbl_ProductStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(174)))), ((int)(((byte)(242)))));
            this.lbl_ProductStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductStocks.Location = new System.Drawing.Point(182, 268);
            this.lbl_ProductStocks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ProductStocks.Name = "lbl_ProductStocks";
            this.lbl_ProductStocks.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbl_ProductStocks.Size = new System.Drawing.Size(38, 26);
            this.lbl_ProductStocks.TabIndex = 22;
            this.lbl_ProductStocks.Text = "10";
            this.lbl_ProductStocks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(223, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Stocks";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ProductQty
            // 
            this.lbl_ProductQty.BackColor = System.Drawing.Color.Silver;
            this.lbl_ProductQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductQty.Location = new System.Drawing.Point(193, 358);
            this.lbl_ProductQty.Name = "lbl_ProductQty";
            this.lbl_ProductQty.Size = new System.Drawing.Size(47, 28);
            this.lbl_ProductQty.TabIndex = 25;
            this.lbl_ProductQty.Text = "1";
            this.lbl_ProductQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Minus
            // 
            this.btn_Minus.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minus.FlatAppearance.BorderSize = 0;
            this.btn_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minus.Location = new System.Drawing.Point(162, 354);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(25, 31);
            this.btn_Minus.TabIndex = 24;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = false;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // lbl_ProductDescription
            // 
            this.lbl_ProductDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_ProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductDescription.Location = new System.Drawing.Point(13, 301);
            this.lbl_ProductDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ProductDescription.Name = "lbl_ProductDescription";
            this.lbl_ProductDescription.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbl_ProductDescription.Size = new System.Drawing.Size(275, 50);
            this.lbl_ProductDescription.TabIndex = 20;
            this.lbl_ProductDescription.Text = "Item Description Lorem Ipsum Dolor Sit amet Goblok Kontol Blah Blah Blah Akirents" +
    "n Omsim";
            this.lbl_ProductDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Plus
            // 
            this.btn_Plus.BackColor = System.Drawing.Color.Transparent;
            this.btn_Plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Plus.FlatAppearance.BorderSize = 0;
            this.btn_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Plus.Location = new System.Drawing.Point(244, 354);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(41, 38);
            this.btn_Plus.TabIndex = 21;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = false;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(96, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 27);
            this.label14.TabIndex = 23;
            this.label14.Text = "Price";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(116)))));
            this.lbl_ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductPrice.Location = new System.Drawing.Point(14, 267);
            this.lbl_ProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.lbl_ProductPrice.Size = new System.Drawing.Size(75, 28);
            this.lbl_ProductPrice.TabIndex = 18;
            this.lbl_ProductPrice.Text = "500";
            this.lbl_ProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cmb_ProductSize.Location = new System.Drawing.Point(13, 358);
            this.cmb_ProductSize.Name = "cmb_ProductSize";
            this.cmb_ProductSize.Size = new System.Drawing.Size(135, 26);
            this.cmb_ProductSize.TabIndex = 33;
            // 
            // picBox_ProductPicture
            // 
            this.picBox_ProductPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_ProductPicture.Image = global::WWWPOS.Properties.Resources.Images;
            this.picBox_ProductPicture.InitialImage = null;
            this.picBox_ProductPicture.Location = new System.Drawing.Point(13, 13);
            this.picBox_ProductPicture.Name = "picBox_ProductPicture";
            this.picBox_ProductPicture.Size = new System.Drawing.Size(275, 245);
            this.picBox_ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_ProductPicture.TabIndex = 34;
            this.picBox_ProductPicture.TabStop = false;
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
            this.cmb_Color.Location = new System.Drawing.Point(13, 390);
            this.cmb_Color.Name = "cmb_Color";
            this.cmb_Color.Size = new System.Drawing.Size(135, 26);
            this.cmb_Color.TabIndex = 35;
            // 
            // lbl_Category
            // 
            this.lbl_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(116)))));
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(155, 390);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.lbl_Category.Size = new System.Drawing.Size(133, 28);
            this.lbl_Category.TabIndex = 36;
            this.lbl_Category.Text = "Category";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.cmb_Color);
            this.Controls.Add(this.picBox_ProductPicture);
            this.Controls.Add(this.lbl_ProductQty);
            this.Controls.Add(this.btn_Plus);
            this.Controls.Add(this.cmb_ProductSize);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.btn_AddToCart);
            this.Controls.Add(this.lbl_ProductStocks);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_ProductDescription);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Margin = new System.Windows.Forms.Padding(10, 10, 15, 10);
            this.Name = "UserControl_Product";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(303, 473);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProductPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.Button btn_AddToCart;
        private System.Windows.Forms.Label lbl_ProductStocks;
        private System.Windows.Forms.Label lbl_ProductQty;
        private System.Windows.Forms.Label lbl_ProductDescription;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.ComboBox cmb_ProductSize;
        private System.Windows.Forms.PictureBox picBox_ProductPicture;
        private System.Windows.Forms.ComboBox cmb_Color;
        private System.Windows.Forms.Label lbl_Category;
    }
}
