using System.Windows.Forms;

namespace QuanLyNhaAn.GUI.ManHinhQLHThong
{
    partial class UC_QLyNguoiDung
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_QLyNguoiDung));
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            btnThem = new Button();
            txbTimKiem = new TextBox();
            btnChuyen = new Button();
            btnSua = new Button();
            groupBox1 = new GroupBox();
            cbxVaiTro = new ComboBox();
            txbMaND = new TextBox();
            txbSTK = new TextBox();
            txbEmail = new TextBox();
            txbTenNH = new TextBox();
            txbSDT = new TextBox();
            txbDonVi = new TextBox();
            txbKhoaHoc = new TextBox();
            txbLopHoc = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            lbDonVi = new Label();
            lbKhoaHoc = new Label();
            lbLop = new Label();
            label2 = new Label();
            label3 = new Label();
            txbHoTen = new TextBox();
            dgvNguoiDung = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            STT = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            MaNguoiDung = new DataGridViewTextBoxColumn();
            Lop = new DataGridViewTextBoxColumn();
            Phong = new DataGridViewTextBoxColumn();
            Khoa = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            ChucVuID = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNguoiDung).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Yellow;
            btnLamMoi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnLamMoi.Location = new Point(763, 144);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(138, 39);
            btnLamMoi.TabIndex = 40;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(658, 242);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 35);
            btnXoa.TabIndex = 39;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(255, 128, 0);
            btnTimKiem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(921, 87);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(102, 39);
            btnTimKiem.TabIndex = 42;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DodgerBlue;
            btnThem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(658, 144);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 37);
            btnThem.TabIndex = 38;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(658, 94);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(243, 27);
            txbTimKiem.TabIndex = 41;
            // 
            // btnChuyen
            // 
            btnChuyen.BackColor = Color.FromArgb(0, 192, 192);
            btnChuyen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnChuyen.Location = new Point(763, 194);
            btnChuyen.Name = "btnChuyen";
            btnChuyen.Size = new Size(195, 39);
            btnChuyen.TabIndex = 37;
            btnChuyen.Text = "Chuyển trạng thái";
            btnChuyen.UseVisualStyleBackColor = false;
            btnChuyen.Click += btnChuyen_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Lime;
            btnSua.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(658, 193);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(99, 38);
            btnSua.TabIndex = 36;
            btnSua.Text = "Chỉnh sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxVaiTro);
            groupBox1.Controls.Add(txbMaND);
            groupBox1.Controls.Add(txbSTK);
            groupBox1.Controls.Add(txbEmail);
            groupBox1.Controls.Add(txbTenNH);
            groupBox1.Controls.Add(txbSDT);
            groupBox1.Controls.Add(txbDonVi);
            groupBox1.Controls.Add(txbKhoaHoc);
            groupBox1.Controls.Add(txbLopHoc);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lbDonVi);
            groupBox1.Controls.Add(lbKhoaHoc);
            groupBox1.Controls.Add(lbLop);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbHoTen);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(609, 264);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nội dung chi tiết";
            // 
            // cbxVaiTro
            // 
            cbxVaiTro.FormattingEnabled = true;
            cbxVaiTro.Location = new Point(389, 219);
            cbxVaiTro.Name = "cbxVaiTro";
            cbxVaiTro.Size = new Size(205, 33);
            cbxVaiTro.TabIndex = 20;
            cbxVaiTro.SelectedIndexChanged += cbxVaiTro_SelectedIndexChanged;
            // 
            // txbMaND
            // 
            txbMaND.Location = new Point(84, 98);
            txbMaND.Name = "txbMaND";
            txbMaND.Size = new Size(171, 32);
            txbMaND.TabIndex = 19;
            // 
            // txbSTK
            // 
            txbSTK.Location = new Point(389, 96);
            txbSTK.Name = "txbSTK";
            txbSTK.Size = new Size(205, 32);
            txbSTK.TabIndex = 18;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(389, 178);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(205, 32);
            txbEmail.TabIndex = 16;
            // 
            // txbTenNH
            // 
            txbTenNH.Location = new Point(389, 138);
            txbTenNH.Name = "txbTenNH";
            txbTenNH.Size = new Size(205, 32);
            txbTenNH.TabIndex = 15;
            // 
            // txbSDT
            // 
            txbSDT.Location = new Point(389, 55);
            txbSDT.Name = "txbSDT";
            txbSDT.Size = new Size(205, 32);
            txbSDT.TabIndex = 14;
            // 
            // txbDonVi
            // 
            txbDonVi.Location = new Point(84, 219);
            txbDonVi.Name = "txbDonVi";
            txbDonVi.Size = new Size(171, 32);
            txbDonVi.TabIndex = 13;
            // 
            // txbKhoaHoc
            // 
            txbKhoaHoc.Location = new Point(84, 179);
            txbKhoaHoc.Name = "txbKhoaHoc";
            txbKhoaHoc.Size = new Size(171, 32);
            txbKhoaHoc.TabIndex = 12;
            // 
            // txbLopHoc
            // 
            txbLopHoc.Location = new Point(84, 139);
            txbLopHoc.Name = "txbLopHoc";
            txbLopHoc.Size = new Size(171, 32);
            txbLopHoc.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(284, 222);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 9;
            label10.Text = "Vai trò";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(284, 182);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 8;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(284, 142);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 7;
            label8.Text = "Tên ngân hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(284, 99);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 6;
            label7.Text = "Số tài khoản";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(284, 58);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 5;
            label6.Text = "Số điện thoại";
            // 
            // lbDonVi
            // 
            lbDonVi.AutoSize = true;
            lbDonVi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbDonVi.Location = new Point(12, 222);
            lbDonVi.Name = "lbDonVi";
            lbDonVi.Size = new Size(52, 20);
            lbDonVi.TabIndex = 4;
            lbDonVi.Text = "Đơn vị";
            // 
            // lbKhoaHoc
            // 
            lbKhoaHoc.AutoSize = true;
            lbKhoaHoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbKhoaHoc.Location = new Point(12, 182);
            lbKhoaHoc.Name = "lbKhoaHoc";
            lbKhoaHoc.Size = new Size(71, 20);
            lbKhoaHoc.TabIndex = 3;
            lbKhoaHoc.Text = "Khóa học";
            // 
            // lbLop
            // 
            lbLop.AutoSize = true;
            lbLop.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbLop.Location = new Point(12, 142);
            lbLop.Name = "lbLop";
            lbLop.Size = new Size(62, 20);
            lbLop.TabIndex = 2;
            lbLop.Text = "Lớp học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã ND";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 58);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Họ và tên";
            // 
            // txbHoTen
            // 
            txbHoTen.Location = new Point(84, 56);
            txbHoTen.Name = "txbHoTen";
            txbHoTen.Size = new Size(171, 32);
            txbHoTen.TabIndex = 10;
            // 
            // dgvNguoiDung
            // 
            dgvNguoiDung.AllowUserToAddRows = false;
            dgvNguoiDung.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(2, 136, 209);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNguoiDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNguoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNguoiDung.Columns.AddRange(new DataGridViewColumn[] { Id, STT, HoTen, MaNguoiDung, Lop, Phong, Khoa, DonVi, ChucVuID, TrangThai });
            dgvNguoiDung.EnableHeadersVisualStyles = false;
            dgvNguoiDung.Location = new Point(10, 372);
            dgvNguoiDung.Name = "dgvNguoiDung";
            dgvNguoiDung.RowHeadersWidth = 51;
            dgvNguoiDung.RowTemplate.Height = 29;
            dgvNguoiDung.Size = new Size(1578, 587);
            dgvNguoiDung.TabIndex = 34;
            dgvNguoiDung.CellClick += dgvNguoiDung_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 125;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 50;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Họ và tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            HoTen.Width = 300;
            // 
            // MaNguoiDung
            // 
            MaNguoiDung.HeaderText = "Mã người dùng";
            MaNguoiDung.MinimumWidth = 6;
            MaNguoiDung.Name = "MaNguoiDung";
            MaNguoiDung.ReadOnly = true;
            MaNguoiDung.Width = 250;
            // 
            // Lop
            // 
            Lop.HeaderText = "Lớp";
            Lop.MinimumWidth = 6;
            Lop.Name = "Lop";
            Lop.ReadOnly = true;
            Lop.Width = 150;
            // 
            // Phong
            // 
            Phong.HeaderText = "Phòng";
            Phong.MinimumWidth = 6;
            Phong.Name = "Phong";
            Phong.ReadOnly = true;
            Phong.Width = 150;
            // 
            // Khoa
            // 
            Khoa.HeaderText = "Khoa";
            Khoa.MinimumWidth = 6;
            Khoa.Name = "Khoa";
            Khoa.ReadOnly = true;
            Khoa.Width = 150;
            // 
            // DonVi
            // 
            DonVi.HeaderText = "Đơn vị";
            DonVi.MinimumWidth = 6;
            DonVi.Name = "DonVi";
            DonVi.ReadOnly = true;
            DonVi.Width = 150;
            // 
            // ChucVuID
            // 
            ChucVuID.HeaderText = "Chức vụ";
            ChucVuID.MinimumWidth = 6;
            ChucVuID.Name = "ChucVuID";
            ChucVuID.ReadOnly = true;
            ChucVuID.Width = 170;
            // 
            // TrangThai
            // 
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            TrangThai.Width = 155;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1648, 1034);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // UC_QLyNguoiDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnTimKiem);
            Controls.Add(btnThem);
            Controls.Add(txbTimKiem);
            Controls.Add(btnChuyen);
            Controls.Add(btnSua);
            Controls.Add(dgvNguoiDung);
            Controls.Add(pictureBox1);
            Name = "UC_QLyNguoiDung";
            Size = new Size(1648, 1034);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNguoiDung).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnTimKiem;
        private Button btnThem;
        private TextBox txbTimKiem;
        private Button btnChuyen;
        private Button btnSua;
        private GroupBox groupBox1;
        private ComboBox cbxVaiTro;
        private TextBox txbMaND;
        private TextBox txbSTK;
        private TextBox txbEmail;
        private TextBox txbTenNH;
        private TextBox txbSDT;
        private TextBox txbDonVi;
        private TextBox txbKhoaHoc;
        private TextBox txbLopHoc;
        private TextBox txbHoTen;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label lbDonVi;
        private Label lbKhoaHoc;
        private Label lbLop;
        private Label label2;
        private Label label3;
        private DataGridView dgvNguoiDung;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn MaNguoiDung;
        private DataGridViewTextBoxColumn Lop;
        private DataGridViewTextBoxColumn Phong;
        private DataGridViewTextBoxColumn Khoa;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn ChucVuID;
        private DataGridViewTextBoxColumn TrangThai;
        private PictureBox pictureBox1;
    }
}
