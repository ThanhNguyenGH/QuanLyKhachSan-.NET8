namespace QuanLyKhachSan.Models;
public class KhachHang
{
    public int MaKhachHang { get; set; }
    public string HoTen { get; set; }
    public string SoCMND { get; set; }
    public string SoDienThoai { get; set; }
    public string DiaChi { get; set; }

    // Navigation properties
    public virtual ICollection<ThuePhong> ThuePhong { get; set; } = new List<ThuePhong>();
    public virtual ICollection<DatPhong> DatPhong { get; set; } = new List<DatPhong>();

    public void CapNhatThongTin(string hoTen, string soDienThoai, string diaChi)
    {
    }
}