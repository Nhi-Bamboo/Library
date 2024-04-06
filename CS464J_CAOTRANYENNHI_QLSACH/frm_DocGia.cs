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
    public partial class frm_DocGia : Form
    {
        public frm_DocGia()
        {
            InitializeComponent();
        }
        ClassChung lopchung = new ClassChung();
        private void btb_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tdg = MessageBox.Show("Bạn có thật sự muốn thoát !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tdg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_ThemDG_Click(object sender, EventArgs e)
        {
            string sql = "Insert into DOCGIA values ('" + txt_MaDG.Text + "',N'" 
                                                        + txt_TenDG.Text + "',N'" 
                                                        + date_NgaySinhDG.Value + "',N'" 
                                                        + txt_DiaChi.Text + "',N'" 
                                                        + int.Parse(txt_SDT.Text) + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Thêm độc giả thành công!!!");
            else MessageBox.Show("Thêm độc giả thất bại!!!");
            LoadDG();
        }

        private void btn_SuaDG_Click(object sender, EventArgs e)
        {
            DialogResult sdg = MessageBox.Show("Bạn có thật sự muốn sửa !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sdg == DialogResult.Yes)
            {
                string sql = "Update DOCGIA set TenDG = N'" + txt_TenDG.Text
                                    + "', NgaySinhDG = N'" + date_NgaySinhDG.Value
                                    + "', DiaChi = N'" + txt_DiaChi.Text
                                    + "', SDT = N'" + int.Parse(txt_SDT.Text)
                                    + "'where MaDG = '" + txt_MaDG.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1)
                    MessageBox.Show("Sửa độc giả thành công!!!");
                else MessageBox.Show("Sửa độc giả thất bại!!!");
                LoadDG();
            }
            
        }

        private void btn_XoaDG_Click(object sender, EventArgs e)
        {
            DialogResult xdg = MessageBox.Show("Bạn có thật sự muốn xóa !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xdg == DialogResult.Yes)
            {
                string sql = "Delete DOCGIA where MaDG = '" + txt_MaDG.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1)
                    MessageBox.Show("Xoá độc giả thành công!!!");
                else MessageBox.Show("Xoá độc giả thất bại!!!");
                LoadDG();
            }
            
        }
        public void LoadDG()
        {

            string sqlDG = "Select * from DOCGIA";
            dt_DG.DataSource = lopchung.LoadDL(sqlDG);
        }

        private void frm_DocGia_Load(object sender, EventArgs e)
        {
            LoadDG();
        }

        private void dt_DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaDG.Text = dt_DG.CurrentRow.Cells[0].Value.ToString();
            txt_TenDG.Text = dt_DG.CurrentRow.Cells["TenDG"].Value.ToString();
            date_NgaySinhDG.Text = dt_DG.CurrentRow.Cells["NgaySinhDG"].Value.ToString();
            txt_DiaChi.Text = dt_DG.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_SDT.Text = dt_DG.CurrentRow.Cells["SDT"].Value.ToString();
        }

        private void lb_MaDG_Click(object sender, EventArgs e)
        {

        }
    }
}
