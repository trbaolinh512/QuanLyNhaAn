using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBaoCom.DTO
{
    public class ThongTinHeThongDto
    {
        public int Id { get; set; }
        public TimeSpan HanBaoSang { get; set; }
        public TimeSpan HanBaoTruaToi { get; set; }
        public decimal GiaTienHocVienSang { get; set; }
        public decimal GiaTienHocVienTrua { get; set; }
        public decimal GiaTienHocVienToi { get; set; }
        public decimal GiaTienCanBoSang { get; set; }
        public decimal GiaTienCanBoTrua { get; set; }
        public decimal GiaTienCanBoToi { get; set; }
    }
}
