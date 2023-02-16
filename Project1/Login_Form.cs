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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String name = txtUseName.Text;
            String pass = txtPass.Text;

            if (name == "Admin" && pass == "123")
            {
                Menu_Form menu = new Menu_Form();
                menu.Show();
                this.Visible = false;
            }
                

        }

        private void checkbox_GhiNho_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
