namespace QuanLyKhachSan.Forms
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            quanLyThietBiToolStripMenuItem = new ToolStripMenuItem();
            themThietBiToolStripMenuItem = new ToolStripMenuItem();
            suaThietBiToolStripMenuItem = new ToolStripMenuItem();
            xoaThietBiToolStripMenuItem = new ToolStripMenuItem();
            xemDanhSachThietBiToolStripMenuItem = new ToolStripMenuItem();
            quanLyDatPhongToolStripMenuItem = new ToolStripMenuItem();
            themDatPhongToolStripMenuItem = new ToolStripMenuItem();
            huyDatPhongToolStripMenuItem = new ToolStripMenuItem();
            xemLichSuDatPhongToolStripMenuItem = new ToolStripMenuItem();
            quanLyThuePhongToolStripMenuItem = new ToolStripMenuItem();
            themThuePhongToolStripMenuItem = new ToolStripMenuItem();
            ketThucThuePhongToolStripMenuItem = new ToolStripMenuItem();
            xemDanhSachThuePhongToolStripMenuItem = new ToolStripMenuItem();
            quanLyHoaDonToolStripMenuItem = new ToolStripMenuItem();
            taoHoaDonToolStripMenuItem = new ToolStripMenuItem();
            xemHoaDonToolStripMenuItem = new ToolStripMenuItem();
            inHoaDonToolStripMenuItem = new ToolStripMenuItem();
            baoCaoToolStripMenuItem = new ToolStripMenuItem();
            baoCaoDoanhThuToolStripMenuItem = new ToolStripMenuItem();
            baoCaoTinhTrangThietBiToolStripMenuItem = new ToolStripMenuItem();
            xuatBaoCaoToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            lblChaoMung = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { quanLyThietBiToolStripMenuItem, quanLyDatPhongToolStripMenuItem, quanLyThuePhongToolStripMenuItem, quanLyHoaDonToolStripMenuItem, baoCaoToolStripMenuItem, thoatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1273, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quanLyThietBiToolStripMenuItem
            // 
            quanLyThietBiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { themThietBiToolStripMenuItem, suaThietBiToolStripMenuItem, xoaThietBiToolStripMenuItem, xemDanhSachThietBiToolStripMenuItem });
            quanLyThietBiToolStripMenuItem.Name = "quanLyThietBiToolStripMenuItem";
            quanLyThietBiToolStripMenuItem.Size = new Size(103, 20);
            quanLyThietBiToolStripMenuItem.Text = "Quản lý Thiết bị";
            // 
            // themThietBiToolStripMenuItem
            // 
            themThietBiToolStripMenuItem.Name = "themThietBiToolStripMenuItem";
            themThietBiToolStripMenuItem.Size = new Size(195, 22);
            themThietBiToolStripMenuItem.Text = "Thêm thiết bị";
            themThietBiToolStripMenuItem.Click += themThietBiToolStripMenuItem_Click;
            // 
            // suaThietBiToolStripMenuItem
            // 
            suaThietBiToolStripMenuItem.Name = "suaThietBiToolStripMenuItem";
            suaThietBiToolStripMenuItem.Size = new Size(195, 22);
            suaThietBiToolStripMenuItem.Text = "Sửa thông tin thiết bị";
            suaThietBiToolStripMenuItem.Click += suaThietBiToolStripMenuItem_Click;
            // 
            // xoaThietBiToolStripMenuItem
            // 
            xoaThietBiToolStripMenuItem.Name = "xoaThietBiToolStripMenuItem";
            xoaThietBiToolStripMenuItem.Size = new Size(195, 22);
            xoaThietBiToolStripMenuItem.Text = "Xóa thiết bị";
            xoaThietBiToolStripMenuItem.Click += xoaThietBiToolStripMenuItem_Click;
            // 
            // xemDanhSachThietBiToolStripMenuItem
            // 
            xemDanhSachThietBiToolStripMenuItem.Name = "xemDanhSachThietBiToolStripMenuItem";
            xemDanhSachThietBiToolStripMenuItem.Size = new Size(195, 22);
            xemDanhSachThietBiToolStripMenuItem.Text = "Xem danh sách thiết bị";
            xemDanhSachThietBiToolStripMenuItem.Click += xemDanhSachThietBiToolStripMenuItem_Click;
            // 
            // quanLyDatPhongToolStripMenuItem
            // 
            quanLyDatPhongToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { themDatPhongToolStripMenuItem, huyDatPhongToolStripMenuItem, xemLichSuDatPhongToolStripMenuItem });
            quanLyDatPhongToolStripMenuItem.Name = "quanLyDatPhongToolStripMenuItem";
            quanLyDatPhongToolStripMenuItem.Size = new Size(119, 20);
            quanLyDatPhongToolStripMenuItem.Text = "Quản lý Đặt phòng";
            // 
            // themDatPhongToolStripMenuItem
            // 
            themDatPhongToolStripMenuItem.Name = "themDatPhongToolStripMenuItem";
            themDatPhongToolStripMenuItem.Size = new Size(193, 22);
            themDatPhongToolStripMenuItem.Text = "Thêm đặt phòng";
            themDatPhongToolStripMenuItem.Click += themDatPhongToolStripMenuItem_Click;
            // 
            // huyDatPhongToolStripMenuItem
            // 
            huyDatPhongToolStripMenuItem.Name = "huyDatPhongToolStripMenuItem";
            huyDatPhongToolStripMenuItem.Size = new Size(193, 22);
            huyDatPhongToolStripMenuItem.Text = "Hủy đặt phòng";
            huyDatPhongToolStripMenuItem.Click += huyDatPhongToolStripMenuItem_Click;
            // 
            // xemLichSuDatPhongToolStripMenuItem
            // 
            xemLichSuDatPhongToolStripMenuItem.Name = "xemLichSuDatPhongToolStripMenuItem";
            xemLichSuDatPhongToolStripMenuItem.Size = new Size(193, 22);
            xemLichSuDatPhongToolStripMenuItem.Text = "Xem lịch sử đặt phòng";
            xemLichSuDatPhongToolStripMenuItem.Click += xemLichSuDatPhongToolStripMenuItem_Click;
            // 
            // quanLyThuePhongToolStripMenuItem
            // 
            quanLyThuePhongToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { themThuePhongToolStripMenuItem, ketThucThuePhongToolStripMenuItem, xemDanhSachThuePhongToolStripMenuItem });
            quanLyThuePhongToolStripMenuItem.Name = "quanLyThuePhongToolStripMenuItem";
            quanLyThuePhongToolStripMenuItem.Size = new Size(128, 20);
            quanLyThuePhongToolStripMenuItem.Text = "Quản lý Thuê phòng";
            // 
            // themThuePhongToolStripMenuItem
            // 
            themThuePhongToolStripMenuItem.Name = "themThuePhongToolStripMenuItem";
            themThuePhongToolStripMenuItem.Size = new Size(220, 22);
            themThuePhongToolStripMenuItem.Text = "Thêm thuê phòng";
            themThuePhongToolStripMenuItem.Click += themThuePhongToolStripMenuItem_Click;
            // 
            // ketThucThuePhongToolStripMenuItem
            // 
            ketThucThuePhongToolStripMenuItem.Name = "ketThucThuePhongToolStripMenuItem";
            ketThucThuePhongToolStripMenuItem.Size = new Size(220, 22);
            ketThucThuePhongToolStripMenuItem.Text = "Kết thúc thuê phòng";
            ketThucThuePhongToolStripMenuItem.Click += ketThucThuePhongToolStripMenuItem_Click;
            // 
            // xemDanhSachThuePhongToolStripMenuItem
            // 
            xemDanhSachThuePhongToolStripMenuItem.Name = "xemDanhSachThuePhongToolStripMenuItem";
            xemDanhSachThuePhongToolStripMenuItem.Size = new Size(220, 22);
            xemDanhSachThuePhongToolStripMenuItem.Text = "Xem danh sách thuê phòng";
            xemDanhSachThuePhongToolStripMenuItem.Click += xemDanhSachThuePhongToolStripMenuItem_Click;
            // 
            // quanLyHoaDonToolStripMenuItem
            // 
            quanLyHoaDonToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { taoHoaDonToolStripMenuItem, xemHoaDonToolStripMenuItem, inHoaDonToolStripMenuItem });
            quanLyHoaDonToolStripMenuItem.Name = "quanLyHoaDonToolStripMenuItem";
            quanLyHoaDonToolStripMenuItem.Size = new Size(109, 20);
            quanLyHoaDonToolStripMenuItem.Text = "Quản lý Hóa đơn";
            // 
            // taoHoaDonToolStripMenuItem
            // 
            taoHoaDonToolStripMenuItem.Name = "taoHoaDonToolStripMenuItem";
            taoHoaDonToolStripMenuItem.Size = new Size(145, 22);
            taoHoaDonToolStripMenuItem.Text = "Tạo hóa đơn";
            taoHoaDonToolStripMenuItem.Click += taoHoaDonToolStripMenuItem_Click;
            // 
            // xemHoaDonToolStripMenuItem
            // 
            xemHoaDonToolStripMenuItem.Name = "xemHoaDonToolStripMenuItem";
            xemHoaDonToolStripMenuItem.Size = new Size(145, 22);
            xemHoaDonToolStripMenuItem.Text = "Xem hóa đơn";
            xemHoaDonToolStripMenuItem.Click += xemHoaDonToolStripMenuItem_Click;
            // 
            // inHoaDonToolStripMenuItem
            // 
            inHoaDonToolStripMenuItem.Name = "inHoaDonToolStripMenuItem";
            inHoaDonToolStripMenuItem.Size = new Size(145, 22);
            inHoaDonToolStripMenuItem.Text = "In hóa đơn";
            inHoaDonToolStripMenuItem.Click += inHoaDonToolStripMenuItem_Click;
            // 
            // baoCaoToolStripMenuItem
            // 
            baoCaoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { baoCaoDoanhThuToolStripMenuItem, baoCaoTinhTrangThietBiToolStripMenuItem, xuatBaoCaoToolStripMenuItem });
            baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem";
            baoCaoToolStripMenuItem.Size = new Size(61, 20);
            baoCaoToolStripMenuItem.Text = "Báo cáo";
            // 
            // baoCaoDoanhThuToolStripMenuItem
            // 
            baoCaoDoanhThuToolStripMenuItem.Name = "baoCaoDoanhThuToolStripMenuItem";
            baoCaoDoanhThuToolStripMenuItem.Size = new Size(211, 22);
            baoCaoDoanhThuToolStripMenuItem.Text = "Báo cáo doanh thu";
            baoCaoDoanhThuToolStripMenuItem.Click += baoCaoDoanhThuToolStripMenuItem_Click;
            // 
            // baoCaoTinhTrangThietBiToolStripMenuItem
            // 
            baoCaoTinhTrangThietBiToolStripMenuItem.Name = "baoCaoTinhTrangThietBiToolStripMenuItem";
            baoCaoTinhTrangThietBiToolStripMenuItem.Size = new Size(211, 22);
            baoCaoTinhTrangThietBiToolStripMenuItem.Text = "Báo cáo tình trạng thiết bị";
            baoCaoTinhTrangThietBiToolStripMenuItem.Click += baoCaoTinhTrangThietBiToolStripMenuItem_Click;
            // 
            // xuatBaoCaoToolStripMenuItem
            // 
            xuatBaoCaoToolStripMenuItem.Name = "xuatBaoCaoToolStripMenuItem";
            xuatBaoCaoToolStripMenuItem.Size = new Size(211, 22);
            xuatBaoCaoToolStripMenuItem.Text = "Xuất báo cáo";
            xuatBaoCaoToolStripMenuItem.Click += xuatBaoCaoToolStripMenuItem_Click;
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(50, 20);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click;
            // 
            // lblChaoMung
            // 
            lblChaoMung.AutoSize = true;
            lblChaoMung.Location = new Point(35, 35);
            lblChaoMung.Margin = new Padding(4, 0, 4, 0);
            lblChaoMung.Name = "lblChaoMung";
            lblChaoMung.Size = new Size(0, 15);
            lblChaoMung.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 720);
            Controls.Add(lblChaoMung);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Khách Sạn";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyThietBiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themThietBiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaThietBiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaThietBiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSachThietBiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyDatPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themDatPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huyDatPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemLichSuDatPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyThuePhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themThuePhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ketThucThuePhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSachThuePhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyHoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taoHoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemHoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inHoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoTinhTrangThietBiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuatBaoCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.Label lblChaoMung;
    }
}