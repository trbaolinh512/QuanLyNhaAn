using PhanMemBaoCom.BLL;
using PhanMemBaoCom.DTO;
using PhanMemBaoCom.GUI.ManHinhChung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaAn.GUI.ManHinhCBGV
{
    public partial class MH_CBGV : Form
    {
        ThongTinNguoiDungDto thongTinNguoiDungDto { get; set; }
        DangNhap dangNhap;
        public MH_CBGV(ThongTinNguoiDungDto thongtin, DangNhap dangNhap)
        {
            this.thongTinNguoiDungDto = thongtin;
            this.dangNhap = dangNhap;
            InitializeComponent();
            UC_ThongTinSuatAn uC_YKienDongGop = new UC_ThongTinSuatAn(thongTinNguoiDungDto);
            pnlHienThi.Controls.Add(uC_YKienDongGop);
            lbUser.Text = thongTinNguoiDungDto.HoTen;
        }

        private void btnTTSA_Click(object sender, EventArgs e)
        {
            txtTieuDe.Text = "Thông tin suất ăn";
            pnlHienThi.Controls.Clear();
            UC_ThongTinSuatAn uC_YKienDongGop = new UC_ThongTinSuatAn(thongTinNguoiDungDto);
            pnlHienThi.Controls.Add(uC_YKienDongGop);
        }

        private void btnYKDG_Click(object sender, EventArgs e)
        {
            txtTieuDe.Text = "Ý kiến đóng góp";
            pnlHienThi.Controls.Clear();
            UC_YKienDongGop uc = new UC_YKienDongGop(thongTinNguoiDungDto);
            pnlHienThi.Controls.Add(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dangNhap.Show();
            this.Hide();
        }

        private void pnlUser_Click(object sender, EventArgs e)
        {
            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            thongTinNguoiDungDto = thongTinNguoiDungBll.lay_chi_tiet_theo_mngdung(thongTinNguoiDungDto.MaNguoiDung);
            lbUser.DataBindings.Clear();
            lbUser.DataBindings.Add("Text", thongTinNguoiDungDto, "HoTen");
            ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan(thongTinNguoiDungDto);
            thongTinCaNhan.Show();
        }

        private void MH_CBGV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Kiểm tra lý do đóng Form
            {
                // Khi đóng bằng dấu X, thoát hoàn toàn chương trình
                Application.Exit();
            }
        }
    }
}
