﻿using System.Windows.Forms;

namespace QuanLyNhaAn.GUI.ManHinhQLHThong
{
    partial class UC_QLyChucVu
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_QLyChucVu));
            btnXoa = new Button();
            btnThem = new Button();
            ckbBaoCom = new CheckBox();
            ckbLaHocVien = new CheckBox();
            btnChinhSua = new Button();
            label2 = new Label();
            txbChucVu = new TextBox();
            dgvChucVu = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            STT = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            LaHocVien = new DataGridViewCheckBoxColumn();
            CoQuyenBaoCom = new DataGridViewCheckBoxColumn();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(1204, 194);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(113, 44);
            btnXoa.TabIndex = 41;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DodgerBlue;
            btnThem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(1204, 84);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(113, 48);
            btnThem.TabIndex = 40;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // ckbBaoCom
            // 
            ckbBaoCom.AutoSize = true;
            ckbBaoCom.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ckbBaoCom.Location = new Point(980, 196);
            ckbBaoCom.Name = "ckbBaoCom";
            ckbBaoCom.Size = new Size(206, 29);
            ckbBaoCom.TabIndex = 39;
            ckbBaoCom.Text = "Có quyền báo cơm ?";
            ckbBaoCom.UseVisualStyleBackColor = true;
            // 
            // ckbLaHocVien
            // 
            ckbLaHocVien.AutoSize = true;
            ckbLaHocVien.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ckbLaHocVien.Location = new Point(980, 157);
            ckbLaHocVien.Name = "ckbLaHocVien";
            ckbLaHocVien.Size = new Size(143, 29);
            ckbLaHocVien.TabIndex = 38;
            ckbLaHocVien.Text = "Là học viên ?";
            ckbLaHocVien.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua
            // 
            btnChinhSua.BackColor = Color.Lime;
            btnChinhSua.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnChinhSua.Location = new Point(1204, 140);
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(113, 46);
            btnChinhSua.TabIndex = 37;
            btnChinhSua.Text = "Chỉnh sửa";
            btnChinhSua.UseVisualStyleBackColor = false;
            btnChinhSua.Click += btnChinhSua_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(980, 96);
            label2.Name = "label2";
            label2.Size = new Size(82, 27);
            label2.TabIndex = 36;
            label2.Text = "Chức vụ";
            // 
            // txbChucVu
            // 
            txbChucVu.Location = new Point(980, 125);
            txbChucVu.Name = "txbChucVu";
            txbChucVu.Size = new Size(167, 27);
            txbChucVu.TabIndex = 35;
            // 
            // dgvChucVu
            // 
            dgvChucVu.AllowUserToAddRows = false;
            dgvChucVu.AllowUserToDeleteRows = false;
            dgvChucVu.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(2, 136, 209);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvChucVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvChucVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChucVu.Columns.AddRange(new DataGridViewColumn[] { Id, STT, ChucVu, LaHocVien, CoQuyenBaoCom });
            dgvChucVu.EnableHeadersVisualStyles = false;
            dgvChucVu.Location = new Point(301, 82);
            dgvChucVu.Name = "dgvChucVu";
            dgvChucVu.ReadOnly = true;
            dgvChucVu.RowHeadersWidth = 51;
            dgvChucVu.RowTemplate.Height = 29;
            dgvChucVu.Size = new Size(673, 849);
            dgvChucVu.TabIndex = 34;
            dgvChucVu.CellClick += dgvChucVu_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 6;
            // 
            // STT
            // 
            STT.FillWeight = 35.5665436F;
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 50;
            // 
            // ChucVu
            // 
            ChucVu.FillWeight = 32.484108F;
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            ChucVu.ReadOnly = true;
            ChucVu.Width = 226;
            // 
            // LaHocVien
            // 
            LaHocVien.FillWeight = 32.484108F;
            LaHocVien.HeaderText = "Là học viên";
            LaHocVien.MinimumWidth = 6;
            LaHocVien.Name = "LaHocVien";
            LaHocVien.ReadOnly = true;
            LaHocVien.Width = 125;
            // 
            // CoQuyenBaoCom
            // 
            CoQuyenBaoCom.FillWeight = 299.46524F;
            CoQuyenBaoCom.HeaderText = "Có quyền báo cơm";
            CoQuyenBaoCom.MinimumWidth = 6;
            CoQuyenBaoCom.Name = "CoQuyenBaoCom";
            CoQuyenBaoCom.ReadOnly = true;
            CoQuyenBaoCom.Width = 200;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1648, 1033);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // UC_QLyChucVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(ckbBaoCom);
            Controls.Add(ckbLaHocVien);
            Controls.Add(btnChinhSua);
            Controls.Add(label2);
            Controls.Add(txbChucVu);
            Controls.Add(dgvChucVu);
            Controls.Add(pictureBox1);
            Name = "UC_QLyChucVu";
            Size = new Size(1648, 1034);
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXoa;
        private Button btnThem;
        private CheckBox ckbBaoCom;
        private CheckBox ckbLaHocVien;
        private Button btnChinhSua;
        private Label label2;
        private TextBox txbChucVu;
        private DataGridView dgvChucVu;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewCheckBoxColumn LaHocVien;
        private DataGridViewCheckBoxColumn CoQuyenBaoCom;
    }
}
