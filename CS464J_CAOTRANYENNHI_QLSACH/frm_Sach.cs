using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS464J_CAOTRANYENNHI_QLSACH
{
    public partial class frm_Sach : Form
    {
        public frm_Sach()
        {
            InitializeComponent();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINH\\";
        ClassChung lopchung = new ClassChung();

        private void btn_ThemSach_Click(object sender, EventArgs e)
        {
            string sql = "Insert into SACH values ('" + txt_MaSach.Text + "',N'" 
                                                      + txt_TenSach.Text + "',N'" 
                                                      + cb_TLoai_Sach.SelectedValue.ToString()+ "',N'" 
                                                      + txt_TG_Sach.Text + "',N'" 
                                                      + float.Parse(txt_GiaThanh.Text) + "',N'"
                                                      + txt_HinhAnh.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            pic_anh.Image.Save(duongdan + txt_HinhAnh.Text);
            if (kq >= 1)
                MessageBox.Show("Thêm Sách thành công!!!");
            else MessageBox.Show("Thêm sách thất bại!!!");
            LoadSach();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thật sự muốn thoát !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (f == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_SuaSach_Click(object sender, EventArgs e)
        {
            DialogResult ss = MessageBox.Show("Bạn có thật sự muốn sửa !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ss == DialogResult.Yes)
            {
                string sql = "Update SACH set TenSach = N'" + txt_TenSach.Text
                                 + "', MaLoaiSach = N'" + cb_TLoai_Sach.SelectedValue.ToString()
                                 + "', TacGia = N'" + txt_TG_Sach.Text
                                 + "', GiaThanh = N'" + float.Parse(txt_GiaThanh.Text)
                                 + "', HinhAnh = N'" + txt_HinhAnh.Text
                                 + "'where MaSach = '" + txt_MaSach.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                pic_anh.Image.Save(duongdan + txt_HinhAnh.Text);
                if (kq >= 1)
                    MessageBox.Show("Sửa Sách thành công!!!");
                else MessageBox.Show("Sửa Sách thất bại!!!");
                LoadSach();
            }
            
        }

        private void btn_XoaSach_Click(object sender, EventArgs e)
        {
            DialogResult xs = MessageBox.Show("Bạn có thật sự muốn xóa sách !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xs == DialogResult.Yes)
            {
                string sql = "Delete SACH where MaSach = '" + txt_MaSach.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                File.Delete(duongdan + txt_HinhAnh.Text);
                if (kq >= 1)
                    MessageBox.Show("Xoá Sách thành công");
                else MessageBox.Show("Xoá Sách thất bại");
                LoadSach();
            }
            
        }
        public void LoadSach()
        {

            string sqlSach = "Select * from SACH";
            dt_Sach.DataSource = lopchung.LoadDL(sqlSach);
        }
        public void LoadCBTheLoai()
        {
            string sql = "Select * from THELOAI";
            cb_TLoai_Sach.DataSource = lopchung.LoadDL(sql);
            cb_TLoai_Sach.ValueMember = "MaLoaiSach";
            cb_TLoai_Sach.DisplayMember = "TenLoai";
        }

        private void frm_Sach_Load(object sender, EventArgs e)
        {
            LoadSach();
            LoadCBTheLoai();
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT(*) from SACH";
            int sosach = (int)lopchung.Scalar(sql);
            txt_Dem.Text = sosach.ToString();
        }
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string sql = "Select * From SACH Where TenSach Like N'%" + txt_tim.Text.Trim() + "%'";
            bool kq = lopchung.TimKiem(sql);
            if (kq)
                MessageBox.Show("Sau đây là Sách tìm được ");
            
            else MessageBox.Show("Không có sách cần tìm!!!");
            LoadSachTim();
        }
        public void LoadSachTim()
        {

            string sqlSach = "Select * From SACH Where TenSach Like N'%" + txt_tim.Text.Trim() + "%'";
            dt_Sach.DataSource = lopchung.LoadDL(sqlSach);
        }

        private void dt_Sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSach.Text = dt_Sach.CurrentRow.Cells[0].Value.ToString();
            txt_TenSach.Text = dt_Sach.CurrentRow.Cells["TenSach"].Value.ToString();
            cb_TLoai_Sach.SelectedValue = dt_Sach.CurrentRow.Cells["MaLoaiSach"].Value.ToString();
            txt_TG_Sach.Text = dt_Sach.CurrentRow.Cells["TacGia"].Value.ToString();
            txt_GiaThanh.Text = dt_Sach.CurrentRow.Cells["GiaThanh"].Value.ToString();
            txt_HinhAnh.Text = dt_Sach.CurrentRow.Cells["HinhAnh"].Value.ToString();
            pic_anh.ImageLocation = duongdan + txt_HinhAnh.Text;

        }

        private void pic_quaylai_Click(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void pic_anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Hãy chọn ảnh sách";
            open.Filter = "PNG|*.png|JPG|*.jpg|Tất cả|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pic_anh.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
