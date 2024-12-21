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
        public MH_CBGV(ThongTinNguoiDungDto thongTinNguoiDungDto)
        {
            InitializeComponent();
            UC_ThongTinSuatAn uC_YKienDongGop = new UC_ThongTinSuatAn(thongTinNguoiDungDto);
            pnlHienThi.Controls.Add(uC_YKienDongGop);
            lbUser.Text = thongTinNguoiDungDto.HoTen;
            this.thongTinNguoiDungDto = thongTinNguoiDungDto;
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
            DangNhap manhinh = new DangNhap();
            Point location = this.Location;
            manhinh.Location = location;
            manhinh.Show();
            this.Close();
        }

    }
}
