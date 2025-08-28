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
    public partial class ThongKeSPBan : Form
    {
        DataTable ThongKeBan;
        public ThongKeSPBan()
        {
            InitializeComponent();
        }
        private void LoadDataGridView()
        {
            string sql = @"SELECT HoaDon.MaHoaDon, NhanVien.TenNhanVien, KhachHang.TenKhachHang, SanPham.TenSanPham, HoaDon.NgayHoaDon, 
                          ChiTietHoaDon.SoLuong, SanPham.DonGiaBan, ChiTietHoaDon.ThanhTien
                           FROM ChiTietHoaDon
                           INNER JOIN SanPham ON ChiTietHoaDon.MaSanPham = SanPham.MaSanPham
                           INNER JOIN HoaDon ON ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon
                           INNER JOIN NhanVien ON HoaDon.MaNhanVien = NhanVien.MaNhanVien
                           INNER JOIN KhachHang ON HoaDon.MaKhachHang = KhachHang.MaKhachHang";
            ThongKeBan = Functions.GetDataToTable(sql);
            dgvThongKeBan.DataSource = ThongKeBan;
            dgvThongKeBan.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvThongKeBan.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvThongKeBan.Columns[2].HeaderText = "Tên Khách Hàng";
            dgvThongKeBan.Columns[3].HeaderText = "Tên Sản Phẩm";
            dgvThongKeBan.Columns[4].HeaderText = "Ngày Nhập";
            dgvThongKeBan.Columns[5].HeaderText = "Số Lượng";
            dgvThongKeBan.Columns[6].HeaderText = "Đơn Giá";
            dgvThongKeBan.Columns[7].HeaderText = "Thành Tiền";
            dgvThongKeBan.Columns[0].Width = 200;
            dgvThongKeBan.Columns[1].Width = 200;
            dgvThongKeBan.Columns[2].Width = 200;
            dgvThongKeBan.Columns[3].Width = 200;
            dgvThongKeBan.Columns[4].Width = 200;
            dgvThongKeBan.Columns[5].Width = 200;
            dgvThongKeBan.Columns[6].Width = 200;
            dgvThongKeBan.Columns[7].Width = 200;
            dgvThongKeBan.AllowUserToAddRows = false;
            dgvThongKeBan.EditMode = DataGridViewEditMode.EditProgrammatically;
            string tongTien = Functions.GetFieldValues("SELECT SUM(ChiTietHoaDon.ThanhTien) FROM ChiTietHoaDon").ToString();        }
        private void LoadDataGridViewChild()
        {
            dgvThongKeBan.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvThongKeBan.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvThongKeBan.Columns[2].HeaderText = "Tên Khách Hàng";
            dgvThongKeBan.Columns[3].HeaderText = "Tên Sản Phẩm";
            dgvThongKeBan.Columns[4].HeaderText = "Ngày Nhập";
            dgvThongKeBan.Columns[5].HeaderText = "Số Lượng";
            dgvThongKeBan.Columns[6].HeaderText = "Đơn Giá";
            dgvThongKeBan.Columns[7].HeaderText = "Thành Tiền";
            dgvThongKeBan.Columns[0].Width = 200;
            dgvThongKeBan.Columns[1].Width = 200;
            dgvThongKeBan.Columns[2].Width = 200;
            dgvThongKeBan.Columns[3].Width = 200;
            dgvThongKeBan.Columns[4].Width = 200;
            dgvThongKeBan.Columns[5].Width = 200;
            dgvThongKeBan.Columns[6].Width = 200;
            dgvThongKeBan.Columns[7].Width = 200;
            dgvThongKeBan.AllowUserToAddRows = false;
            dgvThongKeBan.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ThongKeSPBan_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
