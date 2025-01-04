namespace QuanLyNhaAn.GUI.ManHinhQLNAn
{
    partial class UC_TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TrangChu));
            lblNgayHomNay = new Label();
            lblSuatHocVienSang = new Label();
            lblSuatCBGVSang = new Label();
            lblSuatTongQuatSang = new Label();
            dgvHocVien = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            Lop = new DataGridViewTextBoxColumn();
            SoSuatAn = new DataGridViewTextBoxColumn();
            dgvCBGV = new DataGridView();
            STT1 = new DataGridViewTextBoxColumn();
            Phong = new DataGridViewTextBoxColumn();
            Khoa = new DataGridViewTextBoxColumn();
            SoSuatAnCBGV = new DataGridViewTextBoxColumn();
            lblSuatTongQuatTrua = new Label();
            lblSuatCBGVTrua = new Label();
            lblSuatHocVienTrua = new Label();
            lblSuatTongQuatToi = new Label();
            lblSuatCBGVToi = new Label();
            lblSuatHocVienToi = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvHocVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCBGV).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNgayHomNay
            // 
            lblNgayHomNay.AutoSize = true;
            lblNgayHomNay.Location = new Point(17, 85);
            lblNgayHomNay.Name = "lblNgayHomNay";
            lblNgayHomNay.Size = new Size(50, 20);
            lblNgayHomNay.TabIndex = 0;
            lblNgayHomNay.Text = "label1";
            // 
            // lblSuatHocVienSang
            // 
            lblSuatHocVienSang.AutoSize = true;
            lblSuatHocVienSang.Location = new Point(29, 23);
            lblSuatHocVienSang.Name = "lblSuatHocVienSang";
            lblSuatHocVienSang.Size = new Size(50, 20);
            lblSuatHocVienSang.TabIndex = 1;
            lblSuatHocVienSang.Text = "label2";
            // 
            // lblSuatCBGVSang
            // 
            lblSuatCBGVSang.AutoSize = true;
            lblSuatCBGVSang.Location = new Point(28, 54);
            lblSuatCBGVSang.Name = "lblSuatCBGVSang";
            lblSuatCBGVSang.Size = new Size(50, 20);
            lblSuatCBGVSang.TabIndex = 2;
            lblSuatCBGVSang.Text = "label3";
            // 
            // lblSuatTongQuatSang
            // 
            lblSuatTongQuatSang.AutoSize = true;
            lblSuatTongQuatSang.Location = new Point(29, 88);
            lblSuatTongQuatSang.Name = "lblSuatTongQuatSang";
            lblSuatTongQuatSang.Size = new Size(50, 20);
            lblSuatTongQuatSang.TabIndex = 3;
            lblSuatTongQuatSang.Text = "label4";
            // 
            // dgvHocVien
            // 
            dgvHocVien.AllowUserToAddRows = false;
            dgvHocVien.AllowUserToDeleteRows = false;
            dgvHocVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(2, 136, 209);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHocVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHocVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocVien.Columns.AddRange(new DataGridViewColumn[] { STT, Lop, SoSuatAn });
            dgvHocVien.EnableHeadersVisualStyles = false;
            dgvHocVien.Location = new Point(32, 283);
            dgvHocVien.Name = "dgvHocVien";
            dgvHocVien.RowHeadersWidth = 51;
            dgvHocVien.RowTemplate.Height = 29;
            dgvHocVien.Size = new Size(686, 698);
            dgvHocVien.TabIndex = 4;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            // 
            // Lop
            // 
            Lop.HeaderText = "Lớp";
            Lop.MinimumWidth = 6;
            Lop.Name = "Lop";
            Lop.ReadOnly = true;
            // 
            // SoSuatAn
            // 
            SoSuatAn.HeaderText = "Số suất ăn";
            SoSuatAn.MinimumWidth = 6;
            SoSuatAn.Name = "SoSuatAn";
            SoSuatAn.ReadOnly = true;
            // 
            // dgvCBGV
            // 
            dgvCBGV.AllowUserToAddRows = false;
            dgvCBGV.AllowUserToDeleteRows = false;
            dgvCBGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCBGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCBGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCBGV.Columns.AddRange(new DataGridViewColumn[] { STT1, Phong, Khoa, SoSuatAnCBGV });
            dgvCBGV.EnableHeadersVisualStyles = false;
            dgvCBGV.Location = new Point(742, 283);
            dgvCBGV.Name = "dgvCBGV";
            dgvCBGV.RowHeadersWidth = 51;
            dgvCBGV.RowTemplate.Height = 29;
            dgvCBGV.Size = new Size(818, 698);
            dgvCBGV.TabIndex = 5;
            // 
            // STT1
            // 
            STT1.HeaderText = "STT";
            STT1.MinimumWidth = 6;
            STT1.Name = "STT1";
            // 
            // Phong
            // 
            Phong.HeaderText = "Phòng";
            Phong.MinimumWidth = 6;
            Phong.Name = "Phong";
            Phong.ReadOnly = true;
            // 
            // Khoa
            // 
            Khoa.HeaderText = "Khoa";
            Khoa.MinimumWidth = 6;
            Khoa.Name = "Khoa";
            Khoa.ReadOnly = true;
            // 
            // SoSuatAnCBGV
            // 
            SoSuatAnCBGV.HeaderText = "Số suất ăn";
            SoSuatAnCBGV.MinimumWidth = 6;
            SoSuatAnCBGV.Name = "SoSuatAnCBGV";
            SoSuatAnCBGV.ReadOnly = true;
            // 
            // lblSuatTongQuatTrua
            // 
            lblSuatTongQuatTrua.AutoSize = true;
            lblSuatTongQuatTrua.Location = new Point(34, 88);
            lblSuatTongQuatTrua.Name = "lblSuatTongQuatTrua";
            lblSuatTongQuatTrua.Size = new Size(50, 20);
            lblSuatTongQuatTrua.TabIndex = 8;
            lblSuatTongQuatTrua.Text = "label4";
            // 
            // lblSuatCBGVTrua
            // 
            lblSuatCBGVTrua.AutoSize = true;
            lblSuatCBGVTrua.Location = new Point(33, 54);
            lblSuatCBGVTrua.Name = "lblSuatCBGVTrua";
            lblSuatCBGVTrua.Size = new Size(50, 20);
            lblSuatCBGVTrua.TabIndex = 7;
            lblSuatCBGVTrua.Text = "label3";
            // 
            // lblSuatHocVienTrua
            // 
            lblSuatHocVienTrua.AutoSize = true;
            lblSuatHocVienTrua.Location = new Point(34, 23);
            lblSuatHocVienTrua.Name = "lblSuatHocVienTrua";
            lblSuatHocVienTrua.Size = new Size(50, 20);
            lblSuatHocVienTrua.TabIndex = 6;
            lblSuatHocVienTrua.Text = "label2";
            // 
            // lblSuatTongQuatToi
            // 
            lblSuatTongQuatToi.AutoSize = true;
            lblSuatTongQuatToi.Location = new Point(28, 88);
            lblSuatTongQuatToi.Name = "lblSuatTongQuatToi";
            lblSuatTongQuatToi.Size = new Size(50, 20);
            lblSuatTongQuatToi.TabIndex = 11;
            lblSuatTongQuatToi.Text = "label4";
            // 
            // lblSuatCBGVToi
            // 
            lblSuatCBGVToi.AutoSize = true;
            lblSuatCBGVToi.Location = new Point(27, 54);
            lblSuatCBGVToi.Name = "lblSuatCBGVToi";
            lblSuatCBGVToi.Size = new Size(50, 20);
            lblSuatCBGVToi.TabIndex = 10;
            lblSuatCBGVToi.Text = "label3";
            // 
            // lblSuatHocVienToi
            // 
            lblSuatHocVienToi.AutoSize = true;
            lblSuatHocVienToi.Location = new Point(28, 23);
            lblSuatHocVienToi.Name = "lblSuatHocVienToi";
            lblSuatHocVienToi.Size = new Size(50, 20);
            lblSuatHocVienToi.TabIndex = 9;
            lblSuatHocVienToi.Text = "label2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSuatHocVienSang);
            groupBox1.Controls.Add(lblSuatCBGVSang);
            groupBox1.Controls.Add(lblSuatTongQuatSang);
            groupBox1.Location = new Point(17, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buổi sáng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblSuatHocVienTrua);
            groupBox2.Controls.Add(lblSuatCBGVTrua);
            groupBox2.Controls.Add(lblSuatTongQuatTrua);
            groupBox2.Location = new Point(308, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buổi trưa";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblSuatHocVienToi);
            groupBox3.Controls.Add(lblSuatCBGVToi);
            groupBox3.Controls.Add(lblSuatTongQuatToi);
            groupBox3.Location = new Point(598, 122);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 125);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buổi tối";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1653, 1033);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // UC_TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvCBGV);
            Controls.Add(dgvHocVien);
            Controls.Add(lblNgayHomNay);
            Controls.Add(pictureBox1);
            Name = "UC_TrangChu";
            Size = new Size(1647, 1033);
            ((System.ComponentModel.ISupportInitialize)dgvHocVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCBGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNgayHomNay;
        private Label lblSuatHocVienSang;
        private Label lblSuatCBGVSang;
        private Label lblSuatTongQuatSang;
        private DataGridView dgvHocVien;
        private DataGridView dgvCBGV;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Lop;
        private DataGridViewTextBoxColumn SoSuatAn;
        private DataGridViewTextBoxColumn STT1;
        private DataGridViewTextBoxColumn Phong;
        private DataGridViewTextBoxColumn Khoa;
        private DataGridViewTextBoxColumn SoSuatAnCBGV;
        private Label lblSuatTongQuatTrua;
        private Label lblSuatCBGVTrua;
        private Label lblSuatHocVienTrua;
        private Label lblSuatTongQuatToi;
        private Label lblSuatCBGVToi;
        private Label lblSuatHocVienToi;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
    }
}
