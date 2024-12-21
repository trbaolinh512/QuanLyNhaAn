using PhanMemBaoCom.BLL;
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
    public partial class UC_TrangChu : UserControl
    {
        public ThongTinNguoiDungDto thongTinNguoiDungDto { get; set; }
        public UC_TrangChu(ThongTinNguoiDungDto thongtin)
        {
            InitializeComponent();
            thongTinNguoiDungDto = thongtin;
            LoadTrangChu();
        }

        public void LoadTrangChu()
        {
            dgvCBGV.Rows.Clear();
            dgvHocVien.Rows.Clear();

            DateTime thoidiemhientai = DateTime.Now;
            DateTime ngayBatDau = thoidiemhientai.Date; // Bắt đầu ngày hôm nay: 00:00:00
            DateTime ngayKetThuc = ngayBatDau.AddDays(1).AddTicks(-1); // Kết thúc ngày hôm nay: 23:59:59.9999999

            LichSuLuuTruBll lichSuLuuTruBll = new LichSuLuuTruBll();
            lichSuLuuTruBll.ChuyenDoiDuLieu();

            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            List<string> listLop = thongTinNguoiDungBll.lay_thong_tin_lop();
            List<Tuple<string, string>> listCbGV = thongTinNguoiDungBll.lay_thong_tin_phong_khoa();

            int[] soSuatTongLop = new int[3] { 0, 0, 0 };//Phục vị hiển thị trên label

            int stt = 0;
            foreach(string item in listLop)
            {
                stt++;
                int[] soSuatTongTungLop = new int[3] { 0, 0, 0 };//Phục vụ hiển thị data grid view

                List<ThongTinNguoiDungDto> listNguoiDungCungLop = thongTinNguoiDungBll.lay_danh_sach_hoc_vien_cung_lop(item,null);
                int count = listNguoiDungCungLop.Count();
                foreach (ThongTinNguoiDungDto l in listNguoiDungCungLop)//Vòng lặp tính từng người ăn bao nhiêu suất trong từng thời điểm
                {
                    List<LichSuLuuTruDto> listSuatAn = lichSuLuuTruBll.lay_theo_thang_va_id(ngayBatDau, ngayKetThuc, l.Id);
                    int soSuatAnSangTungLop = listSuatAn.Where(x => x.ThoiDiem == 1).Count();//Số người nghỉ buổi sáng
                    int soSuatAnTruaTungLop = listSuatAn.Where(x => x.ThoiDiem == 2).Count();//--
                    int soSuatAnToiTungLop = listSuatAn.Where(x => x.ThoiDiem == 3).Count();//--

                    soSuatTongTungLop[0] += soSuatAnSangTungLop;//Số người ăn buổi sáng
                    soSuatTongTungLop[1] += soSuatAnTruaTungLop;//--
                    soSuatTongTungLop[2] += soSuatAnToiTungLop;//--
                }
                int tongTungLop = soSuatTongTungLop[0] + soSuatTongTungLop[1] + soSuatTongTungLop[2];
                dgvHocVien.Rows.Add(stt,item, count*3 - tongTungLop);
                soSuatTongLop[0] += count - soSuatTongTungLop[0];
                soSuatTongLop[1] += count - soSuatTongTungLop[1];
                soSuatTongLop[2] += count - soSuatTongTungLop[2];
            }

            int[] soSuatTongPhongKhoa = new int[3] { 0, 0, 0 };//Phục vị hiển thị trên label
            stt = 0;
            foreach (var item in listCbGV)
            {
                stt++;
                int[] soSuatTongTungPhongKhoa = new int[3] { 0, 0, 0 };//Phục vụ hiển thị data grid view

                List<ThongTinNguoiDungDto> listNguoiDungCungPhongKhoa = thongTinNguoiDungBll.lay_danh_sach_hoc_vien_cung_phong_khoa(item);
                int count = listNguoiDungCungPhongKhoa.Count();
                foreach (ThongTinNguoiDungDto l in listNguoiDungCungPhongKhoa)//Vòng lặp tính từng người ăn bao nhiêu suất trong từng thời điểm
                {
                    List<LichSuLuuTruDto> listSuatAn = lichSuLuuTruBll.lay_theo_thang_va_id(ngayBatDau, ngayKetThuc, l.Id);
                    int soSuatAnSangTungPhongKhoa = listSuatAn.Where(x => x.ThoiDiem == 1).Count();//Số người nghỉ buổi sáng
                    int soSuatAnTruaTungPhongKhoa = listSuatAn.Where(x => x.ThoiDiem == 2).Count();//--
                    int soSuatAnToiTungPhongKhoa = listSuatAn.Where(x => x.ThoiDiem == 3).Count();//--

                    soSuatTongTungPhongKhoa[0] += soSuatAnSangTungPhongKhoa;//Số người ăn buổi sáng
                    soSuatTongTungPhongKhoa[1] += soSuatAnTruaTungPhongKhoa;//--
                    soSuatTongTungPhongKhoa[2] += soSuatAnToiTungPhongKhoa;//--
                }
                int tongTungPhongKhoa = soSuatTongTungPhongKhoa[0] + soSuatTongTungPhongKhoa[1] + soSuatTongTungPhongKhoa[2];
                dgvCBGV.Rows.Add(stt,item.Item1,item.Item2, tongTungPhongKhoa);
                soSuatTongPhongKhoa[0] += soSuatTongTungPhongKhoa[0];
                soSuatTongPhongKhoa[1] += soSuatTongTungPhongKhoa[1];
                soSuatTongPhongKhoa[2] += soSuatTongTungPhongKhoa[2];
            }

            lblNgayHomNay.Text = "Hiện tại là: "+thoidiemhientai.ToString();
            lblSuatHocVienSang.Text = "Suất học viên: " + soSuatTongLop[0].ToString();
            lblSuatHocVienTrua.Text = "Suất học viên: " + soSuatTongLop[1].ToString();
            lblSuatHocVienToi.Text = "Suất học viên: " + soSuatTongLop[2].ToString();

            lblSuatCBGVSang.Text = "Suất CBGV: " + soSuatTongPhongKhoa[0].ToString();
            lblSuatCBGVTrua.Text = "Suất CBGV: " + soSuatTongPhongKhoa[1].ToString();
            lblSuatCBGVToi.Text = "Suất CBGV: " + soSuatTongPhongKhoa[2].ToString();

            soSuatTongLop[0] += soSuatTongPhongKhoa[0];
            soSuatTongLop[1] += soSuatTongPhongKhoa[1];
            soSuatTongLop[2] += soSuatTongPhongKhoa[2];

            lblSuatTongQuatSang.Text = "Tổng suất cần chuẩn bị: " + soSuatTongLop[0].ToString();
            lblSuatTongQuatTrua.Text = "Tổng suất cần chuẩn bị: " + soSuatTongLop[1].ToString();
            lblSuatTongQuatToi.Text = "Tổng suất cần chuẩn bị: " + soSuatTongLop[2].ToString();
        }
    }
}
