using QuanLyKhachSan.Models;
using System;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class frmMain : Form
    {
        private readonly NguoiDung _nguoiDung;

        public frmMain(NguoiDung nguoiDung)
        {
            InitializeComponent();
            _nguoiDung = nguoiDung;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                lblChaoMung.Text = $"Chào mừng {_nguoiDung.TenDangNhap} ({_nguoiDung.VaiTro})";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải form: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        #region Menu Handlers

        private void themThietBiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmThietBi frm = new frmThietBi())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form Thiết bị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void suaThietBiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Để trống, sẽ gắn form sau
        }

        private void xoaThietBiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Để trống, sẽ gắn form sau
        }

        private void xemDanhSachThietBiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmThietBi frm = new frmThietBi())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form Thiết bị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void themDatPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmDatPhong frm = new frmDatPhong())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form Thiết bị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void huyDatPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Để trống, sẽ gắn form sau
        }

        private void xemLichSuDatPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Để trống, sẽ gắn form sau
        }

        private void themThuePhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Để trống, sẽ gắn form sau
        }

        private void ketThucThuePhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Để trống, sẽ gắn form sau
        }

        private void xemDanhSachThuePhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmThuePhong frm = new frmThuePhong())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form Thiết bị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void taoHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Để trống, sẽ gắn form sau
        }

        private void xemHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmHoaDon frm = new frmHoaDon())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form Thiết bị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Để trống, sẽ gắn form sau
        }

        private void baoCaoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Để trống, sẽ gắn form sau
        }

        private void baoCaoTinhTrangThietBiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Để trống, sẽ gắn form sau
        }

        private void xuatBaoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Để trống, sẽ gắn form sau
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}