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
    public partial class UC_QLyChucVu : UserControl
    {
        ThongTinNguoiDungDto nguoiDungDto { get; set; }
        public UC_QLyChucVu(ThongTinNguoiDungDto nguoidungdto)
        {
            nguoiDungDto = nguoidungdto;
            InitializeComponent();
            LoadChucVu();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ChucVuBll chucVuBll = new ChucVuBll();
            ChucVuDto chucVuDto = new ChucVuDto();
            chucVuDto.ChucVu = txbChucVu.Text;
            chucVuDto.LaHocVien = ckbLaHocVien.Checked;
            chucVuDto.CoQuyenBaoCom = ckbBaoCom.Checked;
            chucVuBll.them_chuc_vu(chucVuDto);
            MessageBox.Show("Chức vụ đã được thêm vào hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadChucVu();
        }
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một dòng trong DataGridView chưa
            if (dgvChucVu.SelectedRows.Count == 0 && dgvChucVu.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một chức vụ để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = null;
            // Kiểm tra nếu người dùng đã chọn một dòng
            if (dgvChucVu.SelectedRows.Count > 0)
            {
                // Lấy ID từ dòng được chọn
                id = dgvChucVu.SelectedRows[0].Cells["Id"].Value.ToString();
            }
            else if (dgvChucVu.SelectedCells.Count > 0)
            {
                // Lấy ID từ ô được chọn (nếu chỉ chọn một ô)
                id = dgvChucVu.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
            }
            int idChucVu = int.Parse(id);

            ChucVuBll chucVuBll = new ChucVuBll();
            ChucVuDto chucVuDto = chucVuBll.lay_theo_id(idChucVu);

            if (chucVuDto == null)
            {
                MessageBox.Show("Không tìm thấy chức vụ cần chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            chucVuDto.ChucVu = txbChucVu.Text;
            chucVuDto.LaHocVien = ckbLaHocVien.Checked;
            chucVuDto.CoQuyenBaoCom = ckbBaoCom.Checked;
            chucVuBll.chinh_sua_chuc_vu(chucVuDto);

            LoadChucVu();

            MessageBox.Show("Chức vụ của bạn đã được chỉnh sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một dòng trong DataGridView chưa
            if (dgvChucVu.SelectedRows.Count == 0 && dgvChucVu.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một chức vụ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = null;
            // Kiểm tra nếu người dùng đã chọn một dòng
            if (dgvChucVu.SelectedRows.Count > 0)
            {
                // Lấy ID từ dòng được chọn
                id = dgvChucVu.SelectedRows[0].Cells["Id"].Value.ToString();
            }
            else if (dgvChucVu.SelectedCells.Count > 0)
            {
                // Lấy ID từ ô được chọn (nếu chỉ chọn một ô)
                id = dgvChucVu.SelectedCells[0].OwningRow.Cells["Id"].Value.ToString();
            }
            int idYkien = int.Parse(id);

            ChucVuBll chucVuBll = new ChucVuBll();
            try
            {
                chucVuBll.xoa_theo_id(idYkien);
                LoadChucVu();

                MessageBox.Show("Chức vụ đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chức vụ không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string id = dgvChucVu.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                ChucVuBll chucVuBll = new ChucVuBll();
                ChucVuDto chucVuDto = chucVuBll.lay_theo_id(int.Parse(id));
                txbChucVu.Text = chucVuDto.ChucVu.ToString();
                ckbBaoCom.Checked = chucVuDto.CoQuyenBaoCom;
                ckbLaHocVien.Checked = chucVuDto.LaHocVien;
            }
        }

        public void LoadChucVu()
        {
            ChucVuBll chucVuBll = new ChucVuBll();
            List<ChucVuDto> chucVuDtos = chucVuBll.lay_tat_ca();

            dgvChucVu.Rows.Clear();
            int Stt = 0;
            foreach (ChucVuDto item in chucVuDtos)
            {
                Stt++;
                dgvChucVu.Rows.Add(
                                    item.Id,
                                    Stt,
                                    item.ChucVu,
                                    item.LaHocVien,
                                    item.CoQuyenBaoCom
                                   );
            }

        }
    }
}
