using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Data.Seed
{
    public static class SeedNhanVien
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.NhanVien.Any())
            {
                string passwordHash = BCrypt.Net.BCrypt.HashPassword("123");
                context.NhanVien.AddRange(
                    new QuanLy
                    {
                        TenDangNhap = "admin",
                        MatKhau = passwordHash,
                        VaiTro = "QuanLy",
                        HoTen = "Pham Thi D",
                        SoDienThoai = "0945678901",
                        Email = "quanly1@khachsan.com"
                    },
                    new NhanVien
                    {
                        TenDangNhap = "nv1",
                        MatKhau = passwordHash,
                        VaiTro = "NhanVien",
                        HoTen = "Le Van C",
                        SoDienThoai = "0923456789",
                        Email = "nhanvien1@khachsan.com"
                    },
                    new NhanVien
                    {
                        TenDangNhap = "nv2",
                        MatKhau = passwordHash,
                        VaiTro = "NhanVien",
                        HoTen = "Nguyen Thi E",
                        SoDienThoai = "0934567890",
                        Email = "nhanvien2@khachsan.com"
                    },
                    new NhanVien
                    {
                        TenDangNhap = "nv3",
                        MatKhau = passwordHash,
                        VaiTro = "NhanVien",
                        HoTen = "Hoang Van F",
                        SoDienThoai = "0956789012",
                        Email = "nhanvien3@khachsan.com"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}