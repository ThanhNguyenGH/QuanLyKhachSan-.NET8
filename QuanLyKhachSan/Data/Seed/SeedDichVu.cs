using QuanLyKhachSan.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Data.Seed
{
    public static class SeedDichVu
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.DichVu.Any())
            {
                context.DichVu.AddRange(
                    new DichVu {  TenDichVu = "Ăn sáng", GiaDichVu = 100000 },
                    new DichVu { TenDichVu = "Giặt là", GiaDichVu = 50000 },
                    new DichVu { TenDichVu = "Spa", GiaDichVu = 300000 },
                    new DichVu {  TenDichVu = "Đưa đón sân bay", GiaDichVu = 200000 },
                    new DichVu { TenDichVu = "Thuê xe", GiaDichVu = 500000 }
                );
                context.SaveChanges();
            }
        }
    }
}