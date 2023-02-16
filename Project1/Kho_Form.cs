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
    public partial class Kho_Form : Form
    {
        public Kho_Form()
        {
            InitializeComponent();
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_NgLieu1.BringToFront();

        }

        private void dụngCụPhaChếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_DCPC1.BringToFront();
        }

        private void dụngCụĐựngThànhPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl_DCDTP1.BringToFront();
        }

        private void nhậpKhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            userControl_LSNK1.BringToFront();

        }

        private void xuấtKhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            userControl_LSXK1.BringToFront();
        }

        private void Menu_VP_Click(object sender, EventArgs e)
        {

        }

        private void userControl_NgLieu1_Load(object sender, EventArgs e)
        {

        }

        private void userControl_DCPC1_Load(object sender, EventArgs e)
        {

        }

        private void userControl_DCDTP1_Load(object sender, EventArgs e)
        {

        }

        private void userControl_LSNK1_Load(object sender, EventArgs e)
        {

        }

        private void userControl_LSXK1_Load(object sender, EventArgs e)
        {

        }

        private void userControl_NgLieu1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
