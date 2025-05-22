using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class frmDatPhong : Form
    {
        private readonly ApplicationDbContext _context;

        public frmDatPhong()
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

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            try
            {
                // Load danh sách khách hàng và phòng vào ComboBox
                cbMaKhachHang.DataSource = _context.KhachHang.ToList();
                cbMaKhachHang.DisplayMember = "HoTen";
                cbMaKhachHang.ValueMember = "MaKhachHang";

                cbMaPhong.DataSource = _context.Phong.ToList();
                cbMaPhong.DisplayMember = "SoPhong";
                cbMaPhong.ValueMember = "MaPhong";

                cbTrangThai.Items.AddRange(new[] { "Chờ xác nhận", "Đã xác nhận", "Đã hủy" });
                cbTrangThai.SelectedIndex = 0;

                // Load dữ liệu đặt phòng
                LoadDatPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDatPhong()
        {
            try
            {
                var datPhongs = _context.DatPhong
                    .Include(dp => dp.KhachHang)
                    .Include(dp => dp.Phong)
                    .Select(dp => new
                    {
                        dp.MaDatPhong,
                        dp.MaKhachHang,
                        KhachHang = dp.KhachHang.HoTen,
                        dp.MaPhong,
                        Phong = dp.Phong.SoPhong,
                        dp.NgayDat,
                        dp.NgayNhanPhong,
                        dp.TrangThai
                    })
                    .ToList();

                dgvDatPhong.DataSource = datPhongs;

                dgvDatPhong.Columns["MaDatPhong"].HeaderText = "Mã Đặt Phòng";
                dgvDatPhong.Columns["MaKhachHang"].HeaderText = "Mã Khách Hàng";
                dgvDatPhong.Columns["KhachHang"].HeaderText = "Tên Khách Hàng";
                dgvDatPhong.Columns["MaPhong"].HeaderText = "Mã Phòng";
                dgvDatPhong.Columns["Phong"].HeaderText = "Số Phòng";
                dgvDatPhong.Columns["NgayDat"].HeaderText = "Ngày Đặt";
                dgvDatPhong.Columns["NgayNhanPhong"].HeaderText = "Ngày Nhận";
                dgvDatPhong.Columns["TrangThai"].HeaderText = "Trạng Thái";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách đặt phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    var datPhong = new DatPhong
                    {
                        MaKhachHang = (int)cbMaKhachHang.SelectedValue,
                        MaPhong = (int)cbMaPhong.SelectedValue,
                        NgayDat = dtpNgayDat.Value,
                        NgayNhanPhong = dtpNgayNhanPhong.Value,
                        TrangThai = cbTrangThai.SelectedItem.ToString()
                    };

                    _context.DatPhong.Add(datPhong);
                    _context.SaveChanges();

                    MessageBox.Show("Thêm đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDatPhong();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm đặt phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDatPhong.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn đặt phòng để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ValidateInput())
                {
                    int maDatPhong = (int)dgvDatPhong.SelectedRows[0].Cells["MaDatPhong"].Value;
                    var datPhong = _context.DatPhong.Find(maDatPhong);

                    if (datPhong != null)
                    {
                        datPhong.MaKhachHang = (int)cbMaKhachHang.SelectedValue;
                        datPhong.MaPhong = (int)cbMaPhong.SelectedValue;
                        datPhong.NgayDat = dtpNgayDat.Value;
                        datPhong.NgayNhanPhong = dtpNgayNhanPhong.Value;
                        datPhong.TrangThai = cbTrangThai.SelectedItem.ToString();

                        _context.SaveChanges();

                        MessageBox.Show("Sửa đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDatPhong();
                        ClearInput();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa đặt phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDatPhong.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn đặt phòng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc muốn xóa đặt phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int maDatPhong = (int)dgvDatPhong.SelectedRows[0].Cells["MaDatPhong"].Value;
                    var datPhong = _context.DatPhong.Find(maDatPhong);

                    if (datPhong != null)
                    {
                        _context.DatPhong.Remove(datPhong);
                        _context.SaveChanges();

                        MessageBox.Show("Xóa đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDatPhong();
                        ClearInput();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa đặt phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                ClearInput();
                LoadDatPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatPhong_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDatPhong.SelectedRows.Count > 0)
                {
                    var row = dgvDatPhong.SelectedRows[0];
                    cbMaKhachHang.SelectedValue = row.Cells["MaKhachHang"].Value;
                    cbMaPhong.SelectedValue = row.Cells["MaPhong"].Value;
                    dtpNgayDat.Value = (DateTime)row.Cells["NgayDat"].Value;
                    dtpNgayNhanPhong.Value = (DateTime)row.Cells["NgayNhanPhong"].Value;
                    cbTrangThai.SelectedItem = row.Cells["TrangThai"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn đặt phòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (dtpNgayNhanPhong.Value < dtpNgayDat.Value)
            {
                MessageBox.Show("Ngày nhận phòng phải sau ngày đặt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (string.IsNullOrEmpty(cbTrangThai.SelectedItem?.ToString()))
            {
                MessageBox.Show("Vui lòng chọn trạng thái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInput()
        {
            cbMaKhachHang.SelectedIndex = -1;
            cbMaPhong.SelectedIndex = -1;
            dtpNgayDat.Value = DateTime.Now;
            dtpNgayNhanPhong.Value = DateTime.Now;
            cbTrangThai.SelectedIndex = 0;
            lblThongBao.Text = "";
        }

        private void frmDatPhong_FormClosing(object sender, FormClosingEventArgs e)
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