namespace doan
{
    partial class frmHoaDonBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboMaHDBan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.cboMaKhach = new System.Windows.Forms.ComboBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.txtNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtMaHDBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvHDBanHang = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblBangChu = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.cboMaHDBan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 599);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 37);
            this.panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(392, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(151, 29);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cboMaHDBan
            // 
            this.cboMaHDBan.FormattingEnabled = true;
            this.cboMaHDBan.Location = new System.Drawing.Point(107, 6);
            this.cboMaHDBan.Name = "cboMaHDBan";
            this.cboMaHDBan.Size = new System.Drawing.Size(279, 28);
            this.cboMaHDBan.TabIndex = 1;
            this.cboMaHDBan.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(908, 599);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenKhach);
            this.groupBox1.Controls.Add(this.cboMaKhach);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.cboMaNhanVien);
            this.groupBox1.Controls.Add(this.txtNgayBan);
            this.groupBox1.Controls.Add(this.txtMaHDBan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(644, 128);
            this.txtDienThoai.Mask = "(999) 000-0000";
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.ReadOnly = true;
            this.txtDienThoai.Size = new System.Drawing.Size(228, 27);
            this.txtDienThoai.TabIndex = 15;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(644, 96);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(228, 27);
            this.txtDiaChi.TabIndex = 14;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(644, 64);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.ReadOnly = true;
            this.txtTenKhach.Size = new System.Drawing.Size(228, 27);
            this.txtTenKhach.TabIndex = 13;
            // 
            // cboMaKhach
            // 
            this.cboMaKhach.FormattingEnabled = true;
            this.cboMaKhach.Location = new System.Drawing.Point(644, 31);
            this.cboMaKhach.Name = "cboMaKhach";
            this.cboMaKhach.Size = new System.Drawing.Size(228, 28);
            this.cboMaKhach.TabIndex = 12;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(145, 128);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(228, 27);
            this.txtTenNhanVien.TabIndex = 11;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(145, 96);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(228, 28);
            this.cboMaNhanVien.TabIndex = 10;
            // 
            // txtNgayBan
            // 
            this.txtNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayBan.Location = new System.Drawing.Point(145, 64);
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.Size = new System.Drawing.Size(228, 27);
            this.txtNgayBan.TabIndex = 9;
            // 
            // txtMaHDBan
            // 
            this.txtMaHDBan.Location = new System.Drawing.Point(145, 32);
            this.txtMaHDBan.Name = "txtMaHDBan";
            this.txtMaHDBan.ReadOnly = true;
            this.txtMaHDBan.Size = new System.Drawing.Size(228, 27);
            this.txtMaHDBan.TabIndex = 8;
            this.txtMaHDBan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(508, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tên khách hàng";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(508, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Mã khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày bán";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa đơn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(313, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 375);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvHDBanHang);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(896, 224);
            this.panel4.TabIndex = 2;
            // 
            // dgvHDBanHang
            // 
            this.dgvHDBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDBanHang.Location = new System.Drawing.Point(0, 0);
            this.dgvHDBanHang.Name = "dgvHDBanHang";
            this.dgvHDBanHang.RowHeadersWidth = 51;
            this.dgvHDBanHang.RowTemplate.Height = 29;
            this.dgvHDBanHang.Size = new System.Drawing.Size(896, 160);
            this.dgvHDBanHang.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtTongTien);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.lblBangChu);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(896, 64);
            this.panel5.TabIndex = 0;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(706, 21);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(168, 27);
            this.txtTongTien.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(613, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Tổng tiền :";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // lblBangChu
            // 
            this.lblBangChu.AutoSize = true;
            this.lblBangChu.Location = new System.Drawing.Point(7, 34);
            this.lblBangChu.Name = "lblBangChu";
            this.lblBangChu.Size = new System.Drawing.Size(78, 20);
            this.lblBangChu.TabIndex = 1;
            this.lblBangChu.Text = "Bằng chữ :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(7, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(173, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nháy đúp 1 dòng để xóa";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDong);
            this.panel3.Controls.Add(this.btnInHoaDon);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 338);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(896, 34);
            this.panel3.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(741, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(127, 29);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(561, 3);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(127, 29);
            this.btnInHoaDon.TabIndex = 3;
            this.btnInHoaDon.Text = "&In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(381, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "&Hủy hóa đơn";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(201, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(127, 29);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "&Lưu hóa đơn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(21, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 29);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm hóa đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtThanhTien);
            this.panel2.Controls.Add(this.txtDonGiaBan);
            this.panel2.Controls.Add(this.txtGiamGia);
            this.panel2.Controls.Add(this.txtTenHang);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.cboMaHang);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 91);
            this.panel2.TabIndex = 0;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(706, 47);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(168, 27);
            this.txtThanhTien.TabIndex = 38;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(706, 13);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.ReadOnly = true;
            this.txtDonGiaBan.Size = new System.Drawing.Size(168, 27);
            this.txtDonGiaBan.TabIndex = 37;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(407, 47);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(168, 27);
            this.txtGiamGia.TabIndex = 36;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(407, 10);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(168, 27);
            this.txtTenHang.TabIndex = 35;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(106, 47);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(168, 27);
            this.txtSoLuong.TabIndex = 27;
            // 
            // cboMaHang
            // 
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(106, 10);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(168, 28);
            this.cboMaHang.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(614, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Thành tiền";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(614, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "Đơn giá";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(300, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Giảm giá %";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(300, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "Tên hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Số lượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Mã hàng";
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 636);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoaDonBan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa đơn bán";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cboMaHDBan;
        private Button btnTimKiem;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtTenNhanVien;
        private ComboBox cboMaNhanVien;
        private DateTimePicker txtNgayBan;
        private TextBox txtMaHDBan;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtDiaChi;
        private TextBox txtTenKhach;
        private ComboBox cboMaKhach;
        private MaskedTextBox txtDienThoai;
        private GroupBox groupBox2;
        private Panel panel3;
        private Panel panel2;
        private TextBox txtThanhTien;
        private TextBox txtDonGiaBan;
        private TextBox txtGiamGia;
        private TextBox txtTenHang;
        private TextBox txtSoLuong;
        private ComboBox cboMaHang;
        private Label label15;
        private Label label16;
        private Label label13;
        private Label label14;
        private Label label11;
        private Label label12;
        private Panel panel4;
        private DataGridView dgvHDBanHang;
        private Panel panel5;
        private Label lblBangChu;
        private Label label17;
        private Label label18;
        private TextBox txtTongTien;
        private Button btnInHoaDon;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnThem;
        private Button btnDong;
    }
}