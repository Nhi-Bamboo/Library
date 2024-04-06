namespace CS464J_CAOTRANYENNHI_QLSACH
{
    partial class frm_DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.lb_Pass = new System.Windows.Forms.Label();
            this.lb_User = new System.Windows.Forms.Label();
            this.chk_hienmatkhau = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(340, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 57);
            this.label1.TabIndex = 13;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Exit.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(493, 339);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(113, 44);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Login.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Login.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(347, 339);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(116, 44);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Pass.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(347, 283);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(259, 39);
            this.txt_Pass.TabIndex = 10;
            // 
            // txt_User
            // 
            this.txt_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_User.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(348, 229);
            this.txt_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(257, 39);
            this.txt_User.TabIndex = 9;
            // 
            // lb_Pass
            // 
            this.lb_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Pass.AutoSize = true;
            this.lb_Pass.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pass.ForeColor = System.Drawing.Color.Black;
            this.lb_Pass.Location = new System.Drawing.Point(200, 289);
            this.lb_Pass.Name = "lb_Pass";
            this.lb_Pass.Size = new System.Drawing.Size(121, 33);
            this.lb_Pass.TabIndex = 8;
            this.lb_Pass.Text = "Password";
            // 
            // lb_User
            // 
            this.lb_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_User.AutoSize = true;
            this.lb_User.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.ForeColor = System.Drawing.Color.Black;
            this.lb_User.Location = new System.Drawing.Point(200, 235);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(130, 33);
            this.lb_User.TabIndex = 7;
            this.lb_User.Text = "UserName";
            // 
            // chk_hienmatkhau
            // 
            this.chk_hienmatkhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_hienmatkhau.AutoSize = true;
            this.chk_hienmatkhau.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_hienmatkhau.Location = new System.Drawing.Point(628, 287);
            this.chk_hienmatkhau.Name = "chk_hienmatkhau";
            this.chk_hienmatkhau.Size = new System.Drawing.Size(198, 37);
            this.chk_hienmatkhau.TabIndex = 14;
            this.chk_hienmatkhau.Text = "Hiện mật khẩu";
            this.chk_hienmatkhau.UseVisualStyleBackColor = true;
            this.chk_hienmatkhau.CheckedChanged += new System.EventHandler(this.chk_hienmatkhau_CheckedChanged);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1025, 586);
            this.Controls.Add(this.chk_hienmatkhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.lb_Pass);
            this.Controls.Add(this.lb_User);
            this.Name = "frm_DangNhap";
            this.Text = "Đăng Nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_Exit;
        public System.Windows.Forms.Button btn_Login;
        public System.Windows.Forms.TextBox txt_Pass;
        public System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label lb_Pass;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.CheckBox chk_hienmatkhau;
    }
}

