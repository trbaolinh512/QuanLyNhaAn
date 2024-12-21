namespace QuanLyNhaAn.GUI.ManHinhQLNAn
{
    partial class UC_TKCBGV
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
            dgvHocVien = new DataGridView();
            cbxKhoa = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHocVien).BeginInit();
            SuspendLayout();
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(492, 101);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(118, 29);
            btnExcel.TabIndex = 35;
            btnExcel.Text = "Xuất file Excel";
            btnExcel.UseVisualStyleBackColor = true;
            // 
            // cbxPhong
            // 
            cbxPhong.FormattingEnabled = true;
            cbxPhong.Items.AddRange(new object[] { "" });
            cbxPhong.Location = new Point(271, 37);
            cbxPhong.Name = "cbxPhong";
            cbxPhong.Size = new Size(120, 28);
            cbxPhong.TabIndex = 34;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(271, 12);
            label34.Name = "label34";
            label34.Size = new Size(51, 20);
            label34.TabIndex = 33;
            label34.Text = "Phòng";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(270, 101);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 32;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cbxPhuongThuc
            // 
            cbxPhuongThuc.FormattingEnabled = true;
            cbxPhuongThuc.Items.AddRange(new object[] { "Theo ngày", "Theo từng buổi" });
            cbxPhuongThuc.Location = new Point(130, 37);
            cbxPhuongThuc.Name = "cbxPhuongThuc";
            cbxPhuongThuc.Size = new Size(120, 28);
            cbxPhuongThuc.TabIndex = 31;
            cbxPhuongThuc.Text = "Theo ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 12);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 30;
            label3.Text = "Phương thức";
            // 
            // dtpThang
            // 
            dtpThang.CustomFormat = "MM/yyyy";
            dtpThang.Format = DateTimePickerFormat.Custom;
            dtpThang.Location = new Point(10, 38);
            dtpThang.Name = "dtpThang";
            dtpThang.Size = new Size(101, 27);
            dtpThang.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 28;
            label2.Text = "Tháng";
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(12, 104);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(238, 27);
            txbTimKiem.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 78);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 26;
            label1.Text = "Tìm kiếm";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(380, 101);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 25;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dgvHocVien
            // 
            dgvHocVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocVien.Location = new Point(3, 160);
            dgvHocVien.Name = "dgvHocVien";
            dgvHocVien.RowHeadersWidth = 51;
            dgvHocVien.RowTemplate.Height = 29;
            dgvHocVien.Size = new Size(1609, 765);
            dgvHocVien.TabIndex = 24;
            // 
            // cbxKhoa
            // 
            cbxKhoa.FormattingEnabled = true;
            cbxKhoa.Items.AddRange(new object[] { "" });
            cbxKhoa.Location = new Point(415, 37);
            cbxKhoa.Name = "cbxKhoa";
            cbxKhoa.Size = new Size(120, 28);
            cbxKhoa.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(415, 12);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 36;
            label4.Text = "Khoa";
            // 
            // UC_TKCBGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbxKhoa);
            Controls.Add(label4);
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
            Controls.Add(dgvHocVien);
            Name = "UC_TKCBGV";
            Size = new Size(1615, 958);
            ((System.ComponentModel.ISupportInitialize)dgvHocVien).EndInit();
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
        private DataGridView dgvHocVien;
        private ComboBox cbxKhoa;
        private Label label4;
    }
}
