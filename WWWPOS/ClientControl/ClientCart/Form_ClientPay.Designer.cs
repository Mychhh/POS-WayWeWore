namespace WWWPOS.ClientControl.ClientCart
{
    partial class Form_ClientPay
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.flPanel_ProductTotal = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GoToCart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_GoToProducts = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(80, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 2);
            this.panel2.TabIndex = 82;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(82, 168);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(255, 32);
            this.label16.TabIndex = 74;
            this.label16.Text = "Order Confirmation";
            // 
            // flPanel_ProductTotal
            // 
            this.flPanel_ProductTotal.AutoScroll = true;
            this.flPanel_ProductTotal.Location = new System.Drawing.Point(59, 231);
            this.flPanel_ProductTotal.Margin = new System.Windows.Forms.Padding(0);
            this.flPanel_ProductTotal.Name = "flPanel_ProductTotal";
            this.flPanel_ProductTotal.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.flPanel_ProductTotal.Size = new System.Drawing.Size(1307, 449);
            this.flPanel_ProductTotal.TabIndex = 80;
            // 
            // btn_Pay
            // 
            this.btn_Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(116)))));
            this.btn_Pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pay.FlatAppearance.BorderSize = 0;
            this.btn_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pay.ForeColor = System.Drawing.Color.Black;
            this.btn_Pay.Location = new System.Drawing.Point(842, 12);
            this.btn_Pay.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(465, 46);
            this.btn_Pay.TabIndex = 29;
            this.btn_Pay.Text = "Confirm Order";
            this.btn_Pay.UseVisualStyleBackColor = false;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.panel4.Controls.Add(this.lbl_TotalPrice);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btn_Pay);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(59, 693);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1307, 72);
            this.panel4.TabIndex = 81;
            // 
            // lbl_TotalPrice
            // 
            this.lbl_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.lbl_TotalPrice.Location = new System.Drawing.Point(155, 12);
            this.lbl_TotalPrice.Name = "lbl_TotalPrice";
            this.lbl_TotalPrice.Size = new System.Drawing.Size(125, 46);
            this.lbl_TotalPrice.TabIndex = 31;
            this.lbl_TotalPrice.Text = "Sheesh";
            this.lbl_TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TotalPrice.Click += new System.EventHandler(this.lbl_TotalPrice_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 46);
            this.label1.TabIndex = 30;
            this.label1.Text = "Subtotal : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_GoToCart
            // 
            this.btn_GoToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(116)))));
            this.btn_GoToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GoToCart.FlatAppearance.BorderSize = 0;
            this.btn_GoToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GoToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoToCart.Location = new System.Drawing.Point(1116, 168);
            this.btn_GoToCart.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GoToCart.Name = "btn_GoToCart";
            this.btn_GoToCart.Size = new System.Drawing.Size(250, 45);
            this.btn_GoToCart.TabIndex = 79;
            this.btn_GoToCart.Text = "View Orders";
            this.btn_GoToCart.UseVisualStyleBackColor = false;
            this.btn_GoToCart.Click += new System.EventHandler(this.btn_BrowseProduct_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.panel1.Location = new System.Drawing.Point(11, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 2);
            this.panel1.TabIndex = 76;
            // 
            // btn_GoToProducts
            // 
            this.btn_GoToProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(116)))));
            this.btn_GoToProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GoToProducts.FlatAppearance.BorderSize = 0;
            this.btn_GoToProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GoToProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoToProducts.Location = new System.Drawing.Point(846, 168);
            this.btn_GoToProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GoToProducts.Name = "btn_GoToProducts";
            this.btn_GoToProducts.Size = new System.Drawing.Size(250, 45);
            this.btn_GoToProducts.TabIndex = 83;
            this.btn_GoToProducts.Text = "Browse product";
            this.btn_GoToProducts.UseVisualStyleBackColor = false;
            this.btn_GoToProducts.Click += new System.EventHandler(this.btn_GoToProducts_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.panel3.Location = new System.Drawing.Point(11, 685);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1400, 2);
            this.panel3.TabIndex = 84;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.pictureBox1.BackgroundImage = global::WWWPOS.Properties.Resources.header;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(474, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 132);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // Form_ClientPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1424, 788);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_GoToProducts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.flPanel_ProductTotal);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_GoToCart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ClientPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ClientTotal";
            this.Load += new System.EventHandler(this.Form_ClientPay_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.FlowLayoutPanel flPanel_ProductTotal;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_GoToCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_TotalPrice;
        private System.Windows.Forms.Button btn_GoToProducts;
        private System.Windows.Forms.Panel panel3;
    }
}