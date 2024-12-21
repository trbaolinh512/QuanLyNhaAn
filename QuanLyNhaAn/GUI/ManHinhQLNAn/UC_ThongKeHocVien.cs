using PhanMemBaoCom.BLL;
using PhanMemBaoCom.DAL;
using PhanMemBaoCom.DTO;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyNhaAn.GUI.ManHinhQLNAn
{
    public partial class UC_ThongKeHocVien : UserControl
    {
        public int phuongthuc { get; set; }
        public DateTime ngayHienTai { get; set; }
        public List<ThongTinNguoiDungDto> listNguoiDung { get; set; }
        public UC_ThongKeHocVien()
        {
            InitializeComponent();
            ngayHienTai = DateTime.Now;
            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            List<string> dsLop = thongTinNguoiDungBll.lay_thong_tin_lop();
            listNguoiDung = new List<ThongTinNguoiDungDto>();
            foreach (string s in dsLop)
            {
                listNguoiDung.AddRange(thongTinNguoiDungBll.lay_danh_sach_hoc_vien_cung_lop(s, null));
            }

            dsLop.Insert(0, "Tất cả");
            cbxLop.DataSource = dsLop;
            cbxLop.SelectedIndex = 0;
            HienThiCacNgayTrongThang(dtpThang.Value);
            LoadThongKe(dtpThang.Value);


        }

        public void HienThiCacNgayTrongThang(DateTime chonThang)
        {
            DateTime ngayBatDau = new DateTime(chonThang.Year, chonThang.Month, 1);
            DateTime ngayKetThuc = new DateTime(chonThang.Year, chonThang.Month, DateTime.DaysInMonth(chonThang.Year, chonThang.Month), 23, 59, 0);

            dgvHocVien.Columns.Clear();

            dgvHocVien.Columns.Add("STT", "STT");
            dgvHocVien.Columns.Add("HoTen", "Họ Tên");
            dgvHocVien.Columns.Add("MaHocVien", "Mã học viên");
            dgvHocVien.Columns.Add("PhuongThuc", "Phương thức");
            dgvHocVien.Columns["PhuongThuc"].Frozen = true;
            for (int i = 1; i <= ngayKetThuc.Day; i++)
            {
                dgvHocVien.Columns.Add(i.ToString(), i.ToString());
            }
            dgvHocVien.Columns.Add("TongBuoiNghi", "Tổng buổi nghỉ");
            dgvHocVien.Columns.Add("TongTienHoan", "Tổng tiền hoàn lại");

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
                    dgvHocVien.Rows.Add(row);
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
                    dgvHocVien.Rows.Add(sang);
                    dgvHocVien.Rows.Add(trua);
                    dgvHocVien.Rows.Add(toi);
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
                int[] tongSoBuoiNghi = { 0, 0, 0 };
                decimal[] tongTienHoan = { 0, 0, 0 };
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
                                dgvHocVien[3 + i, index].Value = "";
                                tongSoBuoiNghi[0] += 3;
                                tongTienHoan[0] += tinhTongTien(lsSuatAn, 0);
                                dgvHocVien[3 + i, index].Style.BackColor = Color.Red;
                            }
                            else
                            {
                                dgvHocVien[3 + i, index].Value = "";
                                dgvHocVien[3 + i, index + 1].Value = "";
                                dgvHocVien[3 + i, index + 2].Value = "";

                                tongSoBuoiNghi[0] += 1;
                                tongTienHoan[0] += tinhTongTien(lsSuatAn, 1);

                                tongSoBuoiNghi[1] += 1;
                                tongTienHoan[1] += tinhTongTien(lsSuatAn, 2);

                                tongSoBuoiNghi[2] += 1;
                                tongTienHoan[2] += tinhTongTien(lsSuatAn, 3);

                                dgvHocVien[3 + i, index].Style.BackColor = Color.Red;
                                dgvHocVien[3 + i, index + 1].Style.BackColor = Color.Red;
                                dgvHocVien[3 + i, index + 2].Style.BackColor = Color.Red;
                            }
                        }
                        else if (lsSuatAn.Count > 0)
                        {
                            if (phuongthuc == 0)
                            {
                                dgvHocVien[3 + i, index].Value = "A";
                                dgvHocVien[3 + i, index].Style.BackColor = Color.Yellow;

                                tongSoBuoiNghi[0] += lsSuatAn.Count();
                                tongTienHoan[0] += tinhTongTien(lsSuatAn, 0);
                            }
                            else
                            {
                                dgvHocVien[3 + i, index].Value = "X";
                                dgvHocVien[3 + i, index + 1].Value = "X";
                                dgvHocVien[3 + i, index + 2].Value = "X";

                                if (lsSuatAn.Any(x => x.ThoiDiem == 1))
                                {
                                    dgvHocVien[3 + i, index].Value = "";
                                    tongSoBuoiNghi[0] += 1;
                                    tongTienHoan[0] += tinhTongTien(lsSuatAn, 1);
                                }
                                if (lsSuatAn.Any(x => x.ThoiDiem == 2))
                                {
                                    dgvHocVien[3 + i, index + 1].Value = "";
                                    tongSoBuoiNghi[1] += 1;
                                    tongTienHoan[1] += tinhTongTien(lsSuatAn, 2);
                                }
                                if (lsSuatAn.Any(x => x.ThoiDiem == 3))
                                {
                                    dgvHocVien[3 + i, index + 2].Value = "";
                                    tongSoBuoiNghi[2] += 1;
                                    tongTienHoan[2] += tinhTongTien(lsSuatAn, 3);
                                }

                                dgvHocVien[3 + i, index].Style.BackColor = Color.Yellow;
                                dgvHocVien[3 + i, index + 1].Style.BackColor = Color.Yellow;
                                dgvHocVien[3 + i, index + 2].Style.BackColor = Color.Yellow;
                            }
                        }
                        else
                        {
                            dgvHocVien[3 + i, index].Value = "X";
                            if (phuongthuc != 0)
                            {
                                dgvHocVien[3 + i, index + 1].Value = "X";
                                dgvHocVien[3 + i, index + 2].Value = "X";
                            }
                        }
                    }
                }

                if (phuongthuc == 0)
                {
                    dgvHocVien[4 + ngayKetThuc.Day, index].Value = tongSoBuoiNghi[0];
                    dgvHocVien[5 + ngayKetThuc.Day, index].Value = tongTienHoan[0];
                    index += 1;

                }
                else
                {
                    dgvHocVien[4 + ngayKetThuc.Day, index].Value = tongSoBuoiNghi[0];
                    dgvHocVien[5 + ngayKetThuc.Day, index].Value = tongTienHoan[0];

                    dgvHocVien[4 + ngayKetThuc.Day, index + 1].Value = tongSoBuoiNghi[1];
                    dgvHocVien[5 + ngayKetThuc.Day, index + 1].Value = tongTienHoan[1];

                    dgvHocVien[4 + ngayKetThuc.Day, index + 2].Value = tongSoBuoiNghi[2];
                    dgvHocVien[5 + ngayKetThuc.Day, index + 2].Value = tongTienHoan[2];
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

        private void cbxPhuongThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ngayHienTai = DateTime.Now;
            phuongthuc = cbxPhuongThuc.SelectedIndex;
            HienThiCacNgayTrongThang(dtpThang.Value);
            LoadThongKe(dtpThang.Value);
        }

        private void cbxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            listNguoiDung.Clear();
            string lop = cbxLop.SelectedValue.ToString();
            string timKiem = txbTimKiem.Text;

            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            if (lop.Equals("Tất cả"))
            {
                List<string> dsLop = thongTinNguoiDungBll.lay_thong_tin_lop();
                foreach (string s in dsLop)
                {
                    listNguoiDung.AddRange(thongTinNguoiDungBll.lay_danh_sach_hoc_vien_cung_lop(s, timKiem));
                }
            }
            else
            {
                listNguoiDung = thongTinNguoiDungBll.lay_danh_sach_hoc_vien_cung_lop(lop, timKiem);
            }

            HienThiCacNgayTrongThang(dtpThang.Value);
            LoadThongKe(dtpThang.Value);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            listNguoiDung.Clear();
            string lop = cbxLop.SelectedValue.ToString();
            string timKiem = txbTimKiem.Text;

            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            if (lop.Equals("Tất cả"))
            {
                List<string> dsLop = thongTinNguoiDungBll.lay_thong_tin_lop();
                foreach (string s in dsLop)
                {
                    listNguoiDung.AddRange(thongTinNguoiDungBll.lay_danh_sach_hoc_vien_cung_lop(s, timKiem));
                }
            }
            else
            {
                listNguoiDung = thongTinNguoiDungBll.lay_danh_sach_hoc_vien_cung_lop(lop, timKiem);
            }

            HienThiCacNgayTrongThang(dtpThang.Value);
            LoadThongKe(dtpThang.Value);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            listNguoiDung.Clear();
            cbxLop.SelectedIndex = 0;
            txbTimKiem.Text = string.Empty;
            phuongthuc = 0;
            cbxPhuongThuc.SelectedIndex = 0;

            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            List<string> dsLop = thongTinNguoiDungBll.lay_thong_tin_lop();
            foreach (string s in dsLop)
            {
                listNguoiDung.AddRange(thongTinNguoiDungBll.lay_danh_sach_hoc_vien_cung_lop(s, txbTimKiem.Text));
            }
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
                    dataAccess.ExportToExcel(dgvHocVien, filePath);
                }
            }
            
        }
    }
}
