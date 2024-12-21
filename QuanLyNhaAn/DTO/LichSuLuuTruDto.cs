using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBaoCom.DTO
{
    public class LichSuLuuTruDto
    {
        public int Id { get; set; }
        public int NguoiDungId { get; set; }
        public DateTime NgayLuuTru { get; set; }
        public int ThoiDiem { get; set; }
        public decimal SoTienTuongUng { get; set; }
    }
}
