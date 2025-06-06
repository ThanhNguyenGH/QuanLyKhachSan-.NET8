﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyKhachSan.Data;

#nullable disable

namespace QuanLyKhachSan.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250521150051_KhoiTaoCSDL2nd")]
    partial class KhoiTaoCSDL2nd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuanLyKhachSan.Models.BaoCao", b =>
                {
                    b.Property<int>("MaBaoCao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaBaoCao"));

                    b.Property<string>("KyBaoCao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TongDoanhThu")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MaBaoCao");

                    b.ToTable("BaoCao");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.ChiTietDichVu", b =>
                {
                    b.Property<int>("MaChiTietDichVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaChiTietDichVu"));

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MaDichVu")
                        .HasColumnType("int");

                    b.Property<int>("MaThuePhong")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiGianSuDung")
                        .HasColumnType("datetime2");

                    b.HasKey("MaChiTietDichVu");

                    b.HasIndex("MaDichVu");

                    b.HasIndex("MaThuePhong");

                    b.ToTable("ChiTietDichVu");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.ChiTietHoaDon", b =>
                {
                    b.Property<int>("MaChiTietHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaChiTietHoaDon"));

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("LoaiChiPhi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaHoaDon")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<decimal>("ThanhTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MaChiTietHoaDon");

                    b.HasIndex("MaHoaDon");

                    b.ToTable("ChiTietHoaDon");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.DatPhong", b =>
                {
                    b.Property<int>("MaDatPhong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDatPhong"));

                    b.Property<int>("MaKhachHang")
                        .HasColumnType("int");

                    b.Property<int>("MaPhong")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayDat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayNhanPhong")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDatPhong");

                    b.HasIndex("MaKhachHang");

                    b.HasIndex("MaPhong");

                    b.ToTable("DatPhong");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.DichVu", b =>
                {
                    b.Property<int>("MaDichVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDichVu"));

                    b.Property<decimal>("GiaDichVu")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TenDichVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDichVu");

                    b.ToTable("DichVu");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.HoaDon", b =>
                {
                    b.Property<int>("MaHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHoaDon"));

                    b.Property<int>("MaNguoiDung")
                        .HasColumnType("int");

                    b.Property<int>("MaThuePhong")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayLap")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TongChiPhi")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MaHoaDon");

                    b.HasIndex("MaNguoiDung");

                    b.HasIndex("MaThuePhong");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.KhachHang", b =>
                {
                    b.Property<int>("MaKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaKhachHang"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoCMND")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaKhachHang");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.NguoiDung", b =>
                {
                    b.Property<int>("MaNguoiDung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaNguoiDung"));

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDangNhap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VaiTro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNguoiDung");

                    b.ToTable("NguoiDung", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.Phong", b =>
                {
                    b.Property<int>("MaPhong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaPhong"));

                    b.Property<decimal>("GiaPhong")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("LoaiPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPhong");

                    b.ToTable("Phong");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.ThietBi", b =>
                {
                    b.Property<int>("MaThietBi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaThietBi"));

                    b.Property<int>("MaPhong")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenThietBi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaThietBi");

                    b.HasIndex("MaPhong");

                    b.ToTable("ThietBi");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.ThuePhong", b =>
                {
                    b.Property<int>("MaThuePhong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaThuePhong"));

                    b.Property<int>("MaKhachHang")
                        .HasColumnType("int");

                    b.Property<int>("MaPhong")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayNhanPhong")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTraPhong")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TongChiPhi")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MaThuePhong");

                    b.HasIndex("MaKhachHang");

                    b.HasIndex("MaPhong");

                    b.ToTable("ThuePhong");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.NhanVien", b =>
                {
                    b.HasBaseType("QuanLyKhachSan.Models.NguoiDung");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.QuanLy", b =>
                {
                    b.HasBaseType("QuanLyKhachSan.Models.NhanVien");

                    b.ToTable("QuanLy", (string)null);
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.ChiTietDichVu", b =>
                {
                    b.HasOne("QuanLyKhachSan.Models.DichVu", "DichVu")
                        .WithMany("ChiTietDichVu")
                        .HasForeignKey("MaDichVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyKhachSan.Models.ThuePhong", "ThuePhong")
                        .WithMany("ChiTietDichVu")
                        .HasForeignKey("MaThuePhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DichVu");

                    b.Navigation("ThuePhong");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.ChiTietHoaDon", b =>
                {
                    b.HasOne("QuanLyKhachSan.Models.HoaDon", "HoaDon")
                        .WithMany("ChiTietHoaDon")
                        .HasForeignKey("MaHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.DatPhong", b =>
                {
                    b.HasOne("QuanLyKhachSan.Models.KhachHang", "KhachHang")
                        .WithMany("DatPhong")
                        .HasForeignKey("MaKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyKhachSan.Models.Phong", "Phong")
                        .WithMany("DatPhong")
                        .HasForeignKey("MaPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("Phong");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.HoaDon", b =>
                {
                    b.HasOne("QuanLyKhachSan.Models.NguoiDung", "NguoiDung")
                        .WithMany("HoaDon")
                        .HasForeignKey("MaNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyKhachSan.Models.ThuePhong", "ThuePhong")
                        .WithMany("HoaDon")
                        .HasForeignKey("MaThuePhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");

                    b.Navigation("ThuePhong");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.ThietBi", b =>
                {
                    b.HasOne("QuanLyKhachSan.Models.Phong", "Phong")
                        .WithMany("ThietBi")
                        .HasForeignKey("MaPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Phong");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.ThuePhong", b =>
                {
                    b.HasOne("QuanLyKhachSan.Models.KhachHang", "KhachHang")
                        .WithMany("ThuePhong")
                        .HasForeignKey("MaKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanLyKhachSan.Models.Phong", "Phong")
                        .WithMany("ThuePhong")
                        .HasForeignKey("MaPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("Phong");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.NhanVien", b =>
                {
                    b.HasOne("QuanLyKhachSan.Models.NguoiDung", null)
                        .WithOne()
                        .HasForeignKey("QuanLyKhachSan.Models.NhanVien", "MaNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.QuanLy", b =>
                {
                    b.HasOne("QuanLyKhachSan.Models.NhanVien", null)
                        .WithOne()
                        .HasForeignKey("QuanLyKhachSan.Models.QuanLy", "MaNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.DichVu", b =>
                {
                    b.Navigation("ChiTietDichVu");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.HoaDon", b =>
                {
                    b.Navigation("ChiTietHoaDon");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.KhachHang", b =>
                {
                    b.Navigation("DatPhong");

                    b.Navigation("ThuePhong");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.NguoiDung", b =>
                {
                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.Phong", b =>
                {
                    b.Navigation("DatPhong");

                    b.Navigation("ThietBi");

                    b.Navigation("ThuePhong");
                });

            modelBuilder.Entity("QuanLyKhachSan.Models.ThuePhong", b =>
                {
                    b.Navigation("ChiTietDichVu");

                    b.Navigation("HoaDon");
                });
#pragma warning restore 612, 618
        }
    }
}
