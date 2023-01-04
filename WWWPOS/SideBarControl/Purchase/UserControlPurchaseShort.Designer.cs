namespace WWWPOS.SideBarControl.Purchase
{
    partial class UserControlPurchaseShort
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridSuccessOrders = new System.Windows.Forms.DataGridView();
            this.Order_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Prize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuccessOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Shorts";
            // 
            // dataGridSuccessOrders
            // 
            this.dataGridSuccessOrders.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(53)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSuccessOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSuccessOrders.ColumnHeadersHeight = 35;
            this.dataGridSuccessOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridSuccessOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_ID,
            this.Product_Category,
            this.Product_Name,
            this.Color,
            this.Product_Size,
            this.Product_Prize,
            this.Product_Quantity,
            this.Product_Total});
            this.dataGridSuccessOrders.EnableHeadersVisualStyles = false;
            this.dataGridSuccessOrders.Location = new System.Drawing.Point(23, 37);
            this.dataGridSuccessOrders.Name = "dataGridSuccessOrders";
            this.dataGridSuccessOrders.RowHeadersVisible = false;
            this.dataGridSuccessOrders.RowHeadersWidth = 51;
            this.dataGridSuccessOrders.Size = new System.Drawing.Size(880, 393);
            this.dataGridSuccessOrders.TabIndex = 40;
            // 
            // Order_ID
            // 
            this.Order_ID.HeaderText = "Order ID";
            this.Order_ID.MinimumWidth = 6;
            this.Order_ID.Name = "Order_ID";
            this.Order_ID.Width = 125;
            // 
            // Product_Category
            // 
            this.Product_Category.HeaderText = "Category";
            this.Product_Category.MinimumWidth = 6;
            this.Product_Category.Name = "Product_Category";
            this.Product_Category.Width = 125;
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Name";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Width = 125;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.Width = 125;
            // 
            // Product_Size
            // 
            this.Product_Size.HeaderText = "Size";
            this.Product_Size.MinimumWidth = 6;
            this.Product_Size.Name = "Product_Size";
            this.Product_Size.Width = 125;
            // 
            // Product_Prize
            // 
            this.Product_Prize.HeaderText = "Price";
            this.Product_Prize.MinimumWidth = 6;
            this.Product_Prize.Name = "Product_Prize";
            this.Product_Prize.Width = 125;
            // 
            // Product_Quantity
            // 
            this.Product_Quantity.HeaderText = "Quantity";
            this.Product_Quantity.MinimumWidth = 6;
            this.Product_Quantity.Name = "Product_Quantity";
            this.Product_Quantity.Width = 125;
            // 
            // Product_Total
            // 
            this.Product_Total.HeaderText = "Total";
            this.Product_Total.MinimumWidth = 6;
            this.Product_Total.Name = "Product_Total";
            this.Product_Total.Width = 125;
            // 
            // UserControlPurchaseShort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridSuccessOrders);
            this.Controls.Add(this.label2);
            this.Name = "UserControlPurchaseShort";
            this.Size = new System.Drawing.Size(932, 449);
            this.Load += new System.EventHandler(this.UserControlPurchaseShort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuccessOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Prize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Total;
        public System.Windows.Forms.DataGridView dataGridSuccessOrders;
    }
}
