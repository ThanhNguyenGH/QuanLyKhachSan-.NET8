using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Data.Seed
{
    public static class SeedThuePhong
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.ThuePhong.Any())
            {
                context.ThuePhong.AddRange(
                    new ThuePhong {  MaKhachHang = 1, MaPhong = 1, NgayNhanPhong = new DateTime(2025, 5, 20), NgayTraPhong = new DateTime(2025, 5, 22), TongChiPhi = 750000 },
                    new ThuePhong { MaKhachHang = 2, MaPhong = 2, NgayNhanPhong = new DateTime(2025, 5, 21), NgayTraPhong = new DateTime(2025, 5, 23), TongChiPhi = 1300000 },
                    new ThuePhong {  MaKhachHang = 3, MaPhong = 3, NgayNhanPhong = new DateTime(2025, 5, 22), NgayTraPhong = new DateTime(2025, 5, 24), TongChiPhi = 1700000 },
                    new ThuePhong { MaKhachHang = 4, MaPhong = 4, NgayNhanPhong = new DateTime(2025, 5, 23), NgayTraPhong = new DateTime(2025, 5, 25), TongChiPhi = 1100000 },
                    new ThuePhong {  MaKhachHang = 5, MaPhong = 5, NgayNhanPhong = new DateTime(2025, 5, 24), NgayTraPhong = new DateTime(2025, 5, 26), TongChiPhi = 1600000 }
                );
                context.SaveChanges();
            }
        }
    }
}