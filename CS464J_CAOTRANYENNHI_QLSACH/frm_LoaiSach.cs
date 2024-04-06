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
    public partial class frm_LoaiSach : Form
    {
        public frm_LoaiSach()
        {
            InitializeComponent();
        }
        ClassChung lopchung = new ClassChung();

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tls = MessageBox.Show("Bạn có thật sự muốn thoát !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tls == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_SuaTL_Click(object sender, EventArgs e)
        {
            DialogResult sls = MessageBox.Show("Bạn có thật sự muốn sửa !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sls == DialogResult.Yes)
            {
                string sql = "Update THELOAI set Tenloai = N'" + txt_TenTL.Text + "'where MaLoaiSach = '" + txt_MaTL.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1)
                    MessageBox.Show("Sửa loại sách thành công!!!");
                else MessageBox.Show("Sửa loại sách thất bại!!!");
                LoadLS();
            }
            
        }

        private void btn_ThemTL_Click(object sender, EventArgs e)
        {
            string sql = "Insert into THELOAI values ('" + txt_MaTL.Text + "',N'" + txt_TenTL.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Thêm loại sách thành công!!!");
            else MessageBox.Show("Thêm loại sách thất bại!!!");
            LoadLS();
        }

        private void btn_XoaTL_Click(object sender, EventArgs e)
        {
            DialogResult xls = MessageBox.Show("Bạn có thật sự muốn xóa !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xls == DialogResult.Yes)
            {
                string sql = "Delete THELOAI where MaLoaiSach = '" + txt_MaTL.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1)
                    MessageBox.Show("Xoá loại sách thành công!!!");
                else MessageBox.Show("Xoá loại sách thất bại!!!");
                LoadLS();
            }
            
        }
        public void LoadLS()
        {

            string sqlLS = "Select * from THELOAI";
            dt_TheLoai.DataSource = lopchung.LoadDL(sqlLS);
        }

        private void frm_LoaiSach_Load(object sender, EventArgs e)
        {
            LoadLS();
        }

        private void dt_TheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaTL.Text = dt_TheLoai.CurrentRow.Cells[0].Value.ToString();
            txt_TenTL.Text = dt_TheLoai.CurrentRow.Cells["TenLoai"].Value.ToString();
        }
    }
}
