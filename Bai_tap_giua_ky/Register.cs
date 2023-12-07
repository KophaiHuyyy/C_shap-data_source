using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bai_tap_giua_ky
{
    public partial class Register : Form
    {
        string strCon = "Data Source=DESKTOP-B3E8RSQ\\SQLEXPRESS;Initial Catalog=SalesManagement;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Nếu sqlCon chưa được khởi tạo, nó sẽ được khởi tạo bằng chuỗi kết nối strCon
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            //Kiểm tra trạng thái(state) kết nối
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            string username = txtUserName.Text;
            string password = txtPassWord.Text;
            string full_name = txtFullName.Text;
            string email = txtEmail.Text;

            try
            {
                string query = "INSERT INTO Users (username, password, full_name, email) VALUES (@username, @password, @full_name, @email)";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@full_name", full_name);
                cmd.Parameters.AddWithValue("@email", email);

                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Đăng ký thành công!");
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.ShowDialog();
            this.Show();
        }
    }
}
