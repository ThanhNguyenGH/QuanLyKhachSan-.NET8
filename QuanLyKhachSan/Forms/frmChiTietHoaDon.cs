using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class frmChiTietHoaDon : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly int _maHoaDon;

        public frmChiTietHoaDon(int maHoaDon)
        {
            InitializeComponent();
            _maHoaDon = maHoaDon;
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

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                cbLoaiChiPhi.Items.AddRange(new[] { "Phòng", "Dịch vụ", "Khác" });
                cbLoaiChiPhi.SelectedIndex = 0; // Gọi SelectedIndexChanged để khởi tạo cboMoTa
                LoadChiTietHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbLoaiChiPhi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                cboMoTa.DataSource = null;
                cboMoTa.Items.Clear();

                nudDonGia.Value = 0;

                string loaiChiPhi = cbLoaiChiPhi.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(loaiChiPhi))
                    return;

                if (loaiChiPhi == "Phòng")
                {
                    var phongList = _context.Phong
                        .Select(p => new { p.MaPhong, p.SoPhong, p.GiaPhong })
                        .ToList();

                    cboMoTa.DisplayMember = "SoPhong";
                    cboMoTa.ValueMember = "MaPhong";
                    cboMoTa.DataSource = phongList;
                    cboMoTa.Tag = phongList;
                }
                else if (loaiChiPhi == "Dịch vụ")
                {
                    var dichVuList = _context.DichVu
                        .Select(dv => new { dv.MaDichVu, dv.TenDichVu, dv.GiaDichVu })
                        .ToList();

                    cboMoTa.DisplayMember = "TenDichVu";
                    cboMoTa.ValueMember = "MaDichVu";
                    cboMoTa.DataSource = dichVuList;
                    cboMoTa.Tag = dichVuList;
                }
                else // "Khác"
                {
                    cboMoTa.DisplayMember = null;
                    cboMoTa.ValueMember = null;
                    cboMoTa.DataSource = null; // Chắc chắn đã gỡ DataSource

                    cboMoTa.Items.Add("Chi phí khác");
                    cboMoTa.SelectedIndex = 0;
                }

                // Cập nhật đơn giá nếu có sẵn lựa chọn
                if (cboMoTa.Items.Count > 0 && cboMoTa.SelectedIndex >= 0)
                {
                    UpdateDonGia();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thay đổi loại chi phí: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cboMoTa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateDonGia();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn mô tả: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDonGia()
        {
            if (cbLoaiChiPhi.SelectedItem == null || cboMoTa.SelectedItem == null)
            {
                nudDonGia.Value = 0;
                return;
            }

            string loaiChiPhi = cbLoaiChiPhi.SelectedItem.ToString();
            if (loaiChiPhi == "Phòng")
            {
                var phong = cboMoTa.SelectedItem as dynamic;
                if (phong != null && phong.GiaPhong != null)
                {
                    nudDonGia.Value = phong.GiaPhong;
                }
                else
                {
                    nudDonGia.Value = 0;
                }
            }
            else if (loaiChiPhi == "Dịch vụ")
            {
                var dichVu = cboMoTa.SelectedItem as dynamic;
                if (dichVu != null && dichVu.GiaDichVu != null)
                {
                    nudDonGia.Value = dichVu.GiaDichVu;
                }
                else
                {
                    nudDonGia.Value = 0;
                }
            }
            else // "Khác"
            {
                nudDonGia.Value = 0; // Người dùng tự nhập
            }
        }

        private void LoadChiTietHoaDon()
        {
            try
            {
                var chiTietHoaDons = _context.ChiTietHoaDon
                    .Where(ct => ct.MaHoaDon == _maHoaDon)
                    .Select(ct => new
                    {
                        ct.MaChiTietHoaDon,
                        ct.LoaiChiPhi,
                        ct.MoTa,
                        ct.SoLuong,
                        ct.DonGia,
                        ct.ThanhTien
                    })
                    .ToList();

                dgvChiTietHoaDon.DataSource = chiTietHoaDons;

                dgvChiTietHoaDon.Columns["MaChiTietHoaDon"].HeaderText = "Mã Chi Tiết";
                dgvChiTietHoaDon.Columns["LoaiChiPhi"].HeaderText = "Loại Chi Phí";
                dgvChiTietHoaDon.Columns["MoTa"].HeaderText = "Mô Tả";
                dgvChiTietHoaDon.Columns["SoLuong"].HeaderText = "Số Lượng";
                dgvChiTietHoaDon.Columns["DonGia"].HeaderText = "Đơn Giá";
                dgvChiTietHoaDon.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách chi tiết hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                var chiTiet = new ChiTietHoaDon
                {
                    MaHoaDon = _maHoaDon,
                    LoaiChiPhi = cbLoaiChiPhi.SelectedItem.ToString()
                };

                string moTa;
                if (cbLoaiChiPhi.SelectedItem.ToString() == "Phòng")
                {
                    moTa = ((dynamic)cboMoTa.SelectedItem).SoPhong;
                }
                else if (cbLoaiChiPhi.SelectedItem.ToString() == "Dịch vụ")
                {
                    moTa = ((dynamic)cboMoTa.SelectedItem).TenDichVu;
                }
                else
                {
                    moTa = cboMoTa.Text; // Cho "Khác"
                }

                chiTiet.ThemChiTietHoaDon(
                    moTa,
                    (int)nudSoLuong.Value,
                    (decimal)nudDonGia.Value
                );

                var hoaDon = _context.HoaDon
                    .Include(hd => hd.ChiTietHoaDon)
                    .FirstOrDefault(hd => hd.MaHoaDon == _maHoaDon);
                if (hoaDon != null)
                {
                    hoaDon.ThemChiTietHoaDon(chiTiet);
                    _context.SaveChanges();

                    MessageBox.Show("Thêm chi tiết hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChiTietHoaDon();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm chi tiết hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChiTietHoaDon.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết hóa đơn để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInput()) return;

                int maChiTiet = (int)dgvChiTietHoaDon.SelectedRows[0].Cells["MaChiTietHoaDon"].Value;
                var chiTiet = _context.ChiTietHoaDon.Find(maChiTiet);

                if (chiTiet != null)
                {
                    chiTiet.LoaiChiPhi = cbLoaiChiPhi.SelectedItem.ToString();
                    string moTa;
                    if (cbLoaiChiPhi.SelectedItem.ToString() == "Phòng")
                    {
                        moTa = ((dynamic)cboMoTa.SelectedItem).SoPhong;
                    }
                    else if (cbLoaiChiPhi.SelectedItem.ToString() == "Dịch vụ")
                    {
                        moTa = ((dynamic)cboMoTa.SelectedItem).TenDichVu;
                    }
                    else
                    {
                        moTa = cboMoTa.Text;
                    }

                    chiTiet.ThemChiTietHoaDon(
                        moTa,
                        (int)nudSoLuong.Value,
                        (decimal)nudDonGia.Value
                    );

                    var hoaDon = _context.HoaDon
                        .Include(hd => hd.ChiTietHoaDon)
                        .FirstOrDefault(hd => hd.MaHoaDon == _maHoaDon);
                    if (hoaDon != null)
                    {
                        hoaDon.TinhTongChiPhi();
                        _context.SaveChanges();

                        MessageBox.Show("Sửa chi tiết hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadChiTietHoaDon();
                        ClearInput();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa chi tiết hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChiTietHoaDon.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn chi tiết hóa đơn để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc muốn xóa chi tiết hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                int maChiTiet = (int)dgvChiTietHoaDon.SelectedRows[0].Cells["MaChiTietHoaDon"].Value;
                var chiTiet = _context.ChiTietHoaDon.Find(maChiTiet);

                if (chiTiet != null)
                {
                    _context.ChiTietHoaDon.Remove(chiTiet);
                    var hoaDon = _context.HoaDon
                        .Include(hd => hd.ChiTietHoaDon)
                        .FirstOrDefault(hd => hd.MaHoaDon == _maHoaDon);
                    if (hoaDon != null)
                    {
                        hoaDon.TinhTongChiPhi();
                        _context.SaveChanges();
                    }

                    MessageBox.Show("Xóa chi tiết hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChiTietHoaDon();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa chi tiết hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                ClearInput();
                LoadChiTietHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvChiTietHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvChiTietHoaDon.SelectedRows.Count > 0)
                {
                    var row = dgvChiTietHoaDon.SelectedRows[0];
                    string loaiChiPhi = row.Cells["LoaiChiPhi"].Value.ToString();
                    string moTa = row.Cells["MoTa"].Value.ToString();

                    // Cập nhật cbLoaiChiPhi
                    cbLoaiChiPhi.SelectedItem = loaiChiPhi;

                    // Cập nhật cboMoTa dựa trên LoaiChiPhi
                    if (loaiChiPhi == "Phòng")
                    {
                        var phongList = _context.Phong
                            .Select(p => new { p.MaPhong, p.SoPhong, p.GiaPhong })
                            .ToList();
                        cboMoTa.DataSource = phongList;
                        cboMoTa.DisplayMember = "SoPhong";
                        cboMoTa.ValueMember = "MaPhong";
                        cboMoTa.Tag = phongList;

                        // Tìm và chọn mục phù hợp
                        var selectedPhong = phongList.FirstOrDefault(p => p.SoPhong == moTa);
                        if (selectedPhong != null)
                        {
                            cboMoTa.SelectedValue = selectedPhong.MaPhong;
                        }
                    }
                    else if (loaiChiPhi == "Dịch vụ")
                    {
                        var dichVuList = _context.DichVu
                            .Select(dv => new { dv.MaDichVu, dv.TenDichVu, dv.GiaDichVu })
                            .ToList();
                        cboMoTa.DataSource = dichVuList;
                        cboMoTa.DisplayMember = "TenDichVu";
                        cboMoTa.ValueMember = "MaDichVu";
                        cboMoTa.Tag = dichVuList;

                        var selectedDichVu = dichVuList.FirstOrDefault(dv => dv.TenDichVu == moTa);
                        if (selectedDichVu != null)
                        {
                            cboMoTa.SelectedValue = selectedDichVu.MaDichVu;
                        }
                    }
                    else // "Khác"
                    {
                        cboMoTa.Items.Clear();
                        cboMoTa.Items.Add(moTa);
                        cboMoTa.SelectedIndex = 0;
                    }

                    nudSoLuong.Value = (int)row.Cells["SoLuong"].Value;
                    nudDonGia.Value = (decimal)row.Cells["DonGia"].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn chi tiết hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(cboMoTa.Text))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn mô tả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nudDonGia.Value < 0)
            {
                MessageBox.Show("Đơn giá không được âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(cbLoaiChiPhi.SelectedItem?.ToString()))
            {
                MessageBox.Show("Vui lòng chọn loại chi phí!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInput()
        {
            cbLoaiChiPhi.SelectedIndex = 0; // Kích hoạt SelectedIndexChanged
            cboMoTa.SelectedIndex = cboMoTa.Items.Count > 0 ? 0 : -1;
            nudSoLuong.Value = 1;
            nudDonGia.Value = 0;
            lblThongBao.Text = "";
        }

        private void frmChiTietHoaDon_FormClosing(object sender, FormClosingEventArgs e)
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