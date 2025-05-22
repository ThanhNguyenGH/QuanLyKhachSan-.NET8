using QuanLyKhachSan.Data;
using QuanLyKhachSan.Data.Seed;

namespace QuanLyKhachSan.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Chỉ seed nếu chưa có dữ liệu
            if (!context.KhachHang.Any())
            {
                SeedKhachHang.Seed(context);
                SeedPhong.Seed(context);
                SeedThietBi.Seed(context);
                SeedDichVu.Seed(context);
                SeedNhanVien.Seed(context);
                SeedThuePhong.Seed(context);
                SeedDatPhong.Seed(context);
                SeedHoaDon.Seed(context);
                SeedChiTietHoaDon.Seed(context);
                SeedChiTietDichVu.Seed(context);
                SeedBaoCao.Seed(context);

                context.SaveChanges();
            }
        }
    }
}