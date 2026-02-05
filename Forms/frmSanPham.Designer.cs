namespace QuanLyBanHang.Forms
{
    partial class frmSanPham
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            picHinhAnh = new PictureBox();
            btnDoiAnh = new Button();
            txtMoTa = new TextBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            cboLoaiSanPham = new ComboBox();
            cboHangSanXuat = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnTimKiem = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            txtTenSanPham = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnThoat = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            TenLoai = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            btnXoayAnh = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoayAnh);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 14);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1587, 324);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong Tin Sản Phẩm";
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(968, 16);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(195, 237);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 26;
            picHinhAnh.TabStop = false;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(1184, 38);
            btnDoiAnh.Margin = new Padding(4, 5, 4, 5);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(107, 38);
            btnDoiAnh.TabIndex = 25;
            btnDoiAnh.Text = "Đổi ảnh… ";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(206, 222);
            txtMoTa.Margin = new Padding(4, 5, 4, 5);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(492, 31);
            txtMoTa.TabIndex = 24;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(518, 99);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(180, 31);
            numDonGia.TabIndex = 23;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(518, 42);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(180, 31);
            numSoLuong.TabIndex = 22;
            numSoLuong.ThousandsSeparator = true;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Items.AddRange(new object[] { "Pha Chế", "Quản Lý" });
            cboLoaiSanPham.Location = new Point(203, 37);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(182, 33);
            cboLoaiSanPham.TabIndex = 21;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Items.AddRange(new object[] { "Pha Chế", "Quản Lý" });
            cboHangSanXuat.Location = new Point(203, 93);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(182, 33);
            cboHangSanXuat.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 222);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(146, 25);
            label6.TabIndex = 16;
            label6.Text = "Mô tả sản phẩm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(422, 101);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 15;
            label5.Text = "Đơn giá:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 45);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 14;
            label4.Text = "Số lượng:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1085, 270);
            btnTimKiem.Margin = new Padding(4, 5, 4, 5);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(107, 38);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1252, 270);
            btnNhap.Margin = new Padding(4, 5, 4, 5);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(107, 38);
            btnNhap.TabIndex = 12;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1434, 273);
            btnXuat.Margin = new Padding(4, 5, 4, 5);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(107, 38);
            btnXuat.TabIndex = 11;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(203, 155);
            txtTenSanPham.Margin = new Padding(4, 5, 4, 5);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(495, 31);
            txtTenSanPham.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 160);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 8;
            label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 7;
            label2.Text = "Hãng sản xuất:";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(889, 273);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 38);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Lime;
            btnLuu.Location = new Point(551, 273);
            btnLuu.Margin = new Padding(4, 5, 4, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(107, 38);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.ForeColor = Color.FromArgb(192, 64, 0);
            btnHuyBo.Location = new Point(726, 273);
            btnHuyBo.Margin = new Padding(4, 5, 4, 5);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(107, 38);
            btnHuyBo.TabIndex = 5;
            btnHuyBo.Text = "Huy Bo";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(379, 273);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 38);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(222, 273);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(107, 38);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(41, 273);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(107, 38);
            btnThem.TabIndex = 2;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 1;
            label1.Text = "Phân Loại(*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 429);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1613, 425);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Sản Phẩm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { TenLoai, TenHangSanXuat, TenSanPham, SoLuong, DonGia, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(4, 29);
            dataGridView.Margin = new Padding(4, 5, 4, 5);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(1605, 391);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Phân loại ";
            TenLoai.MinimumWidth = 8;
            TenLoai.Name = "TenLoai";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "Hãng sản xuất";
            TenHangSanXuat.MinimumWidth = 8;
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm ";
            TenSanPham.MinimumWidth = 8;
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            SoLuong.DefaultCellStyle = dataGridViewCellStyle3;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            DonGia.DefaultCellStyle = dataGridViewCellStyle4;
            DonGia.HeaderText = "Đơn giá ";
            DonGia.MinimumWidth = 8;
            DonGia.Name = "DonGia";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình Ảnh";
            HinhAnh.MinimumWidth = 8;
            HinhAnh.Name = "HinhAnh";
            // 
            // btnXoayAnh
            // 
            btnXoayAnh.Location = new Point(1197, 102);
            btnXoayAnh.Name = "btnXoayAnh";
            btnXoayAnh.Size = new Size(162, 34);
            btnXoayAnh.TabIndex = 27;
            btnXoayAnh.Text = "Xoay hình ảnh ";
            btnXoayAnh.UseVisualStyleBackColor = true;
            btnXoayAnh.Click += button1_Click;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1613, 854);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm ";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnTimKiem;
        private Button btnNhap;
        private Button btnXuat;
        private TextBox txtTenSanPham;
        private Label label3;
        private Label label2;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private ComboBox cboLoaiSanPham;
        private ComboBox cboHangSanXuat;
        private TextBox txtMoTa;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private PictureBox picHinhAnh;
        private Button btnDoiAnh;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
        private Button btnXoayAnh;
    }
}