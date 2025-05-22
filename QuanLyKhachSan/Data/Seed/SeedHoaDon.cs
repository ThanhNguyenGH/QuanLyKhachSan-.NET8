using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Data.Seed
{
    public static class SeedHoaDon
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.HoaDon.Any())
            {
                context.HoaDon.AddRange(
                    new HoaDon {  MaNguoiDung = 1, MaThuePhong = 1, TongChiPhi = 750000, NgayLap = new DateTime(2025, 5, 22) },
                    new HoaDon { MaNguoiDung = 2, MaThuePhong = 2, TongChiPhi = 1300000, NgayLap = new DateTime(2025, 5, 23) },
                    new HoaDon {  MaNguoiDung = 3, MaThuePhong = 3, TongChiPhi = 1700000, NgayLap = new DateTime(2025, 5, 24) },
                    new HoaDon { MaNguoiDung = 4, MaThuePhong = 4, TongChiPhi = 1100000, NgayLap = new DateTime(2025, 5, 25) },
                    new HoaDon { MaNguoiDung = 1, MaThuePhong = 5, TongChiPhi = 1600000, NgayLap = new DateTime(2025, 5, 26) }
                );
                context.SaveChanges();
            }
        }
    }
}