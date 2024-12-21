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
    public class YKienDongGopBll
    {
        DataAccess access = new DataAccess();
        public YKienDongGopBll()
        {
        }

        public List<YKienDongGopDto> lay_tat_ca()
        {
            List<YKienDongGopDto> list = new List<YKienDongGopDto>();

            string commandString = "SELECT Id, NoiDung, NoiDungPhanHoi, NguoiGui, NguoiPhanHoi, NgayGui, NgayPhanHoi, AnhGui FROM YKienDongGop";

            using (SqlConnection cn = access.open())
            using (SqlCommand command = new SqlCommand(commandString, cn))
            {
                // Thêm tham số vào lệnh SQL

                // Đọc dữ liệu từ cơ sở dữ liệu
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read()) // Nếu có dữ liệu
                    {
                        YKienDongGopDto dto = new YKienDongGopDto
                        {
                            Id = reader.GetInt32(0),
                            NoiDung = reader["NoiDung"] as string,
                            NoiDungPhanHoi = reader["NoiDungPhanHoi"] as string,
                            NguoiGui = reader.GetInt32(3),
                            NguoiPhanHoi = reader["NguoiPhanHoi"] as int?,
                            NgayGui = reader["NgayGui"] as DateTime?,
                            NgayPhanHoi = reader["NgayPhanHoi"] as DateTime?,
                            AnhGui = reader["AnhGui"] as byte[]
                        };
                        list.Add(dto);
                    }
                }
            }

            return list;
        }
        public List<YKienDongGopDto> lay_theo_idngdung(int nguoidungid)
        {
            List<YKienDongGopDto> list = new List<YKienDongGopDto>();

            string commandString = "SELECT Id, NoiDung, NoiDungPhanHoi, NguoiGui, NguoiPhanHoi, NgayGui, NgayPhanHoi, AnhGui FROM YKienDongGop WHERE NguoiGui = @NguoiGui";

            using (SqlConnection cn = access.open())
            using (SqlCommand command = new SqlCommand(commandString, cn))
            {
                // Thêm tham số vào lệnh SQL
                command.Parameters.AddWithValue("@NguoiGui", nguoidungid);

                // Đọc dữ liệu từ cơ sở dữ liệu
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read()) // Nếu có dữ liệu
                    {
                        YKienDongGopDto dto = new YKienDongGopDto
                        {
                            Id = reader.GetInt32(0),
                            NoiDung = reader["NoiDung"] as string,
                            NoiDungPhanHoi = reader["NoiDungPhanHoi"] as string,
                            NguoiGui = reader.GetInt32(3),
                            NguoiPhanHoi = reader["NguoiPhanHoi"] as int?,
                            NgayGui = reader["NgayGui"] as DateTime?,
                            NgayPhanHoi = reader["NgayPhanHoi"] as DateTime?,
                            AnhGui = reader["AnhGui"] as byte[]
                        };
                        list.Add(dto);
                    }
                }
            }

            return list;
        }

        public YKienDongGopDto lay_theo_id(int id)
        {
            YKienDongGopDto dto = new YKienDongGopDto();

            string commandString = "SELECT Id, NoiDung, NoiDungPhanHoi, NguoiGui, NguoiPhanHoi, NgayGui, NgayPhanHoi, AnhGui FROM YKienDongGop WHERE Id = @Id";

            using (SqlConnection cn = access.open())
            using (SqlCommand command = new SqlCommand(commandString, cn))
            {
                // Thêm tham số vào lệnh SQL
                command.Parameters.AddWithValue("@Id", id);

                // Đọc dữ liệu từ cơ sở dữ liệu
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) // Nếu có dữ liệu
                    {
                        dto = new YKienDongGopDto
                        {
                            Id = reader.GetInt32(0),
                            NoiDung = reader["NoiDung"] as string,
                            NoiDungPhanHoi = reader["NoiDungPhanHoi"] as string,
                            NguoiGui = reader.GetInt32(3),
                            NguoiPhanHoi = reader["NguoiPhanHoi"] as int?,
                            NgayGui = reader["NgayGui"] as DateTime?,
                            NgayPhanHoi = reader["NgayPhanHoi"] as DateTime?,
                            AnhGui = reader["AnhGui"] as byte[]
                        };
                    }
                }
            }

            return dto;
        }
        public int lay_max_id()
        {
            string commandString = "SELECT MAX(ID) FROM YKienDongGop;";
            SqlConnection cn = access.open();
            int maxId = 0;
            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            maxId = reader.GetInt32(0);
                        }
                        catch (Exception ex) { }
                    }
                }
            }
            cn.Close();
            return maxId;
        }

        public void them_yeu_cau(YKienDongGopDto yKienDongGopDto)
        {
            string commandString = @"INSERT INTO YKienDongGop (Id,NoiDung, NoiDungPhanHoi, NguoiGui, NguoiPhanHoi, NgayGui, NgayPhanHoi, AnhGui)
                             VALUES (@Id,@NoiDung, @NoiDungPhanHoi, @NguoiGui, @NguoiPhanHoi, @NgayGui, @NgayPhanHoi, @AnhGui)";

            SqlConnection cn = access.open();
            using (SqlCommand command = new SqlCommand(commandString, cn))
            {
                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@Id", lay_max_id()+1);
                command.Parameters.AddWithValue("@NoiDung", yKienDongGopDto.NoiDung);
                command.Parameters.AddWithValue("@NoiDungPhanHoi", yKienDongGopDto.NoiDungPhanHoi ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NguoiGui", yKienDongGopDto.NguoiGui);
                command.Parameters.AddWithValue("@NguoiPhanHoi", yKienDongGopDto.NguoiPhanHoi ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NgayGui", yKienDongGopDto.NgayGui ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NgayPhanHoi", yKienDongGopDto.NgayPhanHoi ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@AnhGui", yKienDongGopDto.AnhGui ?? new byte[0]);

                // Thực thi lệnh chèn
                command.ExecuteNonQuery();
            }
            cn.Close();
        }

        public void chinh_sua_yeu_cau(YKienDongGopDto yKienDongGopDto)
        {
            string commandString = @"UPDATE YKienDongGop
                             SET NoiDung = @NoiDung,
                                 NoiDungPhanHoi = @NoiDungPhanHoi,
                                 NguoiGui = @NguoiGui,
                                 NguoiPhanHoi = @NguoiPhanHoi,
                                 NgayGui = @NgayGui,
                                 NgayPhanHoi = @NgayPhanHoi,
                                 AnhGui = @AnhGui
                             WHERE Id = @Id";

            SqlConnection cn = access.open();
            using (SqlCommand command = new SqlCommand(commandString, cn))
            {
                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@NoiDung", yKienDongGopDto.NoiDung);
                command.Parameters.AddWithValue("@NoiDungPhanHoi", yKienDongGopDto.NoiDungPhanHoi ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NguoiGui", yKienDongGopDto.NguoiGui);
                command.Parameters.AddWithValue("@NguoiPhanHoi", yKienDongGopDto.NguoiPhanHoi ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NgayGui", yKienDongGopDto.NgayGui ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NgayPhanHoi", yKienDongGopDto.NgayPhanHoi ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@AnhGui", yKienDongGopDto.AnhGui ?? new byte[0]);
                command.Parameters.AddWithValue("@Id", yKienDongGopDto.Id);

                // Thực thi lệnh cập nhật
                command.ExecuteNonQuery();
            }
            cn.Close();
        }

        public int xoa_theo_id(int idYkien)
        {
            string commandString = @"DELETE FROM YKienDongGop
                             WHERE Id = @Id";
            int kq = 0;
            SqlConnection cn = access.open();
            using (SqlCommand command = new SqlCommand(commandString, cn))
            {
                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@Id", idYkien);

                // Thực thi lệnh cập nhật
                kq=  command.ExecuteNonQuery();
            }
            cn.Close();
            return kq;
        }
    }
}
