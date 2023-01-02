namespace WWWPOS.SideBarControl.Orders.PendingOrders
{
    partial class UserControl_PendingOrderContainer
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
            this.lbl_OrderNumber = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flPanel_ParticularItem = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Compute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_ClientPay = new System.Windows.Forms.TextBox();
            this.lbl_Change = new System.Windows.Forms.Label();
            this.lbl_OrderTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flPanel_ParticularItem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_OrderNumber
            // 
            this.lbl_OrderNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.lbl_OrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_OrderNumber.Location = new System.Drawing.Point(8, 5);
            this.lbl_OrderNumber.Name = "lbl_OrderNumber";
            this.lbl_OrderNumber.Size = new System.Drawing.Size(215, 37);
            this.lbl_OrderNumber.TabIndex = 0;
            this.lbl_OrderNumber.Text = "Order Number";
            this.lbl_OrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(156)))), ((int)(((byte)(55)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(433, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mark as success";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(52)))), ((int)(((byte)(82)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(643, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mark as failed";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // flPanel_ParticularItem
            // 
            this.flPanel_ParticularItem.AutoScroll = true;
            this.flPanel_ParticularItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flPanel_ParticularItem.Controls.Add(this.panel1);
            this.flPanel_ParticularItem.Location = new System.Drawing.Point(8, 51);
            this.flPanel_ParticularItem.Name = "flPanel_ParticularItem";
            this.flPanel_ParticularItem.Padding = new System.Windows.Forms.Padding(5);
            this.flPanel_ParticularItem.Size = new System.Drawing.Size(814, 227);
            this.flPanel_ParticularItem.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Compute);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBox_ClientPay);
            this.panel1.Controls.Add(this.lbl_Change);
            this.panel1.Controls.Add(this.lbl_OrderTotal);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 57);
            this.panel1.TabIndex = 6;
            // 
            // btn_Compute
            // 
            this.btn_Compute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.btn_Compute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Compute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Compute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Compute.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Compute.Location = new System.Drawing.Point(535, 9);
            this.btn_Compute.Name = "btn_Compute";
            this.btn_Compute.Size = new System.Drawing.Size(106, 37);
            this.btn_Compute.TabIndex = 5;
            this.btn_Compute.Text = "Compute";
            this.btn_Compute.UseVisualStyleBackColor = false;
            this.btn_Compute.Click += new System.EventHandler(this.btn_Compute_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(296, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_ClientPay
            // 
            this.txtBox_ClientPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_ClientPay.Location = new System.Drawing.Point(327, 12);
            this.txtBox_ClientPay.Name = "txtBox_ClientPay";
            this.txtBox_ClientPay.Size = new System.Drawing.Size(202, 30);
            this.txtBox_ClientPay.TabIndex = 7;
            this.txtBox_ClientPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Change
            // 
            this.lbl_Change.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Change.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Change.Location = new System.Drawing.Point(647, 9);
            this.lbl_Change.Name = "lbl_Change";
            this.lbl_Change.Size = new System.Drawing.Size(121, 37);
            this.lbl_Change.TabIndex = 6;
            this.lbl_Change.Text = "Change";
            this.lbl_Change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_OrderTotal
            // 
            this.lbl_OrderTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(116)))));
            this.lbl_OrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderTotal.ForeColor = System.Drawing.Color.Black;
            this.lbl_OrderTotal.Location = new System.Drawing.Point(146, 9);
            this.lbl_OrderTotal.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_OrderTotal.Name = "lbl_OrderTotal";
            this.lbl_OrderTotal.Size = new System.Drawing.Size(147, 37);
            this.lbl_OrderTotal.TabIndex = 5;
            this.lbl_OrderTotal.Text = "Order Total : ";
            this.lbl_OrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(116)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order Total : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl_PendingOrderContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.flPanel_ParticularItem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_OrderNumber);
            this.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Name = "UserControl_PendingOrderContainer";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(830, 286);
            this.flPanel_ParticularItem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_OrderNumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Change;
        private System.Windows.Forms.Button btn_Compute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_ClientPay;
        public System.Windows.Forms.FlowLayoutPanel flPanel_ParticularItem;
        public System.Windows.Forms.Label lbl_OrderTotal;
        public System.Windows.Forms.Label label1;
    }
}
