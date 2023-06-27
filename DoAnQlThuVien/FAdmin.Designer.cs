namespace DoAnQlThuVien
{
    partial class FAdmin
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvUser = new System.Windows.Forms.ListView();
            this.MaDG = new System.Windows.Forms.ColumnHeader();
            this.Ten = new System.Windows.Forms.ColumnHeader();
            this.NgayDK = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.btnDK = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbNgayDK = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lvUser);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 332);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Người dùng";
            // 
            // lvUser
            // 
            this.lvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaDG,
            this.Ten,
            this.NgayDK});
            this.lvUser.Location = new System.Drawing.Point(6, 22);
            this.lvUser.Name = "lvUser";
            this.lvUser.Size = new System.Drawing.Size(491, 299);
            this.lvUser.TabIndex = 0;
            this.lvUser.UseCompatibleStateImageBehavior = false;
            this.lvUser.View = System.Windows.Forms.View.Details;
            // 
            // MaDG
            // 
            this.MaDG.Text = "Mã Độc giả";
            this.MaDG.Width = 150;
            // 
            // Ten
            // 
            this.Ten.Text = "Tên";
            this.Ten.Width = 200;
            // 
            // NgayDK
            // 
            this.NgayDK.Text = "Ngày đăng ký";
            this.NgayDK.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã Người dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ngày đăng ký";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(109, 18);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 23);
            this.txtHoTen.TabIndex = 18;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(109, 47);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(100, 23);
            this.txtMaDG.TabIndex = 19;
            // 
            // btnDK
            // 
            this.btnDK.Location = new System.Drawing.Point(222, 46);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(87, 23);
            this.btnDK.TabIndex = 20;
            this.btnDK.Text = "Đăng ký";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btDangKy_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(315, 46);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 22;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbNgayDK
            // 
            this.tbNgayDK.Location = new System.Drawing.Point(315, 13);
            this.tbNgayDK.Name = "tbNgayDK";
            this.tbNgayDK.Size = new System.Drawing.Size(150, 23);
            this.tbNgayDK.TabIndex = 23;
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 426);
            this.Controls.Add(this.tbNgayDK);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDK);
            this.Controls.Add(this.txtMaDG);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FAdmin";
            this.Text = "FAdmin";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox2;
        private ListView lvUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox txtUser;
        private Button btDK;
        private Button btnLoad;
        private ColumnHeader MaDG;
        private ColumnHeader Ten;
        private Button btnDK;
        private TextBox txtMaDG;
        private TextBox txtHoTen;
        private ColumnHeader NgayDK;
        private TextBox tbNgayDK;
    }
}