
namespace QuanLyNhaAn.GUI.ManHinhQLNAn
{
    partial class UC_ThongTinSuatAnLPHCan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ThongTinSuatAnLPHCan));
            dgvSuatAn = new DataGridView();
            btnLamMoi = new Button();
            btnLuuLich = new Button();
            label1 = new Label();
            txbTimKiem = new TextBox();
            label2 = new Label();
            dtpThang = new DateTimePicker();
            label3 = new Label();
            cbxPhuongThuc = new ComboBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            pnlAn = new Panel();
            lblAn = new Label();
            lblLuuY = new Label();
            btnTimKiem = new Button();
            btnBoTich = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvSuatAn).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvSuatAn
            // 
            dgvSuatAn.AllowUserToAddRows = false;
            dgvSuatAn.AllowUserToDeleteRows = false;
            dgvSuatAn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSuatAn.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(2, 136, 209);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSuatAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSuatAn.ColumnHeadersHeight = 29;
            dgvSuatAn.EnableHeadersVisualStyles = false;
            dgvSuatAn.Location = new Point(14, 185);
            dgvSuatAn.Name = "dgvSuatAn";
            dgvSuatAn.ReadOnly = true;
            dgvSuatAn.RowHeadersWidth = 51;
            dgvSuatAn.RowTemplate.Height = 29;
            dgvSuatAn.Size = new Size(1483, 786);
            dgvSuatAn.TabIndex = 0;
            dgvSuatAn.ColumnHeaderMouseClick += dgvSuatAn_ColumnHeaderMouseClick;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Yellow;
            btnLamMoi.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLamMoi.ForeColor = Color.Black;
            btnLamMoi.Location = new Point(390, 129);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(98, 42);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLuuLich
            // 
            btnLuuLich.BackColor = Color.DodgerBlue;
            btnLuuLich.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuuLich.Location = new Point(272, 83);
            btnLuuLich.Name = "btnLuuLich";
            btnLuuLich.Size = new Size(94, 39);
            btnLuuLich.TabIndex = 2;
            btnLuuLich.Text = "Lưu lịch";
            btnLuuLich.UseVisualStyleBackColor = false;
            btnLuuLich.Click += btnLuuLich_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 114);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "Tìm kiếm";
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(14, 140);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(238, 27);
            txbTimKiem.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 55);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Tháng";
            // 
            // dtpThang
            // 
            dtpThang.CustomFormat = "MM/yyyy";
            dtpThang.Format = DateTimePickerFormat.Custom;
            dtpThang.Location = new Point(13, 83);
            dtpThang.Name = "dtpThang";
            dtpThang.Size = new Size(101, 27);
            dtpThang.TabIndex = 6;
            dtpThang.ValueChanged += dtpThang_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 57);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 7;
            label3.Text = "Phương thức";
            // 
            // cbxPhuongThuc
            // 
            cbxPhuongThuc.FormattingEnabled = true;
            cbxPhuongThuc.Items.AddRange(new object[] { "Theo ngày", "Theo từng buổi" });
            cbxPhuongThuc.Location = new Point(132, 82);
            cbxPhuongThuc.Name = "cbxPhuongThuc";
            cbxPhuongThuc.Size = new Size(120, 28);
            cbxPhuongThuc.TabIndex = 8;
            cbxPhuongThuc.Text = "Theo ngày";
            cbxPhuongThuc.SelectedIndexChanged += cbxPhuongThuc_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pnlAn);
            groupBox1.Controls.Add(lblAn);
            groupBox1.Location = new Point(1265, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 84);
            groupBox1.TabIndex = 9;
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
            pnlAn.BackColor = Color.Red;
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
            lblAn.Size = new Size(123, 20);
            lblAn.TabIndex = 0;
            lblAn.Text = ": Nghỉ ăn cả ngày";
            // 
            // lblLuuY
            // 
            lblLuuY.AutoSize = true;
            lblLuuY.ForeColor = Color.Red;
            lblLuuY.Location = new Point(1087, 146);
            lblLuuY.Name = "lblLuuY";
            lblLuuY.Size = new Size(519, 20);
            lblLuuY.TabIndex = 10;
            lblLuuY.Text = "*Trước khi đổi sang tháng khác, bạn hãy lưu lịch trong tháng mà bạn đã chỉnh";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(255, 128, 0);
            btnTimKiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(272, 129);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 42);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnBoTich
            // 
            btnBoTich.BackColor = Color.FromArgb(0, 192, 192);
            btnBoTich.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoTich.Location = new Point(392, 83);
            btnBoTich.Name = "btnBoTich";
            btnBoTich.Size = new Size(193, 39);
            btnBoTich.TabIndex = 12;
            btnBoTich.Text = "Chuyển trạng thái tích";
            btnBoTich.UseVisualStyleBackColor = false;
            btnBoTich.Click += btnBoTich_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1647, 1035);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // UC_ThongTinSuatAnLPHCan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(btnBoTich);
            Controls.Add(btnTimKiem);
            Controls.Add(lblLuuY);
            Controls.Add(groupBox1);
            Controls.Add(cbxPhuongThuc);
            Controls.Add(label3);
            Controls.Add(dtpThang);
            Controls.Add(label2);
            Controls.Add(txbTimKiem);
            Controls.Add(label1);
            Controls.Add(btnLuuLich);
            Controls.Add(btnLamMoi);
            Controls.Add(dgvSuatAn);
            Controls.Add(pictureBox1);
            Name = "UC_ThongTinSuatAnLPHCan";
            Size = new Size(1650, 1038);
            ((System.ComponentModel.ISupportInitialize)dgvSuatAn).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private DataGridView dgvSuatAn;
        private Button btnLamMoi;
        private Button btnLuuLich;
        private Label label1;
        private TextBox txbTimKiem;
        private Label label2;
        private DateTimePicker dtpThang;
        private Label label3;
        private ComboBox cbxPhuongThuc;
        private GroupBox groupBox1;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private Panel pnlAn;
        private Label lblAn;
        private Label lblLuuY;
        private Button btnTimKiem;
        private Button btnBoTich;
        private PictureBox pictureBox1;
    }
}
