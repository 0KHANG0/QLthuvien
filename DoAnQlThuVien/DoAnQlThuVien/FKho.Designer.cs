namespace DoAnQlThuVien
{
    partial class FKho
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
            this.lvSach = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.MaSach = new System.Windows.Forms.ColumnHeader();
            this.TenSach = new System.Windows.Forms.ColumnHeader();
            this.TacGia = new System.Windows.Forms.ColumnHeader();
            this.TheLoai = new System.Windows.Forms.ColumnHeader();
            this.NXB = new System.Windows.Forms.ColumnHeader();
            this.GiaBan = new System.Windows.Forms.ColumnHeader();
            this.NamPhatHanh = new System.Windows.Forms.ColumnHeader();
            this.SoTrang = new System.Windows.Forms.ColumnHeader();
            this.NgayNhapKho = new System.Windows.Forms.ColumnHeader();
            this.Tinhtrangsach = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSach
            // 
            this.lvSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MaSach,
            this.TenSach,
            this.TacGia,
            this.TheLoai,
            this.NXB,
            this.GiaBan,
            this.NamPhatHanh,
            this.SoTrang,
            this.NgayNhapKho,
            this.Tinhtrangsach});
            this.lvSach.Location = new System.Drawing.Point(12, 57);
            this.lvSach.Name = "lvSach";
            this.lvSach.Size = new System.Drawing.Size(776, 381);
            this.lvSach.TabIndex = 0;
            this.lvSach.UseCompatibleStateImageBehavior = false;
            this.lvSach.View = System.Windows.Forms.View.Details;
            this.lvSach.SelectedIndexChanged += new System.EventHandler(this.lvSach_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // MaSach
            // 
            this.MaSach.Text = "Mã Sách";
            this.MaSach.Width = 80;
            // 
            // TenSach
            // 
            this.TenSach.Text = "Tên sách";
            this.TenSach.Width = 150;
            // 
            // TacGia
            // 
            this.TacGia.Text = "Tác Giả";
            this.TacGia.Width = 150;
            // 
            // TheLoai
            // 
            this.TheLoai.Text = "Thể Loại";
            this.TheLoai.Width = 100;
            // 
            // NXB
            // 
            this.NXB.Text = "NXB";
            this.NXB.Width = 150;
            // 
            // GiaBan
            // 
            this.GiaBan.Text = "Giá bán";
            this.GiaBan.Width = 100;
            // 
            // NamPhatHanh
            // 
            this.NamPhatHanh.Text = "Năm phát hành";
            this.NamPhatHanh.Width = 120;
            // 
            // SoTrang
            // 
            this.SoTrang.Text = "Số trang";
            // 
            // NgayNhapKho
            // 
            this.NgayNhapKho.Text = "Ngày nhập kho";
            this.NgayNhapKho.Width = 120;
            // 
            // Tinhtrangsach
            // 
            this.Tinhtrangsach.Text = "Tình trạng sách";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(123, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 39);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm Sách";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(12, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(105, 39);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "xóa sách";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(234, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 39);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(345, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(105, 39);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "tải lại";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // FKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvSach);
            this.Name = "FKho";
            this.Text = "FKho";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvSach;
        private Button btnAdd;
        private Button btnDel;
        private Button btnEdit;
        private Button btnLoad;
        private ColumnHeader MaSach;
        private ColumnHeader TenSach;
        private ColumnHeader TacGia;
        private ColumnHeader TheLoai;
        private ColumnHeader NXB;
        private ColumnHeader GiaBan;
        private ColumnHeader NamPhatHanh;
        private ColumnHeader SoTrang;
        private ColumnHeader NgayNhapKho;
        private ColumnHeader Tinhtrangsach;
        private ColumnHeader STT;
    }
}