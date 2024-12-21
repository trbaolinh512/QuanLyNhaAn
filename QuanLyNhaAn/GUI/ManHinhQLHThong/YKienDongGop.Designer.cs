namespace QuanLyNhaAn.GUI.ManHinhQLHThong
{
    partial class YKienDongGop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YKienDongGop));
            btnLuu = new Button();
            label2 = new Label();
            label4 = new Label();
            dgvYKien = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            STT = new DataGridViewTextBoxColumn();
            NoiDung = new DataGridViewTextBoxColumn();
            NoiDungPhanHoi = new DataGridViewTextBoxColumn();
            NguoiGui = new DataGridViewTextBoxColumn();
            NguoiPhanHoi = new DataGridViewTextBoxColumn();
            NgayYeuCau = new DataGridViewTextBoxColumn();
            NgayPhanHoi = new DataGridViewTextBoxColumn();
            txbYeuCau = new TextBox();
            txbPhanHoi = new TextBox();
            label3 = new Label();
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
            ptbAnh = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvYKien).BeginInit();
            panel10.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).BeginInit();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(955, 712);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 17;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(851, 79);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 16;
            label2.Text = "Nội dung ý kiến";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(268, 7);
            label4.Name = "label4";
            label4.Size = new Size(331, 54);
            label4.TabIndex = 14;
            label4.Text = "Ý kiến đóng góp";
            // 
            // dgvYKien
            // 
            dgvYKien.AllowUserToAddRows = false;
            dgvYKien.AllowUserToDeleteRows = false;
            dgvYKien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYKien.Columns.AddRange(new DataGridViewColumn[] { Id, STT, NoiDung, NoiDungPhanHoi, NguoiGui, NguoiPhanHoi, NgayYeuCau, NgayPhanHoi });
            dgvYKien.Location = new Point(265, 96);
            dgvYKien.Name = "dgvYKien";
            dgvYKien.ReadOnly = true;
            dgvYKien.RowHeadersWidth = 51;
            dgvYKien.RowTemplate.Height = 29;
            dgvYKien.Size = new Size(572, 645);
            dgvYKien.TabIndex = 13;
            dgvYKien.CellClick += dgvYKien_CellClick;
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
            STT.Width = 50;
            // 
            // NoiDung
            // 
            NoiDung.HeaderText = "Nội dung";
            NoiDung.MinimumWidth = 6;
            NoiDung.Name = "NoiDung";
            NoiDung.ReadOnly = true;
            NoiDung.Width = 170;
            // 
            // NoiDungPhanHoi
            // 
            NoiDungPhanHoi.HeaderText = "Nội dung phản hồi";
            NoiDungPhanHoi.MinimumWidth = 6;
            NoiDungPhanHoi.Name = "NoiDungPhanHoi";
            NoiDungPhanHoi.ReadOnly = true;
            NoiDungPhanHoi.Resizable = DataGridViewTriState.True;
            NoiDungPhanHoi.SortMode = DataGridViewColumnSortMode.NotSortable;
            NoiDungPhanHoi.Width = 150;
            // 
            // NguoiGui
            // 
            NguoiGui.HeaderText = "Người gửi";
            NguoiGui.MinimumWidth = 6;
            NguoiGui.Name = "NguoiGui";
            NguoiGui.ReadOnly = true;
            NguoiGui.Resizable = DataGridViewTriState.True;
            NguoiGui.SortMode = DataGridViewColumnSortMode.NotSortable;
            NguoiGui.Width = 150;
            // 
            // NguoiPhanHoi
            // 
            NguoiPhanHoi.HeaderText = "Người phản hồi";
            NguoiPhanHoi.MinimumWidth = 6;
            NguoiPhanHoi.Name = "NguoiPhanHoi";
            NguoiPhanHoi.ReadOnly = true;
            NguoiPhanHoi.Width = 170;
            // 
            // NgayYeuCau
            // 
            NgayYeuCau.HeaderText = "Ngày gửi";
            NgayYeuCau.MinimumWidth = 6;
            NgayYeuCau.Name = "NgayYeuCau";
            NgayYeuCau.ReadOnly = true;
            NgayYeuCau.Width = 170;
            // 
            // NgayPhanHoi
            // 
            NgayPhanHoi.HeaderText = "Ngày phản hồi";
            NgayPhanHoi.MinimumWidth = 6;
            NgayPhanHoi.Name = "NgayPhanHoi";
            NgayPhanHoi.ReadOnly = true;
            NgayPhanHoi.Width = 170;
            // 
            // txbYeuCau
            // 
            txbYeuCau.Location = new Point(853, 102);
            txbYeuCau.Multiline = true;
            txbYeuCau.Name = "txbYeuCau";
            txbYeuCau.ReadOnly = true;
            txbYeuCau.Size = new Size(305, 142);
            txbYeuCau.TabIndex = 18;
            // 
            // txbPhanHoi
            // 
            txbPhanHoi.Location = new Point(853, 544);
            txbPhanHoi.Multiline = true;
            txbPhanHoi.Name = "txbPhanHoi";
            txbPhanHoi.Size = new Size(305, 157);
            txbPhanHoi.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(851, 516);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 19;
            label3.Text = "Nội dung phản hồi";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 127, 184);
            panel10.Controls.Add(pnlUser);
            panel10.Location = new Point(-1, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(258, 123);
            panel10.TabIndex = 33;
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
            panel1.Location = new Point(0, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 915);
            panel1.TabIndex = 32;
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
            // ptbAnh
            // 
            ptbAnh.BorderStyle = BorderStyle.FixedSingle;
            ptbAnh.Location = new Point(853, 288);
            ptbAnh.Name = "ptbAnh";
            ptbAnh.Size = new Size(305, 213);
            ptbAnh.TabIndex = 34;
            ptbAnh.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(851, 261);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 35;
            label5.Text = "Ảnh";
            // 
            // YKienDongGop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label5);
            Controls.Add(ptbAnh);
            Controls.Add(panel10);
            Controls.Add(panel1);
            Controls.Add(txbPhanHoi);
            Controls.Add(label3);
            Controls.Add(txbYeuCau);
            Controls.Add(btnLuu);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(dgvYKien);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "YKienDongGop";
            Text = "Quản lý hệ thống";
            ((System.ComponentModel.ISupportInitialize)dgvYKien).EndInit();
            panel10.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button btnLuu;
        private Label label2;
        private TextBox txbChucVu;
        private Label label4;
        private DataGridView dgvYKien;
        private TextBox txbYeuCau;
        private TextBox txbPhanHoi;
        private Label label3;
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
        private PictureBox ptbAnh;
        private Label label5;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn NoiDung;
        private DataGridViewTextBoxColumn NoiDungPhanHoi;
        private DataGridViewTextBoxColumn NguoiGui;
        private DataGridViewTextBoxColumn NguoiPhanHoi;
        private DataGridViewTextBoxColumn NgayYeuCau;
        private DataGridViewTextBoxColumn NgayPhanHoi;
    }
}