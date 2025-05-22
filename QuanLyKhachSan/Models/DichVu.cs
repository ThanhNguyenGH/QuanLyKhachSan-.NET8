namespace QuanLyKhachSan.Models
{
    public class DichVu
    {
        public int MaDichVu { get; set; }
        public string TenDichVu { get; set; }
        public decimal GiaDichVu { get; set; }

        public virtual ICollection<ChiTietDichVu> ChiTietDichVu { get; set; } = new List<ChiTietDichVu>();

        public void ThemDichVu(string tenDichVu, decimal giaDichVu)
        {
            if (string.IsNullOrEmpty(tenDichVu))
                throw new ArgumentException("Tên dịch vụ không được để trống", nameof(tenDichVu));
            if (giaDichVu < 0)
                throw new ArgumentException("Giá dịch vụ không được âm", nameof(giaDichVu));

            TenDichVu = tenDichVu;
            GiaDichVu = giaDichVu;
        }
    }
}