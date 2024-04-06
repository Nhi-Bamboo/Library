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
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void loạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_LoaiSach"] == null)
            {
                frm_LoaiSach ls = new frm_LoaiSach();
                ls.MdiParent = this;
                ls.Show();
            }
            else Application.OpenForms["frm_LoaiSach"].Activate();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Sach"] == null)
            {
                frm_Sach s = new frm_Sach();
                s.MdiParent = this;
                s.Show();
            }
            else Application.OpenForms["frm_Sach"].Activate();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DocGia"] == null)
            {
                frm_DocGia dg = new frm_DocGia();
                dg.MdiParent = this;
                dg.Show();
            }
            else Application.OpenForms["frm_DocGia"].Activate();
        }

        private void mượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_MuonSach"] == null)
            {
                frm_MuonSach ms = new frm_MuonSach();
                ms.MdiParent = this;
                ms.Show();
            }
            else Application.OpenForms["frm_MuonSach"].Activate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ttc = MessageBox.Show("Thoát Chương Trình !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ttc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
