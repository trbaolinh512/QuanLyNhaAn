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

namespace QuanLyNhaAn.GUI.ManHinhQLNAn
{
    public partial class MH_QLyNAn : Form
    {
        public ThongTinNguoiDungDto thongTinNguoiDungdto { get; set; }
        public MH_QLyNAn(ThongTinNguoiDungDto thongTinNguoiDungdto)
        {
            InitializeComponent();
            this.thongTinNguoiDungdto = thongTinNguoiDungdto;
            lbUser.Text = thongTinNguoiDungdto.HoTen;
            UC_TrangChu uc = new UC_TrangChu(thongTinNguoiDungdto);
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

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            pnlHienThi.Controls.Clear();
            UC_TrangChu uc = new UC_TrangChu(thongTinNguoiDungdto);
            pnlHienThi.Controls.Add(uc);
        }

        private void btnTKHV_Click(object sender, EventArgs e)
        {
            pnlHienThi.Controls.Clear();
            UC_ThongKeHocVien uc = new UC_ThongKeHocVien();
            pnlHienThi.Controls.Add(uc);
        }
    }
}
