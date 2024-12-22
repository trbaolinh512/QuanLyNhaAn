﻿namespace QuanLyNhaAn.GUI.ManHinhCBGV
{
    partial class MH_CBGV
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MH_CBGV));
            btnTTSA = new Button();
            btnYKDG = new Button();
            button1 = new Button();
            pnlHienThi = new Panel();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel10 = new Panel();
            pnlUser = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lbUser = new Label();
            txtTieuDe = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel10.SuspendLayout();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnTTSA
            // 
            btnTTSA.BackColor = Color.FromArgb(0, 127, 184);
            btnTTSA.FlatAppearance.BorderSize = 0;
            btnTTSA.FlatStyle = FlatStyle.Flat;
            btnTTSA.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTTSA.ForeColor = Color.White;
            btnTTSA.Image = (Image)resources.GetObject("btnTTSA.Image");
            btnTTSA.ImageAlign = ContentAlignment.MiddleLeft;
            btnTTSA.Location = new Point(3, 20);
            btnTTSA.Margin = new Padding(3, 20, 3, 11);
            btnTTSA.Name = "btnTTSA";
            btnTTSA.Size = new Size(255, 52);
            btnTTSA.TabIndex = 2;
            btnTTSA.Text = "            Thông tin suất ăn";
            btnTTSA.TextAlign = ContentAlignment.MiddleLeft;
            btnTTSA.UseVisualStyleBackColor = false;
            btnTTSA.Click += btnTTSA_Click;
            // 
            // btnYKDG
            // 
            btnYKDG.BackColor = Color.FromArgb(0, 127, 184);
            btnYKDG.FlatAppearance.BorderSize = 0;
            btnYKDG.FlatStyle = FlatStyle.Flat;
            btnYKDG.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnYKDG.ForeColor = Color.White;
            btnYKDG.Image = (Image)resources.GetObject("btnYKDG.Image");
            btnYKDG.ImageAlign = ContentAlignment.MiddleLeft;
            btnYKDG.Location = new Point(3, 103);
            btnYKDG.Margin = new Padding(3, 20, 3, 11);
            btnYKDG.Name = "btnYKDG";
            btnYKDG.Size = new Size(255, 47);
            btnYKDG.TabIndex = 4;
            btnYKDG.Text = "          Ý kiến đóng góp";
            btnYKDG.TextAlign = ContentAlignment.MiddleLeft;
            btnYKDG.UseVisualStyleBackColor = false;
            btnYKDG.Click += btnYKDG_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 127, 184);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 711);
            button1.Margin = new Padding(3, 550, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(247, 52);
            button1.TabIndex = 3;
            button1.Text = "             Đăng Xuất";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlHienThi
            // 
            pnlHienThi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlHienThi.Location = new Point(275, 63);
            pnlHienThi.Name = "pnlHienThi";
            pnlHienThi.Size = new Size(1615, 958);
            pnlHienThi.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(0, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 915);
            panel1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom;
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 127, 184);
            flowLayoutPanel1.Controls.Add(btnTTSA);
            flowLayoutPanel1.Controls.Add(btnYKDG);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Location = new Point(0, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(258, 912);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 127, 184);
            panel10.Controls.Add(pnlUser);
            panel10.Location = new Point(0, -2);
            panel10.Name = "panel10";
            panel10.Size = new Size(258, 123);
            panel10.TabIndex = 7;
            panel10.Click += pnlUser_Click;
            // 
            // pnlUser
            // 
            pnlUser.Controls.Add(pictureBox1);
            pnlUser.Controls.Add(label1);
            pnlUser.Controls.Add(lbUser);
            pnlUser.Location = new Point(12, 14);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(238, 85);
            pnlUser.TabIndex = 0;
            pnlUser.Click += pnlUser_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(10, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pnlUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 14);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 5;
            label1.Text = "Xin chào,";
            label1.Click += pnlUser_Click;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUser.ForeColor = Color.White;
            lbUser.Location = new Point(56, 51);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(70, 28);
            lbUser.TabIndex = 4;
            lbUser.Text = "label1";
            lbUser.Click += pnlUser_Click;
            // 
            // txtTieuDe
            // 
            txtTieuDe.AutoSize = true;
            txtTieuDe.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtTieuDe.Location = new Point(264, 0);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(353, 54);
            txtTieuDe.TabIndex = 4;
            txtTieuDe.Text = "Thông tin suất ăn";
            // 
            // MH_CBGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtTieuDe);
            Controls.Add(panel10);
            Controls.Add(panel1);
            Controls.Add(pnlHienThi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MH_CBGV";
            Text = "Hệ thống báo cơm";
            Click += pnlUser_Click;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel slidebar;
        private Panel panel10;
        private Button btnTTSA;
        private Button btnYKDG;
        private Button button1;
        private Panel pnlHienThi;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbUser;
        private Button button2;
        private Panel pnlUser;
        private Label label1;
        private PictureBox pictureBox1;
        private Label txtTieuDe;
    }
}