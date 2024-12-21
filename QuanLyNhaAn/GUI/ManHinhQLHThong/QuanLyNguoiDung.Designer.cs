namespace QuanLyNhaAn.GUI.ManHinhQLHThong
{
    partial class QuanLyNguoiDung
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNguoiDung));
            slidebarTimer = new System.Windows.Forms.Timer(components);
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
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnChuyen = new Button();
            btnSua = new Button();
            dgvNguoiDung = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            MaNguoiDung = new DataGridViewTextBoxColumn();
            Lop = new DataGridViewTextBoxColumn();
            Phong = new DataGridViewTextBoxColumn();
            Khoa = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            ChucVuID = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            label4 = new Label();
            panel10 = new Panel();
            pnlUser = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lbUser = new Label();
            panel1 = new Panel();
            btnQLChucVu = new Button();
            btnQLNguoiDung = new Button();
            button1 = new Button();
            btnQLYeuCau = new Button();
            btnCaiDat = new Button();
            txbTimKiem = new TextBox();
            btnTimKiem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNguoiDung).BeginInit();
            panel10.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // slidebarTimer
            // 
            slidebarTimer.Interval = 20;
            slidebarTimer.Tick += slidebarTimer_Tick;
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
            groupBox1.Location = new Point(274, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(609, 278);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nội dung chi tiết";
            // 
            // cbxVaiTro
            // 
            cbxVaiTro.FormattingEnabled = true;
            cbxVaiTro.Location = new Point(389, 217);
            cbxVaiTro.Name = "cbxVaiTro";
            cbxVaiTro.Size = new Size(205, 28);
            cbxVaiTro.TabIndex = 20;
            cbxVaiTro.SelectedIndexChanged += cbxVaiTro_SelectedIndexChanged;
            // 
            // txbMaND
            // 
            txbMaND.Location = new Point(84, 96);
            txbMaND.Name = "txbMaND";
            txbMaND.Size = new Size(171, 27);
            txbMaND.TabIndex = 19;
            // 
            // txbSTK
            // 
            txbSTK.Location = new Point(389, 94);
            txbSTK.Name = "txbSTK";
            txbSTK.Size = new Size(205, 27);
            txbSTK.TabIndex = 18;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(389, 176);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(205, 27);
            txbEmail.TabIndex = 16;
            // 
            // txbTenNH
            // 
            txbTenNH.Location = new Point(389, 136);
            txbTenNH.Name = "txbTenNH";
            txbTenNH.Size = new Size(205, 27);
            txbTenNH.TabIndex = 15;
            // 
            // txbSDT
            // 
            txbSDT.Location = new Point(389, 46);
            txbSDT.Name = "txbSDT";
            txbSDT.Size = new Size(205, 27);
            txbSDT.TabIndex = 14;
            // 
            // txbDonVi
            // 
            txbDonVi.Location = new Point(84, 217);
            txbDonVi.Name = "txbDonVi";
            txbDonVi.Size = new Size(171, 27);
            txbDonVi.TabIndex = 13;
            // 
            // txbKhoaHoc
            // 
            txbKhoaHoc.Location = new Point(84, 177);
            txbKhoaHoc.Name = "txbKhoaHoc";
            txbKhoaHoc.Size = new Size(171, 27);
            txbKhoaHoc.TabIndex = 12;
            // 
            // txbLopHoc
            // 
            txbLopHoc.Location = new Point(84, 137);
            txbLopHoc.Name = "txbLopHoc";
            txbLopHoc.Size = new Size(171, 27);
            txbLopHoc.TabIndex = 11;
            // 
            // txbHoTen
            // 
            txbHoTen.Location = new Point(84, 47);
            txbHoTen.Name = "txbHoTen";
            txbHoTen.Size = new Size(171, 27);
            txbHoTen.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(284, 220);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 9;
            label10.Text = "Vai trò";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(284, 180);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 8;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(284, 140);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 7;
            label8.Text = "Tên ngân hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(284, 97);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 6;
            label7.Text = "Số tài khoản";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 49);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 5;
            label6.Text = "Số điện thoại";
            // 
            // lbDonVi
            // 
            lbDonVi.AutoSize = true;
            lbDonVi.Location = new Point(12, 220);
            lbDonVi.Name = "lbDonVi";
            lbDonVi.Size = new Size(52, 20);
            lbDonVi.TabIndex = 4;
            lbDonVi.Text = "Đơn vị";
            // 
            // lbKhoaHoc
            // 
            lbKhoaHoc.AutoSize = true;
            lbKhoaHoc.Location = new Point(12, 180);
            lbKhoaHoc.Name = "lbKhoaHoc";
            lbKhoaHoc.Size = new Size(71, 20);
            lbKhoaHoc.TabIndex = 3;
            lbKhoaHoc.Text = "Khóa học";
            // 
            // lbLop
            // 
            lbLop.AutoSize = true;
            lbLop.Location = new Point(12, 140);
            lbLop.Name = "lbLop";
            lbLop.Size = new Size(62, 20);
            lbLop.TabIndex = 2;
            lbLop.Text = "Lớp học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã ND";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 49);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Họ và tên";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(1013, 106);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(135, 29);
            btnLamMoi.TabIndex = 32;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(908, 199);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(84, 29);
            btnXoa.TabIndex = 24;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(908, 106);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(84, 29);
            btnThem.TabIndex = 23;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnChuyen
            // 
            btnChuyen.Location = new Point(1013, 156);
            btnChuyen.Name = "btnChuyen";
            btnChuyen.Size = new Size(135, 29);
            btnChuyen.TabIndex = 22;
            btnChuyen.Text = "Chuyển trạng thái";
            btnChuyen.UseVisualStyleBackColor = true;
            btnChuyen.Click += btnChuyen_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(908, 155);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(84, 29);
            btnSua.TabIndex = 21;
            btnSua.Text = "Chỉnh sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // dgvNguoiDung
            // 
            dgvNguoiDung.AllowUserToAddRows = false;
            dgvNguoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNguoiDung.Columns.AddRange(new DataGridViewColumn[] { STT, HoTen, MaNguoiDung, Lop, Phong, Khoa, DonVi, ChucVuID, TrangThai });
            dgvNguoiDung.Location = new Point(260, 350);
            dgvNguoiDung.Name = "dgvNguoiDung";
            dgvNguoiDung.RowHeadersWidth = 51;
            dgvNguoiDung.RowTemplate.Height = 29;
            dgvNguoiDung.Size = new Size(1578, 631);
            dgvNguoiDung.TabIndex = 4;
            dgvNguoiDung.CellClick += dgvNguoiDung_CellClick;
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
            HoTen.Width = 125;
            // 
            // MaNguoiDung
            // 
            MaNguoiDung.HeaderText = "Mã người dùng";
            MaNguoiDung.MinimumWidth = 6;
            MaNguoiDung.Name = "MaNguoiDung";
            MaNguoiDung.ReadOnly = true;
            MaNguoiDung.Width = 150;
            // 
            // Lop
            // 
            Lop.HeaderText = "Lớp";
            Lop.MinimumWidth = 6;
            Lop.Name = "Lop";
            Lop.ReadOnly = true;
            Lop.Width = 70;
            // 
            // Phong
            // 
            Phong.HeaderText = "Phòng";
            Phong.MinimumWidth = 6;
            Phong.Name = "Phong";
            Phong.ReadOnly = true;
            Phong.Width = 110;
            // 
            // Khoa
            // 
            Khoa.HeaderText = "Khoa";
            Khoa.MinimumWidth = 6;
            Khoa.Name = "Khoa";
            Khoa.ReadOnly = true;
            Khoa.Width = 70;
            // 
            // DonVi
            // 
            DonVi.HeaderText = "Đơn vị";
            DonVi.MinimumWidth = 6;
            DonVi.Name = "DonVi";
            DonVi.ReadOnly = true;
            DonVi.Width = 110;
            // 
            // ChucVuID
            // 
            ChucVuID.HeaderText = "Chức vụ";
            ChucVuID.MinimumWidth = 6;
            ChucVuID.Name = "ChucVuID";
            ChucVuID.ReadOnly = true;
            ChucVuID.Width = 125;
            // 
            // TrangThai
            // 
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            TrangThai.Width = 110;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(266, 8);
            label4.Name = "label4";
            label4.Size = new Size(399, 54);
            label4.TabIndex = 6;
            label4.Text = "Quản lý người dùng";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 127, 184);
            panel10.Controls.Add(pnlUser);
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(258, 123);
            panel10.TabIndex = 31;
            // 
            // pnlUser
            // 
            pnlUser.Controls.Add(pictureBox1);
            pnlUser.Controls.Add(label1);
            pnlUser.Controls.Add(lbUser);
            pnlUser.Location = new Point(12, 14);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(238, 85);
            pnlUser.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(10, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 14);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 5;
            label1.Text = "Xin chào,";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUser.ForeColor = Color.White;
            lbUser.Location = new Point(56, 51);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(70, 28);
            lbUser.TabIndex = 4;
            lbUser.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 127, 184);
            panel1.Controls.Add(btnQLChucVu);
            panel1.Controls.Add(btnQLNguoiDung);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnQLYeuCau);
            panel1.Controls.Add(btnCaiDat);
            panel1.Location = new Point(1, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 915);
            panel1.TabIndex = 30;
            // 
            // btnQLChucVu
            // 
            btnQLChucVu.BackColor = Color.FromArgb(0, 127, 184);
            btnQLChucVu.FlatAppearance.BorderSize = 0;
            btnQLChucVu.FlatStyle = FlatStyle.Flat;
            btnQLChucVu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLChucVu.ForeColor = Color.White;
            btnQLChucVu.Image = (Image)resources.GetObject("btnQLChucVu.Image");
            btnQLChucVu.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLChucVu.Location = new Point(1, 81);
            btnQLChucVu.Margin = new Padding(3, 20, 3, 11);
            btnQLChucVu.Name = "btnQLChucVu";
            btnQLChucVu.Size = new Size(257, 44);
            btnQLChucVu.TabIndex = 3;
            btnQLChucVu.Text = "          Quản lý chức vụ";
            btnQLChucVu.TextAlign = ContentAlignment.MiddleLeft;
            btnQLChucVu.UseVisualStyleBackColor = false;
            btnQLChucVu.Click += btnQLChucVu_Click;
            // 
            // btnQLNguoiDung
            // 
            btnQLNguoiDung.BackColor = Color.FromArgb(0, 127, 184);
            btnQLNguoiDung.FlatAppearance.BorderSize = 0;
            btnQLNguoiDung.FlatStyle = FlatStyle.Flat;
            btnQLNguoiDung.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLNguoiDung.ForeColor = Color.White;
            btnQLNguoiDung.Image = (Image)resources.GetObject("btnQLNguoiDung.Image");
            btnQLNguoiDung.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLNguoiDung.Location = new Point(1, 14);
            btnQLNguoiDung.Margin = new Padding(3, 3, 3, 11);
            btnQLNguoiDung.Name = "btnQLNguoiDung";
            btnQLNguoiDung.Size = new Size(257, 52);
            btnQLNguoiDung.TabIndex = 2;
            btnQLNguoiDung.Text = "          Quản lý người dùng";
            btnQLNguoiDung.TextAlign = ContentAlignment.MiddleLeft;
            btnQLNguoiDung.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 127, 184);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1, 707);
            button1.Margin = new Padding(3, 250, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(257, 52);
            button1.TabIndex = 3;
            button1.Text = "        Đăng Xuất";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnQLYeuCau
            // 
            btnQLYeuCau.BackColor = Color.FromArgb(0, 127, 184);
            btnQLYeuCau.FlatAppearance.BorderSize = 0;
            btnQLYeuCau.FlatStyle = FlatStyle.Flat;
            btnQLYeuCau.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLYeuCau.ForeColor = Color.White;
            btnQLYeuCau.Image = (Image)resources.GetObject("btnQLYeuCau.Image");
            btnQLYeuCau.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLYeuCau.Location = new Point(1, 143);
            btnQLYeuCau.Margin = new Padding(3, 20, 3, 11);
            btnQLYeuCau.Name = "btnQLYeuCau";
            btnQLYeuCau.Size = new Size(258, 47);
            btnQLYeuCau.TabIndex = 4;
            btnQLYeuCau.Text = "          Ý kiến đóng góp";
            btnQLYeuCau.TextAlign = ContentAlignment.MiddleLeft;
            btnQLYeuCau.UseVisualStyleBackColor = false;
            btnQLYeuCau.Click += btnQLYeuCau_Click;
            // 
            // btnCaiDat
            // 
            btnCaiDat.BackColor = Color.FromArgb(0, 127, 184);
            btnCaiDat.FlatAppearance.BorderSize = 0;
            btnCaiDat.FlatStyle = FlatStyle.Flat;
            btnCaiDat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCaiDat.ForeColor = Color.White;
            btnCaiDat.Image = (Image)resources.GetObject("btnCaiDat.Image");
            btnCaiDat.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaiDat.Location = new Point(1, 209);
            btnCaiDat.Margin = new Padding(3, 20, 3, 3);
            btnCaiDat.Name = "btnCaiDat";
            btnCaiDat.Size = new Size(258, 47);
            btnCaiDat.TabIndex = 5;
            btnCaiDat.Text = "          Cài đặt hệ thống";
            btnCaiDat.TextAlign = ContentAlignment.MiddleLeft;
            btnCaiDat.UseVisualStyleBackColor = false;
            btnCaiDat.Click += btnCaiDat_Click;
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(829, 28);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(205, 27);
            txbTimKiem.TabIndex = 32;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1054, 28);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 33;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // QuanLyNguoiDung
            // 
            AccessibleDescription = "";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnTimKiem);
            Controls.Add(btnThem);
            Controls.Add(txbTimKiem);
            Controls.Add(btnChuyen);
            Controls.Add(panel10);
            Controls.Add(btnSua);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(dgvNguoiDung);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QuanLyNguoiDung";
            Text = "Quản Lý Hệ Thống";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNguoiDung).EndInit();
            panel10.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer slidebarTimer;
        private GroupBox groupBox1;
        private Button btnSua;
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
        private Label label4;
        private Button btnChuyen;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn MaNguoiDung;
        private DataGridViewTextBoxColumn Lop;
        private DataGridViewTextBoxColumn Phong;
        private DataGridViewTextBoxColumn Khoa;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn ChucVuID;
        private DataGridViewTextBoxColumn TrangThai;
        private Panel panel10;
        private Panel pnlUser;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbUser;
        private Panel panel1;
        private Button btnQLChucVu;
        private Button btnQLNguoiDung;
        private Button button1;
        private Button btnQLYeuCau;
        private Button btnCaiDat;
        private Button btnXoa;
        private Button btnThem;
        private Button btnLamMoi;
        private TextBox txbTimKiem;
        private Button btnTimKiem;
    }
}