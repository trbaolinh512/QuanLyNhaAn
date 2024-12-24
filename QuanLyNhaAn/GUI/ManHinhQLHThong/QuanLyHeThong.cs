using Microsoft.VisualBasic.ApplicationServices;
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

namespace QuanLyNhaAn.GUI.ManHinhQLHThong
{
    public partial class QuanLyHeThong : Form
    {
        ThongTinNguoiDungDto thongTinNguoiDungDto { get; set; }
        DangNhap dangNhap;
        public QuanLyHeThong(ThongTinNguoiDungDto dto,DangNhap dangNhap)
        {
            this.dangNhap = dangNhap;
            InitializeComponent();
            thongTinNguoiDungDto = dto;
            lbUser.Text = thongTinNguoiDungDto.HoTen;
            lbUser.DataBindings.Add("Text", thongTinNguoiDungDto, "HoTen");
            txbTitle.Text = "Quản lý người dùng";
            UC_QLyNguoiDung uc = new UC_QLyNguoiDung(thongTinNguoiDungDto);
            pnlHienThi.Controls.Add(uc);
        }

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            pnlHienThi.Controls.Clear();
            txbTitle.Text = "Quản lý người dùng";
            UC_QLyNguoiDung uc = new UC_QLyNguoiDung(thongTinNguoiDungDto);
            pnlHienThi.Controls.Add(uc);
        }

        private void btnQLChucVu_Click(object sender, EventArgs e)
        {
            pnlHienThi.Controls.Clear();
            txbTitle.Text = "Quản lý chức vụ";
            UC_QLyChucVu uc = new UC_QLyChucVu(thongTinNguoiDungDto);
            pnlHienThi.Controls.Add(uc);
        }

        private void btnQLYeuCau_Click(object sender, EventArgs e)
        {
            pnlHienThi.Controls.Clear();
            txbTitle.Text = "Ý kiến đóng góp";
            UC_YKienDongGop uc = new UC_YKienDongGop(thongTinNguoiDungDto);
            pnlHienThi.Controls.Add(uc);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            pnlHienThi.Controls.Clear();
            txbTitle.Text = "Cài đặt hệ thống";
            UC_CaiDatHeThong uc = new UC_CaiDatHeThong(thongTinNguoiDungDto);
            pnlHienThi.Controls.Add(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangNhap.Show();
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

        private void QuanLyHeThong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Kiểm tra lý do đóng Form
            {
                // Khi đóng bằng dấu X, thoát hoàn toàn chương trình
                Application.Exit();
            }
        }
    }
}
