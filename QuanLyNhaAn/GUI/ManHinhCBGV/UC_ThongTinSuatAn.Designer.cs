using System.Windows.Forms;

namespace QuanLyNhaAn.GUI.ManHinhCBGV
{
    partial class UC_ThongTinSuatAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ThongTinSuatAn));
            label1 = new Label();
            dtpChonThang = new DateTimePicker();
            txtTongSuatAn = new Label();
            txtTongTien = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pnlLich = new Panel();
            cbxPhuongThuc = new ComboBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            pnlAn = new Panel();
            lblAn = new Label();
            btnLuuLich = new Button();
            btnLamMoi = new Button();
            lblLuuY = new Label();
            groupBox3 = new GroupBox();
            lblSuatToi = new Label();
            lbTienToi = new Label();
            groupBox2 = new GroupBox();
            lbSuatTrua = new Label();
            lbTienTrua = new Label();
            groupBox4 = new GroupBox();
            lbSuatSang = new Label();
            lbTienSang = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 63);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Tháng";
            // 
            // dtpChonThang
            // 
            dtpChonThang.CustomFormat = "MM/yyyy";
            dtpChonThang.Format = DateTimePickerFormat.Custom;
            dtpChonThang.Location = new Point(81, 58);
            dtpChonThang.Name = "dtpChonThang";
            dtpChonThang.Size = new Size(99, 27);
            dtpChonThang.TabIndex = 1;
            dtpChonThang.ValueChanged += dtpChonThang_ValueChanged;
            // 
            // txtTongSuatAn
            // 
            txtTongSuatAn.AutoSize = true;
            txtTongSuatAn.Location = new Point(25, 99);
            txtTongSuatAn.Name = "txtTongSuatAn";
            txtTongSuatAn.Size = new Size(94, 20);
            txtTongSuatAn.TabIndex = 2;
            txtTongSuatAn.Text = "Tổng suất ăn";
            // 
            // txtTongTien
            // 
            txtTongTien.AutoSize = true;
            txtTongTien.Location = new Point(25, 134);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(72, 20);
            txtTongTien.TabIndex = 3;
            txtTongTien.Text = "Tổng tiền";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnlLich);
            panel1.Location = new Point(300, 161);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 832);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(912, 81);
            panel2.TabIndex = 0;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(2, 136, 209);
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(731, 11);
            button7.Name = "button7";
            button7.Size = new Size(110, 60);
            button7.TabIndex = 6;
            button7.Text = "Chủ nhật";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(2, 136, 209);
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(615, 11);
            button6.Name = "button6";
            button6.Size = new Size(110, 60);
            button6.TabIndex = 5;
            button6.Text = "Thứ 7";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(2, 136, 209);
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(499, 11);
            button5.Name = "button5";
            button5.Size = new Size(110, 60);
            button5.TabIndex = 4;
            button5.Text = "Thứ 6";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(2, 136, 209);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(383, 11);
            button4.Name = "button4";
            button4.Size = new Size(110, 60);
            button4.TabIndex = 3;
            button4.Text = "Thứ 5";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(2, 136, 209);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(267, 11);
            button3.Name = "button3";
            button3.Size = new Size(110, 60);
            button3.TabIndex = 2;
            button3.Text = "Thứ 4";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(2, 136, 209);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(151, 11);
            button2.Name = "button2";
            button2.Size = new Size(110, 60);
            button2.TabIndex = 1;
            button2.Text = "Thứ 3";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 136, 209);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(35, 11);
            button1.Name = "button1";
            button1.Size = new Size(110, 60);
            button1.TabIndex = 0;
            button1.Text = "Thứ 2";
            button1.UseVisualStyleBackColor = false;
            // 
            // pnlLich
            // 
            pnlLich.AutoScroll = true;
            pnlLich.Location = new Point(28, 87);
            pnlLich.Name = "pnlLich";
            pnlLich.Size = new Size(866, 742);
            pnlLich.TabIndex = 1;
            // 
            // cbxPhuongThuc
            // 
            cbxPhuongThuc.FormattingEnabled = true;
            cbxPhuongThuc.Items.AddRange(new object[] { "Theo ngày", "Theo từng buổi" });
            cbxPhuongThuc.Location = new Point(399, 58);
            cbxPhuongThuc.Name = "cbxPhuongThuc";
            cbxPhuongThuc.Size = new Size(134, 28);
            cbxPhuongThuc.TabIndex = 5;
            cbxPhuongThuc.Text = "Theo ngày";
            cbxPhuongThuc.SelectedIndexChanged += cbxPhuongThuc_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 64);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 6;
            label2.Text = "Phương thức";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pnlAn);
            groupBox1.Controls.Add(lblAn);
            groupBox1.Location = new Point(1218, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 84);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lưu ý";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 58);
            label5.Name = "label5";
            label5.Size = new Size(170, 20);
            label5.TabIndex = 3;
            label5.Text = ": Ăn 1-2 buổi trong ngày";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Yellow;
            panel4.Location = new Point(12, 58);
            panel4.Name = "panel4";
            panel4.Size = new Size(20, 20);
            panel4.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 32);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 2;
            label4.Text = "X : Có suất ăn";
            // 
            // pnlAn
            // 
            pnlAn.BackColor = Color.LightSkyBlue;
            pnlAn.Location = new Point(12, 32);
            pnlAn.Name = "pnlAn";
            pnlAn.Size = new Size(20, 20);
            pnlAn.TabIndex = 1;
            // 
            // lblAn
            // 
            lblAn.AutoSize = true;
            lblAn.Location = new Point(38, 32);
            lblAn.Name = "lblAn";
            lblAn.Size = new Size(89, 20);
            lblAn.TabIndex = 0;
            lblAn.Text = ": Ăn cả ngày";
            // 
            // btnLuuLich
            // 
            btnLuuLich.BackColor = Color.DodgerBlue;
            btnLuuLich.Location = new Point(399, 100);
            btnLuuLich.Name = "btnLuuLich";
            btnLuuLich.Size = new Size(94, 29);
            btnLuuLich.TabIndex = 8;
            btnLuuLich.Text = "Lưu lịch";
            btnLuuLich.UseVisualStyleBackColor = false;
            btnLuuLich.Click += btnLuuLich_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Yellow;
            btnLamMoi.Location = new Point(299, 100);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblLuuY
            // 
            lblLuuY.AutoSize = true;
            lblLuuY.ForeColor = Color.Red;
            lblLuuY.Location = new Point(1073, 135);
            lblLuuY.Name = "lblLuuY";
            lblLuuY.Size = new Size(519, 20);
            lblLuuY.TabIndex = 4;
            lblLuuY.Text = "*Trước khi đổi sang tháng khác, bạn hãy lưu lịch trong tháng mà bạn đã chỉnh";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(192, 192, 0);
            groupBox3.Controls.Add(lblSuatToi);
            groupBox3.Controls.Add(lbTienToi);
            groupBox3.Location = new Point(21, 431);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 93);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buổi tối";
            // 
            // lblSuatToi
            // 
            lblSuatToi.AutoSize = true;
            lblSuatToi.Location = new Point(28, 23);
            lblSuatToi.Name = "lblSuatToi";
            lblSuatToi.Size = new Size(50, 20);
            lblSuatToi.TabIndex = 9;
            lblSuatToi.Text = "label2";
            // 
            // lbTienToi
            // 
            lbTienToi.AutoSize = true;
            lbTienToi.Location = new Point(27, 54);
            lbTienToi.Name = "lbTienToi";
            lbTienToi.Size = new Size(50, 20);
            lbTienToi.TabIndex = 10;
            lbTienToi.Text = "label3";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 128, 255);
            groupBox2.Controls.Add(lbSuatTrua);
            groupBox2.Controls.Add(lbTienTrua);
            groupBox2.Location = new Point(21, 314);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 87);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buổi trưa";
            // 
            // lbSuatTrua
            // 
            lbSuatTrua.AutoSize = true;
            lbSuatTrua.Location = new Point(34, 23);
            lbSuatTrua.Name = "lbSuatTrua";
            lbSuatTrua.Size = new Size(50, 20);
            lbSuatTrua.TabIndex = 6;
            lbSuatTrua.Text = "label2";
            // 
            // lbTienTrua
            // 
            lbTienTrua.AutoSize = true;
            lbTienTrua.Location = new Point(33, 54);
            lbTienTrua.Name = "lbTienTrua";
            lbTienTrua.Size = new Size(50, 20);
            lbTienTrua.TabIndex = 7;
            lbTienTrua.Text = "label3";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.LightSeaGreen;
            groupBox4.Controls.Add(lbSuatSang);
            groupBox4.Controls.Add(lbTienSang);
            groupBox4.Location = new Point(21, 189);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 91);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Buổi sáng";
            // 
            // lbSuatSang
            // 
            lbSuatSang.AutoSize = true;
            lbSuatSang.Location = new Point(29, 23);
            lbSuatSang.Name = "lbSuatSang";
            lbSuatSang.Size = new Size(50, 20);
            lbSuatSang.TabIndex = 1;
            lbSuatSang.Text = "label2";
            // 
            // lbTienSang
            // 
            lbTienSang.AutoSize = true;
            lbTienSang.Location = new Point(28, 54);
            lbTienSang.Name = "lbTienSang";
            lbTienSang.Size = new Size(50, 20);
            lbTienSang.TabIndex = 2;
            lbTienSang.Text = "label3";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1647, 1035);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // UC_ThongTinSuatAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(lblLuuY);
            Controls.Add(btnLamMoi);
            Controls.Add(btnLuuLich);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(cbxPhuongThuc);
            Controls.Add(panel1);
            Controls.Add(txtTongTien);
            Controls.Add(txtTongSuatAn);
            Controls.Add(dtpChonThang);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "UC_ThongTinSuatAn";
            Size = new Size(1647, 1035);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpChonThang;
        private Label txtTongSuatAn;
        private Label txtTongTien;
        private Panel panel1;
        private Panel panel2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel pnlLich;
        private Button button7;
        private ComboBox cbxPhuongThuc;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnLuuLich;
        private Button btnLamMoi;
        private Panel pnlAn;
        private Label lblAn;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private Label lblLuuY;
        private GroupBox groupBox3;
        private Label lblSuatToi;
        private Label lbTienToi;
        private GroupBox groupBox2;
        private Label lbSuatTrua;
        private Label lbTienTrua;
        private GroupBox groupBox4;
        private Label lbSuatSang;
        private Label lbTienSang;
        private PictureBox pictureBox1;
    }
}
