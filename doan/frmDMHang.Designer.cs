namespace doan
{
    partial class frmDMHang
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.ab = new System.Windows.Forms.Panel();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cboMaChatLieu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(864, 11);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(94, 29);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(156, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(392, 11);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "&Lưu ";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(510, 11);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(94, 29);
            this.btnBoQua.TabIndex = 10;
            this.btnBoQua.Text = "&Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(38, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // ab
            // 
            this.ab.Controls.Add(this.dgvHang);
            this.ab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ab.Location = new System.Drawing.Point(0, 259);
            this.ab.Name = "ab";
            this.ab.Size = new System.Drawing.Size(991, 257);
            this.ab.TabIndex = 5;
            // 
            // dgvHang
            // 
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHang.Location = new System.Drawing.Point(0, 0);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.RowHeadersWidth = 51;
            this.dgvHang.RowTemplate.Height = 29;
            this.dgvHang.Size = new System.Drawing.Size(991, 257);
            this.dgvHang.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnHienThi);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnBoQua);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 516);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 51);
            this.panel1.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(628, 11);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 29);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(746, 11);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(94, 29);
            this.btnHienThi.TabIndex = 12;
            this.btnHienThi.Text = "&Hiển thị DG";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(274, 11);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC HÀNG HÓA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hàng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ghi chú";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(123, 44);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.ReadOnly = true;
            this.txtMaHang.Size = new System.Drawing.Size(256, 27);
            this.txtMaHang.TabIndex = 7;
            this.txtMaHang.TextChanged += new System.EventHandler(this.txtMaHang_TextChanged);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(123, 80);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(256, 27);
            this.txtTenHang.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDonGiaBan);
            this.panel2.Controls.Add(this.txtDonGiaNhap);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.txtGhiChu);
            this.panel2.Controls.Add(this.cboMaChatLieu);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTenHang);
            this.panel2.Controls.Add(this.txtMaHang);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 259);
            this.panel2.TabIndex = 4;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(123, 224);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.ReadOnly = true;
            this.txtDonGiaBan.Size = new System.Drawing.Size(256, 27);
            this.txtDonGiaBan.TabIndex = 22;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(123, 188);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.ReadOnly = true;
            this.txtDonGiaNhap.Size = new System.Drawing.Size(256, 27);
            this.txtDonGiaNhap.TabIndex = 21;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(123, 152);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(256, 27);
            this.txtSoLuong.TabIndex = 20;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(510, 51);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(448, 196);
            this.txtGhiChu.TabIndex = 19;
            // 
            // cboMaChatLieu
            // 
            this.cboMaChatLieu.FormattingEnabled = true;
            this.cboMaChatLieu.Location = new System.Drawing.Point(123, 116);
            this.cboMaChatLieu.Name = "cboMaChatLieu";
            this.cboMaChatLieu.Size = new System.Drawing.Size(256, 28);
            this.cboMaChatLieu.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Đơn giá bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Đơn giá nhập";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mã chất liệu";
            // 
            // frmDMHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 567);
            this.Controls.Add(this.ab);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmDMHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh Mục Hàng Hóa";
            this.ab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDong;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnBoQua;
        private Button btnThem;
        private Panel ab;
        private Panel panel1;
        private Button btnSua;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private TextBox txtMaHang;
        private TextBox txtTenHang;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label4;
        private Button btnHienThi;
        private Button btnTimKiem;
        private ComboBox cboMaChatLieu;
        private TextBox txtGhiChu;
        private TextBox txtSoLuong;
        private TextBox txtDonGiaBan;
        private TextBox txtDonGiaNhap;
        private DataGridView dgvHang;
    }
}