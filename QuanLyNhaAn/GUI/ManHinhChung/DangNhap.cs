using PhanMemBaoCom.BLL;
using PhanMemBaoCom.DTO;
using PhanMemBaoCom.Helper;
using QuanLyNhaAn.GUI.ManHinhCBGV;
using QuanLyNhaAn.GUI.ManHinhHVien;
using QuanLyNhaAn.GUI.ManHinhLPHCan;
using QuanLyNhaAn.GUI.ManHinhQLHThong;
using QuanLyNhaAn.GUI.ManHinhQLNAn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemBaoCom.GUI.ManHinhChung
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tk = txbTaiKhoan.Text.Trim();
            string mk = txtPassword.Text;
            Security security = new Security();
            string pasHass = security.MD5Hash(mk);

            ThongTinNguoiDungBll nguoidungbll = new ThongTinNguoiDungBll();
            ThongTinNguoiDungDto nguoiDungDto = nguoidungbll.dangnhap(tk, pasHass);
            if (nguoiDungDto == null)
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại tài khoản hoặc mật khẩu.",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else if (!nguoiDungDto.TrangThai)
            {
                MessageBox.Show("Tài khoản của bạn đã bị cấm khỏi hệ thống.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else
            {
                ChucVuBll chucVuBll = new ChucVuBll();
                List<ChucVuDto> chucVuDtos = chucVuBll.lay_tat_ca();
                if (chucVuDtos[nguoiDungDto.ChucVuId - 1].LaHocVien)
                {
                    if (chucVuDtos[nguoiDungDto.ChucVuId - 1].CoQuyenBaoCom)
                    {
                        //Man lop pho hau can
                        MH_LPHCan manhinh = new MH_LPHCan(nguoiDungDto);
                        Point location = this.Location;
                        manhinh.StartPosition = FormStartPosition.Manual;
                        manhinh.Location = location;
                        manhinh.Show();
                        this.Hide();
                    }
                    else
                    {
                        //Man hoc vien binh thuong
                        MH_HVien manhinh = new MH_HVien(nguoiDungDto);
                        Point location = this.Location;
                        manhinh.StartPosition = FormStartPosition.Manual;
                        manhinh.Location = location;
                        manhinh.Show();
                        this.Hide();
                    }
                }
                else
                {
                    if (chucVuDtos[nguoiDungDto.ChucVuId - 1].Id == 1)//Quản lý hệ thống
                    {
                        //Man hinh quan tri he thong
                        QuanLyHeThong qly = new QuanLyHeThong(nguoiDungDto);
                        Point location = this.Location;
                        qly.StartPosition = FormStartPosition.Manual;
                        qly.Location = location;
                        qly.Show();
                        this.Hide();


                    }
                    else
                    {
                        if (chucVuDtos[nguoiDungDto.ChucVuId - 1].Id == 2)//Quản lý nhà ăn
                        {
                            //Man hinh quan tri nha an
                            MH_QLyNAn manhinh = new MH_QLyNAn(nguoiDungDto);
                            Point location = this.Location;
                            manhinh.StartPosition = FormStartPosition.Manual;
                            manhinh.Location = location;
                            manhinh.Show();
                            this.Hide();
                        }
                        else
                        {
                            //Man hinh can bo giao vien
                            MH_CBGV manhinh = new MH_CBGV(nguoiDungDto);
                            Point location = this.Location;
                            manhinh.StartPosition = FormStartPosition.Manual;
                            manhinh.Location = location;
                            manhinh.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void ckbViewPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !ckbViewPass.Checked;
        }

        private void btnQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau manhinh = new QuenMatKhau();
            Point location = this.Location;
            manhinh.StartPosition = FormStartPosition.Manual;
            manhinh.Location = location;
            manhinh.Show();
            this.Hide();
        }
    }
}
