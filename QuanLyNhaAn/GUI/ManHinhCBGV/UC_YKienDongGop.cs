using PhanMemBaoCom.BLL;
using PhanMemBaoCom.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaAn.GUI.ManHinhCBGV
{
    public partial class UC_YKienDongGop : UserControl
    {
        public byte[] imageData { get; set; }
        public ThongTinNguoiDungDto nguoiDungDto { get; set; }
        public UC_YKienDongGop(ThongTinNguoiDungDto thongTinNguoiDungDto)
        {
            InitializeComponent();
            nguoiDungDto = thongTinNguoiDungDto;
            LoadYKien();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageData = File.ReadAllBytes(openFileDialog.FileName);
                    ptbAnh.Image = Image.FromFile(openFileDialog.FileName);
                    ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn ảnh: " + ex.Message);
                }
            }
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            imageData = null;
            ptbAnh.Image = null;
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung ý kiến đóng góp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            YKienDongGopBll yKienDongGopBll = new YKienDongGopBll();

            // Tạo đối tượng YKienDongGopDto
            YKienDongGopDto yKienDongGopDto = new YKienDongGopDto
            {
                NoiDung = txbYeuCau.Text,
                NguoiGui = nguoiDungDto.Id,
                NgayGui = DateTime.Now,
                AnhGui = imageData // Nếu có ảnh
            };

            try
            {
                // Lưu thông tin vào cơ sở dữ liệu
                yKienDongGopBll.them_yeu_cau(yKienDongGopDto);

                // Sau khi lưu thành công, cập nhật lại DataGridView
                LoadYKien();

                MessageBox.Show("Ý kiến đóng góp của bạn đã được gửi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi gửi ý kiến đóng góp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một dòng trong DataGridView chưa
            if (dgvYeuCau.SelectedRows.Count == 0 && dgvYeuCau.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một ý kiến đóng góp để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = null;
            // Kiểm tra nếu người dùng đã chọn một dòng
            if (dgvYeuCau.SelectedRows.Count > 0)
            {
                // Lấy ID từ dòng được chọn
                id = dgvYeuCau.SelectedRows[0].Cells["Id"].Value.ToString();
            }
            else if (dgvYeuCau.SelectedCells.Count > 0)
            {
                // Lấy ID từ ô được chọn (nếu chỉ chọn một ô)
                id = dgvYeuCau.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
            }
            int idYkien = int.Parse(id);

            YKienDongGopBll yKienDongGopBll = new YKienDongGopBll();
            YKienDongGopDto yKienDongGopDto = yKienDongGopBll.lay_theo_id(idYkien);

            if (yKienDongGopDto == null)
            {
                MessageBox.Show("Không tìm thấy thông tin ý kiến đóng góp cần chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            yKienDongGopDto.NgayGui = DateTime.Now;
            yKienDongGopDto.NoiDung = txbYeuCau.Text;
            yKienDongGopDto.AnhGui = imageData;
            yKienDongGopBll.chinh_sua_yeu_cau(yKienDongGopDto);
            LoadYKien();

            MessageBox.Show("Ý kiến đóng góp của bạn đã được chỉnh sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dgvYeuCau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string id = dgvYeuCau.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                YKienDongGopBll yKienDongGopBll = new YKienDongGopBll();
                YKienDongGopDto yKienDongGopDto = yKienDongGopBll.lay_theo_id(int.Parse(id));
                string noiDung = dgvYeuCau.Rows[e.RowIndex].Cells["NoiDung"].Value.ToString();
                txbYeuCau.Text = noiDung;

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

        public void LoadYKien()
        {
            dgvYeuCau.Rows.Clear();
            YKienDongGopBll yKienDongGopBll = new YKienDongGopBll();
            List<YKienDongGopDto> yKienDongGopDtos = yKienDongGopBll.lay_theo_idngdung(nguoiDungDto.Id);
            ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
            int Stt = 0;
            foreach (YKienDongGopDto item in yKienDongGopDtos)
            {
                string tenNguoiPhanHoi = null;
                if (item.NguoiPhanHoi != null)
                {
                    tenNguoiPhanHoi = thongTinNguoiDungBll.lay_chi_tiet_theo_iddung(item.NguoiPhanHoi.Value).HoTen;
                }
                Stt++;
                dgvYeuCau.Rows.Add(
                                    item.Id,
                                    Stt,
                                    item.NoiDung,
                                    item.NoiDungPhanHoi,
                                    tenNguoiPhanHoi,
                                    item.NgayGui,
                                    item.NgayPhanHoi
                                   );
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một dòng trong DataGridView chưa
            if (dgvYeuCau.SelectedRows.Count == 0 && dgvYeuCau.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một ý kiến đóng góp để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = null;
            // Kiểm tra nếu người dùng đã chọn một dòng
            if (dgvYeuCau.SelectedRows.Count > 0)
            {
                // Lấy ID từ dòng được chọn
                id = dgvYeuCau.SelectedRows[0].Cells["Id"].Value.ToString();
            }
            else if (dgvYeuCau.SelectedCells.Count > 0)
            {
                // Lấy ID từ ô được chọn (nếu chỉ chọn một ô)
                id = dgvYeuCau.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
            }
            int idYkien = int.Parse(id);

            YKienDongGopBll yKienDongGopBll = new YKienDongGopBll();
            int kq = yKienDongGopBll.xoa_theo_id(idYkien);
            if (kq > 0)
            {
                MessageBox.Show("Ý kiến đóng góp của bạn đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ý kiến đóng góp của bạn bị xóa thất bại! Hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txbYeuCau.Text = null;
            imageData = null;
            ptbAnh.Image = null;
            LoadYKien();

            
        }
    }
}
