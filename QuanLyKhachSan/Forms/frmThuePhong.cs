using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class frmThuePhong : Form
    {
        private readonly ApplicationDbContext _context;

        public frmThuePhong()
        {
            InitializeComponent();
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

        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            try
            {
                cbMaKhachHang.DataSource = _context.KhachHang.ToList();
                cbMaKhachHang.DisplayMember = "HoTen";
                cbMaKhachHang.ValueMember = "MaKhachHang";

                cbMaPhong.DataSource = _context.Phong.ToList();
                cbMaPhong.DisplayMember = "SoPhong";
                cbMaPhong.ValueMember = "MaPhong";

                LoadThuePhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadThuePhong()
        {
            try
            {
                var thuePhongs = _context.ThuePhong
                    .Include(tp => tp.KhachHang)
                    .Include(tp => tp.Phong)
                    .Select(tp => new
                    {
                        tp.MaThuePhong,
                        tp.MaKhachHang,
                        KhachHang = tp.KhachHang.HoTen,
                        tp.MaPhong,
                        Phong = tp.Phong.SoPhong,
                        tp.NgayNhanPhong,
                        tp.NgayTraPhong,
                        tp.TongChiPhi
                    })
                    .ToList();

                dgvThuePhong.DataSource = thuePhongs;

                dgvThuePhong.Columns["MaThuePhong"].HeaderText = "Mã Thuê Phòng";
                dgvThuePhong.Columns["MaKhachHang"].Visible = false;
                dgvThuePhong.Columns["KhachHang"].HeaderText = "Khách Hàng";
                dgvThuePhong.Columns["MaPhong"].Visible = false;
                dgvThuePhong.Columns["Phong"].HeaderText = "Phòng";
                dgvThuePhong.Columns["NgayNhanPhong"].HeaderText = "Ngày Nhận";
                dgvThuePhong.Columns["NgayTraPhong"].HeaderText = "Ngày Trả";
                dgvThuePhong.Columns["TongChiPhi"].HeaderText = "Tổng Chi Phí";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách thuê phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                var thuePhong = new ThuePhong
                {
                    MaKhachHang = (int)cbMaKhachHang.SelectedValue,
                    MaPhong = (int)cbMaPhong.SelectedValue,
                    NgayNhanPhong = dtpNgayNhanPhong.Value,
                    NgayTraPhong = dtpNgayTraPhong.Value,
                    TongChiPhi = (decimal)nudTongChiPhi.Value
                };

                _context.ThuePhong.Add(thuePhong);
                _context.SaveChanges();

                MessageBox.Show("Thêm thuê phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThuePhong();
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm thuê phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThuePhong.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn thuê phòng để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInput()) return;

                int maThuePhong = (int)dgvThuePhong.SelectedRows[0].Cells["MaThuePhong"].Value;
                var thuePhong = _context.ThuePhong.Find(maThuePhong);

                if (thuePhong != null)
                {
                    thuePhong.MaKhachHang = (int)cbMaKhachHang.SelectedValue;
                    thuePhong.MaPhong = (int)cbMaPhong.SelectedValue;
                    thuePhong.NgayNhanPhong = dtpNgayNhanPhong.Value;
                    thuePhong.NgayTraPhong = dtpNgayTraPhong.Value;
                    thuePhong.TongChiPhi = (decimal)nudTongChiPhi.Value;

                    _context.SaveChanges();

                    MessageBox.Show("Sửa thuê phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThuePhong();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa thuê phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThuePhong.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn thuê phòng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc muốn xóa thuê phòng này? Các chi tiết dịch vụ và hóa đơn liên quan sẽ bị xóa!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                int maThuePhong = (int)dgvThuePhong.SelectedRows[0].Cells["MaThuePhong"].Value;
                var thuePhong = _context.ThuePhong
                    .Include(tp => tp.ChiTietDichVu)
                    .Include(tp => tp.HoaDon)
                    .ThenInclude(hd => hd.ChiTietHoaDon)
                    .FirstOrDefault(tp => tp.MaThuePhong == maThuePhong);

                if (thuePhong != null)
                {
                    foreach (var hoaDon in thuePhong.HoaDon)
                        _context.ChiTietHoaDon.RemoveRange(hoaDon.ChiTietHoaDon);

                    _context.HoaDon.RemoveRange(thuePhong.HoaDon);
                    _context.ChiTietDichVu.RemoveRange(thuePhong.ChiTietDichVu);
                    _context.ThuePhong.Remove(thuePhong);
                    _context.SaveChanges();

                    MessageBox.Show("Xóa thuê phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThuePhong();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa thuê phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                ClearInput();
                LoadThuePhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThuePhong.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn thuê phòng để nhận!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maThuePhong = (int)dgvThuePhong.SelectedRows[0].Cells["MaThuePhong"].Value;
                var thuePhong = _context.ThuePhong.Find(maThuePhong);

                if (thuePhong != null)
                {
                    thuePhong.NhanPhong();
                    _context.SaveChanges();

                    MessageBox.Show("Nhận phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThuePhong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nhận phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThuePhong.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn thuê phòng để trả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maThuePhong = (int)dgvThuePhong.SelectedRows[0].Cells["MaThuePhong"].Value;
                var thuePhong = _context.ThuePhong
                    .Include(tp => tp.Phong)
                    .Include(tp => tp.ChiTietDichVu)
                    .FirstOrDefault(tp => tp.MaThuePhong == maThuePhong);

                if (thuePhong != null)
                {
                    thuePhong.TraPhong();
                    _context.SaveChanges();

                    MessageBox.Show($"Trả phòng thành công! Tổng chi phí: {thuePhong.TongChiPhi:C}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThuePhong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi trả phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChiTietDichVu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThuePhong.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn thuê phòng để xem chi tiết dịch vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maThuePhong = (int)dgvThuePhong.SelectedRows[0].Cells["MaThuePhong"].Value;
                using var frm = new frmChiTietDichVu(maThuePhong);
                frm.ShowDialog();
                LoadThuePhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form Chi tiết dịch vụ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThuePhong.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn thuê phòng để lập hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maThuePhong = (int)dgvThuePhong.SelectedRows[0].Cells["MaThuePhong"].Value;
                var thuePhong = _context.ThuePhong
                    .Include(tp => tp.Phong)
                    .Include(tp => tp.ChiTietDichVu)
                    .ThenInclude(ct => ct.DichVu)
                    .FirstOrDefault(tp => tp.MaThuePhong == maThuePhong);

                if (thuePhong == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin thuê phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (thuePhong.NgayTraPhong == default)
                {
                    MessageBox.Show("Phòng chưa được trả, không thể lập hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var hoaDon = new HoaDon
                {
                    MaNguoiDung = 1, // TODO: Thay bằng MaNguoiDung từ người dùng đăng nhập
                    MaThuePhong = maThuePhong,
                    NgayLap = DateTime.Now,
                    ThuePhong = thuePhong
                };

                hoaDon.TaoChiTietTuThuePhong();
                if (hoaDon.TongChiPhi <= 0)
                {
                    MessageBox.Show("Hóa đơn không có chi phí, vui lòng kiểm tra chi tiết dịch vụ hoặc giá phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _context.HoaDon.Add(hoaDon);
                _context.SaveChanges();

                MessageBox.Show($"Lập hóa đơn thành công! Mã hóa đơn: {hoaDon.MaHoaDon}\nTổng chi phí: {hoaDon.TongChiPhi:C}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThuePhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lập hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvThuePhong_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvThuePhong.SelectedRows.Count > 0)
                {
                    var row = dgvThuePhong.SelectedRows[0];
                    cbMaKhachHang.SelectedValue = row.Cells["MaKhachHang"].Value;
                    cbMaPhong.SelectedValue = row.Cells["MaPhong"].Value;
                    dtpNgayNhanPhong.Value = row.Cells["NgayNhanPhong"].Value != DBNull.Value ? (DateTime)row.Cells["NgayNhanPhong"].Value : DateTime.Now;
                    dtpNgayTraPhong.Value = row.Cells["NgayTraPhong"].Value != DBNull.Value ? (DateTime)row.Cells["NgayTraPhong"].Value : DateTime.Now;
                    nudTongChiPhi.Value = (decimal)row.Cells["TongChiPhi"].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn thuê phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (cbMaKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbMaPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpNgayNhanPhong.Value > dtpNgayTraPhong.Value)
            {
                MessageBox.Show("Ngày nhận phòng phải trước ngày trả phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nudTongChiPhi.Value < 0)
            {
                MessageBox.Show("Tổng chi phí không được âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInput()
        {
            cbMaKhachHang.SelectedIndex = -1;
            cbMaPhong.SelectedIndex = -1;
            dtpNgayNhanPhong.Value = DateTime.Now;
            dtpNgayTraPhong.Value = DateTime.Now;
            nudTongChiPhi.Value = 0;
            lblThongBao.Text = "";
        }

        private void frmThuePhong_FormClosing(object sender, FormClosingEventArgs e)
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