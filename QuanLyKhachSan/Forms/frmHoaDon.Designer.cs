namespace QuanLyKhachSan.Forms
{
    partial class frmHoaDon
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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.lblMaNguoiDung = new System.Windows.Forms.Label();
            this.lblMaThuePhong = new System.Windows.Forms.Label();
            this.lblTongChiPhi = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.cbMaNguoiDung = new System.Windows.Forms.ComboBox();
            this.cbMaThuePhong = new System.Windows.Forms.ComboBox();
            this.nudTongChiPhi = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongChiPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(30, 220);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(740, 200);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.SelectionChanged += new System.EventHandler(this.dgvHoaDon_SelectionChanged);
            // 
            // lblMaNguoiDung
            // 
            this.lblMaNguoiDung.AutoSize = true;
            this.lblMaNguoiDung.Location = new System.Drawing.Point(30, 30);
            this.lblMaNguoiDung.Name = "lblMaNguoiDung";
            this.lblMaNguoiDung.Size = new System.Drawing.Size(83, 13);
            this.lblMaNguoiDung.TabIndex = 1;
            this.lblMaNguoiDung.Text = "Người dùng:";
            // 
            // lblMaThuePhong
            // 
            this.lblMaThuePhong.AutoSize = true;
            this.lblMaThuePhong.Location = new System.Drawing.Point(30, 60);
            this.lblMaThuePhong.Name = "lblMaThuePhong";
            this.lblMaThuePhong.Size = new System.Drawing.Size(96, 13);
            this.lblMaThuePhong.TabIndex = 2;
            this.lblMaThuePhong.Text = "Mã thuê phòng:";
            // 
            // lblTongChiPhi
            // 
            this.lblTongChiPhi.AutoSize = true;
            this.lblTongChiPhi.Location = new System.Drawing.Point(30, 90);
            this.lblTongChiPhi.Name = "lblTongChiPhi";
            this.lblTongChiPhi.Size = new System.Drawing.Size(81, 13);
            this.lblTongChiPhi.TabIndex = 3;
            this.lblTongChiPhi.Text = "Tổng chi phí:";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(30, 120);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(65, 13);
            this.lblNgayLap.TabIndex = 4;
            this.lblNgayLap.Text = "Ngày lập:";
            // 
            // cbMaNguoiDung
            // 
            this.cbMaNguoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNguoiDung.FormattingEnabled = true;
            this.cbMaNguoiDung.Location = new System.Drawing.Point(120, 27);
            this.cbMaNguoiDung.Name = "cbMaNguoiDung";
            this.cbMaNguoiDung.Size = new System.Drawing.Size(200, 21);
            this.cbMaNguoiDung.TabIndex = 5;
            // 
            // cbMaThuePhong
            // 
            this.cbMaThuePhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaThuePhong.FormattingEnabled = true;
            this.cbMaThuePhong.Location = new System.Drawing.Point(120, 57);
            this.cbMaThuePhong.Name = "cbMaThuePhong";
            this.cbMaThuePhong.Size = new System.Drawing.Size(200, 21);
            this.cbMaThuePhong.TabIndex = 6;
            // 
            // nudTongChiPhi
            // 
            this.nudTongChiPhi.DecimalPlaces = 2;
            this.nudTongChiPhi.Location = new System.Drawing.Point(120, 87);
            this.nudTongChiPhi.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.nudTongChiPhi.Name = "nudTongChiPhi";
            this.nudTongChiPhi.Size = new System.Drawing.Size(200, 20);
            this.nudTongChiPhi.TabIndex = 7;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(120, 117);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayLap.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(350, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(350, 70);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(350, 110);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(350, 150);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 30);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(350, 190);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(80, 30);
            this.btnChiTiet.TabIndex = 13;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(450, 190);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(80, 30);
            this.btnHienThi.TabIndex = 14;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(30, 190);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 13);
            this.lblThongBao.TabIndex = 15;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.nudTongChiPhi);
            this.Controls.Add(this.cbMaThuePhong);
            this.Controls.Add(this.cbMaNguoiDung);
            this.Controls.Add(this.lblNgayLap);
            this.Controls.Add(this.lblTongChiPhi);
            this.Controls.Add(this.lblMaThuePhong);
            this.Controls.Add(this.lblMaNguoiDung);
            this.Controls.Add(this.dgvHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongChiPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label lblMaNguoiDung;
        private System.Windows.Forms.Label lblMaThuePhong;
        private System.Windows.Forms.Label lblTongChiPhi;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.ComboBox cbMaNguoiDung;
        private System.Windows.Forms.ComboBox cbMaThuePhong;
        private System.Windows.Forms.NumericUpDown nudTongChiPhi;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label lblThongBao;
    }
}