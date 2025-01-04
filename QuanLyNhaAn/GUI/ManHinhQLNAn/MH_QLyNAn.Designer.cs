namespace QuanLyNhaAn.GUI.ManHinhQLNAn
{
    partial class MH_QLyNAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MH_QLyNAn));
            pnlHienThi = new Panel();
            panel10 = new Panel();
            pnlUser = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lbUser = new Label();
            panel1 = new Panel();
            btnTKHV = new Button();
            btnTrangChu = new Button();
            button1 = new Button();
            btnTKCBGV = new Button();
            btnYKDG = new Button();
            lblTieuDe = new Label();
            panel10.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHienThi
            // 
            pnlHienThi.Location = new Point(255, 0);
            pnlHienThi.Name = "pnlHienThi";
            pnlHienThi.Size = new Size(1647, 1033);
            pnlHienThi.TabIndex = 5;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 127, 184);
            panel10.Controls.Add(pnlUser);
            panel10.Location = new Point(-1, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(258, 123);
            panel10.TabIndex = 31;
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
            panel1.Controls.Add(btnTKHV);
            panel1.Controls.Add(btnTrangChu);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnTKCBGV);
            panel1.Controls.Add(btnYKDG);
            panel1.Location = new Point(0, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 914);
            panel1.TabIndex = 30;
            // 
            // btnTKHV
            // 
            btnTKHV.BackColor = Color.FromArgb(0, 127, 184);
            btnTKHV.FlatAppearance.BorderSize = 0;
            btnTKHV.FlatStyle = FlatStyle.Flat;
            btnTKHV.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTKHV.ForeColor = Color.White;
            btnTKHV.Image = (Image)resources.GetObject("btnTKHV.Image");
            btnTKHV.ImageAlign = ContentAlignment.MiddleLeft;
            btnTKHV.Location = new Point(1, 81);
            btnTKHV.Margin = new Padding(3, 20, 3, 11);
            btnTKHV.Name = "btnTKHV";
            btnTKHV.Size = new Size(257, 44);
            btnTKHV.TabIndex = 3;
            btnTKHV.Text = "          Thống kê học viên";
            btnTKHV.TextAlign = ContentAlignment.MiddleLeft;
            btnTKHV.UseVisualStyleBackColor = false;
            btnTKHV.Click += btnTKHV_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.FromArgb(0, 127, 184);
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrangChu.ForeColor = Color.White;
            btnTrangChu.Image = (Image)resources.GetObject("btnTrangChu.Image");
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(1, 14);
            btnTrangChu.Margin = new Padding(3, 3, 3, 11);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(257, 52);
            btnTrangChu.TabIndex = 2;
            btnTrangChu.Text = "          Trang chủ";
            btnTrangChu.TextAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
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
            button1.Location = new Point(1, 742);
            button1.Margin = new Padding(3, 450, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(257, 52);
            button1.TabIndex = 3;
            button1.Text = "        Đăng Xuất";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnTKCBGV
            // 
            btnTKCBGV.BackColor = Color.FromArgb(0, 127, 184);
            btnTKCBGV.FlatAppearance.BorderSize = 0;
            btnTKCBGV.FlatStyle = FlatStyle.Flat;
            btnTKCBGV.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTKCBGV.ForeColor = Color.White;
            btnTKCBGV.Image = (Image)resources.GetObject("btnTKCBGV.Image");
            btnTKCBGV.ImageAlign = ContentAlignment.MiddleLeft;
            btnTKCBGV.Location = new Point(1, 143);
            btnTKCBGV.Margin = new Padding(3, 20, 3, 11);
            btnTKCBGV.Name = "btnTKCBGV";
            btnTKCBGV.Size = new Size(258, 47);
            btnTKCBGV.TabIndex = 4;
            btnTKCBGV.Text = "          Thống kê CB-GV";
            btnTKCBGV.TextAlign = ContentAlignment.MiddleLeft;
            btnTKCBGV.UseVisualStyleBackColor = false;
            btnTKCBGV.Click += btnTKCBGV_Click;
            // 
            // btnYKDG
            // 
            btnYKDG.BackColor = Color.FromArgb(0, 127, 184);
            btnYKDG.FlatAppearance.BorderSize = 0;
            btnYKDG.FlatStyle = FlatStyle.Flat;
            btnYKDG.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnYKDG.ForeColor = Color.White;
            btnYKDG.Image = (Image)resources.GetObject("btnYKDG.Image");
            btnYKDG.ImageAlign = ContentAlignment.MiddleLeft;
            btnYKDG.Location = new Point(1, 209);
            btnYKDG.Margin = new Padding(3, 20, 3, 3);
            btnYKDG.Name = "btnYKDG";
            btnYKDG.Size = new Size(258, 47);
            btnYKDG.TabIndex = 5;
            btnYKDG.Text = "          Ý kiến đóng góp";
            btnYKDG.TextAlign = ContentAlignment.MiddleLeft;
            btnYKDG.UseVisualStyleBackColor = false;
            btnYKDG.Click += btnYKDG_Click;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.Location = new Point(265, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(208, 54);
            lblTieuDe.TabIndex = 32;
            lblTieuDe.Text = "Trang chủ";
            // 
            // MH_QLyNAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(lblTieuDe);
            Controls.Add(panel10);
            Controls.Add(panel1);
            Controls.Add(pnlHienThi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MH_QLyNAn";
            Text = "Quản lý nhà ăn";
            FormClosing += MH_QLyNAn_FormClosing;
            Click += pnlUser_Click;
            panel10.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlHienThi;
        private Panel panel10;
        private Panel pnlUser;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbUser;
        private Panel panel1;
        private Button btnTKHV;
        private Button btnTrangChu;
        private Button button1;
        private Button btnTKCBGV;
        private Button btnYKDG;
        private Label lblTieuDe;
    }
}