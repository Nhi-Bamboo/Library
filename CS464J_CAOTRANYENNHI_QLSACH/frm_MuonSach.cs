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
    public partial class frm_MuonSach : Form
    {
        public frm_MuonSach()
        {
            InitializeComponent();
        }
        ClassChung lopchung = new ClassChung();
        private void btb_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tms = MessageBox.Show("Bạn có thật sự muốn thoát !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tms == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_themmuon_Click(object sender, EventArgs e)
        {
            string sql = "Insert into MUONSACH values ('" + txt_MaMuonSach.Text + "',N'" 
                                                          + cb_MaDGMuon.SelectedValue.ToString() + "',N'" 
                                                          + cb_MaSachMuon.SelectedValue.ToString() + "',N'" 
                                                          + int.Parse(txt_SoLuong.Text) + "',N'" 
                                                          + date_NgayMuon.Value + "',N'" 
                                                          + date_NgayTra.Value + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Thêm thành công!!!");
            else MessageBox.Show("Thêm thất bại!!!");
            LoadMS();
        }

        private void btn_SuaMuon_Click(object sender, EventArgs e)
        {
            DialogResult sms = MessageBox.Show("Bạn có thật sự muốn sửa !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sms == DialogResult.Yes)
            {
                string sql = "Update MUONSACH set MaDG = N'" + cb_MaDGMuon.SelectedValue.ToString()
                                 + "', MaSach = N'" + cb_MaSachMuon.SelectedValue.ToString()
                                 + "', SoLuong = N'" + int.Parse(txt_SoLuong.Text)
                                 + "', NgayMuon = N'" + date_NgayMuon.Value
                                 + "', NgayTra = N'" + date_NgayTra.Value
                                 + "'where MaMS = '" + txt_MaMuonSach.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1)
                    MessageBox.Show("Sửa thành công!!!");
                else MessageBox.Show("Sửa thất bại!!!");
                LoadMS();
            }
            
        }

        private void btn_XoaMuon_Click(object sender, EventArgs e)
        {
            DialogResult xms = MessageBox.Show("Bạn có thật sự muốn xóa !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xms == DialogResult.Yes)
            {
                string sql = "Delete MUONSACH where MaMS = '" + txt_MaMuonSach.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1)
                    MessageBox.Show("Xoá thành công!!!");
                else MessageBox.Show("Xoá thất bại!!!");
                LoadMS();
            }
            
        }
        public void LoadMS()
        {

            string sqlMS = "Select * from MUONSACH";
            dt_MSach.DataSource = lopchung.LoadDL(sqlMS);
        }
        public void LoadCBMaDG()
        {
            string sql = "Select * from DOCGIA";
            cb_MaDGMuon.DataSource = lopchung.LoadDL(sql);
            cb_MaDGMuon.ValueMember = "MaDG";
            cb_MaDGMuon.DisplayMember = "TenDG";
        }
        public void LoadCBMaSach()
        {
            string sql = "Select * from SACH";
            cb_MaSachMuon.DataSource = lopchung.LoadDL(sql);
            cb_MaSachMuon.ValueMember = "MaSach";
            cb_MaSachMuon.DisplayMember = "TenSach";
        }

        private void frm_MuonSach_Load(object sender, EventArgs e)
        {
            LoadMS();
            LoadCBMaDG();
            LoadCBMaSach();
        }

        private void dt_MSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaMuonSach.Text = dt_MSach.CurrentRow.Cells[0].Value.ToString();
            cb_MaDGMuon.SelectedValue = dt_MSach.CurrentRow.Cells["MaDG"].Value.ToString();
            cb_MaSachMuon.SelectedValue = dt_MSach.CurrentRow.Cells["MaSach"].Value.ToString();
            txt_SoLuong.Text = dt_MSach.CurrentRow.Cells["SoLuong"].Value.ToString();
            date_NgayMuon.Text = dt_MSach.CurrentRow.Cells["NgayMuon"].Value.ToString();
            date_NgayTra.Text = dt_MSach.CurrentRow.Cells["NgayTra"].Value.ToString();
        }

    }
}
