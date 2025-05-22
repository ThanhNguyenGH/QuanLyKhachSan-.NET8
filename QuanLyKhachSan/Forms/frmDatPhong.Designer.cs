namespace QuanLyKhachSan.Forms
{
    partial class frmDatPhong
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvDatPhong = new DataGridView();
            lblMaKhachHang = new Label();
            lblMaPhong = new Label();
            lblNgayDat = new Label();
            lblNgayNhanPhong = new Label();
            lblTrangThai = new Label();
            cbMaKhachHang = new ComboBox();
            cbMaPhong = new ComboBox();
            dtpNgayDat = new DateTimePicker();
            dtpNgayNhanPhong = new DateTimePicker();
            cbTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblThongBao = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatPhong).BeginInit();
            SuspendLayout();
            // 
            // dgvDatPhong
            // 
            dgvDatPhong.AllowUserToAddRows = false;
            dgvDatPhong.AllowUserToDeleteRows = false;
            dgvDatPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatPhong.Location = new Point(35, 254);
            dgvDatPhong.Margin = new Padding(4, 3, 4, 3);
            dgvDatPhong.Name = "dgvDatPhong";
            dgvDatPhong.ReadOnly = true;
            dgvDatPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatPhong.Size = new Size(863, 231);
            dgvDatPhong.TabIndex = 0;
            dgvDatPhong.SelectionChanged += dgvDatPhong_SelectionChanged;
            // 
            // lblMaKhachHang
            // 
            lblMaKhachHang.AutoSize = true;
            lblMaKhachHang.Location = new Point(35, 35);
            lblMaKhachHang.Margin = new Padding(4, 0, 4, 0);
            lblMaKhachHang.Name = "lblMaKhachHang";
            lblMaKhachHang.Size = new Size(73, 15);
            lblMaKhachHang.TabIndex = 1;
            lblMaKhachHang.Text = "Khách hàng:";
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Location = new Point(35, 69);
            lblMaPhong.Margin = new Padding(4, 0, 4, 0);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(45, 15);
            lblMaPhong.TabIndex = 2;
            lblMaPhong.Text = "Phòng:";
            // 
            // lblNgayDat
            // 
            lblNgayDat.AutoSize = true;
            lblNgayDat.Location = new Point(35, 104);
            lblNgayDat.Margin = new Padding(4, 0, 4, 0);
            lblNgayDat.Name = "lblNgayDat";
            lblNgayDat.Size = new Size(58, 15);
            lblNgayDat.TabIndex = 3;
            lblNgayDat.Text = "Ngày đặt:";
            // 
            // lblNgayNhanPhong
            // 
            lblNgayNhanPhong.AutoSize = true;
            lblNgayNhanPhong.Location = new Point(35, 138);
            lblNgayNhanPhong.Margin = new Padding(4, 0, 4, 0);
            lblNgayNhanPhong.Name = "lblNgayNhanPhong";
            lblNgayNhanPhong.Size = new Size(106, 15);
            lblNgayNhanPhong.TabIndex = 4;
            lblNgayNhanPhong.Text = "Ngày nhận phòng:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(35, 177);
            lblTrangThai.Margin = new Padding(4, 0, 4, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(63, 15);
            lblTrangThai.TabIndex = 6;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cbMaKhachHang
            // 
            cbMaKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaKhachHang.FormattingEnabled = true;
            cbMaKhachHang.Location = new Point(140, 31);
            cbMaKhachHang.Margin = new Padding(4, 3, 4, 3);
            cbMaKhachHang.Name = "cbMaKhachHang";
            cbMaKhachHang.Size = new Size(233, 23);
            cbMaKhachHang.TabIndex = 7;
            // 
            // cbMaPhong
            // 
            cbMaPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaPhong.FormattingEnabled = true;
            cbMaPhong.Location = new Point(140, 66);
            cbMaPhong.Margin = new Padding(4, 3, 4, 3);
            cbMaPhong.Name = "cbMaPhong";
            cbMaPhong.Size = new Size(233, 23);
            cbMaPhong.TabIndex = 8;
            // 
            // dtpNgayDat
            // 
            dtpNgayDat.Location = new Point(140, 100);
            dtpNgayDat.Margin = new Padding(4, 3, 4, 3);
            dtpNgayDat.Name = "dtpNgayDat";
            dtpNgayDat.Size = new Size(233, 23);
            dtpNgayDat.TabIndex = 9;
            // 
            // dtpNgayNhanPhong
            // 
            dtpNgayNhanPhong.Location = new Point(140, 135);
            dtpNgayNhanPhong.Margin = new Padding(4, 3, 4, 3);
            dtpNgayNhanPhong.Name = "dtpNgayNhanPhong";
            dtpNgayNhanPhong.Size = new Size(233, 23);
            dtpNgayNhanPhong.TabIndex = 10;
            // 
            // cbTrangThai
            // 
            cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(140, 173);
            cbTrangThai.Margin = new Padding(4, 3, 4, 3);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(233, 23);
            cbTrangThai.TabIndex = 12;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(408, 35);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(93, 35);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(408, 81);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(93, 35);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(408, 127);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(93, 35);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(408, 173);
            btnLamMoi.Margin = new Padding(4, 3, 4, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(93, 35);
            btnLamMoi.TabIndex = 16;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.ForeColor = Color.Red;
            lblThongBao.Location = new Point(35, 231);
            lblThongBao.Margin = new Padding(4, 0, 4, 0);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 15);
            lblThongBao.TabIndex = 17;
            // 
            // frmDatPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(lblThongBao);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cbTrangThai);
            Controls.Add(dtpNgayNhanPhong);
            Controls.Add(dtpNgayDat);
            Controls.Add(cbMaPhong);
            Controls.Add(cbMaKhachHang);
            Controls.Add(lblTrangThai);
            Controls.Add(lblNgayNhanPhong);
            Controls.Add(lblNgayDat);
            Controls.Add(lblMaPhong);
            Controls.Add(lblMaKhachHang);
            Controls.Add(dgvDatPhong);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmDatPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Đặt Phòng";
            FormClosing += frmDatPhong_FormClosing;
            Load += frmDatPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatPhong;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.Label lblNgayNhanPhong;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cbMaKhachHang;
        private System.Windows.Forms.ComboBox cbMaPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.DateTimePicker dtpNgayNhanPhong;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblThongBao;
    }
}