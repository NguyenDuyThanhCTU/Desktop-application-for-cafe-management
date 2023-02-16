using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form_NhanVien : Form
    {
        public Form_NhanVien()
        {
            InitializeComponent();
        }

        private void điểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_DiemDanh1.BringToFront();
        }

        private void danhsachcalamviectoolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_DSCLV1.BringToFront();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_DSNV1.BringToFront();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ThemMoiNV TM = new Form_ThemMoiNV();
            TM.Show();
        }
    }
}
