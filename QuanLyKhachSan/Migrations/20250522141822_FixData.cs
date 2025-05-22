using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class FixData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ThanhTien",
                table: "ChiTietDichVu",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThanhTien",
                table: "ChiTietDichVu");
        }
    }
}
