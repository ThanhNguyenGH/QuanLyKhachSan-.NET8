using System;

namespace QuanLyKhachSan.Models
{
    public class ChiTietDichVu
    {
        public int MaChiTietDichVu { get; set; }
        public int MaThuePhong { get; set; }
        public int MaDichVu { get; set; }
        public int SoLuong { get; set; }
        public DateTime ThoiGianSuDung { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; } // Thêm thuộc tính

        // Khóa ngoại
        public virtual ThuePhong ThuePhong { get; set; }
        public virtual DichVu DichVu { get; set; }

        public void ThemChiTietDichVu(DichVu dichVu, int soLuong, DateTime thoiGianSuDung)
        {
            if (dichVu == null)
                throw new ArgumentNullException(nameof(dichVu));
            if (soLuong <= 0)
                throw new ArgumentException("Số lượng phải lớn hơn 0", nameof(soLuong));
            if (thoiGianSuDung == default)
                throw new ArgumentException("Thời gian sử dụng không hợp lệ", nameof(thoiGianSuDung));

            MaDichVu = dichVu.MaDichVu;
            SoLuong = soLuong;
            ThoiGianSuDung = thoiGianSuDung;
            DonGia = dichVu.GiaDichVu;
            TinhThanhTien();
        }

        public void CapNhatChiTietDichVu(int soLuong, DateTime thoiGianSuDung)
        {
            if (soLuong <= 0)
                throw new ArgumentException("Số lượng phải lớn hơn 0", nameof(soLuong));
            if (thoiGianSuDung == default)
                throw new ArgumentException("Thời gian sử dụng không hợp lệ", nameof(thoiGianSuDung));

            SoLuong = soLuong;
            ThoiGianSuDung = thoiGianSuDung;
            TinhThanhTien();
        }

        public void TinhThanhTien()
        {
            if (DonGia < 0 || SoLuong <= 0)
            {
                ThanhTien = 0;
                return;
            }
            ThanhTien = SoLuong * DonGia;
        }
    }
}