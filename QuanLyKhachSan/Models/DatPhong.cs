namespace QuanLyKhachSan.Models;
public class DatPhong
{
    public int MaDatPhong { get; set; }
    public int MaKhachHang { get; set; }
    public int MaPhong { get; set; }
    public DateTime NgayDat { get; set; }
    public DateTime NgayNhanPhong { get; set; }
    public string TrangThai { get; set; }

    // Khóa ngoại
    public virtual KhachHang KhachHang { get; set; }
    public virtual Phong Phong { get; set; }

    public void XacNhanDatPhong()
    {
    }

    public void HuyDatPhong()
    {
    }
}