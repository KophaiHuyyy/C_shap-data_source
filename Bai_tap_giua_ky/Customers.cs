using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_tap_giua_ky
{
    public partial class Customers : Form
    {
        string strCon = @"Data Source=DESKTOP-B3E8RSQ\SQLEXPRESS;Initial Catalog=SalesManagement;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        public Customers()
        {
            InitializeComponent();
        }



        private void HienThiDuLieuKhachHang()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            //Kiểm tra trạng thái(state) kết nối
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            string query = "SELECT * FROM Customers";
            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder buider = new SqlCommandBuilder(adapter);

            ds = new DataSet();

            adapter.Fill(ds, "tblCustomers");

            dtgvCustomer.DataSource = ds.Tables["tblCustomers"];
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            HienThiDuLieuKhachHang();
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            DataRow dataRow = ds.Tables["tblCustomers"].NewRow();
            //row["customer_id"] = txtCustomerID.Text.Trim();
            dataRow["last_name"] = txtLastName.Text.Trim();
            dataRow["first_name"] = txtFirstName.Text.Trim();
            dataRow["email"] = txtEmail.Text.Trim();
            dataRow["phone"] = txtPhone.Text.Trim();

            ds.Tables["tblCustomers"].Rows.Add(dataRow);

            int kq = adapter.Update(ds.Tables["tblCustomers"]);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        int vt = -1;
        private void btnEditKH_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn vật tư!");
                return;
            }

            DataRow dataRow = ds.Tables["tblCustomers"].Rows[vt];
            dataRow.BeginEdit();

            //row["customers_id"] = txtId.Text.Trim();
            dataRow["last_name"] = txtLastName.Text.Trim();
            dataRow["first_name"] = txtFirstName.Text.Trim();
            dataRow["email"] = txtEmail.Text.Trim();
            dataRow["phone"] = txtPhone.Text.Trim();

            dataRow.EndEdit();

            int re = adapter.Update(ds.Tables["tblCustomers"]);
            if (re > 0)
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void dtgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) { return; }
            DataRow dataRow = ds.Tables["tblCustomers"].Rows[vt];
            txtCustomerID.Text = dataRow["customer_id"].ToString();
            txtLastName.Text = dataRow["last_name"].ToString();
            txtFirstName.Text = dataRow["first_name"].ToString();
            txtEmail.Text = dataRow["email"].ToString();
            txtPhone.Text = dataRow["Phone"].ToString();
        }

        private void btnDeleteKH_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                XoaKhachHang();

            }
        }

        private void XoaKhachHang()
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!");
            }

            DataRow dataRow = ds.Tables["tblCustomers"].Rows[vt];
            dataRow.Delete();

            try
            {
                int kq = adapter.Update(ds.Tables["tblCustomers"]);
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnCustomerSearchKH_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustomerSearch.Text.Trim()) && int.TryParse(txtCustomerSearch.Text.Trim(), out int searchCustomerId))
            {
                TimKiemKhachHangTheoID(searchCustomerId);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một ID khách hàng hợp lệ.");
            }
        }

        private void TimKiemKhachHangTheoID(int customerId)
        {

            DataRow[] resultRows = ds.Tables["tblCustomers"].Select($"customer_id = {customerId}");

            if (resultRows.Length > 0)
            {
                // Hiển thị thông tin sản phẩm tìm được
                DataRow dataRow = resultRows[0];
                txtCustomerID.Text = dataRow["customer_id"].ToString();
                txtLastName.Text = dataRow["last_name"].ToString();
                txtFirstName.Text = dataRow["first_name"].ToString();
                txtEmail.Text = dataRow["email"].ToString();
                txtPhone.Text = dataRow["Phone"].ToString();

                MessageBox.Show("Đã tìm thấy khách hàng!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng với ID đã nhập.");
            }
        }
    }
}