namespace QuanLyKhachSan.Models;
public class ThietBi
{
    public int MaThietBi { get; set; }
    public string TenThietBi { get; set; }
    public int SoLuong { get; set; }
    public int MaPhong { get; set; }

    // Khóa ngoại
    public virtual Phong Phong { get; set; }

    public void CapNhatSoLuong(int soLuong)
    {
    }
}