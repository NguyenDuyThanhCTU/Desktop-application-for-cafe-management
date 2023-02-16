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
    public partial class UserControl_NgLieu : UserControl
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader rd;

        public UserControl_NgLieu()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                cmd = new SqlCommand("Select * From Kho where PhanLoai = N'Nguyên Liệu'", conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                DGV_NguyenLieu.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            btnCapNhat.Enabled = false;
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            Xuat_NhapKho_Form xuatnhap = new Xuat_NhapKho_Form();
            xuatnhap.Show();
            btnCapNhat.Enabled = true;
        }

        private void UserControl_NgLieu_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=RITA\\SQLEXPRESS;Initial Catalog = CAFE;User Id=sa;pwd=1234;");
            conn.Open();
            try
            {
                cmd = new SqlCommand("Select * From Kho where PhanLoai = N'Nguyên Liệu'", conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                DGV_NguyenLieu.DataSource = dt;
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
                worksheet.Name = "Danh sách nguyên liệu";

                for(int i = 0; i < DGV_NguyenLieu.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = DGV_NguyenLieu.Columns[i].HeaderText;

                }

                for(int i = 0; i < DGV_NguyenLieu.Rows.Count - 1; i++)
                {
                    for(int j = 0; j < DGV_NguyenLieu.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = DGV_NguyenLieu.Rows[i].Cells[j].Value.ToString();
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
            if(savefiledialog.ShowDialog() == DialogResult.OK)
            {
                ToExcel(savefiledialog.FileName);
            }
        }
    }
}
