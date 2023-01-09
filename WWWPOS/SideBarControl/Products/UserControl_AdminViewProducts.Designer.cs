﻿namespace WWWPOS.SideBarControl.Products
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
            this.lbl_ProductDescription = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_ProductStock = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.picbox_ProductImage = new System.Windows.Forms.PictureBox();
            this.cmb_ProductSize = new System.Windows.Forms.ComboBox();
            this.cmb_ProductColor = new System.Windows.Forms.ComboBox();
            this.lbl_ProductColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProductDescription
            // 
            this.lbl_ProductDescription.BackColor = System.Drawing.Color.Silver;
            this.lbl_ProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductDescription.Location = new System.Drawing.Point(15, 341);
            this.lbl_ProductDescription.Name = "lbl_ProductDescription";
            this.lbl_ProductDescription.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.lbl_ProductDescription.Size = new System.Drawing.Size(265, 64);
            this.lbl_ProductDescription.TabIndex = 30;
            this.lbl_ProductDescription.Text = "Description";
            this.lbl_ProductDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(165, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Stocks";
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.BackColor = System.Drawing.Color.Silver;
            this.lbl_ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductPrice.Location = new System.Drawing.Point(71, 233);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.lbl_ProductPrice.Size = new System.Drawing.Size(28, 24);
            this.lbl_ProductPrice.TabIndex = 27;
            this.lbl_ProductPrice.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(13, 268);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 23);
            this.label20.TabIndex = 28;
            this.label20.Text = "Size";
            // 
            // lbl_ProductStock
            // 
            this.lbl_ProductStock.BackColor = System.Drawing.Color.Silver;
            this.lbl_ProductStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductStock.Location = new System.Drawing.Point(233, 235);
            this.lbl_ProductStock.Name = "lbl_ProductStock";
            this.lbl_ProductStock.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.lbl_ProductStock.Size = new System.Drawing.Size(47, 23);
            this.lbl_ProductStock.TabIndex = 29;
            this.lbl_ProductStock.Text = "0";
            this.lbl_ProductStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(12, 233);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 23);
            this.label14.TabIndex = 31;
            this.label14.Text = "Price";
            // 
            // picbox_ProductImage
            // 
            this.picbox_ProductImage.Image = global::WWWPOS.Properties.Resources.image;
            this.picbox_ProductImage.Location = new System.Drawing.Point(16, 18);
            this.picbox_ProductImage.Margin = new System.Windows.Forms.Padding(4);
            this.picbox_ProductImage.Name = "picbox_ProductImage";
            this.picbox_ProductImage.Size = new System.Drawing.Size(264, 212);
            this.picbox_ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_ProductImage.TabIndex = 36;
            this.picbox_ProductImage.TabStop = false;
            // 
            // cmb_ProductSize
            // 
            this.cmb_ProductSize.BackColor = System.Drawing.Color.Silver;
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
            this.cmb_ProductColor.BackColor = System.Drawing.Color.Silver;
            this.cmb_ProductColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_ProductColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ProductColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProductColor.FormattingEnabled = true;
            this.cmb_ProductColor.Location = new System.Drawing.Point(41, 428);
            this.cmb_ProductColor.Name = "cmb_ProductColor";
            this.cmb_ProductColor.Size = new System.Drawing.Size(210, 26);
            this.cmb_ProductColor.TabIndex = 38;
            // 
            // lbl_ProductColor
            // 
            this.lbl_ProductColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lbl_ProductColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductColor.Location = new System.Drawing.Point(70, 304);
            this.lbl_ProductColor.Name = "lbl_ProductColor";
            this.lbl_ProductColor.Size = new System.Drawing.Size(210, 26);
            this.lbl_ProductColor.TabIndex = 64;
            this.lbl_ProductColor.Text = "Color";
            this.lbl_ProductColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl_AdminViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lbl_ProductColor);
            this.Controls.Add(this.cmb_ProductColor);
            this.Controls.Add(this.cmb_ProductSize);
            this.Controls.Add(this.picbox_ProductImage);
            this.Controls.Add(this.lbl_ProductDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lbl_ProductStock);
            this.Controls.Add(this.label14);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_AdminViewProducts";
            this.Size = new System.Drawing.Size(293, 422);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_ProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_ProductImage;
        private System.Windows.Forms.Label lbl_ProductDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_ProductStock;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_ProductSize;
        private System.Windows.Forms.ComboBox cmb_ProductColor;
        private System.Windows.Forms.Label lbl_ProductColor;
    }
}
