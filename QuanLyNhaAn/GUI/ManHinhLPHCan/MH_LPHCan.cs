using PhanMemBaoCom.BLL;
using PhanMemBaoCom.DTO;
using PhanMemBaoCom.GUI.ManHinhChung;
using QuanLyNhaAn.GUI.ManHinhCBGV;
using QuanLyNhaAn.GUI.ManHinhQLNAn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaAn.GUI.ManHinhLPHCan
{
    public partial class MH_LPHCan : Form
    {
        public ThongTinNguoiDungDto thongTinNguoiDungDto { get; set; }
        public MH_LPHCan(ThongTinNguoiDungDto thongtin)
        {
            thongTinNguoiDungDto = thongtin;
            InitializeComponent();
            UC_ThongTinSuatAnLPHCan uC = new UC_ThongTinSuatAnLPHCan(thongTinNguoiDungDto);
            pnlHienThi.Controls.Add(uC);
            lbUser.Text = thongTinNguoiDungDto.HoTen;
        }

        private void btnTTSA_Click(object sender, EventArgs e)
        {
            txtTieuDe.Text = "Thông tin suất ăn của lớp";
            pnlHienThi.Controls.Clear();
            UC_ThongTinSuatAnLPHCan uC_YKienDongGop = new UC_ThongTinSuatAnLPHCan(thongTinNguoiDungDto);
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
            DangNhap manhinh = new DangNhap();
            Point location = this.Location;
            manhinh.Location = location;
            manhinh.Show();
            this.Close();
        }

        private void btnXemSuatAn_Click(object sender, EventArgs e)
        {
            txtTieuDe.Text = "Thông tin suất ăn";
            pnlHienThi.Controls.Clear();
            UC_ThongTinSuatAn uC_YKienDongGop = new UC_ThongTinSuatAn(thongTinNguoiDungDto);
            pnlHienThi.Controls.Add(uC_YKienDongGop);
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
    }
}
