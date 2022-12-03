namespace WWWPOS
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Short = new System.Windows.Forms.Button();
            this.btn_TShirt = new System.Windows.Forms.Button();
            this.btn_ViewCart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userSearch = new System.Windows.Forms.TextBox();
            this.clientPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.panel1.Location = new System.Drawing.Point(13, 147);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 2);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(155, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "All Products";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Short
            // 
            this.btn_Short.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.btn_Short.FlatAppearance.BorderSize = 0;
            this.btn_Short.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Short.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Short.ForeColor = System.Drawing.Color.White;
            this.btn_Short.Location = new System.Drawing.Point(343, 157);
            this.btn_Short.Name = "btn_Short";
            this.btn_Short.Size = new System.Drawing.Size(169, 37);
            this.btn_Short.TabIndex = 3;
            this.btn_Short.Text = "Short";
            this.btn_Short.UseVisualStyleBackColor = false;
            this.btn_Short.Click += new System.EventHandler(this.btn_Short_Click);
            // 
            // btn_TShirt
            // 
            this.btn_TShirt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.btn_TShirt.FlatAppearance.BorderSize = 0;
            this.btn_TShirt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TShirt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_TShirt.ForeColor = System.Drawing.Color.White;
            this.btn_TShirt.Location = new System.Drawing.Point(535, 157);
            this.btn_TShirt.Name = "btn_TShirt";
            this.btn_TShirt.Size = new System.Drawing.Size(169, 37);
            this.btn_TShirt.TabIndex = 4;
            this.btn_TShirt.Text = "T-Shirt";
            this.btn_TShirt.UseVisualStyleBackColor = false;
            this.btn_TShirt.Click += new System.EventHandler(this.btn_TShirt_Click);
            // 
            // btn_ViewCart
            // 
            this.btn_ViewCart.BackColor = System.Drawing.Color.White;
            this.btn_ViewCart.FlatAppearance.BorderSize = 0;
            this.btn_ViewCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_ViewCart.ForeColor = System.Drawing.Color.Black;
            this.btn_ViewCart.Image = ((System.Drawing.Image)(resources.GetObject("btn_ViewCart.Image")));
            this.btn_ViewCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewCart.Location = new System.Drawing.Point(723, 157);
            this.btn_ViewCart.Name = "btn_ViewCart";
            this.btn_ViewCart.Size = new System.Drawing.Size(169, 37);
            this.btn_ViewCart.TabIndex = 5;
            this.btn_ViewCart.Text = "View Cart";
            this.btn_ViewCart.UseVisualStyleBackColor = false;
            this.btn_ViewCart.Click += new System.EventHandler(this.btn_ViewCart_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.userSearch);
            this.panel2.Location = new System.Drawing.Point(95, 210);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 60, 10, 60);
            this.panel2.Size = new System.Drawing.Size(848, 40);
            this.panel2.TabIndex = 6;
            // 
            // userSearch
            // 
            this.userSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userSearch.Location = new System.Drawing.Point(10, 10);
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(663, 19);
            this.userSearch.TabIndex = 0;
            this.userSearch.Text = "Search products";
            this.userSearch.Enter += new System.EventHandler(this.userSearch_Enter);
            this.userSearch.Leave += new System.EventHandler(this.userSearch_Leave);
            // 
            // clientPanel
            // 
            this.clientPanel.Location = new System.Drawing.Point(13, 256);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(1014, 372);
            this.clientPanel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.pictureBox1.BackgroundImage = global::WWWPOS.Properties.Resources.header;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(325, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(800, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 32);
            this.label1.TabIndex = 1;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.ForeColor = System.Drawing.Color.Blue;
            this.btn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Menu.Image")));
            this.btn_Menu.Location = new System.Drawing.Point(1001, 3);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(27, 32);
            this.btn_Menu.TabIndex = 50;
            this.btn_Menu.UseVisualStyleBackColor = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_ViewCart);
            this.Controls.Add(this.btn_TShirt);
            this.Controls.Add(this.btn_Short);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Short;
        private System.Windows.Forms.Button btn_TShirt;
        private System.Windows.Forms.Button btn_ViewCart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox userSearch;
        private System.Windows.Forms.Panel clientPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Menu;
    }
}