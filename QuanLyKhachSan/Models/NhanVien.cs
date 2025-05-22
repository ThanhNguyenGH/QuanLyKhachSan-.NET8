namespace QuanLyKhachSan.Models;
public class NhanVien : NguoiDung
{
    public string HoTen { get; set; }
    public string SoDienThoai { get; set; }
    public string Email { get; set; }

    public void ThemKhachHang(KhachHang khachHang)
    {
    }

    public void CapNhatTrangThaiPhong(Phong phong, string trangThai)
    {
    }

    public void QuanLyThietBi(Phong phong, ThietBi thietBi, string hanhDong)
    {
    }

    public void GhiNhanDichVu(ThuePhong thuePhong, DichVu dichVu)
    {
    }

    public HoaDon TaoHoaDon(ThuePhong thuePhong)
    {
        return null;
    }

    public BaoCao TaoBaoCao(string ky)
    {
        return null;
    }

    public override bool DangNhap(string tenDangNhap, string matKhau)
    {
        return false;
    }

    public override void DangXuat()
    {
    }
}