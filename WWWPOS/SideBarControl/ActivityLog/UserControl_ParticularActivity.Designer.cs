namespace WWWPOS.SideBarControl.ActivityLog
{
    partial class UserControl_ParticularActivity
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
            this.lbl_WhatHappend = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_WhatHappend
            // 
            this.lbl_WhatHappend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WhatHappend.Location = new System.Drawing.Point(6, 3);
            this.lbl_WhatHappend.Name = "lbl_WhatHappend";
            this.lbl_WhatHappend.Size = new System.Drawing.Size(657, 65);
            this.lbl_WhatHappend.TabIndex = 0;
            this.lbl_WhatHappend.Text = "What Happened";
            this.lbl_WhatHappend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.Location = new System.Drawing.Point(687, 23);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(105, 25);
            this.lbl_Time.TabIndex = 2;
            this.lbl_Time.Text = "12:30 PM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(673, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 57);
            this.panel1.TabIndex = 3;
            // 
            // UserControl_ParticularActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_WhatHappend);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControl_ParticularActivity";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(808, 71);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WhatHappend;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Panel panel1;
    }
}
