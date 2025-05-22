using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaoCaos",
                columns: table => new
                {
                    MaBaoCao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KyBaoCao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TongDoanhThu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaoCaos", x => x.MaBaoCao);
                });

            migrationBuilder.CreateTable(
                name: "DichVus",
                columns: table => new
                {
                    MaDichVu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDichVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaDichVu = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVus", x => x.MaDichVu);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    MaKhachHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoCMND = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.MaKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDungs",
                columns: table => new
                {
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDangNhap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDungs", x => x.MaNguoiDung);
                });

            migrationBuilder.CreateTable(
                name: "Phongs",
                columns: table => new
                {
                    MaPhong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoPhong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiPhong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaPhong = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phongs", x => x.MaPhong);
                });

            migrationBuilder.CreateTable(
                name: "DatPhongs",
                columns: table => new
                {
                    MaDatPhong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhachHang = table.Column<int>(type: "int", nullable: false),
                    MaPhong = table.Column<int>(type: "int", nullable: false),
                    NgayDat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayNhanPhong = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatPhongs", x => x.MaDatPhong);
                    table.ForeignKey(
                        name: "FK_DatPhongs_KhachHangs_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DatPhongs_Phongs_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "Phongs",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThietBis",
                columns: table => new
                {
                    MaThietBi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThietBi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MaPhong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThietBis", x => x.MaThietBi);
                    table.ForeignKey(
                        name: "FK_ThietBis_Phongs_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "Phongs",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThuePhongs",
                columns: table => new
                {
                    MaThuePhong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhachHang = table.Column<int>(type: "int", nullable: false),
                    MaPhong = table.Column<int>(type: "int", nullable: false),
                    NgayNhanPhong = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTraPhong = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongChiPhi = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuePhongs", x => x.MaThuePhong);
                    table.ForeignKey(
                        name: "FK_ThuePhongs_KhachHangs_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThuePhongs_Phongs_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "Phongs",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDichVus",
                columns: table => new
                {
                    MaChiTietDichVu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThuePhong = table.Column<int>(type: "int", nullable: false),
                    MaDichVu = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    ThoiGianSuDung = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDichVus", x => x.MaChiTietDichVu);
                    table.ForeignKey(
                        name: "FK_ChiTietDichVus_DichVus_MaDichVu",
                        column: x => x.MaDichVu,
                        principalTable: "DichVus",
                        principalColumn: "MaDichVu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDichVus_ThuePhongs_MaThuePhong",
                        column: x => x.MaThuePhong,
                        principalTable: "ThuePhongs",
                        principalColumn: "MaThuePhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    MaHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false),
                    MaThuePhong = table.Column<int>(type: "int", nullable: false),
                    TongChiPhi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDons_NguoiDungs_MaNguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NguoiDungs",
                        principalColumn: "MaNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDons_ThuePhongs_MaThuePhong",
                        column: x => x.MaThuePhong,
                        principalTable: "ThuePhongs",
                        principalColumn: "MaThuePhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDons",
                columns: table => new
                {
                    MaChiTietHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHoaDon = table.Column<int>(type: "int", nullable: false),
                    LoaiChiPhi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDons", x => x.MaChiTietHoaDon);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDons_HoaDons_MaHoaDon",
                        column: x => x.MaHoaDon,
                        principalTable: "HoaDons",
                        principalColumn: "MaHoaDon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDichVus_MaDichVu",
                table: "ChiTietDichVus",
                column: "MaDichVu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDichVus_MaThuePhong",
                table: "ChiTietDichVus",
                column: "MaThuePhong");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDons_MaHoaDon",
                table: "ChiTietHoaDons",
                column: "MaHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_DatPhongs_MaKhachHang",
                table: "DatPhongs",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_DatPhongs_MaPhong",
                table: "DatPhongs",
                column: "MaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_MaNguoiDung",
                table: "HoaDons",
                column: "MaNguoiDung");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_MaThuePhong",
                table: "HoaDons",
                column: "MaThuePhong");

            migrationBuilder.CreateIndex(
                name: "IX_ThietBis_MaPhong",
                table: "ThietBis",
                column: "MaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_ThuePhongs_MaKhachHang",
                table: "ThuePhongs",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_ThuePhongs_MaPhong",
                table: "ThuePhongs",
                column: "MaPhong");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaoCaos");

            migrationBuilder.DropTable(
                name: "ChiTietDichVus");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDons");

            migrationBuilder.DropTable(
                name: "DatPhongs");

            migrationBuilder.DropTable(
                name: "ThietBis");

            migrationBuilder.DropTable(
                name: "DichVus");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "NguoiDungs");

            migrationBuilder.DropTable(
                name: "ThuePhongs");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "Phongs");
        }
    }
}
