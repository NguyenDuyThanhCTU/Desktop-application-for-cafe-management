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
    public partial class Menu_Form : Form
    {
        public Menu_Form()
        {
            InitializeComponent();
        }

        private void Menu_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Form_NhanVien nv = new Form_NhanVien();
            nv.Show();
        }

        private void btnQLKho_Click(object sender, EventArgs e)
        {
            Kho_Form kho = new Kho_Form();
            kho.Show();
        }

        private void btnTongket_Click(object sender, EventArgs e)
        {
            Form_HoaDon hd = new Form_HoaDon();
            hd.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            login.Show();
            this.Visible = false;
        }
    }
}
