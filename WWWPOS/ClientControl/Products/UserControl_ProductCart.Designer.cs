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
            this.picBox_ProductPicture = new System.Windows.Forms.PictureBox();
            this.lbl_ProductStocks = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.lbl_ProductDescription = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.cmb_Color = new System.Windows.Forms.ComboBox();
            this.lbl_ProductQty = new System.Windows.Forms.Label();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.cmb_ProductSize = new System.Windows.Forms.ComboBox();
            this.btn_Minus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_ProductPicture
            // 
            this.picBox_ProductPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_ProductPicture.Image = global::WWWPOS.Properties.Resources.Images;
            this.picBox_ProductPicture.InitialImage = null;
            this.picBox_ProductPicture.Location = new System.Drawing.Point(19, 13);
            this.picBox_ProductPicture.Name = "picBox_ProductPicture";
            this.picBox_ProductPicture.Size = new System.Drawing.Size(275, 245);
            this.picBox_ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_ProductPicture.TabIndex = 35;
            this.picBox_ProductPicture.TabStop = false;
            // 
            // lbl_ProductStocks
            // 
            this.lbl_ProductStocks.AutoSize = true;
            this.lbl_ProductStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(174)))), ((int)(((byte)(242)))));
            this.lbl_ProductStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductStocks.Location = new System.Drawing.Point(455, 69);
            this.lbl_ProductStocks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ProductStocks.Name = "lbl_ProductStocks";
            this.lbl_ProductStocks.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbl_ProductStocks.Size = new System.Drawing.Size(38, 26);
            this.lbl_ProductStocks.TabIndex = 37;
            this.lbl_ProductStocks.Text = "10";
            this.lbl_ProductStocks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(496, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 18);
            this.label11.TabIndex = 39;
            this.label11.Text = "Stocks";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(396, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 18);
            this.label14.TabIndex = 38;
            this.label14.Text = "Items";
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(116)))));
            this.lbl_ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductPrice.Location = new System.Drawing.Point(314, 67);
            this.lbl_ProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.lbl_ProductPrice.Size = new System.Drawing.Size(75, 28);
            this.lbl_ProductPrice.TabIndex = 36;
            this.lbl_ProductPrice.Text = "500";
            this.lbl_ProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ProductDescription
            // 
            this.lbl_ProductDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_ProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductDescription.Location = new System.Drawing.Point(314, 154);
            this.lbl_ProductDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ProductDescription.Name = "lbl_ProductDescription";
            this.lbl_ProductDescription.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbl_ProductDescription.Size = new System.Drawing.Size(388, 50);
            this.lbl_ProductDescription.TabIndex = 40;
            this.lbl_ProductDescription.Text = "Item Description Lorem Ipsum Dolor Sit amet Goblok Kontol Blah Blah Blah Akirents" +
    "n Omsim";
            this.lbl_ProductDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Category
            // 
            this.lbl_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(116)))));
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(313, 111);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.lbl_Category.Size = new System.Drawing.Size(106, 28);
            this.lbl_Category.TabIndex = 48;
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
            this.cmb_Color.Location = new System.Drawing.Point(567, 113);
            this.cmb_Color.Name = "cmb_Color";
            this.cmb_Color.Size = new System.Drawing.Size(135, 26);
            this.cmb_Color.TabIndex = 47;
            // 
            // lbl_ProductQty
            // 
            this.lbl_ProductQty.BackColor = System.Drawing.Color.Silver;
            this.lbl_ProductQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductQty.Location = new System.Drawing.Point(608, 70);
            this.lbl_ProductQty.Name = "lbl_ProductQty";
            this.lbl_ProductQty.Size = new System.Drawing.Size(47, 28);
            this.lbl_ProductQty.TabIndex = 43;
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
            this.btn_Plus.Location = new System.Drawing.Point(659, 66);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(41, 38);
            this.btn_Plus.TabIndex = 41;
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
            this.cmb_ProductSize.Location = new System.Drawing.Point(426, 113);
            this.cmb_ProductSize.Name = "cmb_ProductSize";
            this.cmb_ProductSize.Size = new System.Drawing.Size(135, 26);
            this.cmb_ProductSize.TabIndex = 46;
            // 
            // btn_Minus
            // 
            this.btn_Minus.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minus.FlatAppearance.BorderSize = 0;
            this.btn_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minus.Location = new System.Drawing.Point(577, 65);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(25, 31);
            this.btn_Minus.TabIndex = 42;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = false;
            // 
            // UserControl_ProductCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.cmb_Color);
            this.Controls.Add(this.lbl_ProductQty);
            this.Controls.Add(this.btn_Plus);
            this.Controls.Add(this.cmb_ProductSize);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.lbl_ProductDescription);
            this.Controls.Add(this.lbl_ProductStocks);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.picBox_ProductPicture);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControl_ProductCart";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(730, 270);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProductPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_ProductPicture;
        private System.Windows.Forms.Label lbl_ProductStocks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.Label lbl_ProductDescription;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.ComboBox cmb_Color;
        private System.Windows.Forms.Label lbl_ProductQty;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.ComboBox cmb_ProductSize;
        private System.Windows.Forms.Button btn_Minus;
    }
}
