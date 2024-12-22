namespace QuanLyNhaAn.GUI.ManHinhQLNAn
{
    partial class UC_ThongKeHocVien
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
            dgvHocVien = new DataGridView();
            btnTimKiem = new Button();
            cbxPhuongThuc = new ComboBox();
            label3 = new Label();
            dtpThang = new DateTimePicker();
            label2 = new Label();
            txbTimKiem = new TextBox();
            label1 = new Label();
            btnLamMoi = new Button();
            cbxLop = new ComboBox();
            label4 = new Label();
            btnExcel = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            pnlAn = new Panel();
            lblAn = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHocVien).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHocVien
            // 
            dgvHocVien.AllowUserToAddRows = false;
            dgvHocVien.AllowUserToDeleteRows = false;
            dgvHocVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocVien.Location = new Point(3, 166);
            dgvHocVien.Name = "dgvHocVien";
            dgvHocVien.RowHeadersWidth = 51;
            dgvHocVien.RowTemplate.Height = 29;
            dgvHocVien.Size = new Size(1609, 700);
            dgvHocVien.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(270, 107);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 20;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cbxPhuongThuc
            // 
            cbxPhuongThuc.FormattingEnabled = true;
            cbxPhuongThuc.Items.AddRange(new object[] { "Theo ngày", "Theo từng buổi" });
            cbxPhuongThuc.Location = new Point(130, 43);
            cbxPhuongThuc.Name = "cbxPhuongThuc";
            cbxPhuongThuc.Size = new Size(120, 28);
            cbxPhuongThuc.TabIndex = 19;
            cbxPhuongThuc.Text = "Theo ngày";
            cbxPhuongThuc.SelectedIndexChanged += cbxPhuongThuc_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 18);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 18;
            label3.Text = "Phương thức";
            // 
            // dtpThang
            // 
            dtpThang.CustomFormat = "MM/yyyy";
            dtpThang.Format = DateTimePickerFormat.Custom;
            dtpThang.Location = new Point(10, 44);
            dtpThang.Name = "dtpThang";
            dtpThang.Size = new Size(101, 27);
            dtpThang.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 16);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 16;
            label2.Text = "Tháng";
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(12, 110);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(238, 27);
            txbTimKiem.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 84);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 14;
            label1.Text = "Tìm kiếm";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(380, 107);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // cbxLop
            // 
            cbxLop.FormattingEnabled = true;
            cbxLop.Items.AddRange(new object[] { "" });
            cbxLop.Location = new Point(271, 43);
            cbxLop.Name = "cbxLop";
            cbxLop.Size = new Size(120, 28);
            cbxLop.TabIndex = 22;
            cbxLop.SelectedIndexChanged += cbxLop_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 18);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 21;
            label4.Text = "Lớp";
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(492, 107);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(118, 29);
            btnExcel.TabIndex = 23;
            btnExcel.Text = "Xuất file Excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(pnlAn);
            groupBox1.Controls.Add(lblAn);
            groupBox1.Location = new Point(1226, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 84);
            groupBox1.TabIndex = 24;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(207, 32);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 2;
            label6.Text = "X : Có suất ăn";
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
            // UC_ThongKeHocVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(btnExcel);
            Controls.Add(cbxLop);
            Controls.Add(label4);
            Controls.Add(btnTimKiem);
            Controls.Add(cbxPhuongThuc);
            Controls.Add(label3);
            Controls.Add(dtpThang);
            Controls.Add(label2);
            Controls.Add(txbTimKiem);
            Controls.Add(label1);
            Controls.Add(btnLamMoi);
            Controls.Add(dgvHocVien);
            Name = "UC_ThongKeHocVien";
            Size = new Size(1615, 958);
            ((System.ComponentModel.ISupportInitialize)dgvHocVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHocVien;
        private Button btnTimKiem;
        private ComboBox cbxPhuongThuc;
        private Label label3;
        private DateTimePicker dtpThang;
        private Label label2;
        private TextBox txbTimKiem;
        private Label label1;
        private Button btnLamMoi;
        private ComboBox cbxLop;
        private Label label4;
        private Button btnExcel;
        private GroupBox groupBox1;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private Panel pnlAn;
        private Label lblAn;
    }
}
