using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyKhachSan.Models
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public int MaNguoiDung { get; set; }
        public int MaThuePhong { get; set; }
        public decimal TongChiPhi { get; set; }
        public DateTime NgayLap { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
        public virtual ThuePhong ThuePhong { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; } = new List<ChiTietHoaDon>();

        public void ThemChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            if (chiTietHoaDon == null)
                throw new ArgumentNullException(nameof(chiTietHoaDon));

            chiTietHoaDon.MaHoaDon = this.MaHoaDon;
            chiTietHoaDon.TinhThanhTien();
            ChiTietHoaDon.Add(chiTietHoaDon);
            TinhTongChiPhi();
        }

        public void TinhTongChiPhi()
        {
            // Chỉ tính tổng nếu có chi tiết hóa đơn
            TongChiPhi = ChiTietHoaDon?.Sum(ct => ct.ThanhTien) ?? 0;

            // Nếu không có chi tiết, kiểm tra ThuePhong để giữ TongChiPhi hợp lý
            if (!ChiTietHoaDon.Any() && ThuePhong != null)
            {
                var soNgay = (ThuePhong.NgayTraPhong - ThuePhong.NgayNhanPhong).Days;
                soNgay = soNgay < 1 ? 1 : soNgay;
                TongChiPhi = (ThuePhong.Phong?.GiaPhong ?? 0) * soNgay;
            }
        }

        public string HienThiHoaDon()
        {
            var result = $"Hóa đơn #{MaHoaDon}\n" +
                         $"Ngày lập: {NgayLap:dd/MM/yyyy}\n" +
                         $"Người lập: {NguoiDung?.TenDangNhap ?? "Không xác định"}\n" +
                         $"Thuê phòng: #{MaThuePhong}\n" +
                         $"Chi tiết:\n";

            foreach (var ct in ChiTietHoaDon)
            {
                result += $"  - {ct.LoaiChiPhi}: {ct.MoTa}, Số lượng: {ct.SoLuong}, Đơn giá: {ct.DonGia:C}, Thành tiền: {ct.ThanhTien:C}\n";
            }

            result += $"Tổng chi phí: {TongChiPhi:C}";
            return result;
        }

        public void TaoChiTietTuThuePhong()
        {
            if (ThuePhong == null)
                throw new InvalidOperationException("Không có thông tin thuê phòng.");

            // Xóa chi tiết hóa đơn cũ (nếu có) để tránh trùng lặp
            ChiTietHoaDon.Clear();

            // Thêm chi phí phòng
            var soNgay = (ThuePhong.NgayTraPhong - ThuePhong.NgayNhanPhong).Days;
            soNgay = soNgay < 1 ? 1 : soNgay;
            var chiPhiPhong = (ThuePhong.Phong?.GiaPhong ?? 0) * soNgay;

            var chiTietPhong = new ChiTietHoaDon
            {
                LoaiChiPhi = "Phòng",
                MoTa = $"Tiền phòng #{ThuePhong.Phong?.SoPhong ?? "Không xác định"} ({soNgay} ngày)",
                SoLuong = 1,
                DonGia = chiPhiPhong
            };
            ThemChiTietHoaDon(chiTietPhong);

            // Thêm chi phí dịch vụ từ ChiTietDichVu
            if (ThuePhong.ChiTietDichVu != null)
            {
                foreach (var ctDichVu in ThuePhong.ChiTietDichVu)
                {
                    var chiTietDichVu = new ChiTietHoaDon
                    {
                        LoaiChiPhi = "Dịch vụ",
                        MoTa = ctDichVu.DichVu?.TenDichVu ?? "Dịch vụ không xác định",
                        SoLuong = ctDichVu.SoLuong,
                        DonGia = ctDichVu.DonGia
                    };
                    ThemChiTietHoaDon(chiTietDichVu);
                }
            }

            // Đảm bảo TongChiPhi được cập nhật
            TinhTongChiPhi();
        }
    }
}