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
    public partial class Kho : Form
    {
        DataTable kho;
        public Kho()
        {
            InitializeComponent();
        }
        private void Kho_Load(object sender, EventArgs e)
        {
            txtMaKho.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM Kho";
            kho = ChucNang.Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dvgKho.DataSource = kho; //Nguồn dữ dgv
            dvgKho.Columns[0].HeaderText = "Mã Kho";
            dvgKho.Columns[1].HeaderText = "Tên kho";
            dvgKho.Columns[2].HeaderText = "Địa Chỉ Kho";
            dvgKho.Columns[0].Width = 100;
            dvgKho.Columns[1].Width = 250;
            dvgKho.Columns[2].Width = 500;
            dvgKho.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dvgKho.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void dvgKho_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKho.Focus();
                return;
            }
            if (kho.Rows.Count == 0)
            {
                MessageBox.Show("Không có thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKho.Text = dvgKho.CurrentRow.Cells["MaKho"].Value.ToString();
            txtTenKho.Text = dvgKho.CurrentRow.Cells["TenKho"].Value.ToString();
            txtDiaChi.Text = dvgKho.CurrentRow.Cells["DiaChiKho"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }
        private void ResetValue()
        {
            txtMaKho.Text = "";
            txtTenKho.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaKho.Enabled = true; //nhập mới
            txtMaKho.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaKho.Text.Trim().Length == 0) //Nếu chưa nhập mã ncc
            {
                MessageBox.Show("Bạn phải nhập mã kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKho.Focus();
                return;
            }
            if (txtTenKho.Text.Trim().Length == 0) //Nếu chưa nhập tên ncc
            {
                MessageBox.Show("Bạn phải nhập tên kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKho.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }

            sql = "SELECT MaKho From Kho where MaKho=N'" + txtMaKho.Text.Trim() + "'";
            if (ChucNang.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã kho này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKho.Focus();
                return;
            }

            sql = "INSERT INTO Kho VALUES(N'" +
                txtMaKho.Text + "',N'" + txtTenKho.Text + "', N'" + txtDiaChi.Text + "')";
            ChucNang.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaKho.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (kho.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKho.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenKho.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sql = "UPDATE Kho SET  TenKho=N'" + txtTenKho.Text.Trim().ToString() +
                    "',DiaChiKho=N'" + txtDiaChi.Text.Trim().ToString() +
                    "' WHERE MaKho=N'" + txtMaKho.Text + "'";

            ChucNang.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnBoQua.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaKho.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (kho.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKho.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Kho WHERE MaKho=N'" + txtMaKho.Text + "'";
                ChucNang.Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
