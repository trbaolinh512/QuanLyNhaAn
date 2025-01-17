﻿namespace QuanLyNhaAn.GUI.ManHinhQLNAn
{
    partial class UC_ThongKeCBGV
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ThongKeCBGV));
            btnExcel = new Button();
            cbxPhong = new ComboBox();
            label34 = new Label();
            btnTimKiem = new Button();
            cbxPhuongThuc = new ComboBox();
            label3 = new Label();
            dtpThang = new DateTimePicker();
            label2 = new Label();
            txbTimKiem = new TextBox();
            label1 = new Label();
            btnLamMoi = new Button();
            dgvCBGV = new DataGridView();
            groupBox1 = new GroupBox();
            label5 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            pnlAn = new Panel();
            lblAn = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCBGV).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.Lime;
            btnExcel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcel.Location = new Point(492, 182);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(140, 42);
            btnExcel.TabIndex = 35;
            btnExcel.Text = "Xuất file Excel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // cbxPhong
            // 
            cbxPhong.FormattingEnabled = true;
            cbxPhong.Items.AddRange(new object[] { "" });
            cbxPhong.Location = new Point(271, 127);
            cbxPhong.Name = "cbxPhong";
            cbxPhong.Size = new Size(120, 28);
            cbxPhong.TabIndex = 34;
            cbxPhong.SelectedIndexChanged += cbxPhong_SelectedIndexChanged;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = Color.White;
            label34.BorderStyle = BorderStyle.FixedSingle;
            label34.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label34.Location = new Point(271, 99);
            label34.Name = "label34";
            label34.Size = new Size(129, 27);
            label34.TabIndex = 33;
            label34.Text = "Phòng / Khoa";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(255, 128, 0);
            btnTimKiem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(270, 182);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(104, 42);
            btnTimKiem.TabIndex = 32;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cbxPhuongThuc
            // 
            cbxPhuongThuc.FormattingEnabled = true;
            cbxPhuongThuc.Items.AddRange(new object[] { "Theo ngày", "Theo từng buổi" });
            cbxPhuongThuc.Location = new Point(130, 127);
            cbxPhuongThuc.Name = "cbxPhuongThuc";
            cbxPhuongThuc.Size = new Size(120, 28);
            cbxPhuongThuc.TabIndex = 31;
            cbxPhuongThuc.Text = "Theo ngày";
            cbxPhuongThuc.SelectedIndexChanged += cbxPhuongThuc_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(130, 99);
            label3.Name = "label3";
            label3.Size = new Size(122, 27);
            label3.TabIndex = 30;
            label3.Text = "Phương thức";
            // 
            // dtpThang
            // 
            dtpThang.CustomFormat = "MM/yyyy";
            dtpThang.Format = DateTimePickerFormat.Custom;
            dtpThang.Location = new Point(10, 128);
            dtpThang.Name = "dtpThang";
            dtpThang.Size = new Size(101, 27);
            dtpThang.TabIndex = 29;
            dtpThang.ValueChanged += dtpThang_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 100);
            label2.Name = "label2";
            label2.Size = new Size(67, 27);
            label2.TabIndex = 28;
            label2.Text = "Tháng";
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(8, 195);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(238, 27);
            txbTimKiem.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 167);
            label1.Name = "label1";
            label1.Size = new Size(90, 27);
            label1.TabIndex = 26;
            label1.Text = "Tìm kiếm";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Yellow;
            btnLamMoi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnLamMoi.Location = new Point(380, 182);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(106, 42);
            btnLamMoi.TabIndex = 25;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvCBGV
            // 
            dgvCBGV.AllowUserToAddRows = false;
            dgvCBGV.AllowUserToDeleteRows = false;
            dgvCBGV.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(2, 136, 209);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCBGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCBGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCBGV.EnableHeadersVisualStyles = false;
            dgvCBGV.Location = new Point(3, 250);
            dgvCBGV.Name = "dgvCBGV";
            dgvCBGV.ReadOnly = true;
            dgvCBGV.RowHeadersWidth = 51;
            dgvCBGV.RowTemplate.Height = 29;
            dgvCBGV.Size = new Size(1609, 700);
            dgvCBGV.TabIndex = 24;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(pnlAn);
            groupBox1.Controls.Add(lblAn);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(1266, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 84);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lưu ý";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 58);
            label5.Name = "label5";
            label5.Size = new Size(247, 25);
            label5.TabIndex = 3;
            label5.Text = "- A : Ăn 1-2 buổi trong ngày";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Yellow;
            panel4.Location = new Point(12, 58);
            panel4.Name = "panel4";
            panel4.Size = new Size(20, 20);
            panel4.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(207, 32);
            label6.Name = "label6";
            label6.Size = new Size(126, 25);
            label6.TabIndex = 2;
            label6.Text = "X : Có suất ăn";
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
            lblAn.Size = new Size(114, 25);
            lblAn.TabIndex = 0;
            lblAn.Text = ": Ăn cả ngày";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1648, 1033);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // UC_ThongKeCBGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(btnExcel);
            Controls.Add(cbxPhong);
            Controls.Add(label34);
            Controls.Add(btnTimKiem);
            Controls.Add(cbxPhuongThuc);
            Controls.Add(label3);
            Controls.Add(dtpThang);
            Controls.Add(label2);
            Controls.Add(txbTimKiem);
            Controls.Add(label1);
            Controls.Add(btnLamMoi);
            Controls.Add(dgvCBGV);
            Controls.Add(pictureBox1);
            Name = "UC_ThongKeCBGV";
            Size = new Size(1647, 1033);
            ((System.ComponentModel.ISupportInitialize)dgvCBGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcel;
        private ComboBox cbxPhong;
        private Label label34;
        private Button btnTimKiem;
        private ComboBox cbxPhuongThuc;
        private Label label3;
        private DateTimePicker dtpThang;
        private Label label2;
        private TextBox txbTimKiem;
        private Label label1;
        private Button btnLamMoi;
        private DataGridView dgvCBGV;
        private GroupBox groupBox1;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private Panel pnlAn;
        private Label lblAn;
        private PictureBox pictureBox1;
    }
}
