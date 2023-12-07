namespace Bai_tap_giua_ky
{
    partial class Products
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
            this.btnAddSP = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteSP = new System.Windows.Forms.Button();
            this.btnEditSP = new System.Windows.Forms.Button();
            this.dtgvProduct = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.btnSearchSP = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddSP
            // 
            this.btnAddSP.Location = new System.Drawing.Point(3, 3);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(144, 109);
            this.btnAddSP.TabIndex = 0;
            this.btnAddSP.Text = "Thêm ";
            this.btnAddSP.UseVisualStyleBackColor = true;
            this.btnAddSP.Click += new System.EventHandler(this.btnAddSP_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDeleteSP);
            this.panel4.Controls.Add(this.btnEditSP);
            this.panel4.Controls.Add(this.btnAddSP);
            this.panel4.Location = new System.Drawing.Point(12, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(646, 115);
            this.panel4.TabIndex = 5;
            // 
            // btnDeleteSP
            // 
            this.btnDeleteSP.Location = new System.Drawing.Point(315, 2);
            this.btnDeleteSP.Name = "btnDeleteSP";
            this.btnDeleteSP.Size = new System.Drawing.Size(164, 111);
            this.btnDeleteSP.TabIndex = 4;
            this.btnDeleteSP.Text = "Xóa";
            this.btnDeleteSP.UseVisualStyleBackColor = true;
            this.btnDeleteSP.Click += new System.EventHandler(this.btnDeleteSP_Click);
            // 
            // btnEditSP
            // 
            this.btnEditSP.Location = new System.Drawing.Point(153, 3);
            this.btnEditSP.Name = "btnEditSP";
            this.btnEditSP.Size = new System.Drawing.Size(156, 109);
            this.btnEditSP.TabIndex = 1;
            this.btnEditSP.Text = "Sửa";
            this.btnEditSP.UseVisualStyleBackColor = true;
            this.btnEditSP.Click += new System.EventHandler(this.btnEditSP_Click);
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_name,
            this.description,
            this.price,
            this.stock_quantity});
            this.dtgvProduct.Location = new System.Drawing.Point(14, 131);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.RowHeadersWidth = 62;
            this.dtgvProduct.RowTemplate.Height = 28;
            this.dtgvProduct.Size = new System.Drawing.Size(644, 618);
            this.dtgvProduct.TabIndex = 4;
            this.dtgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProduct_CellContentClick);
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "Id";
            this.product_id.MinimumWidth = 8;
            this.product_id.Name = "product_id";
            this.product_id.Width = 150;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "Tên";
            this.product_name.MinimumWidth = 8;
            this.product_name.Name = "product_name";
            this.product_name.Width = 150;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Mô tả";
            this.description.MinimumWidth = 8;
            this.description.Name = "description";
            this.description.Width = 150;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.Width = 150;
            // 
            // stock_quantity
            // 
            this.stock_quantity.DataPropertyName = "stock_quantity";
            this.stock_quantity.HeaderText = "Tồn kho";
            this.stock_quantity.MinimumWidth = 8;
            this.stock_quantity.Name = "stock_quantity";
            this.stock_quantity.Width = 150;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtSearchID);
            this.panel6.Controls.Add(this.btnSearchSP);
            this.panel6.Location = new System.Drawing.Point(696, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(432, 112);
            this.panel6.TabIndex = 7;
            // 
            // txtSearchID
            // 
            this.txtSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchID.Location = new System.Drawing.Point(10, 42);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(283, 28);
            this.txtSearchID.TabIndex = 2;
            // 
            // btnSearchSP
            // 
            this.btnSearchSP.Location = new System.Drawing.Point(298, 2);
            this.btnSearchSP.Name = "btnSearchSP";
            this.btnSearchSP.Size = new System.Drawing.Size(130, 111);
            this.btnSearchSP.TabIndex = 1;
            this.btnSearchSP.Text = "Tìm kiếm";
            this.btnSearchSP.UseVisualStyleBackColor = true;
            this.btnSearchSP.Click += new System.EventHandler(this.btnSearchSP_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.txtId);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(697, 132);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(434, 618);
            this.panel5.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtTonKho);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Location = new System.Drawing.Point(3, 472);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(428, 111);
            this.panel11.TabIndex = 6;
            // 
            // txtTonKho
            // 
            this.txtTonKho.Location = new System.Drawing.Point(126, 46);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.Size = new System.Drawing.Size(296, 26);
            this.txtTonKho.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tồn kho";
            this.label5.UseMnemonic = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtPrice);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(3, 355);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(428, 111);
            this.panel10.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(124, 46);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(296, 26);
            this.txtPrice.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá";
            this.label4.UseMnemonic = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtDescription);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(2, 238);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(428, 111);
            this.panel9.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(128, 46);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(296, 26);
            this.txtDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mô tả";
            this.label3.UseMnemonic = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtName);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(2, 122);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(428, 111);
            this.panel8.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 26);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên";
            this.label2.UseMnemonic = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(129, 51);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(296, 26);
            this.txtId.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(2, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(428, 111);
            this.panel7.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            this.label1.UseMnemonic = false;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 523);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dtgvProduct);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddSP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteSP;
        private System.Windows.Forms.Button btnEditSP;
        private System.Windows.Forms.DataGridView dtgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_quantity;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Button btnSearchSP;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
    }
}