using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet cho các model (bỏ chữ "s")
        public DbSet<ChiTietDichVu> ChiTietDichVu { get; set; }
        public DbSet<BaoCao> BaoCao { get; set; }
        public DbSet<ThietBi> ThietBi { get; set; }
        public DbSet<Phong> Phong { get; set; }
        public DbSet<ThuePhong> ThuePhong { get; set; }
        public DbSet<NguoiDung> NguoiDung { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<QuanLy> QuanLy { get; set; }
        public DbSet<DatPhong> DatPhong { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public DbSet<DichVu> DichVu { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình khóa chính và mối quan hệ

            // ChiTietDichVu
            modelBuilder.Entity<ChiTietDichVu>()
                .HasKey(ctdv => ctdv.MaChiTietDichVu);
            modelBuilder.Entity<ChiTietDichVu>()
                .HasOne(ctdv => ctdv.ThuePhong)
                .WithMany(tp => tp.ChiTietDichVu)
                .HasForeignKey(ctdv => ctdv.MaThuePhong);
            modelBuilder.Entity<ChiTietDichVu>()
                .HasOne(ctdv => ctdv.DichVu)
                .WithMany(dv => dv.ChiTietDichVu)
                .HasForeignKey(ctdv => ctdv.MaDichVu);

            // BaoCao
            modelBuilder.Entity<BaoCao>()
                .HasKey(bc => bc.MaBaoCao);

            // ThietBi
            modelBuilder.Entity<ThietBi>()
                .HasKey(tb => tb.MaThietBi);
            modelBuilder.Entity<ThietBi>()
                .HasOne(tb => tb.Phong)
                .WithMany(p => p.ThietBi)
                .HasForeignKey(tb => tb.MaPhong);

            // Phong
            modelBuilder.Entity<Phong>()
                .HasKey(p => p.MaPhong);

            // ThuePhong
            modelBuilder.Entity<ThuePhong>()
                .HasKey(tp => tp.MaThuePhong);
            modelBuilder.Entity<ThuePhong>()
                .HasOne(tp => tp.KhachHang)
                .WithMany(kh => kh.ThuePhong)
                .HasForeignKey(tp => tp.MaKhachHang);
            modelBuilder.Entity<ThuePhong>()
                .HasOne(tp => tp.Phong)
                .WithMany(p => p.ThuePhong)
                .HasForeignKey(tp => tp.MaPhong);

            // NguoiDung (sử dụng TPT để bỏ Discriminator)
            modelBuilder.Entity<NguoiDung>()
                .ToTable("NguoiDung")
                .HasKey(nd => nd.MaNguoiDung);
            modelBuilder.Entity<NhanVien>()
                .ToTable("NhanVien")
                .HasBaseType<NguoiDung>();
            modelBuilder.Entity<QuanLy>()
                .ToTable("QuanLy")
                .HasBaseType<NhanVien>();

            // DatPhong
            modelBuilder.Entity<DatPhong>()
                .HasKey(dp => dp.MaDatPhong);
            modelBuilder.Entity<DatPhong>()
                .HasOne(dp => dp.KhachHang)
                .WithMany(kh => kh.DatPhong)
                .HasForeignKey(dp => dp.MaKhachHang);
            modelBuilder.Entity<DatPhong>()
                .HasOne(dp => dp.Phong)
                .WithMany(p => p.DatPhong)
                .HasForeignKey(dp => dp.MaPhong);

            // HoaDon
            modelBuilder.Entity<HoaDon>()
                .HasKey(hd => hd.MaHoaDon);
            modelBuilder.Entity<HoaDon>()
                .HasOne(hd => hd.NguoiDung)
                .WithMany(nd => nd.HoaDon)
                .HasForeignKey(hd => hd.MaNguoiDung);
            modelBuilder.Entity<HoaDon>()
                .HasOne(hd => hd.ThuePhong)
                .WithMany(tp => tp.HoaDon)
                .HasForeignKey(hd => hd.MaThuePhong);

            // ChiTietHoaDon
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasKey(cthd => cthd.MaChiTietHoaDon);
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(cthd => cthd.HoaDon)
                .WithMany(hd => hd.ChiTietHoaDon)
                .HasForeignKey(cthd => cthd.MaHoaDon);

            // DichVu
            modelBuilder.Entity<DichVu>()
                .HasKey(dv => dv.MaDichVu);

            // KhachHang
            modelBuilder.Entity<KhachHang>()
                .HasKey(kh => kh.MaKhachHang);
        }
    }
}