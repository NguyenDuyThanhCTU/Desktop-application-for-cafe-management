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
    public partial class UserControl_DSCLV : UserControl
    {

        private SqlConnection conn;
        private SqlCommand cmd;


        public UserControl_DSCLV()
        {
            InitializeComponent();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            if(savefiledialog.ShowDialog() == DialogResult.OK)
            {
                ToExcel(savefiledialog.FileName);
            }
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            conn.Open();
            String value = DTP_ChonNgay.Text;
            try
            {
                cmd = new SqlCommand("Select * from CaLamViec where NgayLV = '" + value + "';", conn);

                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                conn.Close();
                DGV_BangDS.DataSource = dt;
                btnXuatFile.Enabled = true;

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserControl_DSCLV_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Server = RITA\\SQLEXPRESS; Database = CAFE; User Id = sa; pwd = 1234;");
                cmd = new SqlCommand("Select * from CaLamViec;", conn);
                btnXuatFile.Enabled = false;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToExcel(String fileName)
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
                worksheet.Name = "Danh Sách Ca Làm Việc";

                for(int i = 0; i < DGV_BangDS.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = DGV_BangDS.Columns[i].HeaderText;
                }

                for(int i = 0; i < DGV_BangDS.Rows.Count - 1; i++)
                {
                    for(int j = 0; j < DGV_BangDS.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = DGV_BangDS.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(fileName);

                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra file Excel thành công !!!");
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
    }
}
