using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyKhachSan.Models
{
    public class ThuePhong
    {
        public int MaThuePhong { get; set; }
        public int MaKhachHang { get; set; }
        public int MaPhong { get; set; }
        public DateTime NgayNhanPhong { get; set; }
        public DateTime NgayTraPhong { get; set; }
        public decimal TongChiPhi { get; set; }

        // Khóa ngoại
        public virtual KhachHang KhachHang { get; set; }
        public virtual Phong Phong { get; set; }
        public virtual ICollection<ChiTietDichVu> ChiTietDichVu { get; set; } = new List<ChiTietDichVu>();
        public virtual ICollection<HoaDon> HoaDon { get; set; } = new List<HoaDon>();

        public void NhanPhong()
        {
            if (NgayNhanPhong == default)
            {
                NgayNhanPhong = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("Phòng đã được nhận trước đó.");
            }
        }

        public void TraPhong()
        {
            if (NgayNhanPhong == default)
            {
                throw new InvalidOperationException("Phòng chưa được nhận.");
            }
            if (NgayTraPhong == default)
            {
                NgayTraPhong = DateTime.Now;
                TinhTongChiPhi();
            }
            else
            {
                throw new InvalidOperationException("Phòng đã được trả trước đó.");
            }
        }

        public void ThemChiTietDichVu(ChiTietDichVu chiTietDichVu)
        {
            if (chiTietDichVu == null)
                throw new ArgumentNullException(nameof(chiTietDichVu));

            chiTietDichVu.MaThuePhong = this.MaThuePhong;
            chiTietDichVu.TinhThanhTien();
            ChiTietDichVu.Add(chiTietDichVu);
            if (NgayTraPhong != default)
            {
                TinhTongChiPhi();
            }
        }

        public void TinhTongChiPhi()
        {
            decimal chiPhiDichVu = ChiTietDichVu?.Sum(ct => ct.ThanhTien) ?? 0;
            decimal chiPhiPhong = 0;

            if (Phong != null && NgayNhanPhong != default && NgayTraPhong != default)
            {
                var soNgay = (NgayTraPhong - NgayNhanPhong).Days;
                chiPhiPhong = soNgay <= 0 ? Phong.GiaPhong : Phong.GiaPhong * soNgay;
            }

            TongChiPhi = chiPhiPhong + chiPhiDichVu;
        }
    }
}