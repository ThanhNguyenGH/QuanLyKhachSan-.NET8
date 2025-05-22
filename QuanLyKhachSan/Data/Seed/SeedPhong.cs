using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Data.Seed
{
    public static class SeedPhong
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Phong.Any())
            {
                context.Phong.AddRange(
                    new Phong {  SoPhong = "101", LoaiPhong = "Standard", GiaPhong = 500000, TrangThai = "Trống" },
                    new Phong { SoPhong = "202", LoaiPhong = "Deluxe", GiaPhong = 1000000, TrangThai = "Trống" },
                    new Phong {  SoPhong = "303", LoaiPhong = "Suite", GiaPhong = 1500000, TrangThai = "Trống" },
                    new Phong { SoPhong = "404", LoaiPhong = "Standard", GiaPhong = 600000, TrangThai = "Đã thuê" },
                    new Phong { SoPhong = "505", LoaiPhong = "Deluxe", GiaPhong = 1100000, TrangThai = "Trống" }
                );
                context.SaveChanges();
            }
        }
    }
}