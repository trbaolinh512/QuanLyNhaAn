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
    public class ChucVuBll
    {
        DataAccess access = new DataAccess();
        public ChucVuBll() {
        }
        public List<ChucVuDto> lay_tat_ca()
        {
            List<ChucVuDto> list = new List<ChucVuDto>();
            string commandString = "SELECT * FROM ChucVu";
            SqlConnection cn = access.open();
            SqlDataReader result = access.ExecuteQuery(commandString, cn);

            while (result.Read())
            {
                list.Add(new ChucVuDto
                {
                    Id = result.GetInt32(0),
                    ChucVu = result.GetString(1),
                    LaHocVien = result.GetBoolean(2),
                    CoQuyenBaoCom = result.GetBoolean(3)
                });
            }
            cn.Close();
            return list;
        }

        public ChucVuDto lay_theo_id(int id)
        {
            ChucVuDto dto = null;
            string commandString = "SELECT * FROM ChucVu WHERE Id = @id";
            SqlConnection cn = access.open();
            SqlCommand command = new SqlCommand(commandString, cn);
            command.Parameters.AddWithValue("@Id", id);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    dto = new ChucVuDto
                    {
                        Id = reader.GetInt32(0),
                        ChucVu = reader.GetString(1),
                        LaHocVien = reader.GetBoolean(2),
                        CoQuyenBaoCom = reader.GetBoolean(3)
                    };
                }
            }

            cn.Close();
            return dto;
        }

        public bool them_chuc_vu(ChucVuDto dto)
        {
            string commandString = "INSERT INTO ChucVu (Id, ChucVu, LaHocVien, CoQuyenBaoCom) VALUES (@Id, @ChucVu, @LaHocVien, @CoQuyenBaoCom)";
            SqlConnection cn = access.open();
            SqlCommand command = new SqlCommand(commandString, cn);
            command.Parameters.AddWithValue("@Id", lay_max_id()+1);
            command.Parameters.AddWithValue("@ChucVu", dto.ChucVu);
            command.Parameters.AddWithValue("@LaHocVien", dto.LaHocVien); 
            command.Parameters.AddWithValue("@CoQuyenBaoCom", dto.CoQuyenBaoCom);

            int result = access.ExecuteCommandText(command);
            cn.Close();
            return result > 0;
        }

        public int lay_max_id()
        {
            string commandString = "SELECT MAX(ID) FROM ChucVu;";
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
        public void chinh_sua_chuc_vu(ChucVuDto chucVuDto)
        {
            string commandString = @"UPDATE ChucVu
                                    SET ChucVu = @ChucVu,
                                        LaHocVien = @LaHocVien,
                                        CoQuyenBaoCom = @CoQuyenBaoCom
                                    WHERE Id = @Id;
                                    ";

            SqlConnection cn = access.open();
            using (SqlCommand command = new SqlCommand(commandString, cn))
            {
                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@ChucVu", chucVuDto.ChucVu);
                command.Parameters.AddWithValue("@LaHocVien", chucVuDto.LaHocVien);
                command.Parameters.AddWithValue("@CoQuyenBaoCom", chucVuDto.CoQuyenBaoCom);
                command.Parameters.AddWithValue("@Id", chucVuDto.Id);

                // Thực thi lệnh cập nhật
                command.ExecuteNonQuery();
            }
            cn.Close();
        }

        public int xoa_theo_id(int id)
        {
            string commandString = @"DELETE FROM ChucVu
                             WHERE Id = @Id";
            int kq = 0;
            SqlConnection cn = access.open();
            using (SqlCommand command = new SqlCommand(commandString, cn))
            {
                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@Id", id);

                // Thực thi lệnh cập nhật
                kq = command.ExecuteNonQuery();
            }
            cn.Close();
            return kq;
        }

    }
}
