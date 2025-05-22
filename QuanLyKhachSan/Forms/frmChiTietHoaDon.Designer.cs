namespace QuanLyKhachSan.Forms
{
    partial class frmChiTietHoaDon
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
            dgvChiTietHoaDon = new DataGridView();
            lblLoaiChiPhi = new Label();
            lblMoTa = new Label();
            lblSoLuong = new Label();
            lblDonGia = new Label();
            cbLoaiChiPhi = new ComboBox();
            nudSoLuong = new NumericUpDown();
            nudDonGia = new NumericUpDown();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblThongBao = new Label();
            cboMoTa = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDonGia).BeginInit();
            SuspendLayout();
            // 
            // dgvChiTietHoaDon
            // 
            dgvChiTietHoaDon.AllowUserToAddRows = false;
            dgvChiTietHoaDon.AllowUserToDeleteRows = false;
            dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHoaDon.Location = new Point(35, 231);
            dgvChiTietHoaDon.Margin = new Padding(4, 3, 4, 3);
            dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            dgvChiTietHoaDon.ReadOnly = true;
            dgvChiTietHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietHoaDon.Size = new Size(863, 231);
            dgvChiTietHoaDon.TabIndex = 0;
            dgvChiTietHoaDon.SelectionChanged += dgvChiTietHoaDon_SelectionChanged;
            // 
            // lblLoaiChiPhi
            // 
            lblLoaiChiPhi.AutoSize = true;
            lblLoaiChiPhi.Location = new Point(35, 35);
            lblLoaiChiPhi.Margin = new Padding(4, 0, 4, 0);
            lblLoaiChiPhi.Name = "lblLoaiChiPhi";
            lblLoaiChiPhi.Size = new Size(71, 15);
            lblLoaiChiPhi.TabIndex = 1;
            lblLoaiChiPhi.Text = "Loại chi phí:";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(35, 69);
            lblMoTa.Margin = new Padding(4, 0, 4, 0);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(41, 15);
            lblMoTa.TabIndex = 2;
            lblMoTa.Text = "Mô tả:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(35, 104);
            lblSoLuong.Margin = new Padding(4, 0, 4, 0);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(57, 15);
            lblSoLuong.TabIndex = 3;
            lblSoLuong.Text = "Số lượng:";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(35, 138);
            lblDonGia.Margin = new Padding(4, 0, 4, 0);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(51, 15);
            lblDonGia.TabIndex = 4;
            lblDonGia.Text = "Đơn giá:";
            // 
            // cbLoaiChiPhi
            // 
            cbLoaiChiPhi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoaiChiPhi.FormattingEnabled = true;
            cbLoaiChiPhi.Location = new Point(140, 31);
            cbLoaiChiPhi.Margin = new Padding(4, 3, 4, 3);
            cbLoaiChiPhi.Name = "cbLoaiChiPhi";
            cbLoaiChiPhi.Size = new Size(233, 23);
            cbLoaiChiPhi.TabIndex = 5;
            cbLoaiChiPhi.SelectedIndexChanged += cbLoaiChiPhi_SelectedIndexChanged;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(140, 100);
            nudSoLuong.Margin = new Padding(4, 3, 4, 3);
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(233, 23);
            nudSoLuong.TabIndex = 7;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudDonGia
            // 
            nudDonGia.DecimalPlaces = 2;
            nudDonGia.Enabled = false;
            nudDonGia.Location = new Point(140, 135);
            nudDonGia.Margin = new Padding(4, 3, 4, 3);
            nudDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudDonGia.Name = "nudDonGia";
            nudDonGia.Size = new Size(233, 23);
            nudDonGia.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(408, 35);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(93, 35);
            btnThem.TabIndex = 9;
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
            btnSua.TabIndex = 10;
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
            btnXoa.TabIndex = 11;
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
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.ForeColor = Color.Red;
            lblThongBao.Location = new Point(35, 173);
            lblThongBao.Margin = new Padding(4, 0, 4, 0);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 15);
            lblThongBao.TabIndex = 13;
            // 
            // cboMoTa
            // 
            cboMoTa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMoTa.FormattingEnabled = true;
            cboMoTa.Location = new Point(140, 66);
            cboMoTa.Margin = new Padding(4, 3, 4, 3);
            cboMoTa.Name = "cboMoTa";
            cboMoTa.Size = new Size(233, 23);
            cboMoTa.TabIndex = 14;
            cboMoTa.SelectedIndexChanged += cboMoTa_SelectedIndexChanged;
            // 
            // frmChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(cboMoTa);
            Controls.Add(lblThongBao);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(nudDonGia);
            Controls.Add(nudSoLuong);
            Controls.Add(cbLoaiChiPhi);
            Controls.Add(lblDonGia);
            Controls.Add(lblSoLuong);
            Controls.Add(lblMoTa);
            Controls.Add(lblLoaiChiPhi);
            Controls.Add(dgvChiTietHoaDon);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmChiTietHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Chi Tiết Hóa Đơn";
            FormClosing += frmChiTietHoaDon_FormClosing;
            Load += frmChiTietHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDonGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.Label lblLoaiChiPhi;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.ComboBox cbLoaiChiPhi;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.NumericUpDown nudDonGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblThongBao;
        private ComboBox cboMoTa;
    }
}