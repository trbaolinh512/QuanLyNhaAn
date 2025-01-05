using System.Windows.Forms;

namespace QuanLyNhaAn.GUI.ManHinhQLHThong
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_YKienDongGop));
            label5 = new Label();
            ptbAnh = new PictureBox();
            txbPhanHoi = new TextBox();
            label3 = new Label();
            txbYeuCau = new TextBox();
            btnLuu = new Button();
            dgvYKien = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            STT = new DataGridViewTextBoxColumn();
            NoiDung = new DataGridViewTextBoxColumn();
            NoiDungPhanHoi = new DataGridViewTextBoxColumn();
            NguoiGui = new DataGridViewTextBoxColumn();
            NguoiPhanHoi = new DataGridViewTextBoxColumn();
            NgayYeuCau = new DataGridViewTextBoxColumn();
            NgayPhanHoi = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvYKien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1208, 318);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 42;
            label5.Text = "Ảnh";
            // 
            // ptbAnh
            // 
            ptbAnh.BorderStyle = BorderStyle.FixedSingle;
            ptbAnh.Location = new Point(1208, 342);
            ptbAnh.Name = "ptbAnh";
            ptbAnh.Size = new Size(305, 276);
            ptbAnh.TabIndex = 41;
            ptbAnh.TabStop = false;
            // 
            // txbPhanHoi
            // 
            txbPhanHoi.Location = new Point(1208, 660);
            txbPhanHoi.Multiline = true;
            txbPhanHoi.Name = "txbPhanHoi";
            txbPhanHoi.Size = new Size(305, 173);
            txbPhanHoi.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1208, 635);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 39;
            label3.Text = "Nội dung phản hồi";
            // 
            // txbYeuCau
            // 
            txbYeuCau.Location = new Point(1208, 87);
            txbYeuCau.Multiline = true;
            txbYeuCau.Name = "txbYeuCau";
            txbYeuCau.ReadOnly = true;
            txbYeuCau.Size = new Size(305, 187);
            txbYeuCau.TabIndex = 38;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.DodgerBlue;
            btnLuu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.Location = new Point(1301, 847);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(134, 40);
            btnLuu.TabIndex = 37;
            btnLuu.Text = "Gửi phản hồi";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // dgvYKien
            // 
            dgvYKien.AllowUserToAddRows = false;
            dgvYKien.AllowUserToDeleteRows = false;
            dgvYKien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvYKien.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(2, 136, 209);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvYKien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvYKien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYKien.Columns.AddRange(new DataGridViewColumn[] { Id, STT, NoiDung, NoiDungPhanHoi, NguoiGui, NguoiPhanHoi, NgayYeuCau, NgayPhanHoi });
            dgvYKien.EnableHeadersVisualStyles = false;
            dgvYKien.Location = new Point(3, 81);
            dgvYKien.Name = "dgvYKien";
            dgvYKien.ReadOnly = true;
            dgvYKien.RowHeadersWidth = 51;
            dgvYKien.RowTemplate.Height = 29;
            dgvYKien.Size = new Size(1167, 795);
            dgvYKien.TabIndex = 36;
            dgvYKien.CellClick += dgvYKien_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            // 
            // NoiDung
            // 
            NoiDung.HeaderText = "Nội dung";
            NoiDung.MinimumWidth = 6;
            NoiDung.Name = "NoiDung";
            NoiDung.ReadOnly = true;
            // 
            // NoiDungPhanHoi
            // 
            NoiDungPhanHoi.HeaderText = "Nội dung phản hồi";
            NoiDungPhanHoi.MinimumWidth = 6;
            NoiDungPhanHoi.Name = "NoiDungPhanHoi";
            NoiDungPhanHoi.ReadOnly = true;
            NoiDungPhanHoi.Resizable = DataGridViewTriState.True;
            NoiDungPhanHoi.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // NguoiGui
            // 
            NguoiGui.HeaderText = "Người gửi";
            NguoiGui.MinimumWidth = 6;
            NguoiGui.Name = "NguoiGui";
            NguoiGui.ReadOnly = true;
            NguoiGui.Resizable = DataGridViewTriState.True;
            NguoiGui.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // NguoiPhanHoi
            // 
            NguoiPhanHoi.HeaderText = "Người phản hồi";
            NguoiPhanHoi.MinimumWidth = 6;
            NguoiPhanHoi.Name = "NguoiPhanHoi";
            NguoiPhanHoi.ReadOnly = true;
            // 
            // NgayYeuCau
            // 
            NgayYeuCau.HeaderText = "Ngày gửi";
            NgayYeuCau.MinimumWidth = 6;
            NgayYeuCau.Name = "NgayYeuCau";
            NgayYeuCau.ReadOnly = true;
            // 
            // NgayPhanHoi
            // 
            NgayPhanHoi.HeaderText = "Ngày phản hồi";
            NgayPhanHoi.MinimumWidth = 6;
            NgayPhanHoi.Name = "NgayPhanHoi";
            NgayPhanHoi.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1653, 1034);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // UC_YKienDongGop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label5);
            Controls.Add(ptbAnh);
            Controls.Add(txbPhanHoi);
            Controls.Add(label3);
            Controls.Add(txbYeuCau);
            Controls.Add(btnLuu);
            Controls.Add(dgvYKien);
            Controls.Add(pictureBox1);
            Name = "UC_YKienDongGop";
            Size = new Size(1648, 1034);
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvYKien).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private PictureBox ptbAnh;
        private TextBox txbPhanHoi;
        private Label label3;
        private TextBox txbYeuCau;
        private Button btnLuu;
        private DataGridView dgvYKien;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn NoiDung;
        private DataGridViewTextBoxColumn NoiDungPhanHoi;
        private DataGridViewTextBoxColumn NguoiGui;
        private DataGridViewTextBoxColumn NguoiPhanHoi;
        private DataGridViewTextBoxColumn NgayYeuCau;
        private DataGridViewTextBoxColumn NgayPhanHoi;
        private PictureBox pictureBox1;
    }
}
