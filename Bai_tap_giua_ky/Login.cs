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
    public partial class Login : Form
    {
        string strCon = @"Data Source=DESKTOP-B3E8RSQ\SQLEXPRESS;Initial Catalog=SalesManagement;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Login()
        {
            InitializeComponent();
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to skip the program?", "Report!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register f = new Register();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtAcoount.Text;
            string password = txtPass.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.");
                return;
            }

            if (ValidateLogin(email, password))
            {   

                MessageBox.Show("Đăng nhập thành công!");
                // Thực hiện các hành động sau khi đăng nhập thành công
                TableManager g = new TableManager();
                this.Hide();
                g.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private bool ValidateLogin(string email, string password)
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
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();

                string query = "SELECT * FROM users WHERE email = @Email AND password = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }
    }
}
