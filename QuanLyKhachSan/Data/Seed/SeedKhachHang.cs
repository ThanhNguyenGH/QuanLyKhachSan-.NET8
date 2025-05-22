using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Data.Seed
{
    public static class SeedKhachHang
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.KhachHang.Any())
            {
                context.KhachHang.AddRange(
                    new KhachHang { HoTen = "Nguyen Van A", SoCMND = "123456789", SoDienThoai = "0901234567", DiaChi = "123 Le Loi, TP HCM" },
                    new KhachHang { HoTen = "Tran Thi B", SoCMND = "987654321", SoDienThoai = "0912345678", DiaChi = "456 Tran Hung Dao, Ha Noi" },
                    new KhachHang { HoTen = "Le Van C", SoCMND = "456789123", SoDienThoai = "0923456789", DiaChi = "789 Nguyen Trai, Da Nang" },
                    new KhachHang { HoTen = "Pham Thi D", SoCMND = "321654987", SoDienThoai = "0934567890", DiaChi = "101 Ly Thuong Kiet, Hue" },
                    new KhachHang { HoTen = "Hoang Van E", SoCMND = "654987321", SoDienThoai = "0945678901", DiaChi = "202 Ba Trieu, Can Tho" }
                );
                context.SaveChanges();
            }
        }
    }
}