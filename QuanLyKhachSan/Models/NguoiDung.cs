namespace QuanLyKhachSan.Models;
public abstract class NguoiDung
{
    public int MaNguoiDung { get; set; }
    public string TenDangNhap { get; set; }
    public string MatKhau { get; set; }
    public string VaiTro { get; set; }

    // Navigation property
    public virtual ICollection<HoaDon> HoaDon { get; set; } = new List<HoaDon>();

    public abstract bool DangNhap(string tenDangNhap, string matKhau);
    public abstract void DangXuat();
}