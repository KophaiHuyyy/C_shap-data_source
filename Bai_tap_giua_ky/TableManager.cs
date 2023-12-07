using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_tap_giua_ky
{
    public partial class TableManager : Form
    {
        public TableManager()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            this.Hide();
            c.ShowDialog();
            this.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order q =new Order();
            this.Hide();
            q.ShowDialog();
            this.Show();
        }
    }
}
