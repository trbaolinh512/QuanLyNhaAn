using Microsoft.VisualBasic.ApplicationServices;
using PhanMemBaoCom.BLL;
using PhanMemBaoCom.DTO;
using PhanMemBaoCom.GUI.ManHinhChung;
using PhanMemBaoCom.Helper;
using QuanLyNhaAn.Util;
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
    public partial class UC_QLyNguoiDung : UserControl
    {
        bool sliderbarExpand;
        List<ChucVuDto> lch { get; set; }
        ThongTinNguoiDungDto nguoiDungDto { get; set; }
        List<ThongTinNguoiDungDto> list { get; set; }
        public UC_QLyNguoiDung(ThongTinNguoiDungDto tnguoidungdto)
        {
            InitializeComponent();
            nguoiDungDto = tnguoidungdto;

            txbLopHoc.Text = string.Empty; lbLop.Text = "Lớp";
            txbKhoaHoc.Text = string.Empty; lbKhoaHoc.Text = "Khoa"; lbKhoaHoc.Visible = false; txbKhoaHoc.Visible = false;

            ChucVuBll chucVuBll = new ChucVuBll();
            cbxVaiTro.DataSource = chucVuBll.lay_tat_ca();
            cbxVaiTro.DisplayMember = "ChucVu";  // Hiển thị trường TenChucVu
            cbxVaiTro.ValueMember = "Id";  // Lưu trữ giá trị Id
            cbxVaiTro.SelectedIndex = 0;
            ThongTinNguoiDungBll bll = new ThongTinNguoiDungBll();
            list = bll.lay_tat_ca(null);

            //Hien thi danh sach nguoi dung
            DanhSachNguoiDung();

        }

        private void DanhSachNguoiDung()
        {
            dgvNguoiDung.Rows.Clear();
            ChucVuBll ch = new ChucVuBll();
            lch = ch.lay_tat_ca();
            int stt = 0;
            foreach (ThongTinNguoiDungDto item in list)
            {
                stt++;
                dgvNguoiDung.Rows.Add(item.Id,
                                        stt,
                                        item.HoTen,
                                        item.MaNguoiDung,
                                        item.Lop,
                                        item.Phong,
                                        item.Khoa,
                                        item.DonVi,
                                        lch[item.ChucVuId - 1].ChucVu,
                                        item.TrangThai ? "Bình thường" : "Bị cấm");
            }
        }

        private void dgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị của ô đã được nhấp vào

                // Lấy giá trị từ các cột cụ thể
                string maND = dgvNguoiDung.Rows[e.RowIndex].Cells["MaNguoiDung"].Value.ToString();
                ThongTinNguoiDungBll bll = new ThongTinNguoiDungBll();
                ThongTinNguoiDungDto nguoidung = bll.lay_chi_tiet_theo_mngdung(maND);
                txbHoTen.Text = nguoidung.HoTen.ToString();
                txbMaND.Text = nguoidung.MaNguoiDung.ToString();

                if (lch[nguoidung.ChucVuId - 1].LaHocVien)
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
                //txbLop.Text = nguoidung.Lop.ToString(); txbLopHoc lbLop
                //txbPhong.Text = nguoidung.Phong.ToString();lbKhoaHoc txbKhoaHoc
                //txbKhoa.Text = nguoidung.Khoa.ToString();
                txbDonVi.Text = nguoidung.DonVi.ToString();

                //txbChucVu.Text = nguoidung.ChucVu.ToString();
                cbxVaiTro.DataSource = lch.ToList();  // Gán danh sách vào ComboBox
                cbxVaiTro.DisplayMember = "ChucVu";  // Hiển thị trường TenChucVu
                cbxVaiTro.ValueMember = "Id";  // Lưu trữ giá trị Id
                cbxVaiTro.SelectedIndex = nguoidung.ChucVuId - 1;

                txbSDT.Text = nguoidung.SDT.ToString();
                txbSTK.Text = nguoidung.SoTaiKhoan.ToString();
                txbTenNH.Text = nguoidung.NganHang.ToString();
                txbEmail.Text = nguoidung.Email.ToString();

            }
        }
        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (Cursor.Current != Cursors.WaitCursor)
            {
                try
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
                    Cursor.Current = Cursors.WaitCursor;
                    Application.DoEvents();
                    ThongTinNguoiDungDto nguoiDungMoi = new ThongTinNguoiDungDto
                    {
                        HoTen = txbHoTen.Text,
                        MaNguoiDung = txbMaND.Text,
                        Lop = lbLop.Text == "Lớp" ? txbLopHoc.Text : null,
                        Khoa = lbLop.Text == "Phòng" ? txbLopHoc.Text : null,
                        Phong = lbKhoaHoc.Visible ? txbKhoaHoc.Text : null,
                        DonVi = txbDonVi.Text,
                        ChucVuId = cbxVaiTro.SelectedIndex + 1,
                        TrangThai = true,
                        SDT = txbSDT.Text,
                        SoTaiKhoan = txbSTK.Text,
                        NganHang = txbTenNH.Text,
                        Email = txbEmail.Text
                    };
                    MailProcess mailProcess = new MailProcess();
                    Security security = new Security();

                    string matkhaumoi = security.GenerateRandomString();

                    nguoiDungMoi.MatKhau = security.MD5Hash(matkhaumoi);

                    ThongTinNguoiDungBll bll = new ThongTinNguoiDungBll();
                    bool check = bll.check_ton_tai_manguoidung(nguoiDungMoi.MaNguoiDung);
                    if (check)
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Mã người dùng đã tồn tại! Không thể thêm người dùng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        bool result = bll.them_nguoi_dung(nguoiDungMoi);
                        if (result)
                        {

                            string title = "Thông báo về tài khoản mới";
                            string content = @"<p>Tài khoản của bạn đã được tạo trong hệ thống đăng ký suất ăn.</p><br><p>Mật khẩu của bạn:" + matkhaumoi + "<p>";
                            var status = mailProcess.sendMail(nguoiDungMoi.Email, title, content);
                            Cursor.Current = Cursors.Default;
                            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            list = bll.lay_tat_ca(txbTimKiem.Text);
                            DanhSachNguoiDung();
                        }
                        else
                        {
                            Cursor.Current = Cursors.Default;
                            MessageBox.Show("Thêm mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
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

                string Id = null;
                ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
                // Kiểm tra xem người dùng đã chọn một dòng trong DataGridView chưa
                if (dgvNguoiDung.SelectedRows.Count == 0 && dgvNguoiDung.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một người dùng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Kiểm tra nếu người dùng đã chọn một dòng
                if (dgvNguoiDung.SelectedRows.Count > 0)
                {
                    // Lấy ID từ dòng được chọn
                    Id = dgvNguoiDung.SelectedRows[0].Cells["Id"].Value.ToString();
                }
                else if (dgvNguoiDung.SelectedCells.Count > 0)
                {
                    // Lấy ID từ ô được chọn (nếu chỉ chọn một ô)
                    Id = dgvNguoiDung.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
                }

                ThongTinNguoiDungDto nguoiDungSua = list.FirstOrDefault(nd => nd.Id == int.Parse(Id));
                if (nguoiDungSua != null && int.Parse(Id) == nguoiDungSua.Id && !nguoiDungSua.MaNguoiDung.Equals(txbMaND.Text))
                {
                    bool check = thongTinNguoiDungBll.check_ton_tai_manguoidung(txbMaND.Text);
                    if (check)
                    {
                        MessageBox.Show("Mã người dùng đã tồn tại! Không thể chỉnh sửa người dùng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (nguoiDungSua != null)
                {
                    nguoiDungSua.HoTen = txbHoTen.Text;
                    nguoiDungSua.MaNguoiDung = txbMaND.Text;
                    nguoiDungSua.Lop = lbLop.Text == "Lớp" ? txbLopHoc.Text : null;
                    nguoiDungSua.Khoa = lbLop.Text == "Phòng" ? txbLopHoc.Text : null;
                    nguoiDungSua.Phong = lbKhoaHoc.Visible ? txbKhoaHoc.Text : null;
                    nguoiDungSua.DonVi = txbDonVi.Text;
                    nguoiDungSua.ChucVuId = cbxVaiTro.SelectedIndex + 1;
                    nguoiDungSua.SDT = txbSDT.Text;
                    nguoiDungSua.SoTaiKhoan = txbSTK.Text;
                    nguoiDungSua.NganHang = txbTenNH.Text;
                    nguoiDungSua.Email = txbEmail.Text;

                    ThongTinNguoiDungBll bll = new ThongTinNguoiDungBll();
                    bool result = bll.cap_nhat_nguoi_dung(nguoiDungSua);
                    if (result)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    list = bll.lay_tat_ca(txbTimKiem.Text);
                    nguoiDungDto = thongTinNguoiDungBll.lay_chi_tiet_theo_iddung(nguoiDungDto.Id);
                    DanhSachNguoiDung();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = null;
                ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
                // Kiểm tra xem người dùng đã chọn một dòng trong DataGridView chưa
                if (dgvNguoiDung.SelectedRows.Count == 0 && dgvNguoiDung.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một người dùng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Kiểm tra nếu người dùng đã chọn một dòng
                if (dgvNguoiDung.SelectedRows.Count > 0)
                {
                    // Lấy ID từ dòng được chọn
                    Id = dgvNguoiDung.SelectedRows[0].Cells["Id"].Value.ToString();
                }
                else if (dgvNguoiDung.SelectedCells.Count > 0)
                {
                    // Lấy ID từ ô được chọn (nếu chỉ chọn một ô)
                    Id = dgvNguoiDung.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
                }

                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    ThongTinNguoiDungBll bll = new ThongTinNguoiDungBll();
                    bool result = bll.xoa_nguoi_dung(Id);
                    if (result)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    list = bll.lay_tat_ca(txbTimKiem.Text);
                    DanhSachNguoiDung();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa người dùng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = null;
                ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
                // Kiểm tra xem người dùng đã chọn một dòng trong DataGridView chưa
                if (dgvNguoiDung.SelectedRows.Count == 0 && dgvNguoiDung.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một người dùng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Kiểm tra nếu người dùng đã chọn một dòng
                if (dgvNguoiDung.SelectedRows.Count > 0)
                {
                    // Lấy ID từ dòng được chọn
                    Id = dgvNguoiDung.SelectedRows[0].Cells["Id"].Value.ToString();
                }
                else if (dgvNguoiDung.SelectedCells.Count > 0)
                {
                    // Lấy ID từ ô được chọn (nếu chỉ chọn một ô)
                    Id = dgvNguoiDung.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
                }

                ThongTinNguoiDungDto nguoiDungSua = list.FirstOrDefault(nd => nd.Id == int.Parse(Id));
                if (nguoiDungSua != null)
                {
                    nguoiDungSua.TrangThai = !nguoiDungSua.TrangThai;

                    ThongTinNguoiDungBll bll = new ThongTinNguoiDungBll();
                    bool result = bll.cap_nhat_nguoi_dung(nguoiDungSua);
                    if (result)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    list = bll.lay_tat_ca(txbTimKiem.Text);
                    DanhSachNguoiDung();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string input = txbTimKiem.Text;

            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            list = thongTinNguoiDungBll.lay_tat_ca(input);

            DanhSachNguoiDung();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txbHoTen.Text = string.Empty;
            txbMaND.Text = string.Empty;
            txbLopHoc.Text = string.Empty; lbLop.Text = "Lớp";
            txbKhoaHoc.Text = string.Empty; lbKhoaHoc.Text = "Khoa"; lbKhoaHoc.Visible = false; txbKhoaHoc.Visible = false;
            txbDonVi.Text = string.Empty;

            txbSDT.Text = string.Empty;
            txbSTK.Text = string.Empty;
            txbTenNH.Text = string.Empty;
            txbEmail.Text = string.Empty;

            ChucVuBll chucVuBll = new ChucVuBll();
            cbxVaiTro.DataSource = chucVuBll.lay_tat_ca();
            cbxVaiTro.DisplayMember = "ChucVu";  // Hiển thị trường TenChucVu
            cbxVaiTro.ValueMember = "Id";  // Lưu trữ giá trị Id
            cbxVaiTro.SelectedIndex = 0;

            txbTimKiem.Text = string.Empty;
            DanhSachNguoiDung();
        }

        private void cbxVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChucVuBll chucVuBll = new ChucVuBll();
            ChucVuDto chucVuDto = chucVuBll.lay_theo_id(cbxVaiTro.SelectedIndex + 1);
            if (chucVuDto != null)
            {
                if (chucVuDto.LaHocVien)
                {
                    lbLop.Text = "Lớp";
                    lbKhoaHoc.Visible = false; txbKhoaHoc.Visible = false;
                }
                else
                {
                    lbLop.Text = "Phòng";
                    lbKhoaHoc.Text = "Khoa";
                    lbKhoaHoc.Visible = true; txbKhoaHoc.Visible = true;
                }
            }
        }

        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbDonVi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
