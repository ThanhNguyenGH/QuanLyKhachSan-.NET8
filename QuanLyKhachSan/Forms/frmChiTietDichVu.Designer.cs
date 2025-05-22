namespace QuanLyKhachSan.Forms
{
    partial class frmChiTietDichVu
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
            this.dgvChiTietDichVu = new System.Windows.Forms.DataGridView();
            this.lblMaDichVu = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblThoiGianSuDung = new System.Windows.Forms.Label();
            this.cbMaDichVu = new System.Windows.Forms.ComboBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.dtpThoiGianSuDung = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiTietDichVu
            // 
            this.dgvChiTietDichVu.AllowUserToAddRows = false;
            this.dgvChiTietDichVu.AllowUserToDeleteRows = false;
            this.dgvChiTietDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDichVu.Location = new System.Drawing.Point(30, 180);
            this.dgvChiTietDichVu.Name = "dgvChiTietDichVu";
            this.dgvChiTietDichVu.ReadOnly = true;
            this.dgvChiTietDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietDichVu.Size = new System.Drawing.Size(740, 200);
            this.dgvChiTietDichVu.TabIndex = 0;
            this.dgvChiTietDichVu.SelectionChanged += new System.EventHandler(this.dgvChiTietDichVu_SelectionChanged);
            // 
            // lblMaDichVu
            // 
            this.lblMaDichVu.AutoSize = true;
            this.lblMaDichVu.Location = new System.Drawing.Point(30, 30);
            this.lblMaDichVu.Name = "lblMaDichVu";
            this.lblMaDichVu.Size = new System.Drawing.Size(65, 13);
            this.lblMaDichVu.TabIndex = 1;
            this.lblMaDichVu.Text = "Dịch vụ:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(30, 60);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(65, 13);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblThoiGianSuDung
            // 
            this.lblThoiGianSuDung.AutoSize = true;
            this.lblThoiGianSuDung.Location = new System.Drawing.Point(30, 90);
            this.lblThoiGianSuDung.Name = "lblThoiGianSuDung";
            this.lblThoiGianSuDung.Size = new System.Drawing.Size(110, 13);
            this.lblThoiGianSuDung.TabIndex = 3;
            this.lblThoiGianSuDung.Text = "Thời gian sử dụng:";
            // 
            // cbMaDichVu
            // 
            this.cbMaDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaDichVu.FormattingEnabled = true;
            this.cbMaDichVu.Location = new System.Drawing.Point(120, 27);
            this.cbMaDichVu.Name = "cbMaDichVu";
            this.cbMaDichVu.Size = new System.Drawing.Size(200, 21);
            this.cbMaDichVu.TabIndex = 4;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(120, 57);
            this.nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(200, 20);
            this.nudSoLuong.TabIndex = 5;
            this.nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpThoiGianSuDung
            // 
            this.dtpThoiGianSuDung.Location = new System.Drawing.Point(120, 87);
            this.dtpThoiGianSuDung.Name = "dtpThoiGianSuDung";
            this.dtpThoiGianSuDung.Size = new System.Drawing.Size(200, 20);
            this.dtpThoiGianSuDung.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(350, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(350, 70);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(350, 110);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(350, 150);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 30);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(30, 150);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 13);
            this.lblThongBao.TabIndex = 11;
            // 
            // frmChiTietDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpThoiGianSuDung);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.cbMaDichVu);
            this.Controls.Add(this.lblThoiGianSuDung);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblMaDichVu);
            this.Controls.Add(this.dgvChiTietDichVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmChiTietDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Chi Tiết Dịch Vụ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChiTietDichVu_FormClosing);
            this.Load += new System.EventHandler(this.frmChiTietDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTietDichVu;
        private System.Windows.Forms.Label lblMaDichVu;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblThoiGianSuDung;
        private System.Windows.Forms.ComboBox cbMaDichVu;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.DateTimePicker dtpThoiGianSuDung;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblThongBao;
    }
}