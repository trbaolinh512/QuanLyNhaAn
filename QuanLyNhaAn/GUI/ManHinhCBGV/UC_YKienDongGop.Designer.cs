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
            ((System.ComponentModel.ISupportInitialize)dgvYeuCau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).BeginInit();
            SuspendLayout();
            // 
            // dgvYeuCau
            // 
            dgvYeuCau.AllowUserToAddRows = false;
            dgvYeuCau.AllowUserToDeleteRows = false;
            dgvYeuCau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYeuCau.Columns.AddRange(new DataGridViewColumn[] { Id, STT, NoiDung, NoiDungPhanHoi, NguoiPhanHoi, NgayGui, NgayPhanHoi });
            dgvYeuCau.Location = new Point(0, 0);
            dgvYeuCau.Name = "dgvYeuCau";
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
            Id.Visible = false;
            Id.Width = 125;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.Width = 125;
            // 
            // NoiDung
            // 
            NoiDung.HeaderText = "Nội dung";
            NoiDung.MinimumWidth = 6;
            NoiDung.Name = "NoiDung";
            NoiDung.Width = 225;
            // 
            // NoiDungPhanHoi
            // 
            NoiDungPhanHoi.HeaderText = "Nội dung phản hồi";
            NoiDungPhanHoi.MinimumWidth = 6;
            NoiDungPhanHoi.Name = "NoiDungPhanHoi";
            NoiDungPhanHoi.Width = 225;
            // 
            // NguoiPhanHoi
            // 
            NguoiPhanHoi.HeaderText = "Người phản hồi";
            NguoiPhanHoi.MinimumWidth = 6;
            NguoiPhanHoi.Name = "NguoiPhanHoi";
            NguoiPhanHoi.Width = 125;
            // 
            // NgayGui
            // 
            NgayGui.HeaderText = "Ngày Gửi";
            NgayGui.MinimumWidth = 6;
            NgayGui.Name = "NgayGui";
            NgayGui.Width = 150;
            // 
            // NgayPhanHoi
            // 
            NgayPhanHoi.HeaderText = "Ngày phản hồi";
            NgayPhanHoi.MinimumWidth = 6;
            NgayPhanHoi.Name = "NgayPhanHoi";
            NgayPhanHoi.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1066, 15);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Nội dung";
            // 
            // txbYeuCau
            // 
            txbYeuCau.Location = new Point(1144, 15);
            txbYeuCau.Multiline = true;
            txbYeuCau.Name = "txbYeuCau";
            txbYeuCau.Size = new Size(419, 135);
            txbYeuCau.TabIndex = 2;
            // 
            // btnGui
            // 
            btnGui.Location = new Point(1188, 621);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(94, 29);
            btnGui.TabIndex = 3;
            btnGui.Text = "Gửi";
            btnGui.UseVisualStyleBackColor = true;
            btnGui.Click += btnGui_Click;
            // 
            // ptbAnh
            // 
            ptbAnh.BorderStyle = BorderStyle.FixedSingle;
            ptbAnh.Location = new Point(1144, 176);
            ptbAnh.Name = "ptbAnh";
            ptbAnh.Size = new Size(419, 419);
            ptbAnh.TabIndex = 4;
            ptbAnh.TabStop = false;
            // 
            // btnChinhSua
            // 
            btnChinhSua.Location = new Point(1301, 621);
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(94, 29);
            btnChinhSua.TabIndex = 5;
            btnChinhSua.Text = "Chỉnh sửa";
            btnChinhSua.UseVisualStyleBackColor = true;
            btnChinhSua.Click += btnChinhSua_Click;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(1044, 176);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(94, 29);
            btnChonAnh.TabIndex = 6;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1413, 621);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXoaAnh
            // 
            btnXoaAnh.Location = new Point(1044, 220);
            btnXoaAnh.Name = "btnXoaAnh";
            btnXoaAnh.Size = new Size(94, 29);
            btnXoaAnh.TabIndex = 8;
            btnXoaAnh.Text = "Xóa ảnh";
            btnXoaAnh.UseVisualStyleBackColor = true;
            btnXoaAnh.Click += btnXoaAnh_Click;
            // 
            // UC_YKienDongGop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnXoaAnh);
            Controls.Add(btnXoa);
            Controls.Add(btnChonAnh);
            Controls.Add(btnChinhSua);
            Controls.Add(ptbAnh);
            Controls.Add(btnGui);
            Controls.Add(txbYeuCau);
            Controls.Add(label1);
            Controls.Add(dgvYeuCau);
            Name = "UC_YKienDongGop";
            Size = new Size(1615, 958);
            ((System.ComponentModel.ISupportInitialize)dgvYeuCau).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn NoiDung;
        private DataGridViewTextBoxColumn NoiDungPhanHoi;
        private DataGridViewTextBoxColumn NguoiPhanHoi;
        private DataGridViewTextBoxColumn NgayGui;
        private DataGridViewTextBoxColumn NgayPhanHoi;
    }
}
