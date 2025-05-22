using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class frmThietBi : Form
    {
        private readonly ApplicationDbContext _context;

        public frmThietBi()
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

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            try
            {
                // Load danh sách phòng vào ComboBox
                cbMaPhong.DataSource = _context.Phong.ToList();
                cbMaPhong.DisplayMember = "SoPhong";
                cbMaPhong.ValueMember = "MaPhong";

                // Load dữ liệu thiết bị vào DataGridView
                LoadThietBi();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadThietBi()
        {
            try
            {
                var thietBis = _context.ThietBi
                    .Include(tb => tb.Phong)
                    .Select(tb => new
                    {
                        tb.MaThietBi,
                        tb.TenThietBi,
                        tb.SoLuong,
                        tb.MaPhong,
                        Phong = tb.Phong.SoPhong
                    })
                    .ToList();

                dgvThietBi.DataSource = thietBis;

                dgvThietBi.Columns["MaThietBi"].HeaderText = "Mã Thiết Bị";
                dgvThietBi.Columns["TenThietBi"].HeaderText = "Tên Thiết Bị";
                dgvThietBi.Columns["SoLuong"].HeaderText = "Số Lượng";
                dgvThietBi.Columns["MaPhong"].HeaderText = "Mã Phòng";
                dgvThietBi.Columns["Phong"].HeaderText = "Số Phòng";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách thiết bị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    var thietBi = new ThietBi
                    {
                        TenThietBi = txtTenThietBi.Text.Trim(),
                        SoLuong = (int)nudSoLuong.Value,
                        MaPhong = (int)cbMaPhong.SelectedValue
                    };

                    _context.ThietBi.Add(thietBi);
                    _context.SaveChanges();

                    MessageBox.Show("Thêm thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThietBi();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm thiết bị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThietBi.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn thiết bị để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ValidateInput())
                {
                    int maThietBi = (int)dgvThietBi.SelectedRows[0].Cells["MaThietBi"].Value;
                    var thietBi = _context.ThietBi.Find(maThietBi);

                    if (thietBi != null)
                    {
                        thietBi.TenThietBi = txtTenThietBi.Text.Trim();
                        thietBi.SoLuong = (int)nudSoLuong.Value;
                        thietBi.MaPhong = (int)cbMaPhong.SelectedValue;

                        _context.SaveChanges();

                        MessageBox.Show("Sửa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadThietBi();
                        ClearInput();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa thiết bị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThietBi.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn thiết bị để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc muốn xóa thiết bị này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int maThietBi = (int)dgvThietBi.SelectedRows[0].Cells["MaThietBi"].Value;
                    var thietBi = _context.ThietBi.Find(maThietBi);

                    if (thietBi != null)
                    {
                        _context.ThietBi.Remove(thietBi);
                        _context.SaveChanges();

                        MessageBox.Show("Xóa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadThietBi();
                        ClearInput();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa thiết bị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                ClearInput();
                LoadThietBi();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvThietBi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvThietBi.SelectedRows.Count > 0)
                {
                    var row = dgvThietBi.SelectedRows[0];
                    txtTenThietBi.Text = row.Cells["TenThietBi"].Value.ToString();
                    nudSoLuong.Value = (int)row.Cells["SoLuong"].Value;
                    cbMaPhong.SelectedValue = row.Cells["MaPhong"].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn thiết bị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtTenThietBi.Text.Trim()))
            {
                MessageBox.Show("Tên thiết bị không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbMaPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInput()
        {
            txtTenThietBi.Clear();
            nudSoLuong.Value = 1;
            cbMaPhong.SelectedIndex = -1;
            lblThongBao.Text = "";
        }

        private void frmThietBi_FormClosing(object sender, FormClosingEventArgs e)
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