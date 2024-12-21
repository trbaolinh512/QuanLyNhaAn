using Microsoft.Data.SqlClient;
using PhanMemBaoCom.DAL;
using PhanMemBaoCom.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBaoCom.BLL
{
    public class ThongTinHeThongBll
    {
        DataAccess access = new DataAccess();
        public ThongTinHeThongBll()
        {
        }
        public ThongTinHeThongDto lay_tat_ca()
        {
            ThongTinHeThongDto dto = new ThongTinHeThongDto();
            string commandString = "SELECT * FROM ThongTinHeThong; ";
            SqlConnection cn = access.open();
            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Map dữ liệu từ SqlDataReader sang đối tượng ThongTinHeThongDto
                        dto = new ThongTinHeThongDto
                        {
                            Id = reader.GetInt32(0),
                            HanBaoSang = reader.GetTimeSpan(1),
                            HanBaoTruaToi = reader.GetTimeSpan(2),
                            GiaTienHocVienSang = reader.GetDecimal(3),
                            GiaTienHocVienTrua = reader.GetDecimal(4),
                            GiaTienHocVienToi = reader.GetDecimal(5),
                            GiaTienCanBoSang = reader.GetDecimal(6),
                            GiaTienCanBoTrua = reader.GetDecimal(7),
                            GiaTienCanBoToi = reader.GetDecimal(8)
                        };
                    }
                }
            }
            cn.Close();
            return dto;
        }

        public void chinh_sua_he_thong(ThongTinHeThongDto thongTinHeThongDto)
        {
            string commandString = @"UPDATE ThongTinHeThong
                             SET HanBaoSang = @HanBaoSang,
                                 HanBaoTruaToi = @HanBaoTruaToi,
                                 GiaTienHocVienSang = @GiaTienHocVienSang,
                                 GiaTienHocVienTrua = @GiaTienHocVienTrua,
                                 GiaTienHocVienToi = @GiaTienHocVienToi,
                                 GiaTienCanBoSang = @GiaTienCanBoSang,
                                 GiaTienCanBoTrua = @GiaTienCanBoTrua,
                                 GiaTienCanBoToi = @GiaTienCanBoToi
                             WHERE Id = @Id";

            SqlConnection cn = access.open();
            using (SqlCommand command = new SqlCommand(commandString, cn))
            {
                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@HanBaoSang", thongTinHeThongDto.HanBaoSang);
                command.Parameters.AddWithValue("@HanBaoTruaToi", thongTinHeThongDto.HanBaoTruaToi);
                command.Parameters.AddWithValue("@GiaTienHocVienSang", thongTinHeThongDto.GiaTienHocVienSang);
                command.Parameters.AddWithValue("@GiaTienHocVienTrua", thongTinHeThongDto.GiaTienHocVienTrua);
                command.Parameters.AddWithValue("@GiaTienHocVienToi", thongTinHeThongDto.GiaTienHocVienToi);
                command.Parameters.AddWithValue("@GiaTienCanBoSang", thongTinHeThongDto.GiaTienCanBoSang);
                command.Parameters.AddWithValue("@GiaTienCanBoTrua", thongTinHeThongDto.GiaTienCanBoTrua);
                command.Parameters.AddWithValue("@GiaTienCanBoToi", thongTinHeThongDto.GiaTienCanBoToi);
                command.Parameters.AddWithValue("@Id", 1);

                // Thực thi lệnh cập nhật
                command.ExecuteNonQuery();
            }
            cn.Close();
        }
    }
}
