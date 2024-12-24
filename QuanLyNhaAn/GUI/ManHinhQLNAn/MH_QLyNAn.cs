using PhanMemBaoCom.BLL;
using PhanMemBaoCom.DTO;
using PhanMemBaoCom.GUI.ManHinhChung;
using QuanLyNhaAn.GUI.ManHinhCBGV;
using QuanLyNhaAn.GUI.ManHinhQLHThong;
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
    public partial class MH_QLyNAn : Form
    {
        public ThongTinNguoiDungDto thongTinNguoiDungdto { get; set; }
        public DangNhap dangNhap;
        public MH_QLyNAn(ThongTinNguoiDungDto thongtin,DangNhap dangNhap)
        {
            this.dangNhap = dangNhap;
            InitializeComponent();
            this.thongTinNguoiDungdto = thongtin;
            lbUser.Text = thongTinNguoiDungdto.HoTen;
            UC_TrangChu uc = new UC_TrangChu(thongTinNguoiDungdto);
            pnlHienThi.Controls.Add(uc);
            lblTieuDe.Text = "Trang chủ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dangNhap.Show();
            this.Hide();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            pnlHienThi.Controls.Clear();
            UC_TrangChu uc = new UC_TrangChu(thongTinNguoiDungdto);
            pnlHienThi.Controls.Add(uc);
            lblTieuDe.Text = "Trang chủ";
        }

        private void btnTKHV_Click(object sender, EventArgs e)
        {
            pnlHienThi.Controls.Clear();
            UC_ThongKeHocVien uc = new UC_ThongKeHocVien();
            pnlHienThi.Controls.Add(uc);
            lblTieuDe.Text = "Thống kê học viên";
        }

        private void btnYKDG_Click(object sender, EventArgs e)
        {
            pnlHienThi.Controls.Clear();
            ManHinhQLHThong.UC_YKienDongGop uc = new ManHinhQLHThong.UC_YKienDongGop(thongTinNguoiDungdto);
            pnlHienThi.Controls.Add(uc);
            lblTieuDe.Text = "Ý kiến đóng góp";
        }

        private void btnTKCBGV_Click(object sender, EventArgs e)
        {
            pnlHienThi.Controls.Clear();
            UC_ThongKeCBGV uc = new UC_ThongKeCBGV();
            pnlHienThi.Controls.Add(uc);
            lblTieuDe.Text = "Thống kê CB-GV";
        }

        private void pnlUser_Click(object sender, EventArgs e)
        {
            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            thongTinNguoiDungdto = thongTinNguoiDungBll.lay_chi_tiet_theo_mngdung(thongTinNguoiDungdto.MaNguoiDung);
            lbUser.DataBindings.Clear();
            lbUser.DataBindings.Add("Text", thongTinNguoiDungdto, "HoTen");
            ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan(thongTinNguoiDungdto);
            thongTinCaNhan.Show();

        }

        private void MH_QLyNAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Kiểm tra lý do đóng Form
            {
                // Khi đóng bằng dấu X, thoát hoàn toàn chương trình
                Application.Exit();
            }
        }
    }
}
