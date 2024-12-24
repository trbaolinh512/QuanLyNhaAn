using PhanMemBaoCom.BLL;
using PhanMemBaoCom.DTO;
using PhanMemBaoCom.GUI.ManHinhChung;
using QuanLyNhaAn.GUI.ManHinhCBGV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaAn.GUI.ManHinhHVien
{
    public partial class MH_HVien : Form
    {
        public ThongTinNguoiDungDto thongtin { get; set; }
        public DangNhap dangNhap;
        public MH_HVien(ThongTinNguoiDungDto thongTinNguoiDungDto, DangNhap dangNhap)
        {
            this.dangNhap = dangNhap;
            InitializeComponent();
            UC_ThongTinSuatAn uC_YKienDongGop = new UC_ThongTinSuatAn(thongTinNguoiDungDto);
            pnlHienThi.Controls.Add(uC_YKienDongGop);
            thongtin = thongTinNguoiDungDto;
            lbUser.Text = thongtin.HoTen;
        }

        private void btnTTSA_Click(object sender, EventArgs e)
        {
            txtTieuDe.Text = "Thông tin suất ăn";
            pnlHienThi.Controls.Clear();
            UC_ThongTinSuatAn uC_YKienDongGop = new UC_ThongTinSuatAn(thongtin);
            pnlHienThi.Controls.Add(uC_YKienDongGop);
        }

        private void btnYKDG_Click(object sender, EventArgs e)
        {
            txtTieuDe.Text = "Ý kiến đóng góp";
            pnlHienThi.Controls.Clear();
            UC_YKienDongGop uc = new UC_YKienDongGop(thongtin);
            pnlHienThi.Controls.Add(uc);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            dangNhap.Show();
            this.Hide();
        }

        private void pnlUser_Click(object sender, EventArgs e)
        {
            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            thongtin = thongTinNguoiDungBll.lay_chi_tiet_theo_mngdung(thongtin.MaNguoiDung);
            lbUser.DataBindings.Clear();
            lbUser.DataBindings.Add("Text", thongtin, "HoTen");
            ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan(thongtin);
            thongTinCaNhan.Show();
        }

        private void MH_HVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Kiểm tra lý do đóng Form
            {
                // Khi đóng bằng dấu X, thoát hoàn toàn chương trình
                Application.Exit();
            }
        }
    }
}
