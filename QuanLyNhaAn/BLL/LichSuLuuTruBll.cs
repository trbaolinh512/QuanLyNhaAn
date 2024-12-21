using Microsoft.Data.SqlClient;
using PhanMemBaoCom.DAL;
using PhanMemBaoCom.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PhanMemBaoCom.BLL
{
    public class LichSuLuuTruBll
    {
        DataAccess access = new DataAccess();
        public LichSuLuuTruBll()
        {
        }
        public List<LichSuLuuTruDto> lay_theo_thang_va_id(DateTime batdau,DateTime ketthuc,int nguoidungId)
        {
            List<LichSuLuuTruDto> list = new List<LichSuLuuTruDto> ();

             batdau = batdau.Date; // Đầu ngày (00:00:00)
             ketthuc = ketthuc.Date.AddDays(1).AddTicks(-1); // Cuối ngày (23:59:59)

            string commandString = "SELECT * FROM LichSuLuuTru WHERE NgayLuuTru BETWEEN @ngaybatdau AND @ngayketthuc AND NguoiDungId = @nguoidungId; ";
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
                        // Map dữ liệu từ SqlDataReader sang đối tượng LichSuLuuTruDto
                        LichSuLuuTruDto item = new LichSuLuuTruDto
                        {
                            Id = reader.GetInt32(0),
                            NguoiDungId = reader.GetInt32(1),
                            NgayLuuTru = reader.GetDateTime(2),
                            ThoiDiem = reader.GetInt32(3),
                            SoTienTuongUng = reader.GetDecimal(4)
                        };
                        list.Add(item);
                    }
                }
            }
            cn.Close();
            return list;
        }

        public void ChuyenDoiDuLieu()
        {
            ThongTinHeThongBll thongTinHeThongBll = new ThongTinHeThongBll();
            YeuCauDangKyBll yeuCauDangKyBll = new YeuCauDangKyBll();
            ChucVuBll chucVuBll = new ChucVuBll();
            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();

            ThongTinHeThongDto thongTinHeThongDto = thongTinHeThongBll.lay_tat_ca();
            List<YeuCauDangKyDto> listYeuCauDangKyDtos = yeuCauDangKyBll.lay_yeu_cau_can_chuyen_doi();

            foreach(YeuCauDangKyDto y in listYeuCauDangKyDtos)
            {
                decimal giatientuongung = 0;
                ThongTinNguoiDungDto thongTinNguoiDungDto = thongTinNguoiDungBll.lay_chi_tiet_theo_iddung(y.NguoiDungId);
                ChucVuDto chucVuDto=chucVuBll.lay_theo_id(thongTinNguoiDungDto.ChucVuId);
                if (chucVuDto.LaHocVien)
                {
                    switch (y.ThoiDiem)
                    {
                        case 1:
                            giatientuongung = thongTinHeThongDto.GiaTienHocVienSang;
                            break;
                        case 2:
                            giatientuongung = thongTinHeThongDto.GiaTienHocVienTrua;
                            break;
                        case 3:
                            giatientuongung = thongTinHeThongDto.GiaTienHocVienToi;
                            break;
                    }
                }
                else
                {
                    switch (y.ThoiDiem)
                    {
                        case 1:
                            giatientuongung = thongTinHeThongDto.GiaTienCanBoSang;
                            break;
                        case 2:
                            giatientuongung = thongTinHeThongDto.GiaTienCanBoTrua;
                            break;
                        case 3:
                            giatientuongung = thongTinHeThongDto.GiaTienCanBoToi;
                            break;
                    }
                }
                int id = lay_max_id();
                LichSuLuuTruDto lichSuLuuTruDto = new LichSuLuuTruDto
                {
                    Id = id + 1,
                    NguoiDungId = y.NguoiDungId,
                    NgayLuuTru = y.NgayDangKy,
                    ThoiDiem = y.ThoiDiem,
                    SoTienTuongUng = giatientuongung
                };
                them_lich_su(lichSuLuuTruDto);
                yeuCauDangKyBll.xoa_yeu_cau(y);
            }
        }

        public void them_lich_su(LichSuLuuTruDto dto)
        {
            string commandString = "INSERT INTO LichSuLuuTru (Id, NguoiDungId, NgayLuuTru, ThoiDiem, SoTienTuongUng) VALUES (@Id, @NguoiDungId, @NgayLuuTru, @ThoiDiem, @SoTienTuongUng) ";
            SqlConnection cn = access.open();
            using (SqlCommand cmd = new SqlCommand(commandString, cn))
            {
                // Thêm các tham số
                cmd.Parameters.AddWithValue("@Id", dto.Id);
                cmd.Parameters.AddWithValue("@NguoiDungId", dto.NguoiDungId);
                cmd.Parameters.AddWithValue("@NgayLuuTru", dto.NgayLuuTru);
                cmd.Parameters.AddWithValue("@ThoiDiem", dto.ThoiDiem);
                cmd.Parameters.AddWithValue("@SoTienTuongUng", dto.SoTienTuongUng);
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
            string commandString = "SELECT MAX(ID) FROM LichSuLuuTru;";
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
                        }catch (Exception ex) { }
                    }
                }
            }
            cn.Close();
            return maxId;
        }
    }
}
