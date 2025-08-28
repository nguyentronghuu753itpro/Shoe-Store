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
    public partial class SanPham : Form
    {
        DataTable SP;
        public SanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            string sql, slq;
            sql = "SELECT * from DanhMucSP";
            slq = "SELECT * FROM NhaPhanPhoi";
            txtMaSanPham.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
            Functions.FillCombo(sql, cboTenDanhMuc, "MaDanhMuc", "TenDanhMuc");
            cboTenDanhMuc.SelectedIndex = -1;
            Functions.FillCombo(slq, cboTenNPP, "MaNPP", "TenNhaPhanPhoi");
            cboTenNPP.SelectedIndex = -1;
            ResetValues();
        }
        private void ResetValues()
        {
            txtMaSanPham.Text = "";
            txtTenSP.Text = "";
            cboTenDanhMuc.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
            txtGhiChu.Text = "";
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT SanPham.MaSanPham, SanPham.TenSanPham,DanhMucSP.TenDanhMuc,NhaPhanPhoi.TenNhaPhanPhoi,SanPham.DonGiaNhap, SanPham.DonGiaBan, SanPham.SoLuong, SanPham.GhiChu  FROM SanPham, DanhMucSP,NhaPhanPhoi   WHERE SanPham.MaDanhMuc = DanhMucSP.MaDanhMuc AND SanPham.MaNPP=NhaPhanPhoi.MaNPP";
            SP = Functions.GetDataToTable(sql);
            dgvSanPham.DataSource = SP;
            dgvSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns[2].HeaderText = "Danh mục";
            dgvSanPham.Columns[3].HeaderText = "Nhà Phân Phối";
            dgvSanPham.Columns[4].HeaderText = "Đơn giá nhập";
            dgvSanPham.Columns[5].HeaderText = "Đơn giá bán";
            dgvSanPham.Columns[6].HeaderText = "Số lượng";
            dgvSanPham.Columns[7].HeaderText = "Ghi Chú";
            dgvSanPham.Columns[0].Width = 130;
            dgvSanPham.Columns[1].Width = 140;
            dgvSanPham.Columns[2].Width = 160;
            dgvSanPham.Columns[3].Width = 150;
            dgvSanPham.Columns[4].Width = 120;
            dgvSanPham.Columns[5].Width = 120;
            dgvSanPham.Columns[6].Width = 120;
            dgvSanPham.Columns[6].Width = 120;
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvSanPham_Click(object sender, EventArgs e)
        {
            string maDanhMuc, maNPP;
            string sql;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSanPham.Focus();
                return;
            }

            if (SP.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMaSanPham.Text = dgvSanPham.CurrentRow.Cells["MaSanPham"].Value.ToString();

            txtTenSP.Text = dgvSanPham.CurrentRow.Cells["TenSanPham"].Value.ToString();


            cboTenDanhMuc.Text = dgvSanPham.CurrentRow.Cells["TenDanhMuc"].Value.ToString();
         

            cboTenNPP.Text = dgvSanPham.CurrentRow.Cells["TenNhaPhanPhoi"].Value.ToString();
          

            txtSoLuong.Text = dgvSanPham.CurrentRow.Cells["SoLuong"].Value.ToString();

            txtDonGiaNhap.Text = dgvSanPham.CurrentRow.Cells["DonGiaNhap"].Value.ToString();

            txtDonGiaBan.Text = dgvSanPham.CurrentRow.Cells["DonGiaBan"].Value.ToString();

            sql = "SELECT GhiChu FROM SanPham WHERE MaSanPham = N'" + txtMaSanPham.Text + "'";
            txtGhiChu.Text = Functions.GetFieldValues(sql);

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            ResetValues();
            txtMaSanPham.Enabled = true;
            txtMaSanPham.Focus();
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaSanPham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSanPham.Focus();
                return;
            }

            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSP.Focus();
                return;
            }

            if (cboTenDanhMuc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboTenDanhMuc.Focus();
                return;
            }

            if (cboTenNPP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhà phân phối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboTenNPP.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }

            sql = "SELECT MaSanPham FROM SanPham WHERE MaSanPham=N'" + txtMaSanPham.Text.Trim() + "'";

            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã tồn tại, bạn phải chọn mã sản phẩm khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSanPham.Focus();
                return;
            }

            sql = "INSERT INTO SanPham(MaSanPham, TenSanPham, MaDanhMuc, MaNPP, SoLuong, DonGiaNhap, DonGiaBan, GhiChu) VALUES(N'"
                + txtMaSanPham.Text.Trim() + "', N'" + txtTenSP.Text.Trim() +
                "', N'" + cboTenDanhMuc.SelectedValue.ToString() +
                "', N'" + cboTenNPP.SelectedValue.ToString() +
                "', " + txtSoLuong.Text.Trim() + ", " + txtDonGiaNhap.Text +
                ", " + txtDonGiaBan.Text + ",  N'" + txtGhiChu.Text.Trim() + "')";

            Functions.RunSQL(sql);
            LoadDataGridView();
            //ResetValues();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaSanPham.Enabled = false;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (SP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSanPham.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboTenNPP.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboTenDanhMuc.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sql = "UPDATE SanPham SET  TenSanPham=N'" + txtTenSP.Text.Trim().ToString() +
                    "',MaSanPham=N'" + txtMaSanPham.Text.Trim().ToString() +
                    "',DonGiaNhap=N'" + txtDonGiaNhap.Text.Trim().ToString() +
                    "',DonGiaBan=N'" + txtDonGiaBan.Text.Trim().ToString() +
                    "',SoLuong=N'" + txtSoLuong.Text.Trim().ToString() +
                    "',MaDanhMuc=N'" + cboTenDanhMuc.SelectedValue.ToString() +
                    "',GhiChu=N'" + txtGhiChu.Text.Trim().ToString() +
                    "',MaNPP='" + cboTenNPP.SelectedValue.ToString() + "' WHERE MaSanPham=N'" + txtMaSanPham.Text + "'";

            ChucNang.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();

            btnBoQua.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaSanPham.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (SP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMaSanPham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE SanPham WHERE MaSanPham=N'" + txtMaSanPham.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Chỉ cho phép các ký tự số và ký tự điều khiển(backspace, delete, etc.)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Ngăn không cho ký tự không phải là số được nhập vào
                }
            }
        }
    }
}
