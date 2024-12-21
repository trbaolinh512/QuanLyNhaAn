namespace PhanMemBaoCom.DTO
{
    public class ThongTinNguoiDungDto
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public string MaNguoiDung { get; set; }
        public string Lop { get; set; }
        public string Phong { get; set; }
        public string Khoa { get; set; }
        public string DonVi { get; set; }
        public int ChucVuId { get; set; }
        public string? SDT { get; set; }
        public string? SoTaiKhoan { get; set; }
        public string NganHang { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public bool TrangThai { get; set; }
    }
}
