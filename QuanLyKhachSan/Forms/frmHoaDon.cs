using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class frmHoaDon : Form
    {
        private readonly ApplicationDbContext _context;

        public frmHoaDon()
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
                this.Close();
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                // Load danh sách người dùng và thuê phòng vào ComboBox
                cbMaNguoiDung.DataSource = _context.NguoiDung.ToList();
                cbMaNguoiDung.DisplayMember = "TenDangNhap";
                cbMaNguoiDung.ValueMember = "MaNguoiDung";

                cbMaThuePhong.DataSource = _context.ThuePhong.ToList();
                cbMaThuePhong.DisplayMember = "MaThuePhong";
                cbMaThuePhong.ValueMember = "MaThuePhong";

                // Load dữ liệu hóa đơn
                LoadHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHoaDon()
        {
            try
            {
                var hoaDons = _context.HoaDon
                    .Include(hd => hd.NguoiDung)
                    .Include(hd => hd.ThuePhong)
                    .ThenInclude(tp => tp.KhachHang)
                    .Include(hd => hd.ThuePhong)
                    .ThenInclude(tp => tp.Phong)
                    .Select(hd => new
                    {
                        hd.MaHoaDon,
                        hd.MaNguoiDung,
                        NguoiDung = hd.NguoiDung.TenDangNhap,
                        hd.MaThuePhong,
                        KhachHang = hd.ThuePhong.KhachHang.HoTen,
                        Phong = hd.ThuePhong.Phong.SoPhong,
                        hd.TongChiPhi,
                        hd.NgayLap
                    })
                    .ToList();

                dgvHoaDon.DataSource = hoaDons;

                dgvHoaDon.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
                dgvHoaDon.Columns["MaNguoiDung"].HeaderText = "Mã Người Dùng";
                dgvHoaDon.Columns["NguoiDung"].HeaderText = "Người Lập";
                dgvHoaDon.Columns["MaThuePhong"].HeaderText = "Mã Thuê Phòng";
                dgvHoaDon.Columns["KhachHang"].HeaderText = "Khách Hàng";
                dgvHoaDon.Columns["Phong"].HeaderText = "Phòng";
                dgvHoaDon.Columns["TongChiPhi"].HeaderText = "Tổng Chi Phí";
                dgvHoaDon.Columns["NgayLap"].HeaderText = "Ngày Lập";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    var hoaDon = new HoaDon
                    {
                        MaNguoiDung = (int)cbMaNguoiDung.SelectedValue,
                        MaThuePhong = (int)cbMaThuePhong.SelectedValue,
                        TongChiPhi = (decimal)nudTongChiPhi.Value,
                        NgayLap = dtpNgayLap.Value
                    };

                    _context.HoaDon.Add(hoaDon);
                    _context.SaveChanges();

                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHoaDon();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHoaDon.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ValidateInput())
                {
                    int maHoaDon = (int)dgvHoaDon.SelectedRows[0].Cells["MaHoaDon"].Value;
                    var hoaDon = _context.HoaDon.Find(maHoaDon);

                    if (hoaDon != null)
                    {
                        hoaDon.MaNguoiDung = (int)cbMaNguoiDung.SelectedValue;
                        hoaDon.MaThuePhong = (int)cbMaThuePhong.SelectedValue;
                        hoaDon.TongChiPhi = (decimal)nudTongChiPhi.Value;
                        hoaDon.NgayLap = dtpNgayLap.Value;

                        _context.SaveChanges();

                        MessageBox.Show("Sửa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadHoaDon();
                        ClearInput();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHoaDon.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int maHoaDon = (int)dgvHoaDon.SelectedRows[0].Cells["MaHoaDon"].Value;
                    var hoaDon = _context.HoaDon.Include(hd => hd.ChiTietHoaDon).FirstOrDefault(hd => hd.MaHoaDon == maHoaDon);

                    if (hoaDon != null)
                    {
                        _context.ChiTietHoaDon.RemoveRange(hoaDon.ChiTietHoaDon);
                        _context.HoaDon.Remove(hoaDon);
                        _context.SaveChanges();

                        MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadHoaDon();
                        ClearInput();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                ClearInput();
                LoadHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHoaDon.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn để xem chi tiết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maHoaDon = (int)dgvHoaDon.SelectedRows[0].Cells["MaHoaDon"].Value;
                using (var frm = new frmChiTietHoaDon(maHoaDon))
                {
                    frm.ShowDialog();
                    LoadHoaDon(); // Cập nhật lại sau khi chỉnh sửa chi tiết
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form Chi tiết hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHoaDon.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn để hiển thị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maHoaDon = (int)dgvHoaDon.SelectedRows[0].Cells["MaHoaDon"].Value;
                var hoaDon = _context.HoaDon
                    .Include(hd => hd.NguoiDung)
                    .Include(hd => hd.ThuePhong)
                    .Include(hd => hd.ChiTietHoaDon)
                    .FirstOrDefault(hd => hd.MaHoaDon == maHoaDon);

                if (hoaDon != null)
                {
                    MessageBox.Show(hoaDon.HienThiHoaDon(), "Thông tin hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvHoaDon.SelectedRows.Count > 0)
                {
                    var row = dgvHoaDon.SelectedRows[0];
                    cbMaNguoiDung.SelectedValue = row.Cells["MaNguoiDung"].Value;
                    cbMaThuePhong.SelectedValue = row.Cells["MaThuePhong"].Value;
                    nudTongChiPhi.Value = (decimal)row.Cells["TongChiPhi"].Value;
                    dtpNgayLap.Value = (DateTime)row.Cells["NgayLap"].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (cbMaNguoiDung.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbMaThuePhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn mã thuê phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            cbMaNguoiDung.SelectedIndex = -1;
            cbMaThuePhong.SelectedIndex = -1;
            nudTongChiPhi.Value = 0;
            dtpNgayLap.Value = DateTime.Now;
            lblThongBao.Text = "";
        }

        private void frmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
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