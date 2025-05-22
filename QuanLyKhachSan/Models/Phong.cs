namespace QuanLyKhachSan.Models;
public class Phong
{
    public int MaPhong { get; set; }
    public string SoPhong { get; set; }
    public string LoaiPhong { get; set; }
    public decimal GiaPhong { get; set; }
    public string TrangThai { get; set; }

    // Navigation properties
    public virtual ICollection<ThietBi> ThietBi { get; set; } = new List<ThietBi>();
    public virtual ICollection<ThuePhong> ThuePhong { get; set; } = new List<ThuePhong>();
    public virtual ICollection<DatPhong> DatPhong { get; set; } = new List<DatPhong>();

    public void CapNhatTrangThai(string trangThai)
    {
    }

    public void ThemThietBi(ThietBi thietBi)
    {
    }

    public void XoaThietBi(ThietBi thietBi)
    {
    }
}