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
    public partial class Order_details : Form
    {
        string strCon = @"Data Source=DESKTOP-B3E8RSQ\SQLEXPRESS;Initial Catalog=SalesManagement;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        public Order_details()
        {
            InitializeComponent();
        }

        private void Order_details_Load(object sender, EventArgs e)
        {
            HienthiDuLieuChiTiet();

        }

        private void HienthiDuLieuChiTiet()
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

            string query = "SELECT * FROM OrderDetails";
            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder buider = new SqlCommandBuilder(adapter);

            ds = new DataSet();

            adapter.Fill(ds, "tblOrderDetails");

            dtgvOrdersCT.DataSource = ds.Tables["tblOrderDetails"];
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            DataRow rows = ds.Tables["tblOrderDetails"].NewRow();

            rows["order_detail_id"] = txtOrder_detail_ID.Text.Trim();
            rows["order_id"] = txtOrdersID.Text.Trim();
            rows["order_id"] = txtOrdersID.Text.Trim();

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
    }
}
