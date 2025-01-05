using System.Windows.Forms;

namespace QuanLyNhaAn.GUI.ManHinhCBGV
{
    partial class UC_YKienDongGop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_YKienDongGop));
            dgvYeuCau = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            STT = new DataGridViewTextBoxColumn();
            NoiDung = new DataGridViewTextBoxColumn();
            NoiDungPhanHoi = new DataGridViewTextBoxColumn();
            NguoiPhanHoi = new DataGridViewTextBoxColumn();
            NgayGui = new DataGridViewTextBoxColumn();
            NgayPhanHoi = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txbYeuCau = new TextBox();
            btnGui = new Button();
            ptbAnh = new PictureBox();
            btnChinhSua = new Button();
            btnChonAnh = new Button();
            btnXoa = new Button();
            btnXoaAnh = new Button();
            txbPhanHoi = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvYeuCau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvYeuCau
            // 
            dgvYeuCau.AllowUserToAddRows = false;
            dgvYeuCau.AllowUserToDeleteRows = false;
            dgvYeuCau.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(2, 136, 209);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvYeuCau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvYeuCau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYeuCau.Columns.AddRange(new DataGridViewColumn[] { Id, STT, NoiDung, NoiDungPhanHoi, NguoiPhanHoi, NgayGui, NgayPhanHoi });
            dgvYeuCau.EnableHeadersVisualStyles = false;
            dgvYeuCau.Location = new Point(16, 73);
            dgvYeuCau.Name = "dgvYeuCau";
            dgvYeuCau.ReadOnly = true;
            dgvYeuCau.RowHeadersWidth = 51;
            dgvYeuCau.RowTemplate.Height = 29;
            dgvYeuCau.Size = new Size(1018, 878);
            dgvYeuCau.TabIndex = 0;
            dgvYeuCau.CellClick += dgvYeuCau_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 50;
            // 
            // NoiDung
            // 
            NoiDung.HeaderText = "Nội dung";
            NoiDung.MinimumWidth = 6;
            NoiDung.Name = "NoiDung";
            NoiDung.ReadOnly = true;
            NoiDung.Width = 225;
            // 
            // NoiDungPhanHoi
            // 
            NoiDungPhanHoi.HeaderText = "Nội dung phản hồi";
            NoiDungPhanHoi.MinimumWidth = 6;
            NoiDungPhanHoi.Name = "NoiDungPhanHoi";
            NoiDungPhanHoi.ReadOnly = true;
            NoiDungPhanHoi.Width = 225;
            // 
            // NguoiPhanHoi
            // 
            NguoiPhanHoi.HeaderText = "Người phản hồi";
            NguoiPhanHoi.MinimumWidth = 6;
            NguoiPhanHoi.Name = "NguoiPhanHoi";
            NguoiPhanHoi.ReadOnly = true;
            NguoiPhanHoi.Width = 225;
            // 
            // NgayGui
            // 
            NgayGui.HeaderText = "Ngày Gửi";
            NgayGui.MinimumWidth = 6;
            NgayGui.Name = "NgayGui";
            NgayGui.ReadOnly = true;
            NgayGui.Width = 225;
            // 
            // NgayPhanHoi
            // 
            NgayPhanHoi.HeaderText = "Ngày phản hồi";
            NgayPhanHoi.MinimumWidth = 6;
            NgayPhanHoi.Name = "NgayPhanHoi";
            NgayPhanHoi.ReadOnly = true;
            NgayPhanHoi.Width = 225;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1070, 88);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Nội dung";
            // 
            // txbYeuCau
            // 
            txbYeuCau.Location = new Point(1148, 88);
            txbYeuCau.Multiline = true;
            txbYeuCau.Name = "txbYeuCau";
            txbYeuCau.Size = new Size(419, 135);
            txbYeuCau.TabIndex = 2;
            // 
            // btnGui
            // 
            btnGui.BackColor = Color.DodgerBlue;
            btnGui.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnGui.ForeColor = Color.Black;
            btnGui.Location = new Point(1185, 684);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(101, 45);
            btnGui.TabIndex = 3;
            btnGui.Text = "Gửi";
            btnGui.UseVisualStyleBackColor = false;
            btnGui.Click += btnGui_Click;
            // 
            // ptbAnh
            // 
            ptbAnh.BorderStyle = BorderStyle.FixedSingle;
            ptbAnh.Location = new Point(1148, 249);
            ptbAnh.Name = "ptbAnh";
            ptbAnh.Size = new Size(419, 419);
            ptbAnh.TabIndex = 4;
            ptbAnh.TabStop = false;
            // 
            // btnChinhSua
            // 
            btnChinhSua.BackColor = Color.Yellow;
            btnChinhSua.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnChinhSua.Location = new Point(1292, 684);
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(107, 45);
            btnChinhSua.TabIndex = 5;
            btnChinhSua.Text = "Chỉnh sửa";
            btnChinhSua.UseVisualStyleBackColor = false;
            btnChinhSua.Click += btnChinhSua_Click;
            // 
            // btnChonAnh
            // 
            btnChonAnh.BackColor = Color.DodgerBlue;
            btnChonAnh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonAnh.ForeColor = Color.Black;
            btnChonAnh.Location = new Point(1040, 249);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(102, 38);
            btnChonAnh.TabIndex = 6;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = false;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(1405, 684);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(106, 45);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXoaAnh
            // 
            btnXoaAnh.BackColor = Color.Red;
            btnXoaAnh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaAnh.ForeColor = Color.Black;
            btnXoaAnh.Location = new Point(1040, 293);
            btnXoaAnh.Name = "btnXoaAnh";
            btnXoaAnh.Size = new Size(102, 38);
            btnXoaAnh.TabIndex = 8;
            btnXoaAnh.Text = "Xóa ảnh";
            btnXoaAnh.UseVisualStyleBackColor = false;
            btnXoaAnh.Click += btnXoaAnh_Click;
            // 
            // txbPhanHoi
            // 
            txbPhanHoi.Location = new Point(1148, 777);
            txbPhanHoi.Multiline = true;
            txbPhanHoi.Name = "txbPhanHoi";
            txbPhanHoi.ReadOnly = true;
            txbPhanHoi.Size = new Size(419, 170);
            txbPhanHoi.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1070, 748);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 9;
            label2.Text = "Nội dung phản hồi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1644, 1035);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // UC_YKienDongGop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txbPhanHoi);
            Controls.Add(label2);
            Controls.Add(btnXoaAnh);
            Controls.Add(btnXoa);
            Controls.Add(btnChonAnh);
            Controls.Add(btnChinhSua);
            Controls.Add(ptbAnh);
            Controls.Add(btnGui);
            Controls.Add(txbYeuCau);
            Controls.Add(label1);
            Controls.Add(dgvYeuCau);
            Controls.Add(pictureBox1);
            Name = "UC_YKienDongGop";
            Size = new Size(1647, 1035);
            ((System.ComponentModel.ISupportInitialize)dgvYeuCau).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvYeuCau;
        private Label label1;
        private TextBox txbYeuCau;
        private Button btnGui;
        private PictureBox ptbAnh;
        private Button btnChinhSua;
        private Button btnChonAnh;
        private Button btnXoa;
        private Button btnXoaAnh;
        private TextBox txbPhanHoi;
        private Label label2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn NoiDung;
        private DataGridViewTextBoxColumn NoiDungPhanHoi;
        private DataGridViewTextBoxColumn NguoiPhanHoi;
        private DataGridViewTextBoxColumn NgayGui;
        private DataGridViewTextBoxColumn NgayPhanHoi;
        private PictureBox pictureBox1;
    }
}
