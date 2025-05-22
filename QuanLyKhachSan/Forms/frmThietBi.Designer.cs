namespace QuanLyKhachSan.Forms
{
    partial class frmThietBi
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
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.lblTenThietBi = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.txtTenThietBi = new System.Windows.Forms.TextBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbMaPhong = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.AllowUserToAddRows = false;
            this.dgvThietBi.AllowUserToDeleteRows = false;
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Location = new System.Drawing.Point(30, 200);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.ReadOnly = true;
            this.dgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThietBi.Size = new System.Drawing.Size(740, 200);
            this.dgvThietBi.TabIndex = 0;
            this.dgvThietBi.SelectionChanged += new System.EventHandler(this.dgvThietBi_SelectionChanged);
            // 
            // lblTenThietBi
            // 
            this.lblTenThietBi.AutoSize = true;
            this.lblTenThietBi.Location = new System.Drawing.Point(30, 30);
            this.lblTenThietBi.Name = "lblTenThietBi";
            this.lblTenThietBi.Size = new System.Drawing.Size(76, 13);
            this.lblTenThietBi.TabIndex = 1;
            this.lblTenThietBi.Text = "Tên thiết bị:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(30, 60);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(60, 13);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(30, 90);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(59, 13);
            this.lblMaPhong.TabIndex = 3;
            this.lblMaPhong.Text = "Phòng:";
            // 
            // txtTenThietBi
            // 
            this.txtTenThietBi.Location = new System.Drawing.Point(120, 27);
            this.txtTenThietBi.Name = "txtTenThietBi";
            this.txtTenThietBi.Size = new System.Drawing.Size(200, 20);
            this.txtTenThietBi.TabIndex = 4;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(120, 57);
            this.nudSoLuong.Minimum = 1;
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(80, 20);
            this.nudSoLuong.TabIndex = 5;
            this.nudSoLuong.Value = 1;
            // 
            // cbMaPhong
            // 
            this.cbMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPhong.FormattingEnabled = true;
            this.cbMaPhong.Location = new System.Drawing.Point(120, 87);
            this.cbMaPhong.Name = "cbMaPhong";
            this.cbMaPhong.Size = new System.Drawing.Size(200, 21);
            this.cbMaPhong.TabIndex = 6;
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
            this.lblThongBao.Location = new System.Drawing.Point(30, 120);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 13);
            this.lblThongBao.TabIndex = 11;
            // 
            // frmThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbMaPhong);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.txtTenThietBi);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblTenThietBi);
            this.Controls.Add(this.dgvThietBi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmThietBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thiết Bị";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThietBi_FormClosing);
            this.Load += new System.EventHandler(this.frmThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.Label lblTenThietBi;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.TextBox txtTenThietBi;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ComboBox cbMaPhong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblThongBao;
    }
}