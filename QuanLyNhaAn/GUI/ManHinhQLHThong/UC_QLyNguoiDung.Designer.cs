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
            txbHoTen = new TextBox();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNguoiDung).BeginInit();
            SuspendLayout();
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(763, 75);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(135, 29);
            btnLamMoi.TabIndex = 40;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(658, 168);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(84, 29);
            btnXoa.TabIndex = 39;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(921, 25);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 42;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(658, 75);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(84, 29);
            btnThem.TabIndex = 38;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(658, 25);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(243, 27);
            txbTimKiem.TabIndex = 41;
            // 
            // btnChuyen
            // 
            btnChuyen.Location = new Point(763, 125);
            btnChuyen.Name = "btnChuyen";
            btnChuyen.Size = new Size(135, 29);
            btnChuyen.TabIndex = 37;
            btnChuyen.Text = "Chuyển trạng thái";
            btnChuyen.UseVisualStyleBackColor = true;
            btnChuyen.Click += btnChuyen_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(658, 124);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(84, 29);
            btnSua.TabIndex = 36;
            btnSua.Text = "Chỉnh sửa";
            btnSua.UseVisualStyleBackColor = true;
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
            groupBox1.Controls.Add(txbHoTen);
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
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(609, 278);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nội dung chi tiết";
            // 
            // cbxVaiTro
            // 
            cbxVaiTro.FormattingEnabled = true;
            cbxVaiTro.Location = new Point(389, 197);
            cbxVaiTro.Name = "cbxVaiTro";
            cbxVaiTro.Size = new Size(205, 28);
            cbxVaiTro.TabIndex = 20;
            cbxVaiTro.SelectedIndexChanged += cbxVaiTro_SelectedIndexChanged;
            // 
            // txbMaND
            // 
            txbMaND.Location = new Point(84, 76);
            txbMaND.Name = "txbMaND";
            txbMaND.Size = new Size(171, 27);
            txbMaND.TabIndex = 19;
            // 
            // txbSTK
            // 
            txbSTK.Location = new Point(389, 74);
            txbSTK.Name = "txbSTK";
            txbSTK.Size = new Size(205, 27);
            txbSTK.TabIndex = 18;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(389, 156);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(205, 27);
            txbEmail.TabIndex = 16;
            // 
            // txbTenNH
            // 
            txbTenNH.Location = new Point(389, 116);
            txbTenNH.Name = "txbTenNH";
            txbTenNH.Size = new Size(205, 27);
            txbTenNH.TabIndex = 15;
            // 
            // txbSDT
            // 
            txbSDT.Location = new Point(389, 26);
            txbSDT.Name = "txbSDT";
            txbSDT.Size = new Size(205, 27);
            txbSDT.TabIndex = 14;
            // 
            // txbDonVi
            // 
            txbDonVi.Location = new Point(84, 197);
            txbDonVi.Name = "txbDonVi";
            txbDonVi.Size = new Size(171, 27);
            txbDonVi.TabIndex = 13;
            // 
            // txbKhoaHoc
            // 
            txbKhoaHoc.Location = new Point(84, 157);
            txbKhoaHoc.Name = "txbKhoaHoc";
            txbKhoaHoc.Size = new Size(171, 27);
            txbKhoaHoc.TabIndex = 12;
            // 
            // txbLopHoc
            // 
            txbLopHoc.Location = new Point(84, 117);
            txbLopHoc.Name = "txbLopHoc";
            txbLopHoc.Size = new Size(171, 27);
            txbLopHoc.TabIndex = 11;
            // 
            // txbHoTen
            // 
            txbHoTen.Location = new Point(84, 27);
            txbHoTen.Name = "txbHoTen";
            txbHoTen.Size = new Size(171, 27);
            txbHoTen.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(284, 200);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 9;
            label10.Text = "Vai trò";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(284, 160);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 8;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(284, 120);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 7;
            label8.Text = "Tên ngân hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(284, 77);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 6;
            label7.Text = "Số tài khoản";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 29);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 5;
            label6.Text = "Số điện thoại";
            // 
            // lbDonVi
            // 
            lbDonVi.AutoSize = true;
            lbDonVi.Location = new Point(12, 200);
            lbDonVi.Name = "lbDonVi";
            lbDonVi.Size = new Size(52, 20);
            lbDonVi.TabIndex = 4;
            lbDonVi.Text = "Đơn vị";
            // 
            // lbKhoaHoc
            // 
            lbKhoaHoc.AutoSize = true;
            lbKhoaHoc.Location = new Point(12, 160);
            lbKhoaHoc.Name = "lbKhoaHoc";
            lbKhoaHoc.Size = new Size(71, 20);
            lbKhoaHoc.TabIndex = 3;
            lbKhoaHoc.Text = "Khóa học";
            // 
            // lbLop
            // 
            lbLop.AutoSize = true;
            lbLop.Location = new Point(12, 120);
            lbLop.Name = "lbLop";
            lbLop.Size = new Size(62, 20);
            lbLop.TabIndex = 2;
            lbLop.Text = "Lớp học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã ND";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 29);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Họ và tên";
            // 
            // dgvNguoiDung
            // 
            dgvNguoiDung.AllowUserToAddRows = false;
            dgvNguoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNguoiDung.Columns.AddRange(new DataGridViewColumn[] { Id, STT, HoTen, MaNguoiDung, Lop, Phong, Khoa, DonVi, ChucVuID, TrangThai });
            dgvNguoiDung.Location = new Point(10, 303);
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
            // UC_QLyNguoiDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnTimKiem);
            Controls.Add(btnThem);
            Controls.Add(txbTimKiem);
            Controls.Add(btnChuyen);
            Controls.Add(btnSua);
            Controls.Add(groupBox1);
            Controls.Add(dgvNguoiDung);
            Name = "UC_QLyNguoiDung";
            Size = new Size(1615, 958);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNguoiDung).EndInit();
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
    }
}
