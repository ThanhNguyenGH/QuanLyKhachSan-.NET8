using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL2nd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDichVus_DichVus_MaDichVu",
                table: "ChiTietDichVus");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDichVus_ThuePhongs_MaThuePhong",
                table: "ChiTietDichVus");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDons_HoaDons_MaHoaDon",
                table: "ChiTietHoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_DatPhongs_KhachHangs_MaKhachHang",
                table: "DatPhongs");

            migrationBuilder.DropForeignKey(
                name: "FK_DatPhongs_Phongs_MaPhong",
                table: "DatPhongs");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_NguoiDungs_MaNguoiDung",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_ThuePhongs_MaThuePhong",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_ThietBis_Phongs_MaPhong",
                table: "ThietBis");

            migrationBuilder.DropForeignKey(
                name: "FK_ThuePhongs_KhachHangs_MaKhachHang",
                table: "ThuePhongs");

            migrationBuilder.DropForeignKey(
                name: "FK_ThuePhongs_Phongs_MaPhong",
                table: "ThuePhongs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThuePhongs",
                table: "ThuePhongs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThietBis",
                table: "ThietBis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phongs",
                table: "Phongs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NguoiDungs",
                table: "NguoiDungs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDons",
                table: "HoaDons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DichVus",
                table: "DichVus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DatPhongs",
                table: "DatPhongs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietHoaDons",
                table: "ChiTietHoaDons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietDichVus",
                table: "ChiTietDichVus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaoCaos",
                table: "BaoCaos");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "NguoiDungs");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "NguoiDungs");

            migrationBuilder.DropColumn(
                name: "HoTen",
                table: "NguoiDungs");

            migrationBuilder.DropColumn(
                name: "SoDienThoai",
                table: "NguoiDungs");

            migrationBuilder.RenameTable(
                name: "ThuePhongs",
                newName: "ThuePhong");

            migrationBuilder.RenameTable(
                name: "ThietBis",
                newName: "ThietBi");

            migrationBuilder.RenameTable(
                name: "Phongs",
                newName: "Phong");

            migrationBuilder.RenameTable(
                name: "NguoiDungs",
                newName: "NguoiDung");

            migrationBuilder.RenameTable(
                name: "KhachHangs",
                newName: "KhachHang");

            migrationBuilder.RenameTable(
                name: "HoaDons",
                newName: "HoaDon");

            migrationBuilder.RenameTable(
                name: "DichVus",
                newName: "DichVu");

            migrationBuilder.RenameTable(
                name: "DatPhongs",
                newName: "DatPhong");

            migrationBuilder.RenameTable(
                name: "ChiTietHoaDons",
                newName: "ChiTietHoaDon");

            migrationBuilder.RenameTable(
                name: "ChiTietDichVus",
                newName: "ChiTietDichVu");

            migrationBuilder.RenameTable(
                name: "BaoCaos",
                newName: "BaoCao");

            migrationBuilder.RenameIndex(
                name: "IX_ThuePhongs_MaPhong",
                table: "ThuePhong",
                newName: "IX_ThuePhong_MaPhong");

            migrationBuilder.RenameIndex(
                name: "IX_ThuePhongs_MaKhachHang",
                table: "ThuePhong",
                newName: "IX_ThuePhong_MaKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_ThietBis_MaPhong",
                table: "ThietBi",
                newName: "IX_ThietBi_MaPhong");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDons_MaThuePhong",
                table: "HoaDon",
                newName: "IX_HoaDon_MaThuePhong");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDons_MaNguoiDung",
                table: "HoaDon",
                newName: "IX_HoaDon_MaNguoiDung");

            migrationBuilder.RenameIndex(
                name: "IX_DatPhongs_MaPhong",
                table: "DatPhong",
                newName: "IX_DatPhong_MaPhong");

            migrationBuilder.RenameIndex(
                name: "IX_DatPhongs_MaKhachHang",
                table: "DatPhong",
                newName: "IX_DatPhong_MaKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietHoaDons_MaHoaDon",
                table: "ChiTietHoaDon",
                newName: "IX_ChiTietHoaDon_MaHoaDon");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietDichVus_MaThuePhong",
                table: "ChiTietDichVu",
                newName: "IX_ChiTietDichVu_MaThuePhong");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietDichVus_MaDichVu",
                table: "ChiTietDichVu",
                newName: "IX_ChiTietDichVu_MaDichVu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThuePhong",
                table: "ThuePhong",
                column: "MaThuePhong");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThietBi",
                table: "ThietBi",
                column: "MaThietBi");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phong",
                table: "Phong",
                column: "MaPhong");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NguoiDung",
                table: "NguoiDung",
                column: "MaNguoiDung");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang",
                column: "MaKhachHang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDon",
                table: "HoaDon",
                column: "MaHoaDon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DichVu",
                table: "DichVu",
                column: "MaDichVu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DatPhong",
                table: "DatPhong",
                column: "MaDatPhong");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietHoaDon",
                table: "ChiTietHoaDon",
                column: "MaChiTietHoaDon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietDichVu",
                table: "ChiTietDichVu",
                column: "MaChiTietDichVu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaoCao",
                table: "BaoCao",
                column: "MaBaoCao");

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNguoiDung);
                    table.ForeignKey(
                        name: "FK_NhanVien_NguoiDung_MaNguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "MaNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuanLy",
                columns: table => new
                {
                    MaNguoiDung = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanLy", x => x.MaNguoiDung);
                    table.ForeignKey(
                        name: "FK_QuanLy_NhanVien_MaNguoiDung",
                        column: x => x.MaNguoiDung,
                        principalTable: "NhanVien",
                        principalColumn: "MaNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDichVu_DichVu_MaDichVu",
                table: "ChiTietDichVu",
                column: "MaDichVu",
                principalTable: "DichVu",
                principalColumn: "MaDichVu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDichVu_ThuePhong_MaThuePhong",
                table: "ChiTietDichVu",
                column: "MaThuePhong",
                principalTable: "ThuePhong",
                principalColumn: "MaThuePhong",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_HoaDon_MaHoaDon",
                table: "ChiTietHoaDon",
                column: "MaHoaDon",
                principalTable: "HoaDon",
                principalColumn: "MaHoaDon",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DatPhong_KhachHang_MaKhachHang",
                table: "DatPhong",
                column: "MaKhachHang",
                principalTable: "KhachHang",
                principalColumn: "MaKhachHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DatPhong_Phong_MaPhong",
                table: "DatPhong",
                column: "MaPhong",
                principalTable: "Phong",
                principalColumn: "MaPhong",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NguoiDung_MaNguoiDung",
                table: "HoaDon",
                column: "MaNguoiDung",
                principalTable: "NguoiDung",
                principalColumn: "MaNguoiDung",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_ThuePhong_MaThuePhong",
                table: "HoaDon",
                column: "MaThuePhong",
                principalTable: "ThuePhong",
                principalColumn: "MaThuePhong",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThietBi_Phong_MaPhong",
                table: "ThietBi",
                column: "MaPhong",
                principalTable: "Phong",
                principalColumn: "MaPhong",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThuePhong_KhachHang_MaKhachHang",
                table: "ThuePhong",
                column: "MaKhachHang",
                principalTable: "KhachHang",
                principalColumn: "MaKhachHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThuePhong_Phong_MaPhong",
                table: "ThuePhong",
                column: "MaPhong",
                principalTable: "Phong",
                principalColumn: "MaPhong",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDichVu_DichVu_MaDichVu",
                table: "ChiTietDichVu");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDichVu_ThuePhong_MaThuePhong",
                table: "ChiTietDichVu");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_HoaDon_MaHoaDon",
                table: "ChiTietHoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_DatPhong_KhachHang_MaKhachHang",
                table: "DatPhong");

            migrationBuilder.DropForeignKey(
                name: "FK_DatPhong_Phong_MaPhong",
                table: "DatPhong");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NguoiDung_MaNguoiDung",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_ThuePhong_MaThuePhong",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_ThietBi_Phong_MaPhong",
                table: "ThietBi");

            migrationBuilder.DropForeignKey(
                name: "FK_ThuePhong_KhachHang_MaKhachHang",
                table: "ThuePhong");

            migrationBuilder.DropForeignKey(
                name: "FK_ThuePhong_Phong_MaPhong",
                table: "ThuePhong");

            migrationBuilder.DropTable(
                name: "QuanLy");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThuePhong",
                table: "ThuePhong");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThietBi",
                table: "ThietBi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phong",
                table: "Phong");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NguoiDung",
                table: "NguoiDung");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDon",
                table: "HoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DichVu",
                table: "DichVu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DatPhong",
                table: "DatPhong");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietHoaDon",
                table: "ChiTietHoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietDichVu",
                table: "ChiTietDichVu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaoCao",
                table: "BaoCao");

            migrationBuilder.RenameTable(
                name: "ThuePhong",
                newName: "ThuePhongs");

            migrationBuilder.RenameTable(
                name: "ThietBi",
                newName: "ThietBis");

            migrationBuilder.RenameTable(
                name: "Phong",
                newName: "Phongs");

            migrationBuilder.RenameTable(
                name: "NguoiDung",
                newName: "NguoiDungs");

            migrationBuilder.RenameTable(
                name: "KhachHang",
                newName: "KhachHangs");

            migrationBuilder.RenameTable(
                name: "HoaDon",
                newName: "HoaDons");

            migrationBuilder.RenameTable(
                name: "DichVu",
                newName: "DichVus");

            migrationBuilder.RenameTable(
                name: "DatPhong",
                newName: "DatPhongs");

            migrationBuilder.RenameTable(
                name: "ChiTietHoaDon",
                newName: "ChiTietHoaDons");

            migrationBuilder.RenameTable(
                name: "ChiTietDichVu",
                newName: "ChiTietDichVus");

            migrationBuilder.RenameTable(
                name: "BaoCao",
                newName: "BaoCaos");

            migrationBuilder.RenameIndex(
                name: "IX_ThuePhong_MaPhong",
                table: "ThuePhongs",
                newName: "IX_ThuePhongs_MaPhong");

            migrationBuilder.RenameIndex(
                name: "IX_ThuePhong_MaKhachHang",
                table: "ThuePhongs",
                newName: "IX_ThuePhongs_MaKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_ThietBi_MaPhong",
                table: "ThietBis",
                newName: "IX_ThietBis_MaPhong");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDon_MaThuePhong",
                table: "HoaDons",
                newName: "IX_HoaDons_MaThuePhong");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDon_MaNguoiDung",
                table: "HoaDons",
                newName: "IX_HoaDons_MaNguoiDung");

            migrationBuilder.RenameIndex(
                name: "IX_DatPhong_MaPhong",
                table: "DatPhongs",
                newName: "IX_DatPhongs_MaPhong");

            migrationBuilder.RenameIndex(
                name: "IX_DatPhong_MaKhachHang",
                table: "DatPhongs",
                newName: "IX_DatPhongs_MaKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietHoaDon_MaHoaDon",
                table: "ChiTietHoaDons",
                newName: "IX_ChiTietHoaDons_MaHoaDon");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietDichVu_MaThuePhong",
                table: "ChiTietDichVus",
                newName: "IX_ChiTietDichVus_MaThuePhong");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietDichVu_MaDichVu",
                table: "ChiTietDichVus",
                newName: "IX_ChiTietDichVus_MaDichVu");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "NguoiDungs",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "NguoiDungs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HoTen",
                table: "NguoiDungs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SoDienThoai",
                table: "NguoiDungs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThuePhongs",
                table: "ThuePhongs",
                column: "MaThuePhong");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThietBis",
                table: "ThietBis",
                column: "MaThietBi");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phongs",
                table: "Phongs",
                column: "MaPhong");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NguoiDungs",
                table: "NguoiDungs",
                column: "MaNguoiDung");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs",
                column: "MaKhachHang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDons",
                table: "HoaDons",
                column: "MaHoaDon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DichVus",
                table: "DichVus",
                column: "MaDichVu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DatPhongs",
                table: "DatPhongs",
                column: "MaDatPhong");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietHoaDons",
                table: "ChiTietHoaDons",
                column: "MaChiTietHoaDon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietDichVus",
                table: "ChiTietDichVus",
                column: "MaChiTietDichVu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaoCaos",
                table: "BaoCaos",
                column: "MaBaoCao");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDichVus_DichVus_MaDichVu",
                table: "ChiTietDichVus",
                column: "MaDichVu",
                principalTable: "DichVus",
                principalColumn: "MaDichVu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDichVus_ThuePhongs_MaThuePhong",
                table: "ChiTietDichVus",
                column: "MaThuePhong",
                principalTable: "ThuePhongs",
                principalColumn: "MaThuePhong",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDons_HoaDons_MaHoaDon",
                table: "ChiTietHoaDons",
                column: "MaHoaDon",
                principalTable: "HoaDons",
                principalColumn: "MaHoaDon",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DatPhongs_KhachHangs_MaKhachHang",
                table: "DatPhongs",
                column: "MaKhachHang",
                principalTable: "KhachHangs",
                principalColumn: "MaKhachHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DatPhongs_Phongs_MaPhong",
                table: "DatPhongs",
                column: "MaPhong",
                principalTable: "Phongs",
                principalColumn: "MaPhong",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_NguoiDungs_MaNguoiDung",
                table: "HoaDons",
                column: "MaNguoiDung",
                principalTable: "NguoiDungs",
                principalColumn: "MaNguoiDung",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_ThuePhongs_MaThuePhong",
                table: "HoaDons",
                column: "MaThuePhong",
                principalTable: "ThuePhongs",
                principalColumn: "MaThuePhong",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThietBis_Phongs_MaPhong",
                table: "ThietBis",
                column: "MaPhong",
                principalTable: "Phongs",
                principalColumn: "MaPhong",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThuePhongs_KhachHangs_MaKhachHang",
                table: "ThuePhongs",
                column: "MaKhachHang",
                principalTable: "KhachHangs",
                principalColumn: "MaKhachHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThuePhongs_Phongs_MaPhong",
                table: "ThuePhongs",
                column: "MaPhong",
                principalTable: "Phongs",
                principalColumn: "MaPhong",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
