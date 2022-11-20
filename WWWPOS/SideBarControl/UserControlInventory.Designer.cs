namespace WWWPOS.SideBarControl
{
    partial class UserControlInventory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_UpdateProduct = new System.Windows.Forms.Button();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.lbl_Inventory = new System.Windows.Forms.Label();
            this.panel_Inventory = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_AddProduct);
            this.panel1.Controls.Add(this.btn_UpdateProduct);
            this.panel1.Controls.Add(this.btn_DeleteProduct);
            this.panel1.Controls.Add(this.lbl_Inventory);
            this.panel1.Location = new System.Drawing.Point(25, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 82);
            this.panel1.TabIndex = 19;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.btn_AddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddProduct.ForeColor = System.Drawing.Color.White;
            this.btn_AddProduct.Location = new System.Drawing.Point(437, 18);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(141, 46);
            this.btn_AddProduct.TabIndex = 4;
            this.btn_AddProduct.Text = "Add Product";
            this.btn_AddProduct.UseVisualStyleBackColor = false;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_UpdateProduct
            // 
            this.btn_UpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.btn_UpdateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_UpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateProduct.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateProduct.Location = new System.Drawing.Point(604, 18);
            this.btn_UpdateProduct.Name = "btn_UpdateProduct";
            this.btn_UpdateProduct.Size = new System.Drawing.Size(141, 46);
            this.btn_UpdateProduct.TabIndex = 3;
            this.btn_UpdateProduct.Text = "Edit Product";
            this.btn_UpdateProduct.UseVisualStyleBackColor = false;
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            this.btn_DeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteProduct.Location = new System.Drawing.Point(767, 18);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(141, 46);
            this.btn_DeleteProduct.TabIndex = 1;
            this.btn_DeleteProduct.Text = "Delete Product";
            this.btn_DeleteProduct.UseVisualStyleBackColor = false;
            // 
            // lbl_Inventory
            // 
            this.lbl_Inventory.AutoSize = true;
            this.lbl_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inventory.Location = new System.Drawing.Point(16, 28);
            this.lbl_Inventory.Name = "lbl_Inventory";
            this.lbl_Inventory.Size = new System.Drawing.Size(118, 29);
            this.lbl_Inventory.TabIndex = 1;
            this.lbl_Inventory.Text = "Inventory";
            // 
            // panel_Inventory
            // 
            this.panel_Inventory.Location = new System.Drawing.Point(25, 117);
            this.panel_Inventory.Name = "panel_Inventory";
            this.panel_Inventory.Size = new System.Drawing.Size(932, 517);
            this.panel_Inventory.TabIndex = 20;
            // 
            // UserControlInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Inventory);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlInventory";
            this.Size = new System.Drawing.Size(976, 655);
            this.Load += new System.EventHandler(this.UserControlInventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_UpdateProduct;
        private System.Windows.Forms.Button btn_DeleteProduct;
        private System.Windows.Forms.Label lbl_Inventory;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Panel panel_Inventory;
    }
}
