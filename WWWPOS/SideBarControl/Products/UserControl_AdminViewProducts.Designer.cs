namespace WWWPOS.SideBarControl.Products
{
    partial class UserControl_AdminViewProducts
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
            this.product_Description = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Product_Price = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.product_Stock = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.product_Image = new System.Windows.Forms.PictureBox();
            this.cmb_ProductSize = new System.Windows.Forms.ComboBox();
            this.cmb_ProductColor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.product_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // product_Description
            // 
            this.product_Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.product_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Description.Location = new System.Drawing.Point(15, 341);
            this.product_Description.Name = "product_Description";
            this.product_Description.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.product_Description.Size = new System.Drawing.Size(265, 64);
            this.product_Description.TabIndex = 30;
            this.product_Description.Text = "Description";
            this.product_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Stocks";
            // 
            // lbl_Product_Price
            // 
            this.lbl_Product_Price.AutoSize = true;
            this.lbl_Product_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(116)))));
            this.lbl_Product_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Price.Location = new System.Drawing.Point(71, 233);
            this.lbl_Product_Price.Name = "lbl_Product_Price";
            this.lbl_Product_Price.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.lbl_Product_Price.Size = new System.Drawing.Size(28, 24);
            this.lbl_Product_Price.TabIndex = 27;
            this.lbl_Product_Price.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(13, 268);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 23);
            this.label20.TabIndex = 28;
            this.label20.Text = "Size";
            // 
            // product_Stock
            // 
            this.product_Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(174)))), ((int)(((byte)(242)))));
            this.product_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Stock.Location = new System.Drawing.Point(233, 232);
            this.product_Stock.Name = "product_Stock";
            this.product_Stock.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.product_Stock.Size = new System.Drawing.Size(47, 26);
            this.product_Stock.TabIndex = 29;
            this.product_Stock.Text = "0";
            this.product_Stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 233);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 23);
            this.label14.TabIndex = 31;
            this.label14.Text = "Price";
            // 
            // product_Image
            // 
            this.product_Image.Image = global::WWWPOS.Properties.Resources.image;
            this.product_Image.Location = new System.Drawing.Point(16, 18);
            this.product_Image.Margin = new System.Windows.Forms.Padding(4);
            this.product_Image.Name = "product_Image";
            this.product_Image.Size = new System.Drawing.Size(264, 212);
            this.product_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.product_Image.TabIndex = 36;
            this.product_Image.TabStop = false;
            // 
            // cmb_ProductSize
            // 
            this.cmb_ProductSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_ProductSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ProductSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProductSize.FormattingEnabled = true;
            this.cmb_ProductSize.Location = new System.Drawing.Point(70, 265);
            this.cmb_ProductSize.Name = "cmb_ProductSize";
            this.cmb_ProductSize.Size = new System.Drawing.Size(210, 26);
            this.cmb_ProductSize.TabIndex = 37;
            this.cmb_ProductSize.DropDownClosed += new System.EventHandler(this.cmb_ProductSize_DropDownClosed);
            // 
            // cmb_ProductColor
            // 
            this.cmb_ProductColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_ProductColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ProductColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProductColor.FormattingEnabled = true;
            this.cmb_ProductColor.Location = new System.Drawing.Point(70, 305);
            this.cmb_ProductColor.Name = "cmb_ProductColor";
            this.cmb_ProductColor.Size = new System.Drawing.Size(210, 26);
            this.cmb_ProductColor.TabIndex = 38;
            // 
            // UserControl_AdminViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.Controls.Add(this.cmb_ProductColor);
            this.Controls.Add(this.cmb_ProductSize);
            this.Controls.Add(this.product_Image);
            this.Controls.Add(this.product_Description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Product_Price);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.product_Stock);
            this.Controls.Add(this.label14);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_AdminViewProducts";
            this.Size = new System.Drawing.Size(293, 422);
            ((System.ComponentModel.ISupportInitialize)(this.product_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox product_Image;
        private System.Windows.Forms.Label product_Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Product_Price;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label product_Stock;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_ProductSize;
        private System.Windows.Forms.ComboBox cmb_ProductColor;
    }
}
