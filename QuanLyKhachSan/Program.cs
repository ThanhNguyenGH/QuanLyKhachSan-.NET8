using QuanLyKhachSan.Forms;
using QuanLyKhachSan.Data.Seed;
using QuanLyKhachSan.Data;
using Microsoft.EntityFrameworkCore;


namespace QuanLyKhachSan
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Seed dữ liệu
            using (var context = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer("Server=.;Database=QuanLyKhachSan;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True")
                .Options))
            {
                SeedData.Initialize(context);
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new frmDangNhap());
        }
    }
}