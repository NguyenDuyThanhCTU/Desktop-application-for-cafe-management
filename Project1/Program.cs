using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Login());
            //Application.Run(new Form_ThemMoiNV());
            //Application.Run(new NhapKho_Form());
            //Application.Run(new Form_NhanVien());
            //Application.Run(new Form_HoaDon());
            //Application.Run(new Form_InHD());
            //Application.Run(new Form_ChiTietHD());

        }
    }
}
