namespace QuanLyNhaAn.GUI.ManHinhQLHThong
{
    partial class QuanLyHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyHeThong));
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
            txbTitle = new Label();
            pnlHienThi = new Panel();
            panel10.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 127, 184);
            panel10.Controls.Add(pnlUser);
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(257, 123);
            panel10.TabIndex = 33;
            panel10.Click += pnlUser_Click;
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
            pnlUser.Click += pnlUser_Click;
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
            pictureBox1.Click += pnlUser_Click;
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
            label1.Click += pnlUser_Click;
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
            lbUser.Click += pnlUser_Click;
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
            // txbTitle
            // 
            txbTitle.AutoSize = true;
            txbTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txbTitle.Location = new Point(264, 0);
            txbTitle.Name = "txbTitle";
            txbTitle.Size = new Size(399, 54);
            txbTitle.TabIndex = 34;
            txbTitle.Text = "Quản lý người dùng";
            // 
            // pnlHienThi
            // 
            pnlHienThi.Location = new Point(265, 57);
            pnlHienThi.Name = "pnlHienThi";
            pnlHienThi.Size = new Size(1615, 958);
            pnlHienThi.TabIndex = 35;
            // 
            // QuanLyHeThong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pnlHienThi);
            Controls.Add(txbTitle);
            Controls.Add(panel10);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QuanLyHeThong";
            Text = "Quản lý người dùng";
            FormClosing += QuanLyHeThong_FormClosing;
            panel10.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label txbTitle;
        private Panel pnlHienThi;
    }
}