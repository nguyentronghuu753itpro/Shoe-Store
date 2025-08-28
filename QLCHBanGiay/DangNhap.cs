using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBanGiay
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ?", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "huu" && txtPassword.Text == "123")
            {
 
                TrangChu ds = new TrangChu();
                this.Hide();
                ds.Show();
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void gunaExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
