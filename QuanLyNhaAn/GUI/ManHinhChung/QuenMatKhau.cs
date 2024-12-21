using PhanMemBaoCom.BLL;
using PhanMemBaoCom.DTO;
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

namespace PhanMemBaoCom.GUI.ManHinhChung
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap manhinh = new DangNhap();
            Point location = this.Location;
            manhinh.StartPosition = FormStartPosition.Manual;
            manhinh.Location = location;
            manhinh.Show();
            this.Hide();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (Cursor.Current != Cursors.WaitCursor)
            {
                Cursor = Cursors.WaitCursor;
                ThongTinNguoiDungBll thongTinNguoiDungBll = new ThongTinNguoiDungBll();
                string tk = txbTaiKhoan.Text;
                string email = txbMail.Text;
                ThongTinNguoiDungDto dto = thongTinNguoiDungBll.quen_mat_khau(tk, email);
                if (dto == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản, hoặc email của bạn! Vui lòng thử lại",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    Cursor = Cursors.Default;
                }
                else
                {
                    
                    MailProcess mailProcess = new MailProcess();
                    Security security = new Security();

                    string matkhaumoi = security.GenerateRandomString();
                    string title = "Thông báo về mật khẩu mới";
                    string content = "Mật khẩu mới của bạn:" + matkhaumoi;
                    
                    var status = await mailProcess.sendMail(email, title, content);
                    int check = thongTinNguoiDungBll.doi_mat_khau(tk, email, security.MD5Hash(matkhaumoi));
                    Cursor = Cursors.Default;
                    if (status && check>0)
                    {
                        
                        MessageBox.Show("Đã gửi mật khẩu mới cho bạn thông qua email: " + email + ".",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi gửi mail! Hãy thử lại.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
            }
            

        }
    }
}
