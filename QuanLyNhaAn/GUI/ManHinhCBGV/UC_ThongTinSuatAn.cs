using PhanMemBaoCom.BLL;
using PhanMemBaoCom.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaAn.GUI.ManHinhCBGV
{
    public partial class UC_ThongTinSuatAn : UserControl
    {
        List<string> daysOfWeekEnglish = new List<string>()
            {
                "Monday",    // Thứ hai
                "Tuesday",   // Thứ ba
                "Wednesday", // Thứ tư
                "Thursday",  // Thứ năm
                "Friday",    // Thứ sáu
                "Saturday",   // Thứ bảy
                "Sunday"    // Chủ nhật
            };
        List<string> daysOfWeekVietnamese = new List<string>()
            {
                "Thứ hai",    // Monday
                "Thứ ba",     // Tuesday
                "Thứ tư",     // Wednesday
                "Thứ năm",    // Thursday
                "Thứ sáu",    // Friday
                "Thứ bảy",     // Saturday
                "Chủ nhật"   // Sunday
            };
        public DateTime thoigianHienTai { get; set; }
        public int soSuatAn { get; set; }
        public decimal soTien { get; set; }
        private List<List<Panel>> MaTranLich;
        public ThongTinNguoiDungDto thongTinNguoiDungDto { get; set; }
        public bool LaHocVien { get; set; }
        public int phuongthuc { get; set; }
        public UC_ThongTinSuatAn(ThongTinNguoiDungDto thongTinNguoiDungDto)
        {
            //Gán thời gian hiện tại để check
            thoigianHienTai = DateTime.Now;

            //Lấy thông tin người dùng từ form chính truyền sang usercontrol
            this.thongTinNguoiDungDto = thongTinNguoiDungDto;
            ChucVuBll bll = new ChucVuBll();
            ChucVuDto dto = bll.lay_theo_id(thongTinNguoiDungDto.ChucVuId);
            LaHocVien = dto.LaHocVien;
            //Set thông tin bằng 0
            phuongthuc = 0;
            soSuatAn = 0;
            soTien = 0;

            InitializeComponent();
            LoadLich();
            ThemSoNgayVaoLich(dtpChonThang.Value);

            CultureInfo vietnamCulture = new CultureInfo("vi-VN");

            // Tạo một bản sao của NumberFormatInfo để chỉnh sửa
            NumberFormatInfo customFormat = (NumberFormatInfo)vietnamCulture.NumberFormat.Clone();
            customFormat.CurrencySymbol = ""; // Loại bỏ ký hiệu tiền tệ

            // Định dạng số tiền
            string formattedMoney = soTien.ToString("C", customFormat).Trim(); // Trim để loại bỏ khoảng trắng dư thừa

            if (LaHocVien)
            {
                pnlAn.BackColor = Color.Red;
                lblAn.Text = ": Nghỉ ăn cả ngày";
                txtTongSuatAn.Text = "Tông buổi nghỉ: " + soSuatAn;
                txtTongTien.Text = "Tông tiền hoàn: " + formattedMoney;

                lblLuuY.Visible = false;
                btnLuuLich.Visible = false;
            }
            else
            {
                pnlAn.BackColor = Color.Green;
                lblAn.Text = ": Ăn cả ngày";
                txtTongSuatAn.Text = "Tông buổi đăng ký ăn: " + soSuatAn + " buổi";
                txtTongTien.Text = "Tông tiền phải đóng: " + formattedMoney;
            }
        }

        public void LoadLich()
        {
            MaTranLich = new List<List<Panel>>();
            int margin = 6;
            Panel oldPanel = new Panel() { Width = 0, Height = 0, Location = new Point(0, 0) };
            for (int i = 0; i < 6; i++)
            {
                MaTranLich.Add(new List<Panel>());
                for (int j = 0; j < 7; j++)
                {
                    Panel pnl = new Panel() { Width = 110, Height = 110 };
                    pnl.BorderStyle = BorderStyle.FixedSingle;
                    pnl.Location = new Point(oldPanel.Location.X + oldPanel.Width + margin, oldPanel.Location.Y);
                    pnlLich.Controls.Add(pnl);
                    MaTranLich[i].Add(pnl);
                    oldPanel = pnl;
                }
                oldPanel = new Panel() { Width = 0, Height = 0, Location = new Point(0, oldPanel.Location.Y + 110 + margin) };
            }
        }

        public void ThemSoNgayVaoLich(DateTime chonThang)
        {
            DateTime ngayBatDau = new DateTime(chonThang.Year, chonThang.Month, 1);
            DateTime ngayKetThuc = new DateTime(chonThang.Year, chonThang.Month, DateTime.DaysInMonth(chonThang.Year, chonThang.Month),23,59,0);

            int line = 0;
            LichSuLuuTruBll lsbll = new LichSuLuuTruBll();
            lsbll.ChuyenDoiDuLieu();

            YeuCauDangKyBll ycbll = new YeuCauDangKyBll();
            List<LichSuLuuTruDto> lichSuLuuTruDtos = lsbll.lay_theo_thang_va_id(ngayBatDau, ngayKetThuc, thongTinNguoiDungDto.Id);
            List<YeuCauDangKyDto> yeuCauDangKyDtos = ycbll.lay_theo_thang_va_id(ngayBatDau, ngayKetThuc, thongTinNguoiDungDto.Id);
            for (int i = 1; i <= ngayKetThuc.Day; i++)
            {
                int column = daysOfWeekVietnamese.IndexOf(ngayBatDau.DayOfWeek.ToString());
                if (column == -1)
                {
                    column = daysOfWeekEnglish.IndexOf(ngayBatDau.DayOfWeek.ToString());
                }

                // Kiểm tra chỉ số dòng và cột hợp lệ
                Panel pnl = MaTranLich[line][column];
                Label txbNgay = new Label();

                Label txbSang = new Label();
                Label txbTrua = new Label();
                Label txbToi = new Label();

                CheckBox cxbSang = new CheckBox();
                CheckBox cxbTrua = new CheckBox();
                CheckBox cxbToi = new CheckBox();

                txbNgay.Text = "Ngày: " + i.ToString();
                txbNgay.BorderStyle = BorderStyle.None;
                pnl.Controls.Add(txbNgay);
                DateTime ngayTrongVLap = new DateTime(chonThang.Year, chonThang.Month, i);
                if (ngayTrongVLap < thoigianHienTai.Date)//Lich su luu tru
                {
                    List<LichSuLuuTruDto> lsSuatAn = lichSuLuuTruDtos.Where(x => x.NgayLuuTru.Day == i).ToList();
                    if (lsSuatAn.Count > 0)
                    {
                        foreach (LichSuLuuTruDto item in lsSuatAn)
                        {
                            soTien += item.SoTienTuongUng;
                        }
                        if (lsSuatAn.Count() == 3)
                        {
                            if (LaHocVien)
                            {
                                pnl.BackColor = Color.Red;
                            }
                            else
                            {
                                pnl.BackColor = Color.Green;
                            }
                            soSuatAn += 3;
                        }
                        else if (lsSuatAn.Count() != 0)
                        {
                            pnl.BackColor = Color.Yellow;
                            soSuatAn += lsSuatAn.Count();
                        }
                    }


                    if (phuongthuc == 0)//Chọn phương thức theo ngày
                    {
                        if (lsSuatAn.Count() == 3)
                        {
                            if (LaHocVien)
                            {
                                txbSang.Text = "";//Không ăn cả ngay đối với học viên
                            }
                            else
                            {
                                txbSang.Text = "Cả ngày: X";//Ăn cả ngay đối với cbgv
                            }
                        }
                        else if (lsSuatAn.Count() == 0)
                        {
                            if (LaHocVien)
                            {
                                txbSang.Text = "Cả ngày: X";//Ăn cả ngay đối với học viên
                            }
                            else
                            {
                                txbSang.Text = "";//Không ăn cả ngay đối với cbgv
                            }
                        }
                        else
                        {
                            txbSang.Text = "Cả ngày: A";//Ăn từ 1->2 buổi trong ngày đối với học viên, CBGV
                        }
                        txbSang.BorderStyle = BorderStyle.None;
                        txbSang.Size = new Size(100, 20);
                        txbSang.Location = new Point(5, 30);
                        pnl.Controls.Add(txbSang);
                    }
                    else //Chọn theo phương thức theo từng buổi
                    {
                        AddLichSuTextBox(pnl, lsSuatAn, 1, "Sáng", new Point(5, 30));
                        AddLichSuTextBox(pnl, lsSuatAn, 2, "Trưa", new Point(5, 55));
                        AddLichSuTextBox(pnl, lsSuatAn, 3, "Tối", new Point(5, 80));
                    }
                }
                else if (ngayTrongVLap > thoigianHienTai.Date) // yêu cầu đăng ký
                {
                    if (!LaHocVien)
                    {
                        List<YeuCauDangKyDto> lsSuatAn = yeuCauDangKyDtos.Where(x => x.NgayDangKy.Day == i).ToList();

                        if (phuongthuc == 0)//Chọn phương thức theo ngày
                        {
                            if (lsSuatAn.Count() == 3)
                            {
                                cxbSang.Checked = true;
                            }
                            else
                            {
                                cxbSang.Checked = false;
                            }
                            txbSang.Text = "Cả ngày: ";
                            txbSang.BorderStyle = BorderStyle.None;
                            txbSang.Size = new Size(65, 20);
                            txbSang.Location = new Point(5, 30);
                            cxbSang.Location = new Point(70, 30);
                            pnl.Controls.Add(txbSang);
                            pnl.Controls.Add(cxbSang);
                        }
                        else //Chọn theo phương thức theo từng buổi
                        {
                            AddYeuCauTextBox(pnl, lsSuatAn, 1, "Sáng", new Point(5, 30), new Point(65, 30));
                            AddYeuCauTextBox(pnl, lsSuatAn, 2, "Trưa", new Point(5, 55), new Point(65, 55));
                            AddYeuCauTextBox(pnl, lsSuatAn, 3, "Tối", new Point(5, 80), new Point(65, 80));
                        }
                    }
                }
                else //Ngày hiện tại -> check đã quá hạn đăng ký của buổi đó hay chưa
                {
                    List<LichSuLuuTruDto> lsSuatAn = lichSuLuuTruDtos.Where(x => x.NgayLuuTru.Day == i).ToList();
                    List<YeuCauDangKyDto> lsSuatAn1 = yeuCauDangKyDtos.Where(x => x.NgayDangKy.Day == i).ToList();
                    // Thời điểm hiện tại
                    //DateTime thoiGianHienTai = DateTime.Now;

                    // Kiểm tra hạn thời gian của từng buổi
                    ThongTinHeThongBll thongTinHeThongBll = new ThongTinHeThongBll();
                    ThongTinHeThongDto thongTinHeThongDto = thongTinHeThongBll.lay_tat_ca();

                    DateTime hanGioMoSang = ngayTrongVLap.AddDays(-1).Date.AddHours(thongTinHeThongDto.HanBaoSang.TotalHours); // 10 giờ sáng hôm trước
                    DateTime hanGioMoTruaToi = ngayTrongVLap.Date.AddHours(thongTinHeThongDto.HanBaoTruaToi.TotalHours);  // 7 giờ sáng hôm nay

                    // Danh sách lưu trữ trạng thái của các buổi
                    bool quaHanSang = thoigianHienTai >= hanGioMoSang;
                    bool quaHanTrua = thoigianHienTai >= hanGioMoTruaToi;

                    if (lsSuatAn.Count > 0)
                    {
                        foreach (LichSuLuuTruDto item in lsSuatAn)
                        {
                            soTien += item.SoTienTuongUng;
                        }
                        if (lsSuatAn.Count() == 3)
                        {
                            if (LaHocVien)
                            {
                                pnl.BackColor = Color.Red;
                            }
                            else
                            {
                                pnl.BackColor = Color.Green;
                            }
                            soSuatAn += 3;
                        }
                        else if (lsSuatAn.Count() != 0)
                        {
                            pnl.BackColor = Color.Yellow;
                            soSuatAn += lsSuatAn.Count();
                        }
                    }

                    if (phuongthuc == 0) // Chọn phương thức theo ngày
                    {
                        // Nếu tất cả các buổi đều quá hạn
                        if (quaHanSang && quaHanTrua)
                        {
                            if (lsSuatAn.Count() == 3)
                            {
                                if (LaHocVien)
                                {
                                    txbSang.Text = "";
                                }
                                else
                                {
                                    txbSang.Text = "Cả ngày: X";
                                }
                            }
                            else if (lsSuatAn.Count() != 0)
                            {
                                txbSang.Text = "Cả ngày: A";
                            }
                            else
                            {
                                if (LaHocVien)
                                {
                                    txbSang.Text = "Cả ngày: X";
                                }
                                else
                                {
                                    txbSang.Text = "";
                                }
                            }
                            txbSang.BorderStyle = BorderStyle.None;
                            txbSang.Size = new Size(100, 20);
                            txbSang.Location = new Point(5, 30);
                            pnl.Controls.Add(txbSang);

                        }
                        else
                        {
                            if (!LaHocVien)
                            {
                                txbSang.Text = "Cả ngày: ";
                                txbSang.BorderStyle = BorderStyle.None;
                                txbSang.Size = new Size(65, 20);
                                txbSang.Location = new Point(5, 30);
                                cxbSang.Location = new Point(70, 30);
                                pnl.Controls.Add(txbSang);
                                pnl.Controls.Add(cxbSang);
                            }
                        }
                    }
                    else // Chọn theo phương thức theo từng buổi
                    {
                        // Xử lý cho buổi sáng
                        if (quaHanSang)
                        {
                            AddLichSuTextBox(pnl, lsSuatAn, 1, "Sáng", new Point(5, 30));
                        }
                        else
                        {
                            if (!LaHocVien)
                            {
                                AddYeuCauTextBox(pnl, lsSuatAn1, 1, "Sáng", new Point(5, 30), new Point(65, 30));
                            }
                        }

                        // Xử lý cho buổi trưa
                        if (quaHanTrua)
                        {
                            AddLichSuTextBox(pnl, lsSuatAn, 2, "Trưa", new Point(5, 55));
                            AddLichSuTextBox(pnl, lsSuatAn, 3, "Tối", new Point(5, 80));
                        }
                        else
                        {
                            if (!LaHocVien)
                            {
                                AddYeuCauTextBox(pnl, lsSuatAn1, 2, "Trưa", new Point(5, 55), new Point(65, 55));
                                AddYeuCauTextBox(pnl, lsSuatAn1, 3, "Tối", new Point(5, 80), new Point(65, 80));
                            }
                        }

                    }
                }

                if (column > 5)
                {
                    line++;
                }

                ngayBatDau = ngayBatDau.AddDays(1);
            }
        }

        private void AddYeuCauTextBox(Panel pnl, List<YeuCauDangKyDto> lsSuatAn, int thoiDiem, string labelText, Point location, Point cbx)
        {
            TextBox textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Size = new Size(60, 20),
                Location = location
            };
            textBox.Text = $"{labelText}:";
            CheckBox checkBox = new CheckBox
            {
                Location = cbx
            };

            // Kiểm tra ThoiDiem
            if (lsSuatAn.Any(x => x.ThoiDiem == thoiDiem))
            {
                if (LaHocVien)
                {
                    checkBox.Checked = false;
                }
                else
                {
                    checkBox.Checked = true;
                }
            }
            else
            {
                if (LaHocVien)
                {
                    checkBox.Checked = true;
                }
                else
                {
                    checkBox.Checked = false;
                }
            }

            pnl.Controls.Add(textBox);
            pnl.Controls.Add(checkBox);
            textBox.BackColor=pnl.BackColor;
        }

        private void AddLichSuTextBox(Panel pnl, List<LichSuLuuTruDto> lsSuatAn, int thoiDiem, string labelText, Point location)
        {
            TextBox textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Size = new Size(65, 20),
                Location = location
            };
            textBox.BackColor = pnl.BackColor;
            // Kiểm tra ThoiDiem
            if (lsSuatAn.Any(x => x.ThoiDiem == thoiDiem))
            {
                if (LaHocVien)
                {
                    textBox.Text = $"{labelText}:";
                }
                else
                {
                    textBox.Text = $"{labelText}: X";
                }
            }
            else
            {
                if (LaHocVien)
                {
                    textBox.Text = $"{labelText}: X";
                }
                else
                {
                    textBox.Text = $"{labelText}: ";
                }
            }

            pnl.Controls.Add(textBox);
        }
        private async Task LamMoiLich()
        {
            for (int i = 0; i < MaTranLich.Count; i++)
            {
                for (int j = 0; j < MaTranLich[i].Count; j++)
                {
                    for (int k = MaTranLich[i][j].Controls.Count - 1; k >= 0; k--)
                    {
                        Control control = MaTranLich[i][j].Controls[k]; // Lấy điều khiển theo chỉ mục
                        MaTranLich[i][j].Controls.Remove(control); // Loại bỏ điều khiển khỏi Panel
                        control.Dispose(); // Giải phóng tài nguyên của điều khiển
                        MaTranLich[i][j].BackColor = Color.White;
                    }
                }
            }
        }
        private async void dtpChonThang_ValueChanged(object sender, EventArgs e)
        {
            thoigianHienTai = DateTime.Now;
            await LamMoiLich();
            ThemSoNgayVaoLich(dtpChonThang.Value);
        }

        private async void cbxPhuongThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            thoigianHienTai = DateTime.Now;
            phuongthuc = cbxPhuongThuc.SelectedIndex;
            await LamMoiLich();
            ThemSoNgayVaoLich(dtpChonThang.Value);

        }

        private async void btnLuuLich_Click(object sender, EventArgs e)
        {
            thoigianHienTai = DateTime.Now;
            for (int i = 0; i < MaTranLich.Count; i++)
            {
                for (int j = 0; j < MaTranLich[i].Count; j++)
                {
                    Panel panel = MaTranLich[i][j];

                    // Kiểm tra nếu Panel chứa CheckBox
                    for (int k = 0; k < panel.Controls.Count; k++)
                    {
                        if (panel.Controls[k] is CheckBox checkBox)
                        {
                            
                            // Xác định thứ tự của CheckBox trong Panel
                            int index = k;

                            // Kiểm tra nếu CheckBox được chọn
                            
                                DateTime dt = dtpChonThang.Value;
                                string day = panel.Controls[0].Text.Replace("Ngày: ", "");
                                DateTime ngayDuocTich = new DateTime(dt.Year, dt.Month, int.Parse(day));

                                ThongTinHeThongBll thongTinHeThongBll = new ThongTinHeThongBll();
                                ThongTinHeThongDto thongTinHeThongDto = thongTinHeThongBll.lay_tat_ca();

                                DateTime hanGioMoSang = ngayDuocTich.AddDays(-1).Date.AddHours(thongTinHeThongDto.HanBaoSang.TotalHours); // 10 giờ sáng hôm trước
                                DateTime hanGioMoTruaToi = ngayDuocTich.Date.AddHours(thongTinHeThongDto.HanBaoTruaToi.TotalHours);  // 7 giờ sáng hôm nay

                                // Danh sách lưu trữ trạng thái của các buổi
                                bool quaHanSang = thoigianHienTai >= hanGioMoSang;
                                bool quaHanTrua = thoigianHienTai >= hanGioMoTruaToi;


                            if (phuongthuc == 0) // Cả ngày
                            {
                                if (!quaHanSang && !quaHanTrua)
                                {

                                    DateTime buoisang = new DateTime(ngayDuocTich.Year, ngayDuocTich.Month, ngayDuocTich.Day);
                                    DateTime buoitrua = buoisang.Add(thongTinHeThongDto.HanBaoTruaToi);
                                    DateTime buoitoi = buoisang.Add(thongTinHeThongDto.HanBaoTruaToi);

                                    YeuCauDangKyBll yeuCauDangKyBll = new YeuCauDangKyBll();
                                    YeuCauDangKyDto yeuCauDangKySang = new YeuCauDangKyDto
                                    {
                                        Id = yeuCauDangKyBll.lay_max_id() + 1,
                                        NguoiDungId = thongTinNguoiDungDto.Id,
                                        NgayDangKy = buoisang,
                                        ThoiDiem = 1
                                    };

                                    YeuCauDangKyDto yeuCauDangKyTrua = new YeuCauDangKyDto
                                    {
                                        Id = yeuCauDangKySang.Id + 1,
                                        NguoiDungId = thongTinNguoiDungDto.Id,
                                        NgayDangKy = buoitrua,
                                        ThoiDiem = 2
                                    };

                                    YeuCauDangKyDto yeuCauDangKyToi = new YeuCauDangKyDto
                                    {
                                        Id = yeuCauDangKyTrua.Id + 1,
                                        NguoiDungId = thongTinNguoiDungDto.Id,
                                        NgayDangKy = buoitoi,
                                        ThoiDiem = 3
                                    };

                                    if (checkBox.Checked)
                                    {
                                        yeuCauDangKyBll.them_yeu_cau(yeuCauDangKySang);
                                        yeuCauDangKyBll.them_yeu_cau(yeuCauDangKyTrua);
                                        yeuCauDangKyBll.them_yeu_cau(yeuCauDangKyToi);
                                    }
                                    else
                                    {
                                        yeuCauDangKyBll.xoa_yeu_cau(yeuCauDangKySang);
                                        yeuCauDangKyBll.xoa_yeu_cau(yeuCauDangKyTrua);
                                        yeuCauDangKyBll.xoa_yeu_cau(yeuCauDangKyToi);
                                    }
                                }
                            }
                            else 
                            {
                                if (!quaHanSang)
                                {
                                    if(panel.Controls[k - 1].Text.Contains("Sáng")) // ô check box của sáng
                                    {
                                        DateTime buoisang = new DateTime(ngayDuocTich.Year, ngayDuocTich.Month, ngayDuocTich.Day);

                                        YeuCauDangKyBll yeuCauDangKyBll = new YeuCauDangKyBll();
                                        YeuCauDangKyDto yeuCauDangKySang = new YeuCauDangKyDto
                                        {
                                            Id = yeuCauDangKyBll.lay_max_id() + 1,
                                            NguoiDungId = thongTinNguoiDungDto.Id,
                                            NgayDangKy = buoisang,
                                            ThoiDiem = 1
                                        };


                                        if (checkBox.Checked)
                                        {
                                            yeuCauDangKyBll.them_yeu_cau(yeuCauDangKySang);
                                        }
                                        else
                                        {
                                            yeuCauDangKyBll.xoa_yeu_cau(yeuCauDangKySang);
                                        }
                                    }
                                }

                                if (!quaHanTrua)
                                {
                                    if (panel.Controls[k - 1].Text.Contains("Trưa"))// ô check box của trưa
                                    {
                                        DateTime buoisang = new DateTime(ngayDuocTich.Year, ngayDuocTich.Month, ngayDuocTich.Day);
                                        DateTime buoitrua = buoisang.Add(thongTinHeThongDto.HanBaoTruaToi);

                                        YeuCauDangKyBll yeuCauDangKyBll = new YeuCauDangKyBll();
                                        YeuCauDangKyDto yeuCauDangKyTrua = new YeuCauDangKyDto
                                        {
                                            Id = yeuCauDangKyBll.lay_max_id() + 1,
                                            NguoiDungId = thongTinNguoiDungDto.Id,
                                            NgayDangKy = buoitrua,
                                            ThoiDiem = 2
                                        };


                                        if (checkBox.Checked)
                                        {
                                            yeuCauDangKyBll.them_yeu_cau(yeuCauDangKyTrua);
                                        }
                                        else
                                        {
                                            yeuCauDangKyBll.xoa_yeu_cau(yeuCauDangKyTrua);
                                        }
                                    }

                                    if (panel.Controls[k - 1].Text.Contains("Tối"))// ô check box của tối
                                    {
                                        DateTime buoisang = new DateTime(ngayDuocTich.Year, ngayDuocTich.Month, ngayDuocTich.Day);
                                        DateTime buoitoi = buoisang.Add(thongTinHeThongDto.HanBaoTruaToi);

                                        YeuCauDangKyBll yeuCauDangKyBll = new YeuCauDangKyBll();
                                        YeuCauDangKyDto yeuCauDangKyToi = new YeuCauDangKyDto
                                        {
                                            Id = yeuCauDangKyBll.lay_max_id() + 1,
                                            NguoiDungId = thongTinNguoiDungDto.Id,
                                            NgayDangKy = buoitoi,
                                            ThoiDiem = 3
                                        };


                                        if (checkBox.Checked)
                                        {
                                            yeuCauDangKyBll.them_yeu_cau(yeuCauDangKyToi);
                                        }
                                        else
                                        {
                                            yeuCauDangKyBll.xoa_yeu_cau(yeuCauDangKyToi);
                                        }
                                    }
                                }

                            }
                            }
                    }
                }
            }

            await LamMoiLich();
            ThemSoNgayVaoLich(dtpChonThang.Value);
            MessageBox.Show(
                            "Đã lưu lịch đăng ký của bạn thành công!\nLưu ý: \n   Những buổi quá hạn thì sẽ không được lưu vào trong hệ thống",
                            "Thông báo", // Tiêu đề của thông báo
                            MessageBoxButtons.OK, // Các nút hiển thị trong thông báo
                            MessageBoxIcon.Information // Biểu tượng hiển thị (Warning, Error, Information, etc.)
                        );
        }

        private async void btnLamMoi_Click(object sender, EventArgs e)
        {
            thoigianHienTai = DateTime.Now;
            await LamMoiLich();
            ThemSoNgayVaoLich(dtpChonThang.Value);
        }
    }
}
