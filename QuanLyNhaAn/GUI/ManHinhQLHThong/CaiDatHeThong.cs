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
    public partial class CaiDatHeThong : Form
    {
        ThongTinNguoiDungDto nguoiDungDto { get; set; }
        public CaiDatHeThong(ThongTinNguoiDungDto nguoidungdto)
        {
            if (nguoidungdto == null)
            {
                this.Close();
                return;
            }
            nguoiDungDto = nguoidungdto;
            InitializeComponent();
            LoadCaiDat();
            lbUser.Text = nguoiDungDto.HoTen;
        }

        private void LoadCaiDat()
        {
            ThongTinHeThongBll thongTinHeThongBll = new ThongTinHeThongBll();
            ThongTinHeThongDto thongTinHeThongDto = thongTinHeThongBll.lay_tat_ca();

            txbTienHVSang.Text = ((int)thongTinHeThongDto.GiaTienHocVienSang).ToString();
            txbTienHVTrua.Text = ((int)thongTinHeThongDto.GiaTienHocVienTrua).ToString();
            txbTienHVToi.Text = ((int)thongTinHeThongDto.GiaTienHocVienToi).ToString();

            txbTienCBGVSang.Text = ((int)thongTinHeThongDto.GiaTienCanBoSang).ToString();
            txbTienCBGVTrua.Text = ((int)thongTinHeThongDto.GiaTienCanBoTrua).ToString();
            txbTienCBGVToi.Text = ((int)thongTinHeThongDto.GiaTienCanBoToi).ToString();

            dtpHanSang.Text=thongTinHeThongDto.HanBaoSang.ToString();
            dtpHanTruaToi.Text= thongTinHeThongDto.HanBaoTruaToi.ToString();
        }

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            QuanLyNguoiDung manhinh = new QuanLyNguoiDung(nguoiDungDto);
            Point location = this.Location;
            manhinh.StartPosition = FormStartPosition.Manual;
            manhinh.Location = location;
            manhinh.Show();
            this.Close();
        }

        private void btnQLChucVu_Click(object sender, EventArgs e)
        {
            QuanLyChucVu manhinh = new QuanLyChucVu(nguoiDungDto);
            Point location = this.Location;
            manhinh.StartPosition = FormStartPosition.Manual;
            manhinh.Location = location;
            manhinh.Show();
            this.Close();
        }

        private void btnQLYeuCau_Click(object sender, EventArgs e)
        {
            YKienDongGop manhinh = new YKienDongGop(nguoiDungDto);
            Point location = this.Location;
            manhinh.StartPosition = FormStartPosition.Manual;
            manhinh.Location = location;
            manhinh.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap manhinh = new DangNhap();
            Point location = this.Location;
            manhinh.Location = location;
            manhinh.Show();
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThongTinHeThongBll thongTinHeThongBll = new ThongTinHeThongBll();
            ThongTinHeThongDto thongTinHeThongDto= new ThongTinHeThongDto();
            try
            {
                thongTinHeThongDto.GiaTienHocVienSang = decimal.Parse(txbTienHVSang.Text);
                thongTinHeThongDto.GiaTienHocVienTrua = decimal.Parse(txbTienHVTrua.Text);
                thongTinHeThongDto.GiaTienHocVienToi = decimal.Parse(txbTienHVToi.Text);

                thongTinHeThongDto.GiaTienCanBoSang = decimal.Parse(txbTienCBGVSang.Text);
                thongTinHeThongDto.GiaTienCanBoTrua = decimal.Parse(txbTienCBGVTrua.Text);
                thongTinHeThongDto.GiaTienCanBoToi = decimal.Parse(txbTienCBGVToi.Text);

                thongTinHeThongDto.HanBaoSang = dtpHanSang.Value.TimeOfDay;
                thongTinHeThongDto.HanBaoTruaToi = dtpHanTruaToi.Value.TimeOfDay;
                thongTinHeThongBll.chinh_sua_he_thong(thongTinHeThongDto);
                MessageBox.Show("Cài đặt đã được lưu trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCaiDat();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lưu trữ thất bại! Hãy kiểm tra lại các trường nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
