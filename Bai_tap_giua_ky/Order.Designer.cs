namespace Bai_tap_giua_ky
{
    partial class Order
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
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnDelete3 = new System.Windows.Forms.Button();
            this.btnEdit3 = new System.Windows.Forms.Button();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.txtSerachOrder = new System.Windows.Forms.TextBox();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.dtgvOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel22 = new System.Windows.Forms.Panel();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.txtDateOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrders)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.btnDelete3);
            this.panel20.Controls.Add(this.btnEdit3);
            this.panel20.Controls.Add(this.btnAdd3);
            this.panel20.Location = new System.Drawing.Point(22, 30);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(646, 115);
            this.panel20.TabIndex = 9;
            // 
            // btnDelete3
            // 
            this.btnDelete3.Location = new System.Drawing.Point(315, 2);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(164, 111);
            this.btnDelete3.TabIndex = 4;
            this.btnDelete3.Text = "Xóa";
            this.btnDelete3.UseVisualStyleBackColor = true;
            // 
            // btnEdit3
            // 
            this.btnEdit3.Location = new System.Drawing.Point(153, 3);
            this.btnEdit3.Name = "btnEdit3";
            this.btnEdit3.Size = new System.Drawing.Size(156, 109);
            this.btnEdit3.TabIndex = 1;
            this.btnEdit3.Text = "Sửa";
            this.btnEdit3.UseVisualStyleBackColor = true;
            // 
            // btnAdd3
            // 
            this.btnAdd3.Location = new System.Drawing.Point(3, 3);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(144, 109);
            this.btnAdd3.TabIndex = 0;
            this.btnAdd3.Text = "Thêm ";
            this.btnAdd3.UseVisualStyleBackColor = true;
            // 
            // txtSerachOrder
            // 
            this.txtSerachOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerachOrder.Location = new System.Drawing.Point(12, 47);
            this.txtSerachOrder.Name = "txtSerachOrder";
            this.txtSerachOrder.Size = new System.Drawing.Size(283, 28);
            this.txtSerachOrder.TabIndex = 2;
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(319, 7);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(130, 111);
            this.btnSearchOrder.TabIndex = 1;
            this.btnSearchOrder.Text = "Tìm kiếm";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // dtgvOrders
            // 
            this.dtgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dtgvOrders.Location = new System.Drawing.Point(37, 176);
            this.dtgvOrders.Name = "dtgvOrders";
            this.dtgvOrders.RowHeadersWidth = 62;
            this.dtgvOrders.RowTemplate.Height = 28;
            this.dtgvOrders.Size = new System.Drawing.Size(640, 617);
            this.dtgvOrders.TabIndex = 7;
            this.dtgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvOrders_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "order_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Oder_ID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "customer_id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Customer_ID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "User_ID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "order_date";
            this.dataGridViewTextBoxColumn9.HeaderText = "Order_date";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "total_amount";
            this.dataGridViewTextBoxColumn10.HeaderText = "Total_amount";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Location = new System.Drawing.Point(22, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(646, 115);
            this.panel4.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(315, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(164, 111);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(153, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(156, 109);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 109);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.txtTotalAmount);
            this.panel22.Controls.Add(this.label11);
            this.panel22.Location = new System.Drawing.Point(10, 354);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(459, 111);
            this.panel22.TabIndex = 15;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(232, 43);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(214, 28);
            this.txtTotalAmount.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Total_amount";
            this.label11.UseMnemonic = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel23);
            this.panel2.Controls.Add(this.panel22);
            this.panel2.Controls.Add(this.panel26);
            this.panel2.Controls.Add(this.panel25);
            this.panel2.Controls.Add(this.panel24);
            this.panel2.Location = new System.Drawing.Point(703, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 632);
            this.panel2.TabIndex = 14;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.txtDateOrder);
            this.panel23.Controls.Add(this.label1);
            this.panel23.Location = new System.Drawing.Point(10, 237);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(459, 111);
            this.panel23.TabIndex = 16;
            // 
            // txtDateOrder
            // 
            this.txtDateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateOrder.Location = new System.Drawing.Point(232, 43);
            this.txtDateOrder.Name = "txtDateOrder";
            this.txtDateOrder.Size = new System.Drawing.Size(214, 28);
            this.txtDateOrder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oder_date";
            this.label1.UseMnemonic = false;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txtOrderID);
            this.panel26.Controls.Add(this.label15);
            this.panel26.Location = new System.Drawing.Point(12, 471);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(454, 111);
            this.panel26.TabIndex = 1;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(226, 43);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(217, 28);
            this.txtOrderID.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(210, 32);
            this.label15.TabIndex = 1;
            this.label15.Text = "Product_name";
            this.label15.UseMnemonic = false;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.txtIdCustomer);
            this.panel25.Controls.Add(this.label14);
            this.panel25.Location = new System.Drawing.Point(10, 3);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(456, 111);
            this.panel25.TabIndex = 12;
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCustomer.Location = new System.Drawing.Point(230, 46);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(214, 28);
            this.txtIdCustomer.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(185, 32);
            this.label14.TabIndex = 1;
            this.label14.Text = "Customer_id";
            this.label14.UseMnemonic = false;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.txtIdUser);
            this.panel24.Controls.Add(this.label13);
            this.panel24.Location = new System.Drawing.Point(10, 120);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(459, 111);
            this.panel24.TabIndex = 13;
            // 
            // txtIdUser
            // 
            this.txtIdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUser.Location = new System.Drawing.Point(232, 38);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(217, 28);
            this.txtIdUser.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 32);
            this.label13.TabIndex = 1;
            this.label13.Text = "User_id";
            this.label13.UseMnemonic = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-265, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 32);
            this.label12.TabIndex = 11;
            this.label12.Text = "Oder_date";
            this.label12.UseMnemonic = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSerachOrder);
            this.panel1.Controls.Add(this.btnSearchOrder);
            this.panel1.Location = new System.Drawing.Point(703, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 133);
            this.panel1.TabIndex = 15;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 1118);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtgvOrders);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrders)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button btnDelete3;
        private System.Windows.Forms.Button btnEdit3;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.TextBox txtSerachOrder;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.DataGridView dtgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox txtDateOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}