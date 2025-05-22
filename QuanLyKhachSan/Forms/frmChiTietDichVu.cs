using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class frmChiTietDichVu : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly int _maThuePhong;

        public frmChiTietDichVu(int maThuePhong)
        {
            InitializeComponent();
            _maThuePhong = maThuePhong;
            try
            {
                var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseSqlServer("Server=.;Database=QuanLyKhachSan;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True")
                    .Options;
                _context = new ApplicationDbContext(options);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khởi tạo DbContext: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void frmChiTietDichVu_Load(object sender, EventArgs e)
        {
            try
            {
                cbMaDichVu.DataSource = _context.DichVu.ToList();
                cbMaDichVu.DisplayMember = "TenDichVu";
                cbMaDichVu.ValueMember = "MaDichVu";

                LoadChiTietDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadChiTietDichVu()
        {
            try
            {
                var chiTietDichVus = _context.ChiTietDichVu
                    .Include(ct => ct.DichVu)
                    .Where(ct => ct.MaThuePhong == _maThuePhong)
                    .Select(ct => new
                    {
                        ct.MaChiTietDichVu,
                        ct.MaDichVu,
                        DichVu = ct.DichVu.TenDichVu,
                        ct.SoLuong,
                        ct.ThoiGianSuDung,
                        ct.DonGia,
                        ct.ThanhTien
                    })
                    .ToList();

                dgvChiTietDichVu.DataSource = chiTietDichVus;

                dgvChiTietDichVu.Columns["MaChiTietDichVu"].HeaderText = "Mã Chi Tiết";
                dgvChiTietDichVu.Columns["MaDichVu"].Visible = false; // Ẩn cột MaDichVu
                dgvChiTietDichVu.Columns["DichVu"].HeaderText = "Dịch Vụ";
                dgvChiTietDichVu.Columns["SoLuong"].HeaderText = "Số Lượng";
                dgvChiTietDichVu.Columns["ThoiGianSuDung"].HeaderText = "Thời Gian Sử Dụng";
                dgvChiTietDichVu.Columns["DonGia"].HeaderText = "Đơn Giá";
                dgvChiTietDichVu.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách chi tiết dịch vụ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                var dichVu = _context.DichVu.Find((int)cbMaDichVu.SelectedValue);
                if (dichVu == null)
                {
                    MessageBox.Show("Dịch vụ không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var chiTiet = new ChiTietDichVu
                {
                    MaThuePhong = _maThuePhong
                };

                chiTiet.ThemChiTietDichVu(
                    dichVu,
                    (int)nudSoLuong.Value,
                    dtpThoiGianSuDung.Value
                );

                var thuePhong = _context.ThuePhong
                    .Include(tp => tp.Phong)
                    .Include(tp => tp.ChiTietDichVu)
                    .FirstOrDefault(tp => tp.MaThuePhong == _maThuePhong);
                if (thuePhong != null)
                {
                    thuePhong.ThemChiTietDichVu(chiTiet);
                    _context.SaveChanges();

                    MessageBox.Show("Thêm chi tiết dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChiTietDichVu();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm chi tiết dịch vụ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChiTietDichVu.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết dịch vụ để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInput()) return;

                int maChiTiet = (int)dgvChiTietDichVu.SelectedRows[0].Cells["MaChiTietDichVu"].Value;
                var chiTiet = _context.ChiTietDichVu.Find(maChiTiet);

                if (chiTiet != null)
                {
                    chiTiet.CapNhatChiTietDichVu(
                        (int)nudSoLuong.Value,
                        dtpThoiGianSuDung.Value
                    );

                    var thuePhong = _context.ThuePhong
                        .Include(tp => tp.Phong)
                        .Include(tp => tp.ChiTietDichVu)
                        .FirstOrDefault(tp => tp.MaThuePhong == _maThuePhong);
                    if (thuePhong != null)
                    {
                        thuePhong.TinhTongChiPhi();
                        _context.SaveChanges();

                        MessageBox.Show("Sửa chi tiết dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadChiTietDichVu();
                        ClearInput();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa chi tiết dịch vụ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChiTietDichVu.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết dịch vụ để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc muốn xóa chi tiết dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                int maChiTiet = (int)dgvChiTietDichVu.SelectedRows[0].Cells["MaChiTietDichVu"].Value;
                var chiTiet = _context.ChiTietDichVu.Find(maChiTiet);

                if (chiTiet != null)
                {
                    _context.ChiTietDichVu.Remove(chiTiet);
                    var thuePhong = _context.ThuePhong
                        .Include(tp => tp.Phong)
                        .Include(tp => tp.ChiTietDichVu)
                        .FirstOrDefault(tp => tp.MaThuePhong == _maThuePhong);
                    if (thuePhong != null)
                    {
                        thuePhong.TinhTongChiPhi();
                        _context.SaveChanges();
                    }

                    MessageBox.Show("Xóa chi tiết dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChiTietDichVu();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa chi tiết dịch vụ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                ClearInput();
                LoadChiTietDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvChiTietDichVu_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvChiTietDichVu.SelectedRows.Count > 0)
                {
                    var row = dgvChiTietDichVu.SelectedRows[0];
                    cbMaDichVu.SelectedValue = row.Cells["MaDichVu"].Value;
                    nudSoLuong.Value = (int)row.Cells["SoLuong"].Value;
                    dtpThoiGianSuDung.Value = (DateTime)row.Cells["ThoiGianSuDung"].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn chi tiết dịch vụ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (cbMaDichVu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpThoiGianSuDung.Value == default)
            {
                MessageBox.Show("Thời gian sử dụng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInput()
        {
            cbMaDichVu.SelectedIndex = -1;
            nudSoLuong.Value = 1;
            dtpThoiGianSuDung.Value = DateTime.Now;
            lblThongBao.Text = "";
        }

        private void frmChiTietDichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _context?.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đóng form: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}