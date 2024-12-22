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
    public partial class UC_CaiDatHeThong : UserControl
    {
        ThongTinNguoiDungDto nguoiDungDto { get; set; }
        public UC_CaiDatHeThong(ThongTinNguoiDungDto nguoidungdto)
        {
            nguoiDungDto = nguoidungdto;
            InitializeComponent();
            LoadCaiDat();
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

            dtpHanSang.Text = thongTinHeThongDto.HanBaoSang.ToString();
            dtpHanTruaToi.Text = thongTinHeThongDto.HanBaoTruaToi.ToString();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThongTinHeThongBll thongTinHeThongBll = new ThongTinHeThongBll();
            ThongTinHeThongDto thongTinHeThongDto = new ThongTinHeThongDto();
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
            catch (Exception ex)
            {
                MessageBox.Show("Lưu trữ thất bại! Hãy kiểm tra lại các trường nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
