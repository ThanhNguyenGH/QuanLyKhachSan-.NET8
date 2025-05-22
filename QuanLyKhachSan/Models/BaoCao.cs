namespace QuanLyKhachSan.Models;
public class BaoCao
{
    public int MaBaoCao { get; set; }
    public string KyBaoCao { get; set; }
    public decimal TongDoanhThu { get; set; }
    public DateTime NgayBatDau { get; set; }
    public DateTime NgayKetThuc { get; set; }

    public void TaoBaoCao()
    {
    }
}