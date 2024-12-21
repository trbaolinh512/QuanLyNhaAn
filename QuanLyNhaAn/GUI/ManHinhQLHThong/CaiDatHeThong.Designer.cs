using System.Windows.Forms;

namespace QuanLyNhaAn.GUI.ManHinhQLHThong
{
    partial class CaiDatHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaiDatHeThong));
            btnQLNguoiDung = new Button();
            btnQLChucVu = new Button();
            btnQLYeuCau = new Button();
            btnCaiDat = new Button();
            button1 = new Button();
            btnLuu = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            dtpHanSang = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            dtpHanTruaToi = new DateTimePicker();
            label12 = new Label();
            groupBox2 = new GroupBox();
            label19 = new Label();
            txbTienHVToi = new TextBox();
            label20 = new Label();
            label17 = new Label();
            txbTienHVTrua = new TextBox();
            label18 = new Label();
            label16 = new Label();
            txbTienHVSang = new TextBox();
            label15 = new Label();
            groupBox3 = new GroupBox();
            label21 = new Label();
            txbTienCBGVSang = new TextBox();
            txbTienCBGVToi = new TextBox();
            label26 = new Label();
            label22 = new Label();
            label25 = new Label();
            label23 = new Label();
            label24 = new Label();
            txbTienCBGVTrua = new TextBox();
            panel1 = new Panel();
            panel10 = new Panel();
            pnlUser = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lbUser = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            button1.Margin = new Padding(3, 450, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(257, 52);
            button1.TabIndex = 3;
            button1.Text = "        Đăng Xuất";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(753, 508);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 24;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(265, 8);
            label4.Name = "label4";
            label4.Size = new Size(336, 54);
            label4.TabIndex = 22;
            label4.Text = "Cài đặt hệ thống";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dtpHanSang);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(dtpHanTruaToi);
            groupBox1.Controls.Add(label12);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(854, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 166);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cài đặt chung";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(240, 43);
            label9.Name = "label9";
            label9.Size = new Size(136, 28);
            label9.TabIndex = 11;
            label9.Text = "- trước 1 ngày";
            // 
            // dtpHanSang
            // 
            dtpHanSang.CustomFormat = "HH:mm";
            dtpHanSang.Format = DateTimePickerFormat.Custom;
            dtpHanSang.Location = new Point(147, 38);
            dtpHanSang.Name = "dtpHanSang";
            dtpHanSang.ShowUpDown = true;
            dtpHanSang.Size = new Size(87, 34);
            dtpHanSang.TabIndex = 10;
            dtpHanSang.Value = new DateTime(2024, 12, 16, 10, 0, 0, 0);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 43);
            label10.Name = "label10";
            label10.Size = new Size(132, 28);
            label10.TabIndex = 9;
            label10.Text = "Hạn báo sáng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(260, 91);
            label11.Name = "label11";
            label11.Size = new Size(116, 28);
            label11.TabIndex = 14;
            label11.Text = "- cùng ngày";
            // 
            // dtpHanTruaToi
            // 
            dtpHanTruaToi.CustomFormat = "HH:mm";
            dtpHanTruaToi.Format = DateTimePickerFormat.Custom;
            dtpHanTruaToi.Location = new Point(173, 86);
            dtpHanTruaToi.Name = "dtpHanTruaToi";
            dtpHanTruaToi.ShowUpDown = true;
            dtpHanTruaToi.Size = new Size(87, 34);
            dtpHanTruaToi.TabIndex = 13;
            dtpHanTruaToi.Value = new DateTime(2024, 12, 16, 7, 0, 0, 0);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 91);
            label12.Name = "label12";
            label12.Size = new Size(160, 28);
            label12.TabIndex = 12;
            label12.Text = "Hạn báo trưa, tối";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(txbTienHVToi);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(txbTienHVTrua);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(txbTienHVSang);
            groupBox2.Controls.Add(label15);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(395, 112);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(381, 166);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cài đặt học viên";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(285, 115);
            label19.Name = "label19";
            label19.Size = new Size(53, 28);
            label19.TabIndex = 8;
            label19.Text = "VNĐ";
            // 
            // txbTienHVToi
            // 
            txbTienHVToi.Location = new Point(154, 111);
            txbTienHVToi.Name = "txbTienHVToi";
            txbTienHVToi.Size = new Size(125, 34);
            txbTienHVToi.TabIndex = 7;
            txbTienHVToi.Text = "27500";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(28, 114);
            label20.Name = "label20";
            label20.Size = new Size(106, 28);
            label20.TabIndex = 6;
            label20.Text = "Suất ăn tối";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(285, 72);
            label17.Name = "label17";
            label17.Size = new Size(53, 28);
            label17.TabIndex = 5;
            label17.Text = "VNĐ";
            // 
            // txbTienHVTrua
            // 
            txbTienHVTrua.Location = new Point(154, 68);
            txbTienHVTrua.Name = "txbTienHVTrua";
            txbTienHVTrua.Size = new Size(125, 34);
            txbTienHVTrua.TabIndex = 4;
            txbTienHVTrua.Text = "27500";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(28, 71);
            label18.Name = "label18";
            label18.Size = new Size(118, 28);
            label18.TabIndex = 3;
            label18.Text = "Suất ăn trưa";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(285, 30);
            label16.Name = "label16";
            label16.Size = new Size(53, 28);
            label16.TabIndex = 2;
            label16.Text = "VNĐ";
            // 
            // txbTienHVSang
            // 
            txbTienHVSang.Location = new Point(154, 26);
            txbTienHVSang.Name = "txbTienHVSang";
            txbTienHVSang.Size = new Size(125, 34);
            txbTienHVSang.TabIndex = 1;
            txbTienHVSang.Text = "15000";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(28, 29);
            label15.Name = "label15";
            label15.Size = new Size(123, 28);
            label15.TabIndex = 0;
            label15.Text = "Suất ăn sáng";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(txbTienCBGVSang);
            groupBox3.Controls.Add(txbTienCBGVToi);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(txbTienCBGVTrua);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(394, 311);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(381, 178);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cài đặt CBGV";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(280, 124);
            label21.Name = "label21";
            label21.Size = new Size(53, 28);
            label21.TabIndex = 17;
            label21.Text = "VNĐ";
            // 
            // txbTienCBGVSang
            // 
            txbTienCBGVSang.Location = new Point(149, 36);
            txbTienCBGVSang.Name = "txbTienCBGVSang";
            txbTienCBGVSang.Size = new Size(125, 34);
            txbTienCBGVSang.TabIndex = 10;
            txbTienCBGVSang.Text = "15000";
            // 
            // txbTienCBGVToi
            // 
            txbTienCBGVToi.Location = new Point(149, 120);
            txbTienCBGVToi.Name = "txbTienCBGVToi";
            txbTienCBGVToi.Size = new Size(125, 34);
            txbTienCBGVToi.TabIndex = 16;
            txbTienCBGVToi.Text = "27500";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(28, 39);
            label26.Name = "label26";
            label26.Size = new Size(123, 28);
            label26.TabIndex = 9;
            label26.Text = "Suất ăn sáng";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(28, 123);
            label22.Name = "label22";
            label22.Size = new Size(106, 28);
            label22.TabIndex = 15;
            label22.Text = "Suất ăn tối";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(280, 40);
            label25.Name = "label25";
            label25.Size = new Size(53, 28);
            label25.TabIndex = 11;
            label25.Text = "VNĐ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(280, 82);
            label23.Name = "label23";
            label23.Size = new Size(53, 28);
            label23.TabIndex = 14;
            label23.Text = "VNĐ";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(28, 81);
            label24.Name = "label24";
            label24.Size = new Size(118, 28);
            label24.TabIndex = 12;
            label24.Text = "Suất ăn trưa";
            // 
            // txbTienCBGVTrua
            // 
            txbTienCBGVTrua.Location = new Point(149, 78);
            txbTienCBGVTrua.Name = "txbTienCBGVTrua";
            txbTienCBGVTrua.Size = new Size(125, 34);
            txbTienCBGVTrua.TabIndex = 13;
            txbTienCBGVTrua.Text = "27500";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 127, 184);
            panel1.Controls.Add(btnQLChucVu);
            panel1.Controls.Add(btnQLNguoiDung);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnQLYeuCau);
            panel1.Controls.Add(btnCaiDat);
            panel1.Location = new Point(0, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 916);
            panel1.TabIndex = 28;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 127, 184);
            panel10.Controls.Add(pnlUser);
            panel10.Location = new Point(-1, -1);
            panel10.Name = "panel10";
            panel10.Size = new Size(258, 123);
            panel10.TabIndex = 29;
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
            // CaiDatHeThong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel10);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnLuu);
            Controls.Add(label4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CaiDatHeThong";
            Text = "Quản lý hệ thống";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnQLNguoiDung;
        private Button btnQLChucVu;
        private Button btnQLYeuCau;
        private Button btnCaiDat;
        private Button button1;
        private Button btnLuu;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label9;
        private DateTimePicker dtpHanSang;
        private Label label10;
        private Label label11;
        private DateTimePicker dtpHanTruaToi;
        private Label label12;
        private Label label19;
        private TextBox txbTienHVToi;
        private Label label20;
        private Label label17;
        private TextBox txbTienHVTrua;
        private Label label18;
        private Label label16;
        private TextBox txbTienHVSang;
        private Label label15;
        private Label label21;
        private TextBox txbTienCBGVSang;
        private TextBox txbTienCBGVToi;
        private Label label26;
        private Label label22;
        private Label label25;
        private Label label23;
        private Label label24;
        private TextBox txbTienCBGVTrua;
        private Panel panel1;
        private Panel panel10;
        private Panel pnlUser;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbUser;
    }
}