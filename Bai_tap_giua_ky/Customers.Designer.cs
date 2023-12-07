namespace Bai_tap_giua_ky
{
    partial class Customers
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
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel28 = new System.Windows.Forms.Panel();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.btnCustomerSearchKH = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnDeleteKH = new System.Windows.Forms.Button();
            this.btnEditKH = new System.Windows.Forms.Button();
            this.btnAddKH = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            this.panel28.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_id,
            this.last_name,
            this.first_name,
            this.email,
            this.phone});
            this.dtgvCustomer.Location = new System.Drawing.Point(24, 155);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.RowHeadersWidth = 62;
            this.dtgvCustomer.RowTemplate.Height = 28;
            this.dtgvCustomer.Size = new System.Drawing.Size(640, 617);
            this.dtgvCustomer.TabIndex = 5;
            this.dtgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCustomer_CellContentClick);
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "ID";
            this.customer_id.MinimumWidth = 8;
            this.customer_id.Name = "customer_id";
            this.customer_id.Width = 150;
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "Họ";
            this.last_name.MinimumWidth = 8;
            this.last_name.Name = "last_name";
            this.last_name.Width = 150;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "Tên";
            this.first_name.MinimumWidth = 8;
            this.first_name.Name = "first_name";
            this.first_name.Width = 150;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 8;
            this.phone.Name = "phone";
            this.phone.Width = 150;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.txtCustomerSearch);
            this.panel28.Controls.Add(this.btnCustomerSearchKH);
            this.panel28.Location = new System.Drawing.Point(693, 22);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(432, 112);
            this.panel28.TabIndex = 8;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerSearch.Location = new System.Drawing.Point(10, 42);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(283, 28);
            this.txtCustomerSearch.TabIndex = 2;
            // 
            // btnCustomerSearchKH
            // 
            this.btnCustomerSearchKH.Location = new System.Drawing.Point(298, 2);
            this.btnCustomerSearchKH.Name = "btnCustomerSearchKH";
            this.btnCustomerSearchKH.Size = new System.Drawing.Size(130, 111);
            this.btnCustomerSearchKH.TabIndex = 1;
            this.btnCustomerSearchKH.Text = "Tìm kiếm";
            this.btnCustomerSearchKH.UseVisualStyleBackColor = true;
            this.btnCustomerSearchKH.Click += new System.EventHandler(this.btnCustomerSearchKH_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnDeleteKH);
            this.panel14.Controls.Add(this.btnEditKH);
            this.panel14.Controls.Add(this.btnAddKH);
            this.panel14.Location = new System.Drawing.Point(24, 22);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(646, 115);
            this.panel14.TabIndex = 7;
            // 
            // btnDeleteKH
            // 
            this.btnDeleteKH.Location = new System.Drawing.Point(315, 2);
            this.btnDeleteKH.Name = "btnDeleteKH";
            this.btnDeleteKH.Size = new System.Drawing.Size(164, 111);
            this.btnDeleteKH.TabIndex = 4;
            this.btnDeleteKH.Text = "Xóa";
            this.btnDeleteKH.UseVisualStyleBackColor = true;
            this.btnDeleteKH.Click += new System.EventHandler(this.btnDeleteKH_Click);
            // 
            // btnEditKH
            // 
            this.btnEditKH.Location = new System.Drawing.Point(153, 3);
            this.btnEditKH.Name = "btnEditKH";
            this.btnEditKH.Size = new System.Drawing.Size(156, 109);
            this.btnEditKH.TabIndex = 1;
            this.btnEditKH.Text = "Sửa";
            this.btnEditKH.UseVisualStyleBackColor = true;
            this.btnEditKH.Click += new System.EventHandler(this.btnEditKH_Click);
            // 
            // btnAddKH
            // 
            this.btnAddKH.Location = new System.Drawing.Point(3, 3);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Size = new System.Drawing.Size(144, 109);
            this.btnAddKH.TabIndex = 0;
            this.btnAddKH.Text = "Thêm ";
            this.btnAddKH.UseVisualStyleBackColor = true;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel19);
            this.panel13.Controls.Add(this.panel18);
            this.panel13.Controls.Add(this.panel17);
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Location = new System.Drawing.Point(693, 155);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(448, 632);
            this.panel13.TabIndex = 6;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.txtPhone);
            this.panel19.Controls.Add(this.label10);
            this.panel19.Location = new System.Drawing.Point(3, 472);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(440, 111);
            this.panel19.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(122, 46);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(314, 28);
            this.txtPhone.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "Số ĐT";
            this.label10.UseMnemonic = false;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.txtEmail);
            this.panel18.Controls.Add(this.label9);
            this.panel18.Location = new System.Drawing.Point(3, 355);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(440, 111);
            this.panel18.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(122, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(314, 28);
            this.txtEmail.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Email";
            this.label9.UseMnemonic = false;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txtFirstName);
            this.panel17.Controls.Add(this.label8);
            this.panel17.Location = new System.Drawing.Point(3, 238);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(440, 111);
            this.panel17.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(122, 46);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(314, 28);
            this.txtFirstName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên";
            this.label8.UseMnemonic = false;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txtLastName);
            this.panel16.Controls.Add(this.label7);
            this.panel16.Location = new System.Drawing.Point(3, 122);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(440, 111);
            this.panel16.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(122, 46);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(314, 28);
            this.txtLastName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Họ";
            this.label7.UseMnemonic = false;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtCustomerID);
            this.panel15.Controls.Add(this.label6);
            this.panel15.Location = new System.Drawing.Point(3, 5);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(440, 111);
            this.panel15.TabIndex = 1;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(122, 46);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(314, 28);
            this.txtCustomerID.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID";
            this.label6.UseMnemonic = false;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 815);
            this.Controls.Add(this.dtgvCustomer);
            this.Controls.Add(this.panel28);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Button btnCustomerSearchKH;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnDeleteKH;
        private System.Windows.Forms.Button btnEditKH;
        private System.Windows.Forms.Button btnAddKH;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label6;
    }
}