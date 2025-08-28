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
    public partial class ThongKeSP : Form
    {
      DataTable ThongKeSanPham;
        public ThongKeSP()
        {
            InitializeComponent();
        }

        private void ThongKeSP_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
            private void LoadDataGridView()
     {
         string sql = @"SELECT PhieuNhap.MaPhieuNhap, NhanVien.TenNhanVien, NhaPhanPhoi.TenNhaPhanPhoi, SanPham.TenSanPham, PhieuNhap.NgayNhap, 
                       ChiTietPhieuNhap.SoLuong, SanPham.DonGiaNhap, ChiTietPhieuNhap.ThanhTien
                        FROM ChiTietPhieuNhap
                        INNER JOIN SanPham ON ChiTietPhieuNhap.MaSanPham = SanPham.MaSanPham
                        INNER JOIN PhieuNhap ON ChiTietPhieuNhap.MaPhieuNhap = PhieuNhap.MaPhieuNhap
                        INNER JOIN NhanVien ON PhieuNhap.MaNhanVien = NhanVien.MaNhanVien
                        INNER JOIN NhaPhanPhoi ON PhieuNhap.MaNPP = NhaPhanPhoi.MaNPP";
         ThongKeSanPham = Functions.GetDataToTable(sql);
         dgvThongKeNhap.DataSource = ThongKeSanPham;
         dgvThongKeNhap.Columns[0].HeaderText = "Mã Phiếu Nhập";
         dgvThongKeNhap.Columns[1].HeaderText = "Tên Nhân Viên";
         dgvThongKeNhap.Columns[2].HeaderText = "Tên Nhà Phân Phối";
         dgvThongKeNhap.Columns[3].HeaderText = "Tên Sản Phẩm";
         dgvThongKeNhap.Columns[4].HeaderText = "Ngày Nhập";
         dgvThongKeNhap.Columns[5].HeaderText = "Số Lượng";
         dgvThongKeNhap.Columns[6].HeaderText = "Đơn Giá";
         dgvThongKeNhap.Columns[7].HeaderText = "Thành Tiền";


         dgvThongKeNhap.Columns[0].Width = 180;
         dgvThongKeNhap.Columns[1].Width = 200;
         dgvThongKeNhap.Columns[2].Width = 200;
         dgvThongKeNhap.Columns[3].Width = 150;
         dgvThongKeNhap.Columns[4].Width = 150;
         dgvThongKeNhap.Columns[5].Width = 150;
         dgvThongKeNhap.Columns[6].Width = 150;
         dgvThongKeNhap.Columns[7].Width = 150;
         dgvThongKeNhap.AllowUserToAddRows = false;
         dgvThongKeNhap.EditMode = DataGridViewEditMode.EditProgrammatically;
         string tongTien = Functions.GetFieldValues("SELECT SUM(ChiTietPhieuNhap.ThanhTien) FROM ChiTietPhieuNhap").ToString();
     }

     private void LoadDataGridViewChild()
     {
         dgvThongKeNhap.Columns[0].HeaderText = "Mã Phiếu Nhập";
         dgvThongKeNhap.Columns[1].HeaderText = "Tên Nhân Viên";
         dgvThongKeNhap.Columns[2].HeaderText = "Tên Nhà Phân Phối";
         dgvThongKeNhap.Columns[3].HeaderText = "Tên Sản Phẩm";
         dgvThongKeNhap.Columns[4].HeaderText = "Ngày Nhập";
         dgvThongKeNhap.Columns[5].HeaderText = "Số Lượng";
         dgvThongKeNhap.Columns[6].HeaderText = "Đơn Giá";
         dgvThongKeNhap.Columns[7].HeaderText = "Thành Tiền";
         dgvThongKeNhap.Columns[0].Width = 180;
         dgvThongKeNhap.Columns[1].Width = 200;
         dgvThongKeNhap.Columns[2].Width = 200;
         dgvThongKeNhap.Columns[3].Width = 150;
         dgvThongKeNhap.Columns[4].Width = 150;
         dgvThongKeNhap.Columns[5].Width = 150;
         dgvThongKeNhap.Columns[6].Width = 150;
         dgvThongKeNhap.Columns[7].Width = 150;
         dgvThongKeNhap.AllowUserToAddRows = false;
         dgvThongKeNhap.EditMode = DataGridViewEditMode.EditProgrammatically;
     }
 }
    }
