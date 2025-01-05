using PhanMemBaoCom.BLL;
using PhanMemBaoCom.DAL;
using PhanMemBaoCom.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaAn.GUI.ManHinhQLNAn
{
    public partial class UC_ThongKeCBGV : UserControl
    {
        public int phuongthuc { get; set; }
        public DateTime ngayHienTai { get; set; }
        public List<ThongTinNguoiDungDto> listNguoiDung { get; set; }
        public UC_ThongKeCBGV()
        {
            InitializeComponent();

            ngayHienTai = DateTime.Now;
            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            List<string> dsPhongKhoa = thongTinNguoiDungBll.lay_thong_tin_phong();
            dsPhongKhoa.AddRange(thongTinNguoiDungBll.lay_thong_tin_khoa());
            listNguoiDung = new List<ThongTinNguoiDungDto>();

            dsPhongKhoa.Insert(0, "Tất cả");
            cbxPhong.DataSource = dsPhongKhoa;
            cbxPhong.SelectedIndex = 0;

            listNguoiDung = thongTinNguoiDungBll.lay_danh_sach_CB_GV_cung_phong_khoa(null, null);
            HienThiCacNgayTrongThang(dtpThang.Value);
            LoadThongKe(dtpThang.Value);
        }
        public void HienThiCacNgayTrongThang(DateTime chonThang)
        {
            ngayHienTai = DateTime.Now;
            DateTime ngayBatDau = new DateTime(chonThang.Year, chonThang.Month, 1);
            DateTime ngayKetThuc = new DateTime(chonThang.Year, chonThang.Month, DateTime.DaysInMonth(chonThang.Year, chonThang.Month), 23, 59, 0);

            dgvCBGV.Columns.Clear();

            dgvCBGV.Columns.Add("STT", "STT");
            dgvCBGV.Columns[0].Width = 50;
            dgvCBGV.Columns.Add("HoTen", "Họ Tên");
            dgvCBGV.Columns[1].Width = 150;
            dgvCBGV.Columns.Add("MaNguoiDung", "Mã nguời dùng");
            dgvCBGV.Columns[2].Width = 140;
            dgvCBGV.Columns.Add("PhuongThuc", "Phương thức");
            dgvCBGV.Columns["PhuongThuc"].Frozen = true;
            dgvCBGV.Columns[3].Width = 150;
            for (int i = 1; i <= ngayKetThuc.Day; i++)
            {
                dgvCBGV.Columns.Add(i.ToString(), i.ToString());
                dgvCBGV.Columns[3 + i].Width = 35;
            }
            dgvCBGV.Columns.Add("TongBuoiDangKy", "Tổng buổi đăng ký");
            dgvCBGV.Columns.Add("TongTienPhaiDong", "Tổng tiền phải đóng");

            dgvCBGV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold, GraphicsUnit.Point);
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
                    dgvCBGV.Rows.Add(row);
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
                    dgvCBGV.Rows.Add(sang);
                    dgvCBGV.Rows.Add(trua);
                    dgvCBGV.Rows.Add(toi);
                    dgvCBGV.Rows[index].DefaultCellStyle.BackColor = SystemColors.Control;
                    index += 3;
                }
            }
        }
        public void LoadThongKe(DateTime chonThang)
        {
            DateTime ngayBatDau = new DateTime(chonThang.Year, chonThang.Month, 1);
            DateTime ngayKetThuc = new DateTime(chonThang.Year, chonThang.Month, DateTime.DaysInMonth(chonThang.Year, chonThang.Month), 23, 59, 0);

            LichSuLuuTruBll lichSuLuuTruBll = new LichSuLuuTruBll();
            lichSuLuuTruBll.ChuyenDoiDuLieu();
            int index = 0;
            int stt = 0;
            foreach (ThongTinNguoiDungDto item in listNguoiDung)
            {
                stt++;
                List<LichSuLuuTruDto> lichSuLuuTruDtos = lichSuLuuTruBll.lay_theo_thang_va_id(ngayBatDau, ngayKetThuc, item.Id);
                int[] tongSoBuoiAn = { 0, 0, 0 };
                decimal[] tongTienDong = { 0, 0, 0 };
                for (int i = 1; i <= ngayKetThuc.Day; i++)
                {

                    DateTime ngayTrongVLap = new DateTime(chonThang.Year, chonThang.Month, i);
                    DateTime thoiGianDauNgay = ngayTrongVLap;
                    DateTime thoiGianCuoiNgay = ngayTrongVLap.AddDays(1).AddMilliseconds(-1);
                    if (ngayTrongVLap < ngayHienTai.Date)//Lich su luu tru
                    {
                        List<LichSuLuuTruDto> lsSuatAn = lichSuLuuTruDtos.Where(x => x.NgayLuuTru >= thoiGianDauNgay && x.NgayLuuTru <= thoiGianCuoiNgay).ToList();
                        if (lsSuatAn.Count == 3)//Ăn
                        {
                            if (phuongthuc == 0)
                            {
                                dgvCBGV[3 + i, index].Value = "";
                                tongSoBuoiAn[0] += 3;
                                tongTienDong[0] += tinhTongTien(lsSuatAn, 0);
                                dgvCBGV[3 + i, index].Style.BackColor = Color.LightSkyBlue;
                            }
                            else
                            {
                                dgvCBGV[3 + i, index].Value = "";
                                dgvCBGV[3 + i, index + 1].Value = "";
                                dgvCBGV[3 + i, index + 2].Value = "";

                                tongSoBuoiAn[0] += 1;
                                tongTienDong[0] += tinhTongTien(lsSuatAn, 1);

                                tongSoBuoiAn[1] += 1;
                                tongTienDong[1] += tinhTongTien(lsSuatAn, 2);

                                tongSoBuoiAn[2] += 1;
                                tongTienDong[2] += tinhTongTien(lsSuatAn, 3);

                                dgvCBGV[3 + i, index].Style.BackColor = Color.LightSkyBlue;
                                dgvCBGV[3 + i, index + 1].Style.BackColor = Color.LightSkyBlue;
                                dgvCBGV[3 + i, index + 2].Style.BackColor = Color.LightSkyBlue;
                            }
                        }
                        else if (lsSuatAn.Count > 0)
                        {
                            if (phuongthuc == 0)
                            {
                                dgvCBGV[3 + i, index].Value = "A";
                                dgvCBGV[3 + i, index].Style.BackColor = Color.Yellow;

                                tongSoBuoiAn[0] += lsSuatAn.Count();
                                tongTienDong[0] += tinhTongTien(lsSuatAn, 0);
                            }
                            else
                            {
                                dgvCBGV[3 + i, index].Value = "X";
                                dgvCBGV[3 + i, index + 1].Value = "X";
                                dgvCBGV[3 + i, index + 2].Value = "X";

                                if (lsSuatAn.Any(x => x.ThoiDiem == 1))
                                {
                                    dgvCBGV[3 + i, index].Value = "";
                                    tongSoBuoiAn[0] += 1;
                                    tongTienDong[0] += tinhTongTien(lsSuatAn, 1);
                                }
                                if (lsSuatAn.Any(x => x.ThoiDiem == 2))
                                {
                                    dgvCBGV[3 + i, index + 1].Value = "";
                                    tongSoBuoiAn[1] += 1;
                                    tongTienDong[1] += tinhTongTien(lsSuatAn, 2);
                                }
                                if (lsSuatAn.Any(x => x.ThoiDiem == 3))
                                {
                                    dgvCBGV[3 + i, index + 2].Value = "";
                                    tongSoBuoiAn[2] += 1;
                                    tongTienDong[2] += tinhTongTien(lsSuatAn, 3);
                                }

                                dgvCBGV[3 + i, index].Style.BackColor = Color.Yellow;
                                dgvCBGV[3 + i, index + 1].Style.BackColor = Color.Yellow;
                                dgvCBGV[3 + i, index + 2].Style.BackColor = Color.Yellow;
                            }
                        }
                        else
                        {
                            dgvCBGV[3 + i, index].Value = "X";
                            if (phuongthuc != 0)
                            {
                                dgvCBGV[3 + i, index + 1].Value = "X";
                                dgvCBGV[3 + i, index + 2].Value = "X";
                            }
                        }
                    }
                }

                if (phuongthuc == 0)
                {
                    dgvCBGV[4 + ngayKetThuc.Day, index].Value = tongSoBuoiAn[0];
                    dgvCBGV[5 + ngayKetThuc.Day, index].Value = tongTienDong[0];
                    index += 1;

                }
                else
                {
                    dgvCBGV[4 + ngayKetThuc.Day, index].Value = tongSoBuoiAn[0];
                    dgvCBGV[5 + ngayKetThuc.Day, index].Value = tongTienDong[0];

                    dgvCBGV[4 + ngayKetThuc.Day, index + 1].Value = tongSoBuoiAn[1];
                    dgvCBGV[5 + ngayKetThuc.Day, index + 1].Value = tongTienDong[1];

                    dgvCBGV[4 + ngayKetThuc.Day, index + 2].Value = tongSoBuoiAn[2];
                    dgvCBGV[5 + ngayKetThuc.Day, index + 2].Value = tongTienDong[2];
                    index += 3;
                }
            }

        }

        private decimal tinhTongTien(List<LichSuLuuTruDto> lsSuatAn, int thoiDiem)
        {
            decimal tong = 0;
            if (thoiDiem == 0)
            {
                foreach (var item in lsSuatAn)
                {
                    tong += item.SoTienTuongUng;
                }
            }
            else
            {
                foreach (var item in lsSuatAn.Where(x => x.ThoiDiem == thoiDiem))
                {
                    tong += item.SoTienTuongUng;
                }
            }

            return tong;
        }


        private void dtpThang_ValueChanged(object sender, EventArgs e)
        {
            HienThiCacNgayTrongThang(dtpThang.Value);
            LoadThongKe(dtpThang.Value);
        }

        private void cbxPhuongThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            phuongthuc = cbxPhuongThuc.SelectedIndex;
            HienThiCacNgayTrongThang(dtpThang.Value);
            LoadThongKe(dtpThang.Value);
        }

        private void cbxPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string phongKhoa = cbxPhong.SelectedValue == null ? string.Empty : cbxPhong.SelectedValue.ToString();
                string timKiem = txbTimKiem.Text;
                ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
                listNguoiDung = thongTinNguoiDungBll.lay_danh_sach_CB_GV_cung_phong_khoa(phongKhoa.Equals("Tất cả") ? null : phongKhoa, timKiem);
                HienThiCacNgayTrongThang(dtpThang.Value);
                LoadThongKe(dtpThang.Value);
            }
            catch { }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            listNguoiDung.Clear();
            string phongKhoa = cbxPhong.SelectedValue.ToString();
            string timKiem = txbTimKiem.Text;

            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            listNguoiDung = thongTinNguoiDungBll.lay_danh_sach_CB_GV_cung_phong_khoa(phongKhoa.Equals("Tất cả")?null: phongKhoa, timKiem);
            HienThiCacNgayTrongThang(dtpThang.Value);
            LoadThongKe(dtpThang.Value);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            listNguoiDung.Clear();
            cbxPhong.SelectedIndex = 0;
            txbTimKiem.Text = string.Empty;

            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            listNguoiDung = thongTinNguoiDungBll.lay_danh_sach_CB_GV_cung_phong_khoa(null, null);
            HienThiCacNgayTrongThang(dtpThang.Value);
            LoadThongKe(dtpThang.Value);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Đặt tiêu đề
                saveFileDialog.Title = "Chọn nơi lưu file Excel";

                // Đặt bộ lọc file
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";

                // Đặt tên file mặc định (tuỳ ý)
                saveFileDialog.FileName = "Report.xlsx";

                // Hiển thị hộp thoại
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file được chọn
                    string filePath = saveFileDialog.FileName;

                    // Thực hiện lưu file Excel tại đây
                    MessageBox.Show($"File sẽ được lưu tại: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Gọi hàm xuất dữ liệu ra file Excel với đường dẫn được chọn
                    DataAccess dataAccess = new DataAccess();
                    dataAccess.ExportToExcel(dgvCBGV, filePath);
                }
            }
        }
    }
}
