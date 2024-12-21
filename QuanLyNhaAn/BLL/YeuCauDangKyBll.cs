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
    internal class YeuCauDangKyBll
    {
        DataAccess access = new DataAccess();
        public YeuCauDangKyBll()
        {
        }
        public List<YeuCauDangKyDto> lay_theo_thang_va_id(DateTime batdau, DateTime ketthuc, int nguoidungId)
        {
            List<YeuCauDangKyDto> list = new List<YeuCauDangKyDto>();

            string commandString = "SELECT * FROM YeuCauDangKy WHERE NgayDangKy BETWEEN @ngaybatdau AND @ngayketthuc AND NguoiDungId = @nguoidungId; ";
            SqlConnection cn = access.open();
            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                // Thêm các tham số
                cmd.Parameters.AddWithValue("@ngaybatdau", batdau);
                cmd.Parameters.AddWithValue("@ngayketthuc", ketthuc);
                cmd.Parameters.AddWithValue("@nguoidungId", nguoidungId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Map dữ liệu từ SqlDataReader sang đối tượng YeuCauDangKyDto
                        YeuCauDangKyDto item = new YeuCauDangKyDto
                        {
                            Id = reader.GetInt32(0),
                            NguoiDungId = reader.GetInt32(1),
                            NgayDangKy = reader.GetDateTime(2),
                            ThoiDiem = reader.GetInt32(3),
                        };
                        list.Add(item);
                    }
                }
            }
            cn.Close();
            return list;
        }

        public List<YeuCauDangKyDto> lay_yeu_cau_can_chuyen_doi()
        {
            List<YeuCauDangKyDto> list = new List<YeuCauDangKyDto> ();
            string commandString = "SELECT * FROM YeuCauDangKy WHERE NgayDangKy < GETDATE();";
            SqlConnection cn = access.open();
            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Map dữ liệu từ SqlDataReader sang đối tượng YeuCauDangKyDto
                        YeuCauDangKyDto item = new YeuCauDangKyDto
                        {
                            Id = reader.GetInt32(0),
                            NguoiDungId = reader.GetInt32(1),
                            NgayDangKy = reader.GetDateTime(2),
                            ThoiDiem = reader.GetInt32(3),
                        };
                        list.Add(item);
                    }
                }
            }
            cn.Close();
            return list;
        }

        public void xoa_yeu_cau(YeuCauDangKyDto y)
        {
            YeuCauDangKyDto check_yeu_cau = check_ngay_thoidiem_nguoidungId(y);
            if (check_yeu_cau != null)
            {
                y = check_yeu_cau;
            }
            else
            {
                return;
            };
            string commandString = "DELETE FROM YeuCauDangKy WHERE ID = @id ";
            SqlConnection cn = access.open();
            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                // Thêm các tham số
                cmd.Parameters.AddWithValue("@Id", y.Id);
                try
                {
                    cmd.ExecuteNonQuery(); // Trả về số dòng bị ảnh hưởng
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        public void them_yeu_cau(YeuCauDangKyDto dto)
        {
            if (check_ngay_thoidiem_nguoidungId(dto)!=null)
            {
                return; 
            }

            string commandString = "INSERT INTO YeuCauDangKy (Id, NguoiDungId, NgayDangKy, ThoiDiem) VALUES (@Id, @NguoiDungId, @NgayDangKy, @ThoiDiem) ";
            SqlConnection cn = access.open();
            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                // Thêm các tham số
                cmd.Parameters.AddWithValue("@Id", dto.Id);
                cmd.Parameters.AddWithValue("@NguoiDungId", dto.NguoiDungId);
                cmd.Parameters.AddWithValue("@NgayDangKy", dto.NgayDangKy);
                cmd.Parameters.AddWithValue("@ThoiDiem", dto.ThoiDiem);
                try
                {
                    cmd.ExecuteNonQuery(); // Trả về số dòng bị ảnh hưởng
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        public int lay_max_id()
        {
            string commandString = "SELECT MAX(ID) FROM YeuCauDangKy;";
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

        public YeuCauDangKyDto check_ngay_thoidiem_nguoidungId(YeuCauDangKyDto dto)
        {
            DateTime inputDate = dto.NgayDangKy;
            DateTime batdau = new DateTime(inputDate.Year, inputDate.Month, inputDate.Day, 0, 0, 0);
            DateTime ketthuc = new DateTime(inputDate.Year, inputDate.Month, inputDate.Day, 23, 59, 59);

            string commandString = "SELECT * FROM YeuCauDangKy WHERE NgayDangKy BETWEEN @batdau AND @ketthuc AND NguoiDungId = @nguoidungid AND ThoiDiem = @thoidiem;";

            using (SqlConnection cn = access.open()) // Mở kết nối
            {
                using (SqlCommand cmd = new SqlCommand(commandString, cn))
                {
                    // Thêm tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@nguoidungid", dto.NguoiDungId);
                    cmd.Parameters.AddWithValue("@batdau", batdau);
                    cmd.Parameters.AddWithValue("@ketthuc", ketthuc);
                    cmd.Parameters.AddWithValue("@ThoiDiem", dto.ThoiDiem);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Map dữ liệu từ SqlDataReader sang đối tượng YeuCauDangKyDto
                            YeuCauDangKyDto item = new YeuCauDangKyDto
                            {
                                Id = reader.GetInt32(0),
                                NguoiDungId = reader.GetInt32(1),
                                NgayDangKy = reader.GetDateTime(2),
                                ThoiDiem = reader.GetInt32(3),
                            };
                            return item;
                        }
                    }
                }
            }
            return null;
        }

    }
}
