using PhanMemBaoCom.BLL;
using PhanMemBaoCom.DTO;
using PhanMemBaoCom.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemBaoCom.GUI.ManHinhChung
{
    public partial class ThongTinCaNhan : Form
    {
        ThongTinNguoiDungDto nguoidung { get; set; }
        public ThongTinCaNhan(ThongTinNguoiDungDto thongTinNguoiDungDto)
        {
            InitializeComponent();
            nguoidung = thongTinNguoiDungDto;
            ChucVuBll chucVuBll = new ChucVuBll();
            ChucVuDto chucVuDto = chucVuBll.lay_theo_id(nguoidung.ChucVuId);

            txbHoTen.Text = nguoidung.HoTen.ToString();
            txbHoTen.DataBindings.Add("Text", nguoidung, "HoTen");
            txbMaND.Text = nguoidung.MaNguoiDung.ToString();

            if (chucVuDto.LaHocVien)
            {
                lbLop.Text = "Lớp";
                txbLopHoc.Text = nguoidung.Lop.ToString();

                lbKhoaHoc.Visible = false;
                txbKhoaHoc.Visible = false;
            }
            else
            {
                lbLop.Text = "Khoa";
                txbLopHoc.Text = nguoidung.Khoa.ToString();

                lbKhoaHoc.Text = "Phòng";
                txbKhoaHoc.Text = nguoidung.Phong.ToString();
                txbKhoaHoc.Visible = true;
                lbKhoaHoc.Visible = true;
            }

            txbDonVi.Text = nguoidung.DonVi.ToString();

            txbVaiTro.Text = chucVuDto.ChucVu;
            txbSDT.Text = nguoidung.SDT.ToString();
            txbSTK.Text = nguoidung.SoTaiKhoan.ToString();
            txbTenNH.Text = nguoidung.NganHang.ToString();
            txbEmail.Text = nguoidung.Email.ToString();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbHoTen.Text))
            {
                MessageBox.Show("Bạn chưa điền tên người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txbMaND.Text))
            {
                MessageBox.Show("Bạn chưa điền mã người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                nguoidung.HoTen = txbHoTen.Text;
                nguoidung.Lop = lbLop.Text == "Lớp" ? txbLopHoc.Text : null;
                nguoidung.Khoa = lbLop.Text == "Phòng" ? txbLopHoc.Text : null;
                nguoidung.Phong = lbKhoaHoc.Visible ? txbKhoaHoc.Text : null;
                nguoidung.DonVi = txbDonVi.Text;
                nguoidung.ChucVuId = nguoidung.ChucVuId;
                nguoidung.SDT = txbSDT.Text;
                nguoidung.SoTaiKhoan = txbSTK.Text;
                nguoidung.NganHang = txbTenNH.Text;
                nguoidung.Email = txbEmail.Text;

                ThongTinNguoiDungBll bll = new ThongTinNguoiDungBll();
                bool result = bll.cap_nhat_nguoi_dung(nguoidung);
                if (result)
                {
                    MessageBox.Show("Cập nhật thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbMKCu.Text) || string.IsNullOrEmpty(txbMKMoi.Text))
            {
                MessageBox.Show("Hãy nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txbMKMoi.Text.Length < 8)
            {
                MessageBox.Show("Độ dài mật khẩu mới phải lớn hoặc bằng 8 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
                string mkCu = thongTinNguoiDungBll.lay_chi_tiet_theo_mngdung(nguoidung.MaNguoiDung).MatKhau;
                Security security = new Security();
                if (mkCu.Equals(security.MD5Hash(txbMKCu.Text)))
                {
                    thongTinNguoiDungBll.doi_mat_khau(nguoidung.MaNguoiDung, nguoidung.Email, security.MD5Hash(txbMKMoi.Text));
                    MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }
    }
}
