using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Data.Seed
{
    public static class SeedChiTietHoaDon
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.ChiTietHoaDon.Any())
            {
                context.ChiTietHoaDon.AddRange(
                    new ChiTietHoaDon {  MaHoaDon = 1, LoaiChiPhi = "Phòng", MoTa = "Phòng Standard", SoLuong = 1, DonGia = 500000, ThanhTien = 500000 },
                    new ChiTietHoaDon { MaHoaDon = 1, LoaiChiPhi = "Dịch vụ", MoTa = "Ăn sáng", SoLuong = 2, DonGia = 100000, ThanhTien = 200000 },
                    new ChiTietHoaDon {  MaHoaDon = 2, LoaiChiPhi = "Phòng", MoTa = "Phòng Deluxe", SoLuong = 1, DonGia = 1000000, ThanhTien = 1000000 },
                    new ChiTietHoaDon { MaHoaDon = 2, LoaiChiPhi = "Dịch vụ", MoTa = "Spa", SoLuong = 1, DonGia = 300000, ThanhTien = 300000 },
                    new ChiTietHoaDon { MaHoaDon = 3, LoaiChiPhi = "Phòng", MoTa = "Phòng Suite", SoLuong = 1, DonGia = 1500000, ThanhTien = 1500000 }
                );
                context.SaveChanges();
            }
        }
    }
}