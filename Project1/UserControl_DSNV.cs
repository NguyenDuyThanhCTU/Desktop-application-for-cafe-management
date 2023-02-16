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
    public partial class UserControl_DSNV : UserControl
    {

        private SqlConnection conn;
        private SqlCommand cmd;

        public UserControl_DSNV()
        {
            InitializeComponent();
        }

        private void UserControl_DSNV_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Server = RITA\\SQLEXPRESS; Initial Catalog = CAFE; User Id = sa; pwd = 1234;");
                cmd = new SqlCommand("Select * from NhanVien", conn);
 //              conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            btnXuatFile.Enabled = false;
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            conn.Open();

            String value = cmbHienThi.SelectedItem.ToString();

            if(value.Equals("Tất Cả"))
            {
                cmd = new SqlCommand("Select * from NhanVien", conn);
            }
            else
            {
                cmd = new SqlCommand("Select * from NhanVien where ChucVu = N'" + value + "';", conn);
            }

            //Chuyển dữ liệu về data
            SqlDataAdapter data = new SqlDataAdapter(cmd);

            //Tạo kho ảo để lưu trữ dữ liệu
            DataTable dt = new DataTable();

            //Đỗ dữ liệu vào kho
            data.Fill(dt);

            conn.Close();

            //Đõ dữ liệu vào Bảng DataGirdViews
            DGV_BangDS.DataSource = dt;

            btnXuatFile.Enabled = true;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            Form_ChinhSuaNV cs = new Form_ChinhSuaNV();
            cs.Show();
        }

        private void ToExcel(String fileName)
        {
            //Khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                //Tạo đối tượng COM
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                //Tạo mới workbook bằng phương thức Add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];

                //Đặt tên cho sheet
                worksheet.Name = "Quản lý nhân viên";

                //Thêm tiêu đề vào excel
                for(int i = 0; i < DGV_BangDS.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = DGV_BangDS.Columns[i].HeaderText;
                }

                //Thêm nội dung vào excel
                for(int i = 0; i < DGV_BangDS.Rows.Count - 1; i++)
                {
                    for(int j = 0; j < DGV_BangDS.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = DGV_BangDS.Rows[i].Cells[j].Value.ToString();
                    }
                }

                //Sử dụng phương thức SaveAs() để lưu workbook với fileName
                workbook.SaveAs(fileName);

                //Đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!!!");
            }
            catch(Exception ex)
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
