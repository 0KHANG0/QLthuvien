namespace DoAnQlThuVien
{
    partial class FUser
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
            this.Panel_left = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnKhoSach = new System.Windows.Forms.Button();
            this.btnPhieuMuon = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_body = new System.Windows.Forms.Panel();
            this.Panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_left
            // 
            this.Panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Panel_left.Controls.Add(this.btnUser);
            this.Panel_left.Controls.Add(this.btnExit);
            this.Panel_left.Controls.Add(this.btnKhoSach);
            this.Panel_left.Controls.Add(this.btnPhieuMuon);
            this.Panel_left.Controls.Add(this.btnLibrary);
            this.Panel_left.Controls.Add(this.pictureBox1);
            this.Panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_left.Location = new System.Drawing.Point(0, 0);
            this.Panel_left.Name = "Panel_left";
            this.Panel_left.Size = new System.Drawing.Size(150, 654);
            this.Panel_left.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Location = new System.Drawing.Point(12, 143);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(120, 33);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "Độc giả";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Location = new System.Drawing.Point(11, 619);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Đăng Xuất";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnKhoSach
            // 
            this.btnKhoSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKhoSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoSach.Location = new System.Drawing.Point(11, 221);
            this.btnKhoSach.Name = "btnKhoSach";
            this.btnKhoSach.Size = new System.Drawing.Size(120, 33);
            this.btnKhoSach.TabIndex = 3;
            this.btnKhoSach.Text = "Kho Sách";
            this.btnKhoSach.UseVisualStyleBackColor = false;
            this.btnKhoSach.Click += new System.EventHandler(this.btnKhoSach_Click);
            // 
            // btnPhieuMuon
            // 
            this.btnPhieuMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPhieuMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuMuon.Location = new System.Drawing.Point(11, 182);
            this.btnPhieuMuon.Name = "btnPhieuMuon";
            this.btnPhieuMuon.Size = new System.Drawing.Size(120, 33);
            this.btnPhieuMuon.TabIndex = 2;
            this.btnPhieuMuon.Text = "Phiếu mượn";
            this.btnPhieuMuon.UseVisualStyleBackColor = false;
            this.btnPhieuMuon.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Location = new System.Drawing.Point(12, 104);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(120, 33);
            this.btnLibrary.TabIndex = 1;
            this.btnLibrary.Text = "Thư Viện";
            this.btnLibrary.UseVisualStyleBackColor = false;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnQlThuVien.Properties.Resources.Facebook_Avatar_3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Panel_body
            // 
            this.Panel_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_body.BackgroundImage = global::DoAnQlThuVien.Properties.Resources.thu_vien;
            this.Panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_body.Location = new System.Drawing.Point(149, 0);
            this.Panel_body.Name = "Panel_body";
            this.Panel_body.Size = new System.Drawing.Size(877, 654);
            this.Panel_body.TabIndex = 1;
            // 
            // FUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 654);
            this.Controls.Add(this.Panel_body);
            this.Controls.Add(this.Panel_left);
            this.Name = "FUser";
            this.Text = "FUser";
            this.Panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Panel_left;
        private Button btnKhoSach;
        private Button btnPhieuMuon;
        private Button btnLibrary;
        private PictureBox pictureBox1;
        private Panel Panel_body;
        private Button btnExit;
        private Button btnUser;
    }
}