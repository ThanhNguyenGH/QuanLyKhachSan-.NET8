using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Data.Seed
{
    public static class SeedBaoCao
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.BaoCao.Any())
            {
                context.BaoCao.AddRange(
                    new BaoCao {  KyBaoCao = "Tháng 5/2025", TongDoanhThu = 7450000, NgayBatDau = new DateTime(2025, 5, 1), NgayKetThuc = new DateTime(2025, 5, 31) },
                    new BaoCao { KyBaoCao = "Quý 2/2025", TongDoanhThu = 15000000, NgayBatDau = new DateTime(2025, 4, 1), NgayKetThuc = new DateTime(2025, 6, 30) },
                    new BaoCao { KyBaoCao = "Tháng 4/2025", TongDoanhThu = 5000000, NgayBatDau = new DateTime(2025, 4, 1), NgayKetThuc = new DateTime(2025, 4, 30) }
                );
                context.SaveChanges();
            }
        }
    }
}