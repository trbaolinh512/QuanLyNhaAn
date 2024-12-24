namespace PhanMemBaoCom.GUI.ManHinhChung
{
    partial class QuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMatKhau));
            label3 = new Label();
            btnLogin = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnQuenMK = new LinkLabel();
            txbMail = new TextBox();
            txbTaiKhoan = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(457, 19);
            label3.Name = "label3";
            label3.Size = new Size(264, 46);
            label3.TabIndex = 23;
            label3.Text = "Quên mật khẩu";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(489, 222);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 37);
            btnLogin.TabIndex = 20;
            btnLogin.Text = "Gửi yêu cầu";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(475, 180);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(475, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // btnQuenMK
            // 
            btnQuenMK.AutoSize = true;
            btnQuenMK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuenMK.Location = new Point(666, 222);
            btnQuenMK.Name = "btnQuenMK";
            btnQuenMK.Size = new Size(108, 28);
            btnQuenMK.TabIndex = 17;
            btnQuenMK.TabStop = true;
            btnQuenMK.Text = "Đăng nhập";
            btnQuenMK.LinkClicked += btnQuenMK_LinkClicked;
            // 
            // txbMail
            // 
            txbMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbMail.Location = new Point(519, 180);
            txbMail.Name = "txbMail";
            txbMail.Size = new Size(176, 34);
            txbMail.TabIndex = 16;
            // 
            // txbTaiKhoan
            // 
            txbTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbTaiKhoan.Location = new Point(519, 105);
            txbTaiKhoan.Name = "txbTaiKhoan";
            txbTaiKhoan.Size = new Size(176, 34);
            txbTaiKhoan.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(519, 151);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 14;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(519, 77);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 13;
            label1.Text = "Tài khoản";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 452);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnQuenMK);
            Controls.Add(txbMail);
            Controls.Add(txbTaiKhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QuenMatKhau";
            Text = "Quên mật khẩu";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnLogin;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private LinkLabel btnQuenMK;
        private TextBox txbMail;
        private TextBox txbTaiKhoan;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}