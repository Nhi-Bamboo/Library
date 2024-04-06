using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464J_CAOTRANYENNHI_QLSACH
{
    public partial class frm_DangNhap : Form
    {
        int dem;
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        ClassChung lopchung = new ClassChung();

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT (*) from TAIKHOAN where TaiKhoan = '" + txt_User.Text + "' and MatKhau = '" + txt_Pass.Text + "'";
            int kq = (int)lopchung.Scalar(sql);
            if (kq >= 1)
            {
                frm_Home main = new frm_Home();
                main.Show();
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                dem++;
                if (dem < 3)
                {
                    MessageBox.Show("Đăng nhập thất bại !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dem == 3)
                {
                    MessageBox.Show("Đăng nhập thất bại !!!\nBạn đã nhập sai 3 lan!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult tdn = MessageBox.Show("Bạn có thật sự muốn thoát !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tdn == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chk_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pass.PasswordChar = chk_hienmatkhau.Checked ? '\0' : '*';
        }
    }
}
