﻿namespace QLCHBanGiay
{
    partial class NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.toolStripqlnv = new System.Windows.Forms.ToolStrip();
            this.tsLuu = new System.Windows.Forms.ToolStripButton();
            this.tsLamMoi = new System.Windows.Forms.ToolStripButton();
            this.tsThem = new System.Windows.Forms.ToolStripButton();
            this.tsSua = new System.Windows.Forms.ToolStripButton();
            this.tsXoa = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbQuanLyNhanVien = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.mskDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.mskNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.chkGioiTinh = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.lbtimkem = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.toolStripqlnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripqlnv
            // 
            this.toolStripqlnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStripqlnv.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripqlnv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLuu,
            this.tsLamMoi,
            this.tsThem,
            this.tsSua,
            this.tsXoa});
            this.toolStripqlnv.Location = new System.Drawing.Point(0, 0);
            this.toolStripqlnv.Name = "toolStripqlnv";
            this.toolStripqlnv.Size = new System.Drawing.Size(1378, 27);
            this.toolStripqlnv.TabIndex = 0;
            this.toolStripqlnv.Text = "toolStrip1";
            // 
            // tsLuu
            // 
            this.tsLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLuu.Image = ((System.Drawing.Image)(resources.GetObject("tsLuu.Image")));
            this.tsLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLuu.Name = "tsLuu";
            this.tsLuu.Size = new System.Drawing.Size(61, 24);
            this.tsLuu.Text = "Lưu";
            this.tsLuu.Click += new System.EventHandler(this.tsLuu_Click);
            // 
            // tsLamMoi
            // 
            this.tsLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("tsLamMoi.Image")));
            this.tsLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLamMoi.Name = "tsLamMoi";
            this.tsLamMoi.Size = new System.Drawing.Size(98, 24);
            this.tsLamMoi.Text = "Làm mới";
            this.tsLamMoi.Click += new System.EventHandler(this.tsLamMoi_Click);
            // 
            // tsThem
            // 
            this.tsThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsThem.Image = ((System.Drawing.Image)(resources.GetObject("tsThem.Image")));
            this.tsThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsThem.Name = "tsThem";
            this.tsThem.Size = new System.Drawing.Size(75, 24);
            this.tsThem.Text = "Thêm";
            this.tsThem.Click += new System.EventHandler(this.tsThem_Click);
            // 
            // tsSua
            // 
            this.tsSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSua.Image = ((System.Drawing.Image)(resources.GetObject("tsSua.Image")));
            this.tsSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSua.Name = "tsSua";
            this.tsSua.Size = new System.Drawing.Size(62, 24);
            this.tsSua.Text = "Sửa";
            this.tsSua.Click += new System.EventHandler(this.tsSua_Click);
            // 
            // tsXoa
            // 
            this.tsXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsXoa.Image = ((System.Drawing.Image)(resources.GetObject("tsXoa.Image")));
            this.tsXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsXoa.Name = "tsXoa";
            this.tsXoa.Size = new System.Drawing.Size(62, 24);
            this.tsXoa.Text = "Xóa";
            this.tsXoa.Click += new System.EventHandler(this.tsXoa_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel1.Controls.Add(this.lbQuanLyNhanVien);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.guna2GroupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.toolStripqlnv);
            this.splitContainer1.Size = new System.Drawing.Size(1378, 815);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // lbQuanLyNhanVien
            // 
            this.lbQuanLyNhanVien.AutoSize = true;
            this.lbQuanLyNhanVien.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLyNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lbQuanLyNhanVien.Location = new System.Drawing.Point(333, 35);
            this.lbQuanLyNhanVien.Name = "lbQuanLyNhanVien";
            this.lbQuanLyNhanVien.Size = new System.Drawing.Size(590, 70);
            this.lbQuanLyNhanVien.TabIndex = 3;
            this.lbQuanLyNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Controls.Add(this.mskDienThoai);
            this.guna2GroupBox1.Controls.Add(this.mskNgaySinh);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.chkGioiTinh);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.txtEmail);
            this.guna2GroupBox1.Controls.Add(this.txtMaNhanVien);
            this.guna2GroupBox1.Controls.Add(this.dgvNhanVien);
            this.guna2GroupBox1.Controls.Add(this.lbtimkem);
            this.guna2GroupBox1.Controls.Add(this.txtDiaChi);
            this.guna2GroupBox1.Controls.Add(this.txtTenNhanVien);
            this.guna2GroupBox1.Controls.Add(this.lbDiaChi);
            this.guna2GroupBox1.Controls.Add(this.lbDienThoai);
            this.guna2GroupBox1.Controls.Add(this.lbGioiTinh);
            this.guna2GroupBox1.Controls.Add(this.lbTenNhanVien);
            this.guna2GroupBox1.Controls.Add(this.lbMaNhanVien);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 31);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1360, 632);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Thông Tin";
            // 
            // mskDienThoai
            // 
            this.mskDienThoai.BackColor = System.Drawing.SystemColors.Window;
            this.mskDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDienThoai.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDienThoai.Location = new System.Drawing.Point(868, 101);
            this.mskDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskDienThoai.Mask = "(999) 000-0000";
            this.mskDienThoai.Name = "mskDienThoai";
            this.mskDienThoai.Size = new System.Drawing.Size(200, 34);
            this.mskDienThoai.TabIndex = 38;
            // 
            // mskNgaySinh
            // 
            this.mskNgaySinh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNgaySinh.Location = new System.Drawing.Point(868, 158);
            this.mskNgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskNgaySinh.Name = "mskNgaySinh";
            this.mskNgaySinh.Size = new System.Drawing.Size(325, 34);
            this.mskNgaySinh.TabIndex = 37;
            this.mskNgaySinh.Value = new System.DateTime(2024, 5, 24, 20, 26, 3, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(726, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ngày sinh:";
            // 
            // chkGioiTinh
            // 
            this.chkGioiTinh.AutoSize = true;
            this.chkGioiTinh.Location = new System.Drawing.Point(229, 118);
            this.chkGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkGioiTinh.Name = "chkGioiTinh";
            this.chkGioiTinh.Size = new System.Drawing.Size(18, 17);
            this.chkGioiTinh.TabIndex = 35;
            this.chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(254, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nam";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(229, 212);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(325, 27);
            this.txtEmail.TabIndex = 32;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(229, 65);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(325, 27);
            this.txtMaNhanVien.TabIndex = 31;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(95, 246);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1175, 181);
            this.dgvNhanVien.TabIndex = 30;
            this.dgvNhanVien.Click += new System.EventHandler(this.dgvNhanVien_Click);
            // 
            // lbtimkem
            // 
            this.lbtimkem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtimkem.AutoSize = true;
            this.lbtimkem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbtimkem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtimkem.ForeColor = System.Drawing.Color.Black;
            this.lbtimkem.Location = new System.Drawing.Point(91, 212);
            this.lbtimkem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtimkem.Name = "lbtimkem";
            this.lbtimkem.Size = new System.Drawing.Size(60, 25);
            this.lbtimkem.TabIndex = 27;
            this.lbtimkem.Text = "Email";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Location = new System.Drawing.Point(229, 158);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(325, 27);
            this.txtDiaChi.TabIndex = 24;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(868, 59);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(325, 27);
            this.txtTenNhanVien.TabIndex = 18;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lbDiaChi.Location = new System.Drawing.Point(91, 164);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(71, 25);
            this.lbDiaChi.TabIndex = 23;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDienThoai.ForeColor = System.Drawing.Color.Black;
            this.lbDienThoai.Location = new System.Drawing.Point(725, 115);
            this.lbDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(99, 25);
            this.lbDienThoai.TabIndex = 21;
            this.lbDienThoai.Text = "Điện thoại";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lbGioiTinh.Location = new System.Drawing.Point(91, 114);
            this.lbGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(82, 25);
            this.lbGioiTinh.TabIndex = 19;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lbTenNhanVien.Location = new System.Drawing.Point(725, 66);
            this.lbTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(137, 25);
            this.lbTenNhanVien.TabIndex = 17;
            this.lbTenNhanVien.Text = "Tên nhân viên";
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lbMaNhanVien.Location = new System.Drawing.Point(91, 65);
            this.lbMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(130, 25);
            this.lbMaNhanVien.TabIndex = 16;
            this.lbMaNhanVien.Text = "Mã nhân viên";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 815);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.toolStripqlnv.ResumeLayout(false);
            this.toolStripqlnv.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripqlnv;
        private System.Windows.Forms.ToolStripButton tsLamMoi;
        private System.Windows.Forms.ToolStripButton tsThem;
        private System.Windows.Forms.ToolStripButton tsSua;
        private System.Windows.Forms.ToolStripButton tsXoa;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbQuanLyNhanVien;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label lbtimkem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ToolStripButton tsLuu;
        private System.Windows.Forms.CheckBox chkGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker mskNgaySinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskDienThoai;
    }
}