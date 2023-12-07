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
    public partial class Order : Form
    {
        string strCon = @"Data Source=DESKTOP-B3E8RSQ\SQLEXPRESS;Initial Catalog=SalesManagement;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi()
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

            dtgvOrders.DataSource = ds.Tables["tblOrders"];
        }

        private void btnThem_Click(object sender, EventArgs e)
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

        int vt = -1;
        private void btnSua_Click(object sender, EventArgs e)
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

        private void dtgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnXoa_Click(object sender, EventArgs e)
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

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSerachOrder.Text.Trim()) && int.TryParse(txtSerachOrder.Text.Trim(), out int searchOrdersId))
            {
                TimKiemKhachHangTheoID(searchOrdersId);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một ID khách hàng hợp lệ.");
            }
        }

        private void TimKiemKhachHangTheoID(int order_Id)
        {
            DataRow[] resultRows = ds.Tables["tblOrders"].Select($"order_Id = {order_Id}");

            if (resultRows.Length > 0)
            {
                // Hiển thị thông tin sản phẩm tìm được
                DataRow rows = resultRows[0];
                txtOrderID.Text = rows["product_name"].ToString();
                txtIdCustomer.Text = rows["customer_id"].ToString();
                txtIdUser.Text = rows["user_id"].ToString();
                txtDateOrder.Text = rows["order_date"].ToString();
                txtTotalAmount.Text = rows["total_amount"].ToString();

                MessageBox.Show("Đã tìm thấy khách hàng!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng với ID đã nhập.");
            }
        }
    }
}
