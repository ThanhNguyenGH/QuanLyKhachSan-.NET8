using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Data;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyKhachSan.Forms
{
    public partial class frmDangNhap : Form
    {
        private readonly ApplicationDbContext _context;

        public frmDangNhap()
        {
            InitializeComponent();
            // Khởi tạo DbContext
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer("Server=.;Database=QuanLyKhachSan;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True")
                .Options;
            _context = new ApplicationDbContext(options);
        }

        // Xử lý sự kiện khi nhấn nút Đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // Kiểm tra input
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                lblThongBao.Text = "Vui lòng nhập tên đăng nhập và mật khẩu!";
                return;
            }

            // Tìm người dùng theo tên đăng nhập
            var nguoiDung = _context.NguoiDung
                .FirstOrDefault(nd => nd.TenDangNhap == tenDangNhap);

            // Kiểm tra người dùng tồn tại và xác minh mật khẩu bằng BCrypt
            if (nguoiDung == null || !BCrypt.Net.BCrypt.Verify(matKhau, nguoiDung.MatKhau))
            {
                lblThongBao.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
                return;
            }
         
            // Mở frmMain và truyền thông tin người dùng (nếu cần)
            frmMain mainForm = new frmMain(nguoiDung);
            mainForm.Show();

            // Ẩn frmDangNhap
            this.Hide();
        }


        // Xử lý sự kiện khi nhấn nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {      
                Application.Exit(); 
        }

        // Xử lý sự kiện khi form đóng
        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose(); // Giải phóng DbContext
        }
    }
}