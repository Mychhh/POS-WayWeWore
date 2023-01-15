namespace WWWPOS.MessageFolder
{
    partial class SuccessMessageDialogue
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
            this.btn_Alright = new System.Windows.Forms.Button();
            this.lbl_SuccessMessage = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_Alright
            // 
            this.btn_Alright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.btn_Alright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Alright.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Alright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alright.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Alright.Location = new System.Drawing.Point(91, 216);
            this.btn_Alright.Name = "btn_Alright";
            this.btn_Alright.Size = new System.Drawing.Size(131, 36);
            this.btn_Alright.TabIndex = 5;
            this.btn_Alright.Text = "Okay";
            this.btn_Alright.UseVisualStyleBackColor = false;
            this.btn_Alright.Click += new System.EventHandler(this.btn_Alright_Click_1);
            // 
            // lbl_SuccessMessage
            // 
            this.lbl_SuccessMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SuccessMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_SuccessMessage.Location = new System.Drawing.Point(12, 54);
            this.lbl_SuccessMessage.Name = "lbl_SuccessMessage";
            this.lbl_SuccessMessage.Size = new System.Drawing.Size(288, 159);
            this.lbl_SuccessMessage.TabIndex = 6;
            this.lbl_SuccessMessage.Text = "Success Message";
            this.lbl_SuccessMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Black;
            this.btn_Close.Location = new System.Drawing.Point(260, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(40, 40);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.panel4.Location = new System.Drawing.Point(309, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 282);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 282);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(-1, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 3);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 3);
            this.panel1.TabIndex = 8;
            // 
            // SuccessMessageDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(312, 282);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_SuccessMessage);
            this.Controls.Add(this.btn_Alright);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuccessMessageDialogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuccessMessageDialogue";
            this.Load += new System.EventHandler(this.SuccessMessageDialogue_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Alright;
        private System.Windows.Forms.Label lbl_SuccessMessage;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}