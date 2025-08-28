using QLCHBanGiay.ChucNang;
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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            //ActivateButton(btnSender); /*đổi màu các Form*/
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(childForm);
            this.panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Nhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien(), sender    );
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHang(), sender);
        }
        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDonBan(), sender);
        }
        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDonNhap(), sender);

        }
        private void btn_Giay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SanPham(), sender);
        }

        private void btn_PhanLoaiGiay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoaiGiay(), sender);
        }

        private void btn_NPP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhaPhanPhoi(), sender);
        }
        private void btn_ThongKeSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeSP(), sender);

        }

        private void btn_ThongKeBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeSPBan(), sender);
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Kho(), sender);
        }
    }
}
