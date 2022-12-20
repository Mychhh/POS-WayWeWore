namespace WWWPOS
{
    partial class Form_ClientLandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ClientLandingPage));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_MainClient = new System.Windows.Forms.Panel();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.Transparent;
            this.panel_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Menu.Location = new System.Drawing.Point(1226, 15);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(130, 98);
            this.panel_Menu.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.panel1.Location = new System.Drawing.Point(10, 146);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 2);
            this.panel1.TabIndex = 56;
            // 
            // panel_MainClient
            // 
            this.panel_MainClient.Location = new System.Drawing.Point(1, 156);
            this.panel_MainClient.Name = "panel_MainClient";
            this.panel_MainClient.Padding = new System.Windows.Forms.Padding(5);
            this.panel_MainClient.Size = new System.Drawing.Size(1421, 631);
            this.panel_MainClient.TabIndex = 64;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.ForeColor = System.Drawing.Color.Blue;
            this.btn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Menu.Image")));
            this.btn_Menu.Location = new System.Drawing.Point(1371, 12);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(27, 31);
            this.btn_Menu.TabIndex = 61;
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.pictureBox1.BackgroundImage = global::WWWPOS.Properties.Resources.header;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(494, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 132);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // Form_ClientLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1424, 788);
            this.Controls.Add(this.panel_MainClient);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ClientLandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientPage";
            this.Load += new System.EventHandler(this.ClientPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel_MainClient;
    }
}