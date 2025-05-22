using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Data.Seed
{
    public static class SeedChiTietDichVu
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.ChiTietDichVu.Any())
            {
                context.ChiTietDichVu.AddRange(
                    new ChiTietDichVu { MaThuePhong = 1, MaDichVu = 1, SoLuong = 2, ThoiGianSuDung = new DateTime(2025, 5, 20), DonGia = 100000, ThanhTien = 2 * 100000 },
                    new ChiTietDichVu { MaThuePhong = 1, MaDichVu = 2, SoLuong = 1, ThoiGianSuDung = new DateTime(2025, 5, 21), DonGia = 50000, ThanhTien = 1 * 50000 },
                    new ChiTietDichVu { MaThuePhong = 2, MaDichVu = 3, SoLuong = 1, ThoiGianSuDung = new DateTime(2025, 5, 21), DonGia = 300000, ThanhTien = 1 * 300000 },
                    new ChiTietDichVu { MaThuePhong = 3, MaDichVu = 4, SoLuong = 1, ThoiGianSuDung = new DateTime(2025, 5, 22), DonGia = 200000, ThanhTien = 1 * 200000 },
                    new ChiTietDichVu { MaThuePhong = 4, MaDichVu = 5, SoLuong = 1, ThoiGianSuDung = new DateTime(2025, 5, 23), DonGia = 500000, ThanhTien = 1 * 500000 }
                );
                context.SaveChanges();
            }
        }
    }
}