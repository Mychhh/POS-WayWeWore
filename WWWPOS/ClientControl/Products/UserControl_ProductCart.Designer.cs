namespace WWWPOS.ClientControl.Products
{
    partial class UserControl_ProductCart
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
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.lbl_ProductDescription = new System.Windows.Forms.Label();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.cmb_ProductSize = new System.Windows.Forms.ComboBox();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.lbl_ProductQty = new System.Windows.Forms.Label();
            this.cmb_Color = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.picBox_ProductPicture = new System.Windows.Forms.PictureBox();
            this.lbl_ItemTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.BackColor = System.Drawing.Color.Silver;
            this.lbl_ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductPrice.Location = new System.Drawing.Point(218, 41);
            this.lbl_ProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.lbl_ProductPrice.Size = new System.Drawing.Size(174, 28);
            this.lbl_ProductPrice.TabIndex = 36;
            this.lbl_ProductPrice.Text = "500";
            this.lbl_ProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ProductDescription
            // 
            this.lbl_ProductDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_ProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductDescription.Location = new System.Drawing.Point(217, 111);
            this.lbl_ProductDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ProductDescription.Name = "lbl_ProductDescription";
            this.lbl_ProductDescription.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbl_ProductDescription.Size = new System.Drawing.Size(362, 50);
            this.lbl_ProductDescription.TabIndex = 40;
            this.lbl_ProductDescription.Text = "Item Description Lorem Ipsum Dolor Sit amet Goblok Kontol Blah Blah Blah Akirents" +
    "n Omsim";
            this.lbl_ProductDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Minus
            // 
            this.btn_Minus.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minus.FlatAppearance.BorderSize = 0;
            this.btn_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minus.Location = new System.Drawing.Point(459, 165);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(25, 31);
            this.btn_Minus.TabIndex = 42;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = false;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // cmb_ProductSize
            // 
            this.cmb_ProductSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_ProductSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ProductSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProductSize.FormattingEnabled = true;
            this.cmb_ProductSize.Location = new System.Drawing.Point(217, 77);
            this.cmb_ProductSize.Name = "cmb_ProductSize";
            this.cmb_ProductSize.Size = new System.Drawing.Size(175, 26);
            this.cmb_ProductSize.TabIndex = 46;
            // 
            // btn_Plus
            // 
            this.btn_Plus.BackColor = System.Drawing.Color.Transparent;
            this.btn_Plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Plus.FlatAppearance.BorderSize = 0;
            this.btn_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Plus.Location = new System.Drawing.Point(540, 164);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(41, 38);
            this.btn_Plus.TabIndex = 41;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = false;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // lbl_ProductQty
            // 
            this.lbl_ProductQty.BackColor = System.Drawing.Color.Silver;
            this.lbl_ProductQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductQty.Location = new System.Drawing.Point(490, 170);
            this.lbl_ProductQty.Name = "lbl_ProductQty";
            this.lbl_ProductQty.Size = new System.Drawing.Size(47, 28);
            this.lbl_ProductQty.TabIndex = 43;
            this.lbl_ProductQty.Text = "1";
            this.lbl_ProductQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Color
            // 
            this.cmb_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Color.FormattingEnabled = true;
            this.cmb_Color.Location = new System.Drawing.Point(404, 77);
            this.cmb_Color.Name = "cmb_Color";
            this.cmb_Color.Size = new System.Drawing.Size(175, 26);
            this.cmb_Color.TabIndex = 47;
            // 
            // lbl_Category
            // 
            this.lbl_Category.BackColor = System.Drawing.Color.Silver;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(404, 41);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.lbl_Category.Size = new System.Drawing.Size(175, 28);
            this.lbl_Category.TabIndex = 48;
            this.lbl_Category.Text = "Category";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.BackColor = System.Drawing.Color.Black;
            this.btn_DeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteProduct.FlatAppearance.BorderSize = 0;
            this.btn_DeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteProduct.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_DeleteProduct.Location = new System.Drawing.Point(554, 4);
            this.btn_DeleteProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(25, 25);
            this.btn_DeleteProduct.TabIndex = 50;
            this.btn_DeleteProduct.Text = "X";
            this.btn_DeleteProduct.UseVisualStyleBackColor = false;
            this.btn_DeleteProduct.Click += new System.EventHandler(this.btn_DeleteProduct_Click);
            // 
            // picBox_ProductPicture
            // 
            this.picBox_ProductPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_ProductPicture.Image = global::WWWPOS.Properties.Resources.Images;
            this.picBox_ProductPicture.InitialImage = null;
            this.picBox_ProductPicture.Location = new System.Drawing.Point(8, 8);
            this.picBox_ProductPicture.Name = "picBox_ProductPicture";
            this.picBox_ProductPicture.Size = new System.Drawing.Size(197, 196);
            this.picBox_ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_ProductPicture.TabIndex = 35;
            this.picBox_ProductPicture.TabStop = false;
            // 
            // lbl_ItemTotal
            // 
            this.lbl_ItemTotal.BackColor = System.Drawing.Color.Silver;
            this.lbl_ItemTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.lbl_ItemTotal.Location = new System.Drawing.Point(320, 170);
            this.lbl_ItemTotal.Name = "lbl_ItemTotal";
            this.lbl_ItemTotal.Size = new System.Drawing.Size(121, 26);
            this.lbl_ItemTotal.TabIndex = 51;
            this.lbl_ItemTotal.Text = "1";
            this.lbl_ItemTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(218, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 52;
            this.label2.Text = "Item total :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl_ProductCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ItemTotal);
            this.Controls.Add(this.btn_DeleteProduct);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.cmb_Color);
            this.Controls.Add(this.lbl_ProductQty);
            this.Controls.Add(this.btn_Plus);
            this.Controls.Add(this.cmb_ProductSize);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.lbl_ProductDescription);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.picBox_ProductPicture);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UserControl_ProductCart";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(591, 213);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProductPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_ProductPicture;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.Label lbl_ProductDescription;
        private System.Windows.Forms.Label lbl_ProductQty;
        private System.Windows.Forms.Label lbl_Category;
        public System.Windows.Forms.Button btn_DeleteProduct;
        public System.Windows.Forms.Button btn_Minus;
        public System.Windows.Forms.Button btn_Plus;
        public System.Windows.Forms.ComboBox cmb_ProductSize;
        public System.Windows.Forms.ComboBox cmb_Color;
        private System.Windows.Forms.Label lbl_ItemTotal;
        private System.Windows.Forms.Label label2;
    }
}
