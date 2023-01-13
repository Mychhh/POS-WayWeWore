namespace WWWPOS.ClientControl.ClientCart
{
    partial class UserControl_ProducOrderInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_OrderID = new System.Windows.Forms.Label();
            this.lbl_OrderDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Date : ";
            // 
            // lbl_OrderID
            // 
            this.lbl_OrderID.AutoSize = true;
            this.lbl_OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderID.ForeColor = System.Drawing.Color.White;
            this.lbl_OrderID.Location = new System.Drawing.Point(98, 16);
            this.lbl_OrderID.Name = "lbl_OrderID";
            this.lbl_OrderID.Size = new System.Drawing.Size(129, 20);
            this.lbl_OrderID.TabIndex = 3;
            this.lbl_OrderID.Text = "192.168.254.254";
            // 
            // lbl_OrderDate
            // 
            this.lbl_OrderDate.AutoSize = true;
            this.lbl_OrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderDate.ForeColor = System.Drawing.Color.White;
            this.lbl_OrderDate.Location = new System.Drawing.Point(117, 41);
            this.lbl_OrderDate.Name = "lbl_OrderDate";
            this.lbl_OrderDate.Size = new System.Drawing.Size(93, 20);
            this.lbl_OrderDate.TabIndex = 4;
            this.lbl_OrderDate.Text = "05-26-2002";
            // 
            // UserControl_ProducOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.lbl_OrderDate);
            this.Controls.Add(this.lbl_OrderID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_ProducOrderInfo";
            this.Size = new System.Drawing.Size(390, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_OrderID;
        public System.Windows.Forms.Label lbl_OrderDate;
    }
}
