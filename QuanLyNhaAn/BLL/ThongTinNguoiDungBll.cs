using Microsoft.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.Logging;
using PhanMemBaoCom.DAL;
using PhanMemBaoCom.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemBaoCom.BLL
{
    public class ThongTinNguoiDungBll
    {
        DataAccess access = new DataAccess();
        public ThongTinNguoiDungBll()
        {
        }
        public List<ThongTinNguoiDungDto> lay_tat_ca(string? input)
        {
            List<ThongTinNguoiDungDto> list = new List<ThongTinNguoiDungDto>();
            string commandString = "SELECT * FROM ThongTinNguoiDung";
            SqlConnection cn = access.open();
            if (input != null)
            {
                commandString += " WHERE (MaNguoiDung Like @input OR HoTen LIKE @input)";
            }
            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                if (input != null)
                    {
                        cmd.Parameters.AddWithValue("@input", $"%{input}%");
                    }
                    SqlDataReader result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        list.Add(new ThongTinNguoiDungDto
                        {
                            Id = result.GetInt32(0),
                            HoTen = result.GetString(1),
                            MaNguoiDung = result.GetString(2),
                            Lop = result.GetString(3),
                            Phong = result.GetString(4),
                            Khoa = result.GetString(5),
                            DonVi = result.GetString(6),
                            ChucVuId = result.GetInt32(7),
                            SDT = result.GetString(8),
                            SoTaiKhoan = result.GetString(9),
                            NganHang = result.GetString(10),
                            Email = result.GetString(11),
                            MatKhau = result.GetString(12),
                            TrangThai = result.GetBoolean(13)
                        });
                    }
                }
            cn.Close();
            return list;
        }

        public ThongTinNguoiDungDto lay_chi_tiet_theo_mngdung(string manguoidung)
        {
            ThongTinNguoiDungDto nguoiDung = null;
            string commandString = "SELECT * FROM ThongTinNguoiDung WHERE MaNguoiDung = @MaNguoiDung";
            SqlConnection cn = access.open();

            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                cmd.Parameters.AddWithValue("@MaNguoiDung", manguoidung);

                SqlDataReader result = cmd.ExecuteReader();
                if (result.Read())
                {
                    nguoiDung = new ThongTinNguoiDungDto
                    {
                        Id = result.GetInt32(0),
                        HoTen = result.GetString(1),
                        MaNguoiDung = result.GetString(2),
                        Lop = result.GetString(3),
                        Phong = result.GetString(4),
                        Khoa = result.GetString(5),
                        DonVi = result.GetString(6),
                        ChucVuId = result.GetInt32(7),
                        SDT = result.GetString(8),
                        SoTaiKhoan = result.GetString(9),
                        NganHang = result.GetString(10),
                        Email = result.GetString(11),
                        MatKhau = result.GetString(12),
                        TrangThai = result.GetBoolean(13)
                    };
                }
            }
            cn.Close();
            return nguoiDung;
        }

        public ThongTinNguoiDungDto lay_chi_tiet_theo_iddung(int id)
        {
            ThongTinNguoiDungDto nguoiDung = null;
            string commandString = "SELECT * FROM ThongTinNguoiDung WHERE Id = @Id";
            SqlConnection cn = access.open();

            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader result = cmd.ExecuteReader();
                if (result.Read())
                {
                    nguoiDung = new ThongTinNguoiDungDto
                    {
                        Id = result.GetInt32(0),
                        HoTen = result.GetString(1),
                        MaNguoiDung = result.GetString(2),
                        Lop = result.GetString(3),
                        Phong = result.GetString(4),
                        Khoa = result.GetString(5),
                        DonVi = result.GetString(6),
                        ChucVuId = result.GetInt32(7),
                        SDT = result.GetString(8),
                        SoTaiKhoan = result.GetString(9),
                        NganHang = result.GetString(10),
                        Email = result.GetString(11),
                        MatKhau = result.GetString(12),
                        TrangThai = result.GetBoolean(13)
                    };
                }
            }
            cn.Close();
            return nguoiDung;
        }

        public ThongTinNguoiDungDto dangnhap(string manguoidung, string matkhau)
        {
            ThongTinNguoiDungDto nguoiDung = null;
            string commandString = "SELECT * FROM ThongTinNguoiDung WHERE MaNguoiDung = @MaNguoiDung AND MatKhau = @MatKhau";
            SqlConnection cn = access.open();

            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                cmd.Parameters.AddWithValue("@MaNguoiDung", manguoidung);
                cmd.Parameters.AddWithValue("@MatKhau", matkhau);

                SqlDataReader result = cmd.ExecuteReader();
                if (result.Read())
                {
                    nguoiDung = new ThongTinNguoiDungDto
                    {
                        Id = result.GetInt32(0),
                        HoTen = result.GetString(1),
                        MaNguoiDung = result.GetString(2),
                        Lop = result.GetString(3),
                        Phong = result.GetString(4),
                        Khoa = result.GetString(5),
                        DonVi = result.GetString(6),
                        ChucVuId = result.GetInt32(7),
                        SDT = result.GetString(8),
                        SoTaiKhoan = result.GetString(9),
                        NganHang = result.GetString(10),
                        Email = result.GetString(11),
                        MatKhau = result.GetString(12),
                        TrangThai = result.GetBoolean(13)
                    };
                }
            }
            cn.Close();
            return nguoiDung;
        }

        public ThongTinNguoiDungDto quen_mat_khau(string manguoidung, string email)
        {
            ThongTinNguoiDungDto nguoiDung = null;
            string commandString = "SELECT * FROM ThongTinNguoiDung WHERE MaNguoiDung = @MaNguoiDung AND Email = @Email";
            SqlConnection cn = access.open();

            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                cmd.Parameters.AddWithValue("@MaNguoiDung", manguoidung);
                cmd.Parameters.AddWithValue("@Email", email);

                SqlDataReader result = cmd.ExecuteReader();
                if (result.Read())
                {
                    nguoiDung = new ThongTinNguoiDungDto
                    {
                        Id = result.GetInt32(0),
                        HoTen = result.GetString(1),
                        MaNguoiDung = result.GetString(2),
                        Lop = result.GetString(3),
                        Phong = result.GetString(4),
                        Khoa = result.GetString(5),
                        DonVi = result.GetString(6),
                        ChucVuId = result.GetInt32(7),
                        SDT = result.GetString(8),
                        SoTaiKhoan = result.GetString(9),
                        NganHang = result.GetString(10),
                        Email = result.GetString(11),
                        MatKhau = result.GetString(12),
                        TrangThai = result.GetBoolean(13)
                    };
                }
            }
            cn.Close();
            return nguoiDung;
        }


        public int doi_mat_khau(string manguoidung, string email, string matkhaumoi)
        {
            string commandString = "UPDATE ThongTinNguoiDung SET MatKhau = @matkhau WHERE MaNguoiDung = @manguoidung AND Email = @email;";
            SqlConnection cn = access.open();

            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                // Thêm các tham số
                cmd.Parameters.AddWithValue("@matkhau", matkhaumoi);
                cmd.Parameters.AddWithValue("@manguoidung", manguoidung);
                cmd.Parameters.AddWithValue("@email", email);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery(); // Trả về số dòng bị ảnh hưởng
                        return rowsAffected;
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    cn.Close();
                }
            }
            return 0;
        }

        public List<ThongTinNguoiDungDto> lay_danh_sach_hoc_vien_cung_lop(string lop,string? input)
        {
            List<ThongTinNguoiDungDto> list = new List<ThongTinNguoiDungDto>();
            string commandString = "SELECT * FROM ThongTinNguoiDung WHERE Lop = @Lop";
            SqlConnection cn = access.open();

            if(input != null)
            {
                commandString += " AND (MaNguoiDung Like @input OR HoTen LIKE @input)";
            }
            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                cmd.Parameters.AddWithValue("@Lop", lop);
                if (input != null)
                {
                    cmd.Parameters.AddWithValue("@input", $"%{input}%");
                }
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    list.Add(new ThongTinNguoiDungDto
                    {
                        Id = result.GetInt32(0),
                        HoTen = result.GetString(1),
                        MaNguoiDung = result.GetString(2),
                        Lop = result.GetString(3),
                        Phong = result.GetString(4),
                        Khoa = result.GetString(5),
                        DonVi = result.GetString(6),
                        ChucVuId = result.GetInt32(7),
                        SDT = result.GetString(8),
                        SoTaiKhoan = result.GetString(9),
                        NganHang = result.GetString(10),
                        Email = result.GetString(11),
                        MatKhau = result.GetString(12),
                        TrangThai = result.GetBoolean(13)
                    });
                }
            }
            cn.Close();
            return list;
        }

        public List<string> lay_thong_tin_lop()
        {
            List<string> list = new List<string>();
            string commandString = "SELECT DISTINCT Lop FROM ThongTinNguoiDung WHERE Lop IS NOT NULL AND Lop <> '';";
            SqlConnection cn = access.open();

            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    list.Add(result.GetString(0));
                }
            }
            cn.Close();
            return list;
        }

        public List<Tuple<string, string>> lay_thong_tin_phong_khoa()
        {
            List<Tuple<string, string>> list = new List<Tuple<string, string>>();
            string commandString = "SELECT DISTINCT Phong,Khoa FROM ThongTinNguoiDung WHERE Phong IS NOT NULL OR Khoa IS NOT NULL OR Phong <> '' OR Khoa <> '';";
            SqlConnection cn = access.open();

            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    if (!string.IsNullOrEmpty(result.GetString(0)) || !string.IsNullOrEmpty(result.GetString(1)))
                    {
                        list.Add(new Tuple<string, string>(result.GetString(0), result.GetString(1)));

                    }
                }
            }
            cn.Close();
            return list;
        }

        public List<ThongTinNguoiDungDto> lay_danh_sach_CB_GV_cung_phong_khoa(string? phong,string? khoa,string? input)
        {
            ChucVuBll chucVuBll = new ChucVuBll();
            List<ChucVuDto> chucVuDtos = chucVuBll.lay_tat_ca();
            List<int> listChucVuCBGV = chucVuDtos.Where(x=>!x.LaHocVien && x.CoQuyenBaoCom).Select(x=>x.Id).ToList();
            List<ThongTinNguoiDungDto> list = new List<ThongTinNguoiDungDto>();
            string commandString = "SELECT * FROM ThongTinNguoiDung WHERE ChucVuId in (@ChucVuId) ";
            SqlConnection cn = access.open();

            if(!string.IsNullOrEmpty(phong) && !string.IsNullOrEmpty(khoa))
            {
                commandString += "AND Phong = @Phong AND Khoa = @Khoa";
            }else if (!string.IsNullOrEmpty(phong))
            {
                commandString += "AND Phong = @Phong";
            }
            else if (!string.IsNullOrEmpty(khoa))
            {
                commandString += "AND Khoa = @Khoa";
            }
            if (input != null)
            {
                commandString += " AND (MaNguoiDung Like @input OR HoTen LIKE @input)";
            }
            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                if (input != null)
                {
                    cmd.Parameters.AddWithValue("@input", $"%{input}%");
                }
                if (!string.IsNullOrEmpty(phong) && !string.IsNullOrEmpty(khoa))
                {
                    cmd.Parameters.AddWithValue("@Phong", phong);
                    cmd.Parameters.AddWithValue("@Khoa", khoa);
                }
                else if (!string.IsNullOrEmpty(phong))
                {
                    cmd.Parameters.AddWithValue("@Phong", phong);
                }
                else if (!string.IsNullOrEmpty(khoa))
                {
                    cmd.Parameters.AddWithValue("@Khoa", khoa);
                }
                
                cmd.Parameters.AddWithValue("@ChucVuId", string.Join(",", listChucVuCBGV));
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    list.Add(new ThongTinNguoiDungDto
                    {
                        Id = result.GetInt32(0),
                        HoTen = result.GetString(1),
                        MaNguoiDung = result.GetString(2),
                        Lop = result.GetString(3),
                        Phong = result.GetString(4),
                        Khoa = result.GetString(5),
                        DonVi = result.GetString(6),
                        ChucVuId = result.GetInt32(7),
                        SDT = result.GetString(8),
                        SoTaiKhoan = result.GetString(9),
                        NganHang = result.GetString(10),
                        Email = result.GetString(11),
                        MatKhau = result.GetString(12),
                        TrangThai = result.GetBoolean(13)
                    });
                }
            }
            cn.Close();
            return list;
        }

        public bool them_nguoi_dung(ThongTinNguoiDungDto nguoiDungMoi)
        {
            string commandString = "INSERT INTO ThongTinNguoiDung (Id, HoTen, MaNguoiDung, Lop, Phong, Khoa, DonVi, ChucVuId, SDT, SoTaiKhoan, NganHang, Email, MatKhau, TrangThai)VALUES(@Id, @HoTen, @MaNguoiDung, @Lop, @Phong, @Khoa, @DonVi, @ChucVuId, @SDT, @SoTaiKhoan, @NganHang, @Email, @MatKhau, @TrangThai)";
            SqlConnection cn = access.open();
            SqlCommand command = new SqlCommand(commandString, cn);
            command.Parameters.AddWithValue("@Id", lay_max_id() + 1);
            command.Parameters.AddWithValue("@HoTen", nguoiDungMoi.HoTen);
            command.Parameters.AddWithValue("@MaNguoiDung", nguoiDungMoi.MaNguoiDung);
            command.Parameters.AddWithValue("@Lop", nguoiDungMoi.Lop == null?"": nguoiDungMoi.Lop);
            command.Parameters.AddWithValue("@Phong", nguoiDungMoi.Phong == null ? "" : nguoiDungMoi.Phong);
            command.Parameters.AddWithValue("@Khoa", nguoiDungMoi.Khoa == null ? "" : nguoiDungMoi.Khoa);
            command.Parameters.AddWithValue("@DonVi", nguoiDungMoi.DonVi);
            command.Parameters.AddWithValue("@ChucVuId", nguoiDungMoi.ChucVuId);
            command.Parameters.AddWithValue("@SDT", nguoiDungMoi.SDT);
            command.Parameters.AddWithValue("@SoTaiKhoan", nguoiDungMoi.SoTaiKhoan);
            command.Parameters.AddWithValue("@NganHang", nguoiDungMoi.NganHang);
            command.Parameters.AddWithValue("@Email", nguoiDungMoi.Email);
            command.Parameters.AddWithValue("@MatKHau", nguoiDungMoi.MatKhau);
            command.Parameters.AddWithValue("@TrangThai",1 );

            int result = access.ExecuteCommandText(command);
            cn.Close();
            return result > 0;
        }

        public int lay_max_id()
        {
            string commandString = "SELECT MAX(ID) FROM ThongTinNguoiDung;";
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
                        catch (Exception ex) {
                            cn.Close();
                        }
                    }
                }
            }
            cn.Close();
            return maxId;
        }

        public bool cap_nhat_nguoi_dung(ThongTinNguoiDungDto nguoiDungSua)
        {
            string commandString = @"
                                    UPDATE ThongTinNguoiDung 
                                    SET 
                                        HoTen = @HoTen,
                                        Lop = @Lop,
                                        Phong = @Phong,
                                        Khoa = @Khoa,
                                        DonVi = @DonVi,
                                        ChucVuId = @ChucVuId,
                                        SDT = @SDT,
                                        SoTaiKhoan = @SoTaiKhoan,
                                        NganHang = @NganHang,
                                        Email = @Email,
                                        MatKhau = @MatKhau,
                                        TrangThai = @TrangThai
                                    WHERE 
                                        MaNguoiDung = @MaNguoiDung";

            SqlConnection cn = access.open();
            SqlCommand command = new SqlCommand(commandString, cn);

            command.Parameters.AddWithValue("@HoTen", nguoiDungSua.HoTen);
            command.Parameters.AddWithValue("@Lop", nguoiDungSua.Lop == null ? "" : nguoiDungSua.Lop);
            command.Parameters.AddWithValue("@Phong", nguoiDungSua.Phong == null ? "" : nguoiDungSua.Phong);
            command.Parameters.AddWithValue("@Khoa", nguoiDungSua.Khoa == null ? "" : nguoiDungSua.Khoa);
            command.Parameters.AddWithValue("@DonVi", nguoiDungSua.DonVi);
            command.Parameters.AddWithValue("@ChucVuId", nguoiDungSua.ChucVuId);
            command.Parameters.AddWithValue("@SDT", nguoiDungSua.SDT);
            command.Parameters.AddWithValue("@SoTaiKhoan", nguoiDungSua.SoTaiKhoan);
            command.Parameters.AddWithValue("@NganHang", nguoiDungSua.NganHang);
            command.Parameters.AddWithValue("@Email", nguoiDungSua.Email);
            command.Parameters.AddWithValue("@MatKhau", nguoiDungSua.MatKhau);
            command.Parameters.AddWithValue("@TrangThai", nguoiDungSua.TrangThai);
            command.Parameters.AddWithValue("@MaNguoiDung", nguoiDungSua.MaNguoiDung);

            int rowsAffected = command.ExecuteNonQuery();
            cn.Close();
            // Kiểm tra số dòng bị ảnh hưởng
            return rowsAffected > 0;
        }

        public bool xoa_nguoi_dung(string maNguoiDung)
        {
            string commandString = @"
                            DELETE FROM ThongTinNguoiDung 
                            WHERE 
                                MaNguoiDung = @MaNguoiDung";

            SqlConnection cn = access.open();
            SqlCommand command = new SqlCommand(commandString, cn);

            command.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);

            try
            {
                // Sử dụng ExecuteNonQuery để thực thi lệnh DELETE
                int rowsAffected = command.ExecuteNonQuery();

                // Nếu số hàng bị ảnh hưởng > 0 thì xóa thành công
                cn.Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Log hoặc xử lý lỗi tại đây nếu cần
                Console.WriteLine(ex.Message);
                cn.Close();
                return false;
            }
        }


        public bool check_ton_tai_manguoidung(string maNguoiDung)
        {
           
                string commandString = @"
                                    SELECT * FROM ThongTinNguoiDung 
                                    WHERE 
                                        MaNguoiDung = @MaNguoiDung";

                SqlConnection cn = access.open();
                SqlCommand command = new SqlCommand(commandString, cn);

                command.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);
            try
            {
                // Thực thi lệnh SQL
                object result = command.ExecuteScalar();
                cn.Close();
                // Kiểm tra kết quả
                return result != null;
            }catch (Exception ex)
            {
                cn.Close();
                return false;
            }
            
        }

        internal List<string> lay_thong_tin_phong()
        {
            List<string> list = new List<string>();
            string commandString = "SELECT DISTINCT Phong FROM ThongTinNguoiDung WHERE Phong IS NOT NULL AND Phong <> '';";
            SqlConnection cn = access.open();

            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    list.Add(result.GetString(0));
                }
            }
            cn.Close();
            return list;
        }

        internal List<string> lay_thong_tin_khoa()
        {
            List<string> list = new List<string>();
            string commandString = "SELECT DISTINCT Khoa FROM ThongTinNguoiDung WHERE Khoa IS NOT NULL AND Khoa <> '';";
            SqlConnection cn = access.open();

            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    list.Add(result.GetString(0));
                }
            }
            cn.Close();
            return list;
        }
    }
}
