namespace CS464J_CAOTRANYENNHI_QLSACH
{
    partial class frm_Sach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sach));
            this.panel4 = new System.Windows.Forms.Panel();
            this.pic_quaylai = new System.Windows.Forms.PictureBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.lb_Title = new System.Windows.Forms.Label();
            this.dt_Sach = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_XoaSach = new System.Windows.Forms.Button();
            this.btn_SuaSach = new System.Windows.Forms.Button();
            this.btn_ThemSach = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_TLoai_Sach = new System.Windows.Forms.ComboBox();
            this.txt_GiaThanh = new System.Windows.Forms.TextBox();
            this.txt_TG_Sach = new System.Windows.Forms.TextBox();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.lb_TenSach = new System.Windows.Forms.Label();
            this.lb_TheLoai = new System.Windows.Forms.Label();
            this.lb_TacGia = new System.Windows.Forms.Label();
            this.lb_GiaThanh = new System.Windows.Forms.Label();
            this.lb_MaSach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Dem = new System.Windows.Forms.TextBox();
            this.btn_Dem = new System.Windows.Forms.Button();
            this.txt_HinhAnh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_anh = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_quaylai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Sach)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.pic_quaylai);
            this.panel4.Controls.Add(this.btn_Tim);
            this.panel4.Controls.Add(this.txt_tim);
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(206, 132);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(730, 58);
            this.panel4.TabIndex = 12;
            // 
            // pic_quaylai
            // 
            this.pic_quaylai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_quaylai.Image = ((System.Drawing.Image)(resources.GetObject("pic_quaylai.Image")));
            this.pic_quaylai.Location = new System.Drawing.Point(689, 15);
            this.pic_quaylai.Name = "pic_quaylai";
            this.pic_quaylai.Size = new System.Drawing.Size(31, 40);
            this.pic_quaylai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_quaylai.TabIndex = 10;
            this.pic_quaylai.TabStop = false;
            this.pic_quaylai.Click += new System.EventHandler(this.pic_quaylai_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Tim.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Tim.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(11, 15);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(144, 35);
            this.btn_Tim.TabIndex = 9;
            this.btn_Tim.Text = "Tìm kiếm";
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tim.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(162, 17);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(514, 34);
            this.txt_tim.TabIndex = 1;
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_Title.Location = new System.Drawing.Point(661, 43);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(388, 56);
            this.lb_Title.TabIndex = 10;
            this.lb_Title.Text = "QUẢN LÝ SÁCH";
            // 
            // dt_Sach
            // 
            this.dt_Sach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_Sach.BackgroundColor = System.Drawing.Color.White;
            this.dt_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Sach.Location = new System.Drawing.Point(206, 196);
            this.dt_Sach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_Sach.Name = "dt_Sach";
            this.dt_Sach.RowHeadersWidth = 51;
            this.dt_Sach.RowTemplate.Height = 24;
            this.dt_Sach.Size = new System.Drawing.Size(730, 606);
            this.dt_Sach.TabIndex = 9;
            this.dt_Sach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_Sach_CellClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel2.Controls.Add(this.btn_XoaSach);
            this.panel2.Controls.Add(this.btn_SuaSach);
            this.panel2.Controls.Add(this.btn_ThemSach);
            this.panel2.Controls.Add(this.txt_Dem);
            this.panel2.Controls.Add(this.btn_Dem);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(942, 132);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 289);
            this.panel2.TabIndex = 8;
            // 
            // btn_XoaSach
            // 
            this.btn_XoaSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_XoaSach.BackColor = System.Drawing.Color.Honeydew;
            this.btn_XoaSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaSach.Location = new System.Drawing.Point(13, 159);
            this.btn_XoaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XoaSach.Name = "btn_XoaSach";
            this.btn_XoaSach.Size = new System.Drawing.Size(127, 48);
            this.btn_XoaSach.TabIndex = 3;
            this.btn_XoaSach.Text = "Xóa";
            this.btn_XoaSach.UseVisualStyleBackColor = false;
            this.btn_XoaSach.Click += new System.EventHandler(this.btn_XoaSach_Click);
            // 
            // btn_SuaSach
            // 
            this.btn_SuaSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SuaSach.BackColor = System.Drawing.Color.Honeydew;
            this.btn_SuaSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaSach.Location = new System.Drawing.Point(13, 228);
            this.btn_SuaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SuaSach.Name = "btn_SuaSach";
            this.btn_SuaSach.Size = new System.Drawing.Size(127, 48);
            this.btn_SuaSach.TabIndex = 1;
            this.btn_SuaSach.Text = "Sửa";
            this.btn_SuaSach.UseVisualStyleBackColor = false;
            this.btn_SuaSach.Click += new System.EventHandler(this.btn_SuaSach_Click);
            // 
            // btn_ThemSach
            // 
            this.btn_ThemSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ThemSach.BackColor = System.Drawing.Color.Honeydew;
            this.btn_ThemSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemSach.Location = new System.Drawing.Point(13, 87);
            this.btn_ThemSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThemSach.Name = "btn_ThemSach";
            this.btn_ThemSach.Size = new System.Drawing.Size(127, 49);
            this.btn_ThemSach.TabIndex = 0;
            this.btn_ThemSach.Text = "Thêm";
            this.btn_ThemSach.UseVisualStyleBackColor = false;
            this.btn_ThemSach.Click += new System.EventHandler(this.btn_ThemSach_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Thoat.BackColor = System.Drawing.Color.Wheat;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(1260, 754);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(127, 48);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txt_HinhAnh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_TLoai_Sach);
            this.panel1.Controls.Add(this.txt_GiaThanh);
            this.panel1.Controls.Add(this.txt_TG_Sach);
            this.panel1.Controls.Add(this.txt_TenSach);
            this.panel1.Controls.Add(this.txt_MaSach);
            this.panel1.Controls.Add(this.lb_TenSach);
            this.panel1.Controls.Add(this.lb_TheLoai);
            this.panel1.Controls.Add(this.lb_TacGia);
            this.panel1.Controls.Add(this.lb_GiaThanh);
            this.panel1.Controls.Add(this.lb_MaSach);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(942, 426);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 324);
            this.panel1.TabIndex = 7;
            // 
            // cb_TLoai_Sach
            // 
            this.cb_TLoai_Sach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_TLoai_Sach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TLoai_Sach.FormattingEnabled = true;
            this.cb_TLoai_Sach.Location = new System.Drawing.Point(149, 115);
            this.cb_TLoai_Sach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_TLoai_Sach.Name = "cb_TLoai_Sach";
            this.cb_TLoai_Sach.Size = new System.Drawing.Size(296, 33);
            this.cb_TLoai_Sach.TabIndex = 11;
            // 
            // txt_GiaThanh
            // 
            this.txt_GiaThanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_GiaThanh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaThanh.Location = new System.Drawing.Point(149, 211);
            this.txt_GiaThanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GiaThanh.Name = "txt_GiaThanh";
            this.txt_GiaThanh.Size = new System.Drawing.Size(296, 34);
            this.txt_GiaThanh.TabIndex = 9;
            // 
            // txt_TG_Sach
            // 
            this.txt_TG_Sach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TG_Sach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TG_Sach.Location = new System.Drawing.Point(149, 161);
            this.txt_TG_Sach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TG_Sach.Name = "txt_TG_Sach";
            this.txt_TG_Sach.Size = new System.Drawing.Size(296, 34);
            this.txt_TG_Sach.TabIndex = 8;
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSach.Location = new System.Drawing.Point(149, 65);
            this.txt_TenSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(296, 34);
            this.txt_TenSach.TabIndex = 7;
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSach.Location = new System.Drawing.Point(149, 17);
            this.txt_MaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(296, 34);
            this.txt_MaSach.TabIndex = 6;
            // 
            // lb_TenSach
            // 
            this.lb_TenSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_TenSach.AutoSize = true;
            this.lb_TenSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenSach.ForeColor = System.Drawing.Color.Black;
            this.lb_TenSach.Location = new System.Drawing.Point(13, 68);
            this.lb_TenSach.Name = "lb_TenSach";
            this.lb_TenSach.Size = new System.Drawing.Size(106, 26);
            this.lb_TenSach.TabIndex = 5;
            this.lb_TenSach.Text = "Tên Sách";
            // 
            // lb_TheLoai
            // 
            this.lb_TheLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_TheLoai.AutoSize = true;
            this.lb_TheLoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TheLoai.ForeColor = System.Drawing.Color.Black;
            this.lb_TheLoai.Location = new System.Drawing.Point(13, 122);
            this.lb_TheLoai.Name = "lb_TheLoai";
            this.lb_TheLoai.Size = new System.Drawing.Size(104, 26);
            this.lb_TheLoai.TabIndex = 4;
            this.lb_TheLoai.Text = "Thể Loại";
            // 
            // lb_TacGia
            // 
            this.lb_TacGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_TacGia.AutoSize = true;
            this.lb_TacGia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TacGia.ForeColor = System.Drawing.Color.Black;
            this.lb_TacGia.Location = new System.Drawing.Point(13, 169);
            this.lb_TacGia.Name = "lb_TacGia";
            this.lb_TacGia.Size = new System.Drawing.Size(93, 26);
            this.lb_TacGia.TabIndex = 3;
            this.lb_TacGia.Text = "Tác Giả";
            // 
            // lb_GiaThanh
            // 
            this.lb_GiaThanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_GiaThanh.AutoSize = true;
            this.lb_GiaThanh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GiaThanh.ForeColor = System.Drawing.Color.Black;
            this.lb_GiaThanh.Location = new System.Drawing.Point(13, 214);
            this.lb_GiaThanh.Name = "lb_GiaThanh";
            this.lb_GiaThanh.Size = new System.Drawing.Size(121, 26);
            this.lb_GiaThanh.TabIndex = 2;
            this.lb_GiaThanh.Text = "Giá Thành";
            // 
            // lb_MaSach
            // 
            this.lb_MaSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_MaSach.AutoSize = true;
            this.lb_MaSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaSach.ForeColor = System.Drawing.Color.Black;
            this.lb_MaSach.Location = new System.Drawing.Point(13, 20);
            this.lb_MaSach.Name = "lb_MaSach";
            this.lb_MaSach.Size = new System.Drawing.Size(102, 26);
            this.lb_MaSach.TabIndex = 0;
            this.lb_MaSach.Text = "Mã Sách";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nhập tên sách để tìm kiếm";
            // 
            // txt_Dem
            // 
            this.txt_Dem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Dem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dem.Location = new System.Drawing.Point(101, 17);
            this.txt_Dem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Dem.Name = "txt_Dem";
            this.txt_Dem.Size = new System.Drawing.Size(44, 34);
            this.txt_Dem.TabIndex = 3;
            // 
            // btn_Dem
            // 
            this.btn_Dem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Dem.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Dem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dem.Location = new System.Drawing.Point(13, 17);
            this.btn_Dem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Dem.Name = "btn_Dem";
            this.btn_Dem.Size = new System.Drawing.Size(81, 35);
            this.btn_Dem.TabIndex = 8;
            this.btn_Dem.Text = "Đếm";
            this.btn_Dem.UseVisualStyleBackColor = false;
            this.btn_Dem.Click += new System.EventHandler(this.btn_Dem_Click);
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HinhAnh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HinhAnh.Location = new System.Drawing.Point(149, 262);
            this.txt_HinhAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Size = new System.Drawing.Size(296, 34);
            this.txt_HinhAnh.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hình Ảnh";
            // 
            // pic_anh
            // 
            this.pic_anh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_anh.BackColor = System.Drawing.Color.PapayaWhip;
            this.pic_anh.Location = new System.Drawing.Point(1098, 132);
            this.pic_anh.Name = "pic_anh";
            this.pic_anh.Size = new System.Drawing.Size(289, 289);
            this.pic_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_anh.TabIndex = 13;
            this.pic_anh.TabStop = false;
            this.pic_anh.Click += new System.EventHandler(this.pic_anh_Click);
            // 
            // frm_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1632, 862);
            this.Controls.Add(this.pic_anh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dt_Sach);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Sach";
            this.Text = "Sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Sach_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_quaylai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Sach)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txt_tim;
        public System.Windows.Forms.Label lb_Title;
        public System.Windows.Forms.DataGridView dt_Sach;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btn_XoaSach;
        public System.Windows.Forms.Button btn_Thoat;
        public System.Windows.Forms.Button btn_SuaSach;
        public System.Windows.Forms.Button btn_ThemSach;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cb_TLoai_Sach;
        public System.Windows.Forms.TextBox txt_GiaThanh;
        public System.Windows.Forms.TextBox txt_TG_Sach;
        public System.Windows.Forms.TextBox txt_TenSach;
        public System.Windows.Forms.TextBox txt_MaSach;
        public System.Windows.Forms.Label lb_TenSach;
        public System.Windows.Forms.Label lb_TheLoai;
        public System.Windows.Forms.Label lb_TacGia;
        public System.Windows.Forms.Label lb_GiaThanh;
        public System.Windows.Forms.Label lb_MaSach;
        public System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.PictureBox pic_quaylai;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_HinhAnh;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_Dem;
        public System.Windows.Forms.Button btn_Dem;
        private System.Windows.Forms.PictureBox pic_anh;
    }
}