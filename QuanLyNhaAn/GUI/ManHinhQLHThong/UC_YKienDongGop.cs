using Microsoft.VisualBasic.ApplicationServices;
using PhanMemBaoCom.BLL;
using PhanMemBaoCom.DTO;
using PhanMemBaoCom.GUI.ManHinhChung;
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
    public partial class UC_YKienDongGop : UserControl
    {
        public byte[] imageData { get; set; }
        ThongTinNguoiDungDto nguoiDungDto { get; set; }
        public UC_YKienDongGop(ThongTinNguoiDungDto nguoidungdto)
        {
            nguoiDungDto = nguoidungdto;
            InitializeComponent();
            LoadYKien();
        }
        public void LoadYKien()
        {
            dgvYKien.Rows.Clear();
            YKienDongGopBll yKienDongGopBll = new YKienDongGopBll();
            List<YKienDongGopDto> yKienDongGopDtos = yKienDongGopBll.lay_tat_ca();
            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            int Stt = 0;
            foreach (YKienDongGopDto item in yKienDongGopDtos)
            {
                string tenNguoiPhanHoi = null;
                if (item.NguoiPhanHoi != null)
                {
                    tenNguoiPhanHoi = thongTinNguoiDungBll.lay_chi_tiet_theo_iddung(item.NguoiPhanHoi.Value).HoTen;
                }
                string tenNguoiGui = null;
                if (item.NguoiGui != null)
                {
                    tenNguoiGui = thongTinNguoiDungBll.lay_chi_tiet_theo_iddung(item.NguoiGui).HoTen;
                }
                Stt++;
                dgvYKien.Rows.Add(
                                    item.Id,
                                    Stt,
                                    item.NoiDung,
                                    item.NoiDungPhanHoi,
                                    tenNguoiGui,
                                    tenNguoiPhanHoi,
                                    item.NgayGui,
                                    item.NgayPhanHoi
                                   );
            }
        }
        private void dgvYKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string id = dgvYKien.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                YKienDongGopBll yKienDongGopBll = new YKienDongGopBll();
                YKienDongGopDto yKienDongGopDto = yKienDongGopBll.lay_theo_id(int.Parse(id));
                string noiDung = dgvYKien.Rows[e.RowIndex].Cells["NoiDung"].Value.ToString();
                string phanhoi = dgvYKien.Rows[e.RowIndex].Cells["NoiDungPhanHoi"].Value != null ? dgvYKien.Rows[e.RowIndex].Cells["NoiDungPhanHoi"].Value.ToString() : null;
                txbYeuCau.Text = noiDung;
                txbPhanHoi.Text = phanhoi;

                imageData = yKienDongGopDto.AnhGui;
                if (imageData != null)
                {
                    try
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            // Chuyển byte[] thành Image và hiển thị trong PictureBox
                            ptbAnh.Image = Image.FromStream(ms);
                            ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một dòng trong DataGridView chưa
            if (dgvYKien.SelectedRows.Count == 0 && dgvYKien.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một ý kiến đóng góp để phản hồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = null;
            // Kiểm tra nếu người dùng đã chọn một dòng
            if (dgvYKien.SelectedRows.Count > 0)
            {
                // Lấy ID từ dòng được chọn
                id = dgvYKien.SelectedRows[0].Cells["Id"].Value.ToString();
            }
            else if (dgvYKien.SelectedCells.Count > 0)
            {
                // Lấy ID từ ô được chọn (nếu chỉ chọn một ô)
                id = dgvYKien.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
            }
            int idYkien = int.Parse(id);

            YKienDongGopBll yKienDongGopBll = new YKienDongGopBll();
            YKienDongGopDto yKienDongGopDto = yKienDongGopBll.lay_theo_id(idYkien);

            if (yKienDongGopDto == null)
            {
                MessageBox.Show("Không tìm thấy thông tin ý kiến đóng góp cần chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            yKienDongGopDto.NgayPhanHoi = DateTime.Now;
            yKienDongGopDto.NguoiPhanHoi = nguoiDungDto.Id;
            yKienDongGopDto.NoiDungPhanHoi = txbPhanHoi.Text;
            yKienDongGopBll.chinh_sua_yeu_cau(yKienDongGopDto);
            LoadYKien();


            MailProcess mailProcess = new MailProcess();
            string title = "Thông báo về ý kiến đóng góp của bạn";
            string content = @"<p>Ý kiến đóng góp của bạn đã có một phản hồi mới</p>
                               <p>Nội dung: " + yKienDongGopDto.NoiDung + "<p>" +
                               "<p>Nội dung phản hồi: " + yKienDongGopDto.NoiDungPhanHoi + "<p>" +
                               "<p>Người phản hồi: " + nguoiDungDto.HoTen + "<p>";

            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            ThongTinNguoiDungDto nguoiGui = thongTinNguoiDungBll.lay_chi_tiet_theo_iddung(yKienDongGopDto.NguoiGui);
            MessageBox.Show("Thông tin đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mailProcess.sendMail(nguoiGui.Email, title, content);

        }
    }
}
