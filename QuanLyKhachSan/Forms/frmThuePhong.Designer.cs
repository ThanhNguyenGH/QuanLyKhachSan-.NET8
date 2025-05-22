namespace QuanLyKhachSan.Forms
{
    partial class frmThuePhong
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
            this.dgvThuePhong = new System.Windows.Forms.DataGridView();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblNgayNhanPhong = new System.Windows.Forms.Label();
            this.lblNgayTraPhong = new System.Windows.Forms.Label();
            this.lblTongChiPhi = new System.Windows.Forms.Label();
            this.cbMaKhachHang = new System.Windows.Forms.ComboBox();
            this.cbMaPhong = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhanPhong = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTraPhong = new System.Windows.Forms.DateTimePicker();
            this.nudTongChiPhi = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnChiTietDichVu = new System.Windows.Forms.Button();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongChiPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThuePhong
            // 
            this.dgvThuePhong.AllowUserToAddRows = false;
            this.dgvThuePhong.AllowUserToDeleteRows = false;
            this.dgvThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuePhong.Location = new System.Drawing.Point(30, 240);
            this.dgvThuePhong.Name = "dgvThuePhong";
            this.dgvThuePhong.ReadOnly = true;
            this.dgvThuePhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuePhong.Size = new System.Drawing.Size(740, 180);
            this.dgvThuePhong.TabIndex = 0;
            this.dgvThuePhong.SelectionChanged += new System.EventHandler(this.dgvThuePhong_SelectionChanged);
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Location = new System.Drawing.Point(30, 30);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(81, 13);
            this.lblMaKhachHang.TabIndex = 1;
            this.lblMaKhachHang.Text = "Khách hàng:";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(30, 60);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(52, 13);
            this.lblMaPhong.TabIndex = 2;
            this.lblMaPhong.Text = "Phòng:";
            // 
            // lblNgayNhanPhong
            // 
            this.lblNgayNhanPhong.AutoSize = true;
            this.lblNgayNhanPhong.Location = new System.Drawing.Point(30, 90);
            this.lblNgayNhanPhong.Name = "lblNgayNhanPhong";
            this.lblNgayNhanPhong.Size = new System.Drawing.Size(96, 13);
            this.lblNgayNhanPhong.TabIndex = 3;
            this.lblNgayNhanPhong.Text = "Ngày nhận phòng:";
            // 
            // lblNgayTraPhong
            // 
            this.lblNgayTraPhong.AutoSize = true;
            this.lblNgayTraPhong.Location = new System.Drawing.Point(30, 120);
            this.lblNgayTraPhong.Name = "lblNgayTraPhong";
            this.lblNgayTraPhong.Size = new System.Drawing.Size(93, 13);
            this.lblNgayTraPhong.TabIndex = 4;
            this.lblNgayTraPhong.Text = "Ngày trả phòng:";
            // 
            // lblTongChiPhi
            // 
            this.lblTongChiPhi.AutoSize = true;
            this.lblTongChiPhi.Location = new System.Drawing.Point(30, 150);
            this.lblTongChiPhi.Name = "lblTongChiPhi";
            this.lblTongChiPhi.Size = new System.Drawing.Size(81, 13);
            this.lblTongChiPhi.TabIndex = 5;
            this.lblTongChiPhi.Text = "Tổng chi phí:";
            // 
            // cbMaKhachHang
            // 
            this.cbMaKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKhachHang.FormattingEnabled = true;
            this.cbMaKhachHang.Location = new System.Drawing.Point(120, 27);
            this.cbMaKhachHang.Name = "cbMaKhachHang";
            this.cbMaKhachHang.Size = new System.Drawing.Size(200, 21);
            this.cbMaKhachHang.TabIndex = 6;
            // 
            // cbMaPhong
            // 
            this.cbMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPhong.FormattingEnabled = true;
            this.cbMaPhong.Location = new System.Drawing.Point(120, 57);
            this.cbMaPhong.Name = "cbMaPhong";
            this.cbMaPhong.Size = new System.Drawing.Size(200, 21);
            this.cbMaPhong.TabIndex = 7;
            // 
            // dtpNgayNhanPhong
            // 
            this.dtpNgayNhanPhong.Location = new System.Drawing.Point(120, 87);
            this.dtpNgayNhanPhong.Name = "dtpNgayNhanPhong";
            this.dtpNgayNhanPhong.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayNhanPhong.TabIndex = 8;
            // 
            // dtpNgayTraPhong
            // 
            this.dtpNgayTraPhong.Location = new System.Drawing.Point(120, 117);
            this.dtpNgayTraPhong.Name = "dtpNgayTraPhong";
            this.dtpNgayTraPhong.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayTraPhong.TabIndex = 9;
            // 
            // nudTongChiPhi
            // 
            this.nudTongChiPhi.DecimalPlaces = 2;
            this.nudTongChiPhi.Location = new System.Drawing.Point(120, 147);
            this.nudTongChiPhi.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.nudTongChiPhi.Name = "nudTongChiPhi";
            this.nudTongChiPhi.Size = new System.Drawing.Size(200, 20);
            this.nudTongChiPhi.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(350, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(350, 70);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(350, 110);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(350, 150);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 30);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Location = new System.Drawing.Point(450, 30);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(80, 30);
            this.btnNhanPhong.TabIndex = 15;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = true;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Location = new System.Drawing.Point(450, 70);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(80, 30);
            this.btnTraPhong.TabIndex = 16;
            this.btnTraPhong.Text = "Trả phòng";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // btnChiTietDichVu
            // 
            this.btnChiTietDichVu.Location = new System.Drawing.Point(450, 110);
            this.btnChiTietDichVu.Name = "btnChiTietDichVu";
            this.btnChiTietDichVu.Size = new System.Drawing.Size(80, 30);
            this.btnChiTietDichVu.TabIndex = 17;
            this.btnChiTietDichVu.Text = "Chi tiết DV";
            this.btnChiTietDichVu.UseVisualStyleBackColor = true;
            this.btnChiTietDichVu.Click += new System.EventHandler(this.btnChiTietDichVu_Click);
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Location = new System.Drawing.Point(450, 150);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(80, 30);
            this.btnLapHoaDon.TabIndex = 18;
            this.btnLapHoaDon.Text = "Lập hóa đơn";
            this.btnLapHoaDon.UseVisualStyleBackColor = true;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(30, 180);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 13);
            this.lblThongBao.TabIndex = 19;
            // 
            // frmThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnLapHoaDon);
            this.Controls.Add(this.btnChiTietDichVu);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnNhanPhong);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.nudTongChiPhi);
            this.Controls.Add(this.dtpNgayTraPhong);
            this.Controls.Add(this.dtpNgayNhanPhong);
            this.Controls.Add(this.cbMaPhong);
            this.Controls.Add(this.cbMaKhachHang);
            this.Controls.Add(this.lblTongChiPhi);
            this.Controls.Add(this.lblNgayTraPhong);
            this.Controls.Add(this.lblNgayNhanPhong);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.lblMaKhachHang);
            this.Controls.Add(this.dgvThuePhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmThuePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thuê Phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThuePhong_FormClosing);
            this.Load += new System.EventHandler(this.frmThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongChiPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThuePhong;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblNgayNhanPhong;
        private System.Windows.Forms.Label lblNgayTraPhong;
        private System.Windows.Forms.Label lblTongChiPhi;
        private System.Windows.Forms.ComboBox cbMaKhachHang;
        private System.Windows.Forms.ComboBox cbMaPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayNhanPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayTraPhong;
        private System.Windows.Forms.NumericUpDown nudTongChiPhi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnChiTietDichVu;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Label lblThongBao;
    }
}