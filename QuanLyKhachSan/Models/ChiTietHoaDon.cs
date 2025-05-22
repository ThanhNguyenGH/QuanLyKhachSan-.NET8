namespace QuanLyKhachSan.Models
{
    public class ChiTietHoaDon
    {
        public int MaChiTietHoaDon { get; set; }
        public int MaHoaDon { get; set; }
        public string LoaiChiPhi { get; set; }
        public string MoTa { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public void ThemChiTietHoaDon(string moTa, int soLuong, decimal donGia)
        {
            MoTa = moTa ?? throw new ArgumentNullException(nameof(moTa));
            SoLuong = soLuong > 0 ? soLuong : throw new ArgumentException("Số lượng phải lớn hơn 0", nameof(soLuong));
            DonGia = donGia >= 0 ? donGia : throw new ArgumentException("Đơn giá không được âm", nameof(donGia));
            TinhThanhTien();
        }

        public void TinhThanhTien()
        {
            if (SoLuong <= 0 || DonGia < 0)
            {
                ThanhTien = 0;
                return;
            }
            ThanhTien = SoLuong * DonGia;
        }
    }
}