using PhanMemBaoCom.BLL;
using PhanMemBaoCom.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyNhaAn.GUI.ManHinhQLNAn
{
    public partial class UC_ThongTinSuatAnLPHCan : UserControl
    {
        public ThongTinNguoiDungDto thongTinNguoiDungDto { get; set; }
        public int phuongthuc { get; set; }
        public DateTime ngayHienTai { get; set; }
        public List<ThongTinNguoiDungDto> listNguoiDung { get; set; }
        public UC_ThongTinSuatAnLPHCan(ThongTinNguoiDungDto dto)
        {
            InitializeComponent();

            thongTinNguoiDungDto = dto;
            phuongthuc = 0;
            ngayHienTai = DateTime.Now;
            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            listNguoiDung = thongTinNguoiDungBll.lay_danh_sach_hoc_vien_cung_lop(thongTinNguoiDungDto.Lop,null);

            HienThiCacNgayTrongThang(dtpThang.Value);
            LoadLich(dtpThang.Value);
        }


        public void HienThiCacNgayTrongThang(DateTime chonThang)
        {
            DateTime ngayBatDau = new DateTime(chonThang.Year, chonThang.Month, 1);
            DateTime ngayKetThuc = new DateTime(chonThang.Year, chonThang.Month, DateTime.DaysInMonth(chonThang.Year, chonThang.Month), 23, 59, 0);

            dgvSuatAn.Columns.Clear();

            dgvSuatAn.Columns.Add("STT", "STT");
            dgvSuatAn.Columns.Add("HoTen", "Họ Tên");
            dgvSuatAn.Columns.Add("MaHocVien", "Mã học viên");
            dgvSuatAn.Columns.Add("PhuongThuc", "Phương thức");
            dgvSuatAn.Columns["PhuongThuc"].Frozen = true;
            for (int i = 1; i <= ngayKetThuc.Day; i++)
            {
                dgvSuatAn.Columns.Add(i.ToString(), i.ToString());
            }

            
            int stt = 0;
            int index = 0;
            foreach (ThongTinNguoiDungDto item in listNguoiDung)
            {
                stt++;

                if (phuongthuc == 0)
                {
                    string[] row = new string[ngayKetThuc.Day + 4];

                    row[0] = stt.ToString();
                    row[1] = item.HoTen;
                    row[2] = item.MaNguoiDung;
                    row[3] = "Ngày";
                    dgvSuatAn.Rows.Add(row);
                }
                else
                {
                    string[] sang = new string[ngayKetThuc.Day + 4];
                    string[] trua = new string[ngayKetThuc.Day + 4];
                    string[] toi = new string[ngayKetThuc.Day + 4];
                    sang[0] = stt.ToString();
                    sang[1] = item.HoTen;
                    sang[2] = item.MaNguoiDung;
                    sang[3] = "Sáng";
                    trua[3] = "Trưa";
                    toi[3] = "Tối";
                    dgvSuatAn.Rows.Add(sang);
                    dgvSuatAn.Rows.Add(trua);
                    dgvSuatAn.Rows.Add(toi);
                    index += 3;
                }
            }
        }
        public void LoadLich(DateTime chonThang)
        {

            DateTime ngayBatDau = new DateTime(chonThang.Year, chonThang.Month, 1);
            DateTime ngayKetThuc = new DateTime(chonThang.Year, chonThang.Month, DateTime.DaysInMonth(chonThang.Year, chonThang.Month), 23, 59, 0);

            YeuCauDangKyBll yeuCauDangKyBll = new YeuCauDangKyBll();
            LichSuLuuTruBll lichSuLuuTruBll = new LichSuLuuTruBll();
            lichSuLuuTruBll.ChuyenDoiDuLieu();
            int index = 0;
            int stt = 0;
            foreach (ThongTinNguoiDungDto item in listNguoiDung)
            {
                stt++;
                List<LichSuLuuTruDto> lichSuLuuTruDtos = lichSuLuuTruBll.lay_theo_thang_va_id(ngayBatDau, ngayKetThuc, item.Id);
                List<YeuCauDangKyDto> yeuCauDangKyDtos = yeuCauDangKyBll.lay_theo_thang_va_id(ngayBatDau, ngayKetThuc, item.Id);

                for (int i = 1; i <= ngayKetThuc.Day; i++)
                {

                    DateTime ngayTrongVLap = new DateTime(chonThang.Year, chonThang.Month, i);
                    DateTime thoiGianDauNgay = ngayTrongVLap;
                    DateTime thoiGianCuoiNgay = ngayTrongVLap.AddDays(1).AddMilliseconds(-1);
                    if (ngayTrongVLap < ngayHienTai.Date)//Lich su luu tru
                    {
                        List<LichSuLuuTruDto> lsSuatAn = lichSuLuuTruDtos.Where(x => x.NgayLuuTru >= thoiGianDauNgay && x.NgayLuuTru <= thoiGianCuoiNgay).ToList();
                        if (lsSuatAn.Count == 3)//Không ăn
                        {
                            if (phuongthuc == 0)
                            {
                                dgvSuatAn[3 + i, index].Value = "";
                                dgvSuatAn[3 + i, index].Style.BackColor = Color.Red;
                            }
                            else
                            {
                                dgvSuatAn[3 + i, index].Value = "";
                                dgvSuatAn[3 + i, index + 1].Value = "";
                                dgvSuatAn[3 + i, index + 2].Value = "";

                                dgvSuatAn[3 + i, index].Style.BackColor = Color.Red;
                                dgvSuatAn[3 + i, index + 1].Style.BackColor = Color.Red;
                                dgvSuatAn[3 + i, index + 2].Style.BackColor = Color.Red;
                            }
                        }
                        else if (lsSuatAn.Count > 0)
                        {
                            if (phuongthuc == 0)
                            {
                                dgvSuatAn[3 + i, index].Value = "A";
                                dgvSuatAn[3 + i, index].Style.BackColor = Color.Yellow;
                            }
                            else
                            {
                                dgvSuatAn[3 + i, index].Value = "X";
                                dgvSuatAn[3 + i, index + 1].Value = "X";
                                dgvSuatAn[3 + i, index + 2].Value = "X";

                                if (lsSuatAn.Any(x => x.ThoiDiem == 1))
                                {
                                    dgvSuatAn[3 + i, index].Value = "";
                                }
                                if (lsSuatAn.Any(x => x.ThoiDiem == 2))
                                {
                                    dgvSuatAn[3 + i, index + 1].Value = "";
                                }
                                if (lsSuatAn.Any(x => x.ThoiDiem == 3))
                                {
                                    dgvSuatAn[3 + i, index + 2].Value = "";
                                }

                                dgvSuatAn[3 + i, index].Style.BackColor = Color.Yellow;
                                dgvSuatAn[3 + i, index + 1].Style.BackColor = Color.Yellow;
                                dgvSuatAn[3 + i, index + 2].Style.BackColor = Color.Yellow;
                            }
                        }
                        else
                        {
                            dgvSuatAn[3 + i, index].Value = "X";
                            if (phuongthuc != 0)
                            {
                                dgvSuatAn[3 + i, index + 1].Value = "X";
                                dgvSuatAn[3 + i, index + 2].Value = "X";
                            }
                        }
                    }
                    else if (ngayTrongVLap > ngayHienTai.Date)//Yeu cau dang ky
                    {

                        List<YeuCauDangKyDto> lsSuatAn = yeuCauDangKyDtos.Where(x => x.NgayDangKy >= thoiGianDauNgay && x.NgayDangKy <= thoiGianCuoiNgay).ToList();
                        if (lsSuatAn.Count == 3)//Không ăn
                        {
                            if (phuongthuc == 0)
                            {
                                DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                                dgvSuatAn[3 + i, index] = checkBoxCell;
                                dgvSuatAn[3 + i, index].Value = false;
                            }
                            else
                            {
                                DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                                dgvSuatAn[3 + i, index] = checkBoxCell;
                                dgvSuatAn[3 + i, index].Value = false;

                                DataGridViewCheckBoxCell checkBoxCell1 = new DataGridViewCheckBoxCell();
                                dgvSuatAn[3 + i, index + 1] = checkBoxCell1;
                                dgvSuatAn[3 + i, index + 1].Value = false;

                                DataGridViewCheckBoxCell checkBoxCell2 = new DataGridViewCheckBoxCell();
                                dgvSuatAn[3 + i, index + 2] = checkBoxCell2;
                                dgvSuatAn[3 + i, index + 2].Value = false;

                            }
                        }
                        else if (lsSuatAn.Count > 0)
                        {
                            if (phuongthuc == 0)
                            {
                                DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                                dgvSuatAn[3 + i, index] = checkBoxCell;
                                dgvSuatAn[3 + i, index].Value = false;
                            }
                            else
                            {
                                DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                                dgvSuatAn[3 + i, index] = checkBoxCell;
                                dgvSuatAn[3 + i, index].Value = true;

                                DataGridViewCheckBoxCell checkBoxCell1 = new DataGridViewCheckBoxCell();
                                dgvSuatAn[3 + i, index + 1] = checkBoxCell1;
                                dgvSuatAn[3 + i, index + 1].Value = true;

                                DataGridViewCheckBoxCell checkBoxCell2 = new DataGridViewCheckBoxCell();
                                dgvSuatAn[3 + i, index + 2] = checkBoxCell2;
                                dgvSuatAn[3 + i, index + 2].Value = true;

                                if (lsSuatAn.Any(x => x.ThoiDiem == 1))
                                {
                                    dgvSuatAn[3 + i, index].Value = false;
                                }
                                if (lsSuatAn.Any(x => x.ThoiDiem == 2))
                                {
                                    dgvSuatAn[3 + i, index + 1].Value = false;
                                }
                                if (lsSuatAn.Any(x => x.ThoiDiem == 3))
                                {
                                    dgvSuatAn[3 + i, index + 2].Value = false;
                                }
                            }
                        }
                        else
                        {
                            DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                            dgvSuatAn[3 + i, index] = checkBoxCell;
                            dgvSuatAn[3 + i, index].Value = true;
                            if (phuongthuc != 0)
                            {
                                DataGridViewCheckBoxCell checkBoxCell1 = new DataGridViewCheckBoxCell();
                                dgvSuatAn[3 + i, index + 1] = checkBoxCell1;
                                dgvSuatAn[3 + i, index + 1].Value = true;

                                DataGridViewCheckBoxCell checkBoxCell2 = new DataGridViewCheckBoxCell();
                                dgvSuatAn[3 + i, index + 2] = checkBoxCell2;
                                dgvSuatAn[3 + i, index + 2].Value = true;
                            }
                        }
                    }
                    else//Ngay hien tai
                    {
                        List<LichSuLuuTruDto> lsSuatAn = lichSuLuuTruDtos.Where(x => x.NgayLuuTru >= thoiGianDauNgay && x.NgayLuuTru <= thoiGianCuoiNgay).ToList();
                        List<YeuCauDangKyDto> lsSuatAn1 = yeuCauDangKyDtos.Where(x => x.NgayDangKy >= thoiGianDauNgay && x.NgayDangKy <= thoiGianCuoiNgay).ToList();
                        // Thời điểm hiện tại
                        //DateTime thoiGianHienTai = DateTime.Now;

                        // Kiểm tra hạn thời gian của từng buổi
                        ThongTinHeThongBll thongTinHeThongBll = new ThongTinHeThongBll();
                        ThongTinHeThongDto thongTinHeThongDto = thongTinHeThongBll.lay_tat_ca();

                        DateTime hanGioMoSang = ngayTrongVLap.AddDays(-1).Date.AddHours(thongTinHeThongDto.HanBaoSang.TotalHours); // 10 giờ sáng hôm trước
                        DateTime hanGioMoTruaToi = ngayTrongVLap.Date.AddHours(thongTinHeThongDto.HanBaoTruaToi.TotalHours);  // 7 giờ sáng hôm nay

                        // Danh sách lưu trữ trạng thái của các buổi
                        bool quaHanSang = ngayHienTai >= hanGioMoSang;
                        bool quaHanTrua = ngayHienTai >= hanGioMoTruaToi;

                        if (phuongthuc == 0) // Chọn phương thức theo ngày
                        {
                            // Nếu tất cả các buổi đều quá hạn
                            if (quaHanSang && quaHanTrua)
                            {
                                dgvSuatAn[3 + i, index].Value = "X";
                                if (lsSuatAn.Count == 3)//Không ăn
                                {
                                    dgvSuatAn[3 + i, index].Value = "";
                                    dgvSuatAn[3 + i, index].Style.BackColor = Color.Red;
                                }
                                else if (lsSuatAn.Count > 0)
                                {
                                    dgvSuatAn[3 + i, index].Value = "A";
                                    dgvSuatAn[3 + i, index].Style.BackColor = Color.Yellow;
                                }
                            }
                            else
                            {
                                DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                                dgvSuatAn[3 + i, index] = checkBoxCell;
                                dgvSuatAn[3 + i, index].Value = true;
                                if (lsSuatAn1.Count == 3)
                                {
                                    dgvSuatAn[3 + i, index].Value = false;
                                }
                            }
                        }
                        else // Chọn theo phương thức theo từng buổi
                        {
                            if (quaHanSang && quaHanTrua)
                            {
                                if (lsSuatAn.Count == 3)//Không ăn
                                {
                                    dgvSuatAn[3 + i, index].Style.BackColor = Color.Red;
                                    dgvSuatAn[3 + i, index + 1].Style.BackColor = Color.Red;
                                    dgvSuatAn[3 + i, index + 2].Style.BackColor = Color.Red;
                                }
                                else if (lsSuatAn.Count > 0)
                                {
                                    dgvSuatAn[3 + i, index].Style.BackColor = Color.Yellow;
                                    dgvSuatAn[3 + i, index + 1].Style.BackColor = Color.Yellow;
                                    dgvSuatAn[3 + i, index + 2].Style.BackColor = Color.Yellow;
                                }
                            }

                            // Xử lý cho buổi sáng
                            if (quaHanSang)
                            {
                                //Hien tex của sáng
                                dgvSuatAn[3 + i, index].Value = "X";
                                if (lsSuatAn.Any(x => x.ThoiDiem == 1))
                                {
                                    dgvSuatAn[3 + i, index].Value = "";
                                }
                            }
                            else
                            {
                                DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                                dgvSuatAn[3 + i, index] = checkBoxCell;
                                dgvSuatAn[3 + i, index].Value = true;
                                if (lsSuatAn1.Any(x => x.ThoiDiem == 1))
                                {
                                    dgvSuatAn[3 + i, index].Value = false;
                                }
                            }

                            // Xử lý cho buổi trưa
                            if (quaHanTrua)
                            {
                                dgvSuatAn[3 + i, index + 1].Value = "X";
                                if (lsSuatAn.Any(x => x.ThoiDiem == 2))
                                {
                                    dgvSuatAn[3 + i, index + 1].Value = "";
                                }

                                dgvSuatAn[3 + i, index + 2].Value = "X";
                                if (lsSuatAn.Any(x => x.ThoiDiem == 3))
                                {
                                    dgvSuatAn[3 + i, index + 2].Value = "";
                                }
                            }
                            else
                            {
                                DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                                dgvSuatAn[3 + i, index + 1] = checkBoxCell;
                                dgvSuatAn[3 + i, index + 1].Value = true;
                                if (lsSuatAn1.Any(x => x.ThoiDiem == 2))
                                {
                                    dgvSuatAn[3 + i, index + 1].Value = false;
                                }

                                DataGridViewCheckBoxCell checkBoxCell2 = new DataGridViewCheckBoxCell();
                                dgvSuatAn[3 + i, index + 2] = checkBoxCell2;
                                dgvSuatAn[3 + i, index + 2].Value = true;
                                if (lsSuatAn1.Any(x => x.ThoiDiem == 3))
                                {
                                    dgvSuatAn[3 + i, index + 2].Value = false;
                                }
                            }

                        }
                    }
                }

                if (phuongthuc == 0)
                {
                    index += 1;
                }
                else
                {
                    index += 3;
                }
            }

        }
        public void cbxPhuongThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ngayHienTai = DateTime.Now;
            phuongthuc = cbxPhuongThuc.SelectedIndex;
            HienThiCacNgayTrongThang(dtpThang.Value);
            LoadLich(dtpThang.Value);
        }

        private void dtpThang_ValueChanged(object sender, EventArgs e)
        {
            ngayHienTai = DateTime.Now;
            HienThiCacNgayTrongThang(dtpThang.Value);
            LoadLich(dtpThang.Value);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ngayHienTai = DateTime.Now;
            txbTimKiem.Text = null;
            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            listNguoiDung = thongTinNguoiDungBll.lay_danh_sach_hoc_vien_cung_lop(thongTinNguoiDungDto.Lop, null);

            HienThiCacNgayTrongThang(dtpThang.Value);
            LoadLich(dtpThang.Value);
        }

        private void btnLuuLich_Click(object sender, EventArgs e)
        {
            if (Cursor.Current != Cursors.WaitCursor)
            {
                Cursor = Cursors.WaitCursor;

                // Tạo các đối tượng BLL và lấy thông tin hệ thống chỉ một lần
                ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
                YeuCauDangKyBll yeuCauDangKyBll = new YeuCauDangKyBll();
                ThongTinHeThongBll thongTinHeThongBll = new ThongTinHeThongBll();
                ThongTinHeThongDto thongTinHeThongDto = thongTinHeThongBll.lay_tat_ca();

                DateTime ngayHienTai = DateTime.Now;
                DateTime thangDangKy = dtpThang.Value;

                foreach (DataGridViewRow row in dgvSuatAn.Rows)
                {
                    string maHocVien = row.Cells["MaHocVien"].Value?.ToString();
                    string tenPhuongThuc = row.Cells["PhuongThuc"].Value?.ToString();
                    if (string.IsNullOrEmpty(tenPhuongThuc)) continue;

                    // Lấy mã học viên dựa trên phương thức
                    if (tenPhuongThuc == "Trưa" && row.Index > 0)
                        maHocVien = dgvSuatAn.Rows[row.Index - 1].Cells["MaHocVien"].Value?.ToString();
                    else if (tenPhuongThuc == "Tối" && row.Index > 1)
                        maHocVien = dgvSuatAn.Rows[row.Index - 2].Cells["MaHocVien"].Value?.ToString();

                    if (string.IsNullOrEmpty(maHocVien)) continue;

                    ThongTinNguoiDungDto thongTinNguoiDung = thongTinNguoiDungBll.lay_chi_tiet_theo_mngdung(maHocVien);
                    if (thongTinNguoiDung == null) continue;

                    for (int i = 4; i < dgvSuatAn.Columns.Count; i++)
                    {
                        var cell = row.Cells[i];
                        if (cell is not DataGridViewCheckBoxCell checkBoxCell) continue;

                        // Tính ngày đăng ký
                        int ngay = int.Parse(dgvSuatAn.Columns[i].HeaderText);
                        DateTime ngayDuocTich = new DateTime(thangDangKy.Year, thangDangKy.Month, ngay);

                        DateTime hanGioMoSang = ngayDuocTich.AddDays(-1).Date.AddHours(thongTinHeThongDto.HanBaoSang.TotalHours);
                        DateTime hanGioMoTruaToi = ngayDuocTich.Date.AddHours(thongTinHeThongDto.HanBaoTruaToi.TotalHours);

                        bool quaHanSang = ngayHienTai >= hanGioMoSang;
                        bool quaHanTrua = ngayHienTai >= hanGioMoTruaToi;

                        // Tính thời điểm và thêm/xóa yêu cầu đăng ký
                        int thoiDiem = tenPhuongThuc switch
                        {
                            "Sáng" => 1,
                            "Trưa" => 2,
                            "Tối" => 3,
                            "Ngày" => 0
                        };

                        if ((thoiDiem == 0 && quaHanSang && quaHanTrua) || (thoiDiem == 1 && quaHanSang) || (thoiDiem > 1 && quaHanTrua)) continue;

                        if (thoiDiem == 0)
                        {
                            ChinhSuaYeuCau(thongTinNguoiDung, ngayDuocTich, 1, (bool)cell.Value);
                            ChinhSuaYeuCau(thongTinNguoiDung, hanGioMoTruaToi, 2, (bool)cell.Value);
                            ChinhSuaYeuCau(thongTinNguoiDung, hanGioMoTruaToi, 3, (bool)cell.Value);
                        }
                        else
                        {
                            switch (thoiDiem)
                            {
                                case 1:
                                    ChinhSuaYeuCau(thongTinNguoiDung, ngayDuocTich, 1, (bool)cell.Value);
                                    break;
                                case 2:
                                    ChinhSuaYeuCau(thongTinNguoiDung, hanGioMoTruaToi, 2, (bool)cell.Value);
                                    break;
                                case 3:
                                    ChinhSuaYeuCau(thongTinNguoiDung, hanGioMoTruaToi, 3, (bool)cell.Value);
                                    break;
                            }
                        }


                    }
                }

                Cursor = Cursors.Default;
            }
            MessageBox.Show(
                            "Đã lưu lịch thành công!\nLưu ý: \n   Những buổi quá hạn thì sẽ không được lưu vào trong hệ thống",
                            "Thông báo", // Tiêu đề của thông báo
                            MessageBoxButtons.OK, // Các nút hiển thị trong thông báo
                            MessageBoxIcon.Information // Biểu tượng hiển thị (Warning, Error, Information, etc.)
                        );
            HienThiCacNgayTrongThang(dtpThang.Value);
            LoadLich(dtpThang.Value);

        }

        private void ChinhSuaYeuCau(ThongTinNguoiDungDto thongTinNguoiDung, DateTime ngayDuocTich, int v, bool value)
        {
            YeuCauDangKyBll yeuCauDangKyBll = new YeuCauDangKyBll();
            YeuCauDangKyDto yeuCauDangKySang = new YeuCauDangKyDto
            {
                Id = yeuCauDangKyBll.lay_max_id() + 1,
                NguoiDungId = thongTinNguoiDung.Id,
                NgayDangKy = ngayDuocTich,
                ThoiDiem = v
            };

            if (!value)
            {
                yeuCauDangKyBll.them_yeu_cau(yeuCauDangKySang);
            }
            else
            {
                yeuCauDangKyBll.xoa_yeu_cau(yeuCauDangKySang);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string input = txbTimKiem.Text;
            ThongTinNguoiDungBll bll = new ThongTinNguoiDungBll();
            listNguoiDung =bll.lay_danh_sach_hoc_vien_cung_lop(thongTinNguoiDungDto.Lop,input.Trim());
            HienThiCacNgayTrongThang(dtpThang.Value);
            LoadLich(dtpThang.Value);
        }
    }
}
