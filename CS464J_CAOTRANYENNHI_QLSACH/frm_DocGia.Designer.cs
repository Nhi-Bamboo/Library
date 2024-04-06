namespace CS464J_CAOTRANYENNHI_QLSACH
{
    partial class frm_DocGia
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
            this.dt_DG = new System.Windows.Forms.DataGridView();
            this.date_NgaySinhDG = new System.Windows.Forms.DateTimePicker();
            this.txt_TenDG = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_MaDG = new System.Windows.Forms.TextBox();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.btn_XoaDG = new System.Windows.Forms.Button();
            this.btb_Thoat = new System.Windows.Forms.Button();
            this.btn_SuaDG = new System.Windows.Forms.Button();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.lb_TenDG = new System.Windows.Forms.Label();
            this.lb_MaDG = new System.Windows.Forms.Label();
            this.btn_ThemDG = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_DG)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_DG
            // 
            this.dt_DG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_DG.BackgroundColor = System.Drawing.Color.White;
            this.dt_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_DG.Location = new System.Drawing.Point(55, 176);
            this.dt_DG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_DG.Name = "dt_DG";
            this.dt_DG.RowHeadersWidth = 51;
            this.dt_DG.RowTemplate.Height = 24;
            this.dt_DG.Size = new System.Drawing.Size(783, 443);
            this.dt_DG.TabIndex = 5;
            this.dt_DG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_DG_CellClick);
            // 
            // date_NgaySinhDG
            // 
            this.date_NgaySinhDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_NgaySinhDG.CustomFormat = "   dd/MM/yyyy";
            this.date_NgaySinhDG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgaySinhDG.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgaySinhDG.Location = new System.Drawing.Point(172, 132);
            this.date_NgaySinhDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_NgaySinhDG.Name = "date_NgaySinhDG";
            this.date_NgaySinhDG.Size = new System.Drawing.Size(228, 34);
            this.date_NgaySinhDG.TabIndex = 9;
            this.date_NgaySinhDG.Value = new System.DateTime(2023, 4, 6, 0, 0, 0, 0);
            // 
            // txt_TenDG
            // 
            this.txt_TenDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenDG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDG.Location = new System.Drawing.Point(172, 82);
            this.txt_TenDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenDG.Name = "txt_TenDG";
            this.txt_TenDG.Size = new System.Drawing.Size(228, 34);
            this.txt_TenDG.TabIndex = 8;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DiaChi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(172, 185);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(228, 34);
            this.txt_DiaChi.TabIndex = 7;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(172, 236);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(228, 34);
            this.txt_SDT.TabIndex = 6;
            // 
            // txt_MaDG
            // 
            this.txt_MaDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaDG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaDG.Location = new System.Drawing.Point(172, 28);
            this.txt_MaDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaDG.Name = "txt_MaDG";
            this.txt_MaDG.Size = new System.Drawing.Size(228, 34);
            this.txt_MaDG.TabIndex = 5;
            // 
            // lb_SDT
            // 
            this.lb_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SDT.Location = new System.Drawing.Point(28, 239);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(56, 26);
            this.lb_SDT.TabIndex = 4;
            this.lb_SDT.Text = "SĐT";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DiaChi.Location = new System.Drawing.Point(28, 188);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(84, 26);
            this.lb_DiaChi.TabIndex = 3;
            this.lb_DiaChi.Text = "Địa Chỉ";
            // 
            // btn_XoaDG
            // 
            this.btn_XoaDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_XoaDG.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_XoaDG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaDG.Location = new System.Drawing.Point(301, 18);
            this.btn_XoaDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XoaDG.Name = "btn_XoaDG";
            this.btn_XoaDG.Size = new System.Drawing.Size(104, 47);
            this.btn_XoaDG.TabIndex = 3;
            this.btn_XoaDG.Text = "Xóa";
            this.btn_XoaDG.UseVisualStyleBackColor = false;
            this.btn_XoaDG.Click += new System.EventHandler(this.btn_XoaDG_Click);
            // 
            // btb_Thoat
            // 
            this.btb_Thoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btb_Thoat.BackColor = System.Drawing.Color.Sienna;
            this.btb_Thoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_Thoat.Location = new System.Drawing.Point(1144, 572);
            this.btb_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btb_Thoat.Name = "btb_Thoat";
            this.btb_Thoat.Size = new System.Drawing.Size(104, 47);
            this.btb_Thoat.TabIndex = 2;
            this.btb_Thoat.Text = "Thoát";
            this.btb_Thoat.UseVisualStyleBackColor = false;
            this.btb_Thoat.Click += new System.EventHandler(this.btb_Thoat_Click);
            // 
            // btn_SuaDG
            // 
            this.btn_SuaDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SuaDG.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_SuaDG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaDG.Location = new System.Drawing.Point(178, 18);
            this.btn_SuaDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SuaDG.Name = "btn_SuaDG";
            this.btn_SuaDG.Size = new System.Drawing.Size(104, 47);
            this.btn_SuaDG.TabIndex = 1;
            this.btn_SuaDG.Text = "Sửa";
            this.btn_SuaDG.UseVisualStyleBackColor = false;
            this.btn_SuaDG.Click += new System.EventHandler(this.btn_SuaDG_Click);
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgaySinh.Location = new System.Drawing.Point(28, 138);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(109, 26);
            this.lb_NgaySinh.TabIndex = 2;
            this.lb_NgaySinh.Text = "Ngày Sinh";
            // 
            // lb_TenDG
            // 
            this.lb_TenDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_TenDG.AutoSize = true;
            this.lb_TenDG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenDG.Location = new System.Drawing.Point(24, 85);
            this.lb_TenDG.Name = "lb_TenDG";
            this.lb_TenDG.Size = new System.Drawing.Size(131, 26);
            this.lb_TenDG.TabIndex = 1;
            this.lb_TenDG.Text = "Tên Độc Giả";
            // 
            // lb_MaDG
            // 
            this.lb_MaDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_MaDG.AutoSize = true;
            this.lb_MaDG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaDG.Location = new System.Drawing.Point(28, 31);
            this.lb_MaDG.Name = "lb_MaDG";
            this.lb_MaDG.Size = new System.Drawing.Size(124, 26);
            this.lb_MaDG.TabIndex = 0;
            this.lb_MaDG.Text = "Mã Độc Giả";
            this.lb_MaDG.Click += new System.EventHandler(this.lb_MaDG_Click);
            // 
            // btn_ThemDG
            // 
            this.btn_ThemDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ThemDG.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_ThemDG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemDG.Location = new System.Drawing.Point(54, 18);
            this.btn_ThemDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThemDG.Name = "btn_ThemDG";
            this.btn_ThemDG.Size = new System.Drawing.Size(104, 47);
            this.btn_ThemDG.TabIndex = 0;
            this.btn_ThemDG.Text = "Thêm";
            this.btn_ThemDG.UseVisualStyleBackColor = false;
            this.btn_ThemDG.Click += new System.EventHandler(this.btn_ThemDG_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btn_XoaDG);
            this.panel2.Controls.Add(this.btn_SuaDG);
            this.panel2.Controls.Add(this.btn_ThemDG);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(843, 484);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 81);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.date_NgaySinhDG);
            this.panel1.Controls.Add(this.txt_TenDG);
            this.panel1.Controls.Add(this.txt_DiaChi);
            this.panel1.Controls.Add(this.txt_SDT);
            this.panel1.Controls.Add(this.txt_MaDG);
            this.panel1.Controls.Add(this.lb_SDT);
            this.panel1.Controls.Add(this.lb_DiaChi);
            this.panel1.Controls.Add(this.lb_NgaySinh);
            this.panel1.Controls.Add(this.lb_TenDG);
            this.panel1.Controls.Add(this.lb_MaDG);
            this.panel1.Location = new System.Drawing.Point(843, 176);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 304);
            this.panel1.TabIndex = 3;
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_Title.Location = new System.Drawing.Point(441, 65);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(447, 55);
            this.lb_Title.TabIndex = 12;
            this.lb_Title.Text = "QUẢN LÝ ĐỘC GIẢ";
            // 
            // frm_DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1377, 735);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.btb_Thoat);
            this.Controls.Add(this.dt_DG);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_DocGia";
            this.Text = "Độc Giả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_DocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_DG)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dt_DG;
        public System.Windows.Forms.DateTimePicker date_NgaySinhDG;
        public System.Windows.Forms.TextBox txt_TenDG;
        public System.Windows.Forms.TextBox txt_DiaChi;
        public System.Windows.Forms.TextBox txt_SDT;
        public System.Windows.Forms.TextBox txt_MaDG;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Label lb_DiaChi;
        public System.Windows.Forms.Button btn_XoaDG;
        public System.Windows.Forms.Button btb_Thoat;
        public System.Windows.Forms.Button btn_SuaDG;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.Label lb_TenDG;
        private System.Windows.Forms.Label lb_MaDG;
        public System.Windows.Forms.Button btn_ThemDG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lb_Title;
    }
}