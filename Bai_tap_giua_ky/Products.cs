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
    public partial class Products : Form
    {
        string strCon = @"Data Source=DESKTOP-B3E8RSQ\SQLEXPRESS;Initial Catalog=SalesManagement;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            HienThiDuLieuSanPham();
        }

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

            adapter.Fill(ds, "tblProducts");

            dtgvProduct.DataSource = ds.Tables["tblProducts"];
        }

        private void btnAddSP_Click(object sender, EventArgs e)
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
        int vt = -1;
        private void dtgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnEditSP_Click(object sender, EventArgs e)
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

        private void btnDeleteSP_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                XoaSP();
            }
        }

        private void XoaSP()
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

        private void btnSearchSP_Click(object sender, EventArgs e)
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
    }
}
