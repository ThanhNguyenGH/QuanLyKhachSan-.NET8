using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Data.Seed
{
    public static class SeedDatPhong
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.DatPhong.Any())
            {
                context.DatPhong.AddRange(
                    new DatPhong {  MaKhachHang = 1, MaPhong = 1, NgayDat = new DateTime(2025, 5, 18), NgayNhanPhong = new DateTime(2025, 5, 20), TrangThai = "Đã xác nhận" },
                    new DatPhong { MaKhachHang = 2, MaPhong = 2, NgayDat = new DateTime(2025, 5, 19), NgayNhanPhong = new DateTime(2025, 5, 21), TrangThai = "Đã xác nhận" },
                    new DatPhong { MaKhachHang = 3, MaPhong = 3, NgayDat = new DateTime(2025, 5, 20), NgayNhanPhong = new DateTime(2025, 5, 22), TrangThai = "Đã xác nhận" },
                    new DatPhong { MaKhachHang = 4, MaPhong = 4, NgayDat = new DateTime(2025, 5, 21), NgayNhanPhong = new DateTime(2025, 5, 23), TrangThai = "Đã xác nhận" },
                    new DatPhong { MaKhachHang = 5, MaPhong = 5, NgayDat = new DateTime(2025, 5, 22), NgayNhanPhong = new DateTime(2025, 5, 24), TrangThai = "Đã xác nhận" }
                );
                context.SaveChanges();
            }
        }
    }
}