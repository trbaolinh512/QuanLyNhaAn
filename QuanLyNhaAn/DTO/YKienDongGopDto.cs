using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBaoCom.DTO
{
    public class YKienDongGopDto
    {
        public int Id { get; set; }
        public string NoiDung { get; set; }
        public string? NoiDungPhanHoi { get; set; }
        public int NguoiGui { get; set; }
        public int? NguoiPhanHoi { get; set; }
        public DateTime? NgayGui { get; set; }
        public DateTime? NgayPhanHoi { get; set; }
        public byte[]? AnhGui { get; set; }
    }
}
