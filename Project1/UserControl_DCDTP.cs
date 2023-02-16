using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class UserControl_DCDTP : UserControl
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        public UserControl_DCDTP()
        {
            InitializeComponent();
        }

        private void UserControl_DCDTP_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server = RITA\\SQLEXPRESS; Database = CAFE; User Id = sa; pwd = 1234;");
            conn.Open();
            try
            {
                cmd = new SqlCommand("Select * From Kho where PhanLoai = N'Dụng Cụ Đựng Thành Phẩm';", conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                DGV_DCDTP.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            btnCapNhat.Enabled = false;
        }

        private void btnNhapXuatKho_Click(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            Xuat_NhapKho_Form xuatnhap = new Xuat_NhapKho_Form();
            xuatnhap.Show();
            btnCapNhat.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                cmd = new SqlCommand("Select * From Kho where PhanLoai = N'Dụng Cụ Đựng Thành Phẩm';", conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                DGV_DCDTP.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            btnCapNhat.Enabled = false;
        }

        private void ToExcel(String filename)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Danh sách DCDTP";

                for (int i = 0; i < DGV_DCDTP.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = DGV_DCDTP.Columns[i].HeaderText;

                }

                for (int i = 0; i < DGV_DCDTP.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < DGV_DCDTP.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = DGV_DCDTP.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(filename);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra file excel thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                ToExcel(savefiledialog.FileName);
            }
        }
    }
}
