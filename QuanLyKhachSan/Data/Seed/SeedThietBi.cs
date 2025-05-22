using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Data.Seed
{
    public static class SeedThietBi
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.ThietBi.Any())
            {
                context.ThietBi.AddRange(
                    new ThietBi {  TenThietBi = "Điều hòa", SoLuong = 2, MaPhong = 1 },
                    new ThietBi { TenThietBi = "Tivi", SoLuong = 1, MaPhong = 1 },
                    new ThietBi { TenThietBi = "Máy sấy tóc", SoLuong = 1, MaPhong = 2 },
                    new ThietBi {  TenThietBi = "Tủ lạnh", SoLuong = 1, MaPhong = 2 },
                    new ThietBi { TenThietBi = "Bàn là", SoLuong = 1, MaPhong = 3 }
                );
                context.SaveChanges();
            }
        }
    }
}