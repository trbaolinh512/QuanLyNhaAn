namespace QuanLyNhaAn.GUI.ManHinhQLHThong
{
    partial class QuanLyChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyChucVu));
            dgvChucVu = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            STT = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            LaHocVien = new DataGridViewCheckBoxColumn();
            CoQuyenBaoCom = new DataGridViewCheckBoxColumn();
            label4 = new Label();
            txbChucVu = new TextBox();
            label2 = new Label();
            btnChinhSua = new Button();
            ckbLaHocVien = new CheckBox();
            ckbBaoCom = new CheckBox();
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
            btnThem = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).BeginInit();
            panel10.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvChucVu
            // 
            dgvChucVu.AllowUserToAddRows = false;
            dgvChucVu.AllowUserToDeleteRows = false;
            dgvChucVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChucVu.Columns.AddRange(new DataGridViewColumn[] { Id, STT, ChucVu, LaHocVien, CoQuyenBaoCom });
            dgvChucVu.Location = new Point(274, 98);
            dgvChucVu.Name = "dgvChucVu";
            dgvChucVu.ReadOnly = true;
            dgvChucVu.RowHeadersWidth = 51;
            dgvChucVu.RowTemplate.Height = 29;
            dgvChucVu.Size = new Size(605, 899);
            dgvChucVu.TabIndex = 2;
            dgvChucVu.CellClick += dgvChucVu_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 125;
            // 
            // ChucVu
            // 
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            ChucVu.ReadOnly = true;
            ChucVu.Width = 150;
            // 
            // LaHocVien
            // 
            LaHocVien.HeaderText = "Là học viên";
            LaHocVien.MinimumWidth = 6;
            LaHocVien.Name = "LaHocVien";
            LaHocVien.ReadOnly = true;
            LaHocVien.Width = 125;
            // 
            // CoQuyenBaoCom
            // 
            CoQuyenBaoCom.HeaderText = "Có quyền báo cơm";
            CoQuyenBaoCom.MinimumWidth = 6;
            CoQuyenBaoCom.Name = "CoQuyenBaoCom";
            CoQuyenBaoCom.ReadOnly = true;
            CoQuyenBaoCom.Width = 150;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(272, 9);
            label4.Name = "label4";
            label4.Size = new Size(324, 54);
            label4.TabIndex = 7;
            label4.Text = "Quản lý chức vụ";
            // 
            // txbChucVu
            // 
            txbChucVu.Location = new Point(924, 140);
            txbChucVu.Name = "txbChucVu";
            txbChucVu.Size = new Size(167, 27);
            txbChucVu.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(924, 112);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 9;
            label2.Text = "Chức vụ";
            // 
            // btnChinhSua
            // 
            btnChinhSua.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnChinhSua.Location = new Point(1104, 173);
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(101, 29);
            btnChinhSua.TabIndex = 10;
            btnChinhSua.Text = "Chỉnh sửa";
            btnChinhSua.UseVisualStyleBackColor = true;
            btnChinhSua.Click += btnChinhSua_Click;
            // 
            // ckbLaHocVien
            // 
            ckbLaHocVien.AutoSize = true;
            ckbLaHocVien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ckbLaHocVien.Location = new Point(924, 173);
            ckbLaHocVien.Name = "ckbLaHocVien";
            ckbLaHocVien.Size = new Size(116, 24);
            ckbLaHocVien.TabIndex = 11;
            ckbLaHocVien.Text = "Là học viên ?";
            ckbLaHocVien.UseVisualStyleBackColor = true;
            // 
            // ckbBaoCom
            // 
            ckbBaoCom.AutoSize = true;
            ckbBaoCom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ckbBaoCom.Location = new Point(924, 212);
            ckbBaoCom.Name = "ckbBaoCom";
            ckbBaoCom.Size = new Size(167, 24);
            ckbBaoCom.TabIndex = 12;
            ckbBaoCom.Text = "Có quyền báo cơm ?";
            ckbBaoCom.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 127, 184);
            panel10.Controls.Add(pnlUser);
            panel10.Location = new Point(-1, -2);
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
            panel1.Location = new Point(0, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 918);
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
            btnQLNguoiDung.Click += btnQLNguoiDung_Click;
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
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(1104, 131);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(101, 29);
            btnThem.TabIndex = 32;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(1104, 212);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(101, 29);
            btnXoa.TabIndex = 33;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // QuanLyChucVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(panel10);
            Controls.Add(panel1);
            Controls.Add(ckbBaoCom);
            Controls.Add(ckbLaHocVien);
            Controls.Add(btnChinhSua);
            Controls.Add(label2);
            Controls.Add(txbChucVu);
            Controls.Add(label4);
            Controls.Add(dgvChucVu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QuanLyChucVu";
            Text = "Quản lý hệ thống";
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).EndInit();
            panel10.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvChucVu;
        private Label label4;
        private TextBox txbChucVu;
        private Label label2;
        private Button btnChinhSua;
        private CheckBox ckbLaHocVien;
        private CheckBox ckbBaoCom;
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
        private Button btnThem;
        private Button btnXoa;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewCheckBoxColumn LaHocVien;
        private DataGridViewCheckBoxColumn CoQuyenBaoCom;
    }
}