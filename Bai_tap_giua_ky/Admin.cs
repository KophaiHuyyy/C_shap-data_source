using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_tap_giua_ky
{
    public partial class Admin : Form
    {
        string strCon = @"Data Source=DESKTOP-B3E8RSQ\SQLEXPRESS;Initial Catalog=SalesManagement;Integrated Security=True";
        SqlConnection sqlCon = null; 
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            HienThiDuLieuSanPham();
            HienThiDuLieuKhachHang();
            HienThiDuLieuYeuCau();
        }

        
        // Mục sản phẩm ____________________________________________________________________________________________________________________________

        private void HienThiDuLieuSanPham()
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

            string query = "SELECT * FROM Products";
            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder buider = new SqlCommandBuilder(adapter);
            
            ds = new DataSet();

            adapter.Fill(ds,"tblProducts");

            dtgvProducts.DataSource = ds.Tables["tblProducts"];
        }

        //Thêm sản phẩm.
        private void btnAdd_Click(object sender, EventArgs e)
        {

            DataRow row = ds.Tables["tblProducts"].NewRow();
            //row["product_id"] = txtId.Text.Trim();
            row["product_name"] = txtName.Text.Trim();
            row["description"] = txtDescription.Text.Trim();
            row["price"] = txtPrice.Text.Trim();
            row["stock_quantity"] = txtTonKho.Text.Trim();

            ds.Tables["tblProducts"].Rows.Add(row);

            int kq = adapter.Update(ds.Tables["tblProducts"]);
            if (kq > 0)
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại");
            }  

        }

        //Sửa sản phẩm
        int vt = -1;
        private void dtgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) { return; }
            DataRow row = ds.Tables["tblProducts"].Rows[vt];
            txtId.Text = row["product_id"].ToString();
            txtName.Text = row["product_name"].ToString();
            txtDescription.Text = row["description"].ToString();
            txtPrice.Text = row["price"].ToString();
            txtTonKho.Text = row["stock_quantity"].ToString();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn vật tư!");
                return;
            }

            DataRow row = ds.Tables["tblProducts"].Rows[vt];
            row.BeginEdit();

            row["product_id"] = txtId.Text.Trim();
            row["product_name"] = txtName.Text.Trim();
            row["description"] = txtDescription.Text.Trim();
            row["price"] = txtPrice.Text.Trim();
            row["stock_quantity"] = txtTonKho.Text.Trim();

            row.EndEdit();

            int re = adapter.Update(ds.Tables["tblProducts"]);
            if (re > 0)
            {
                MessageBox.Show("Sửa sản phẩm thành công!");
            }
            else
            {
                MessageBox.Show("Sửa sản phẩm thất bại!");
            }
        }

        //Xóa sản phẩm
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                XoaSanPham();
            }
        }

        private void XoaSanPham()
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!");
            }

            DataRow row = ds.Tables["tblProducts"].Rows[vt];
            row.Delete();

            try
            {
                int kq = adapter.Update(ds.Tables["tblProducts"]);
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

        private void TimKiemSanPhamTheoID(int productId)
        {
            DataRow[] resultRows = ds.Tables["tblProducts"].Select($"product_id = {productId}");

            if (resultRows.Length > 0)
            {
                // Hiển thị thông tin sản phẩm tìm được
                DataRow row = resultRows[0];
                txtId.Text = row["product_id"].ToString();
                txtName.Text = row["product_name"].ToString();
                txtDescription.Text = row["description"].ToString();
                txtPrice.Text = row["price"].ToString();
                txtTonKho.Text = row["stock_quantity"].ToString();

                MessageBox.Show("Đã tìm thấy sản phẩm!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm với ID đã nhập.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchID.Text.Trim()) && int.TryParse(txtSearchID.Text.Trim(), out int searchId))
            {
                TimKiemSanPhamTheoID(searchId);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một ID sản phẩm hợp lệ.");
            }
        }
        // Mục khách hàng_________________________________________________________________________________________________________________________________
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

            dtgvCustomers.DataSource = ds.Tables["tblCustomers"];
        }


        // Thêm khách hàng
        private void btnAdd2_Click(object sender, EventArgs e)
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

        //Sửa khách hàng
        private void dtgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) { return; }
            DataRow dataRow = ds.Tables["tblCustomers"].Rows[vt];
            txtCustomerID.Text = dataRow["customer_id"].ToString();
            txtLastName.Text = dataRow["last_name"].ToString();
            txtFirstName.Text= dataRow["first_name"].ToString();
            txtEmail.Text = dataRow["email"].ToString();
            txtPhone.Text = dataRow["Phone"].ToString();
        }

        private void btnEdit2_Click(object sender, EventArgs e)
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
                MessageBox.Show("Sửa sản công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnDelete2_Click(object sender, EventArgs e)
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

        private void btnCustomerSearch_Click(object sender, EventArgs e)
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

        //Mục Order____________________________________________________________________________________________________
        private void HienThiDuLieuYeuCau()
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

            string query = "SELECT * FROM Orders";
            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder buider = new SqlCommandBuilder(adapter);

            ds = new DataSet();

            adapter.Fill(ds, "tblOrders");

            dtgvOrder.DataSource = ds.Tables["tblOrders"];
        }

        //Thêm yêu cầu
        private void btnAdd3_Click(object sender, EventArgs e)
        {
            DataRow rows = ds.Tables["tblOrders"].NewRow();
            
            rows["customer_id"] = txtIdCustomer.Text.Trim();
            rows["user_id"] = txtIdUser.Text.Trim();
            // Chuyển đổi chuỗi ngày thành kiểu DateTime
            DateTime orderDate;
            if (DateTime.TryParseExact(txtDateOrder.Text.Trim(), "dd/MM/yyyy", null, DateTimeStyles.None, out orderDate))
            {
                rows["order_date"] = orderDate;
            }
            else
            {
                MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.");
                return;
            }
            rows["total_amount"] = txtTotalAmount.Text.Trim();
            rows["product_name"] = txtOrderID.Text.Trim();

            ds.Tables["tblOrders"].Rows.Add(rows);

            int kq = adapter.Update(ds.Tables["tblOrders"]);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        //Sửa Yêu Cầu
        private void dtgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) { return; }
            DataRow rows = ds.Tables["tblOrders"].Rows[vt];
            txtOrderID.Text = rows["product_name"].ToString();
            txtIdCustomer.Text = rows["customer_id"].ToString();
            txtIdUser.Text = rows["user_id"].ToString();
            txtDateOrder.Text = rows["order_date"].ToString();
            txtTotalAmount.Text = rows["total_amount"].ToString();
           
        }

        private void btnEdit3_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn!");
                return;
            }

            DataRow rows = ds.Tables["tblOrders"].Rows[vt];
            rows.BeginEdit();

            rows["customer_id"] = txtIdCustomer.Text.Trim();
            rows["user_id"] = txtIdUser.Text.Trim();
            rows["order_date"] = txtDateOrder.Text.Trim();
            rows["total_amount"] = txtTotalAmount.Text.Trim();
            rows["product_name"] = txtOrderID.Text.Trim();


            rows.EndEdit();

            int re = adapter.Update(ds.Tables["tblOrders"]);
            if (re > 0)
            {
                MessageBox.Show("Sửa sản  công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnDelete3_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                XoaYeucau();
            }
        }

        private void XoaYeucau()
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!");
            }

            DataRow rows = ds.Tables["tblOrders"].Rows[vt];
            rows.Delete();

            try
            {
                int kq = adapter.Update(ds.Tables["tblOrders"]);
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
    }
}
