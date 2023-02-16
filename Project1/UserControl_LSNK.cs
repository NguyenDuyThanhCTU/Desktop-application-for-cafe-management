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
    public partial class UserControl_LSNK : UserControl
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        private String manv;
        private String ngay;
        private String tennv;


        public UserControl_LSNK()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Boolean check = Check_CSDL();
            if(check == true)
            {
                txtMa.Text = manv;
                txtTen.Text = tennv;
                txtNgay.Text = ngay;

                conn.Open();
                String sqlStr = "Select LSNhapKho.MaVP, TenVP, LSNhapKho.SoLuong from LSNhapKho, Kho " +
                            "where LSNhapKho.MaVP = Kho.MaVP and LSNhapKho.MaNV = '" + manv + "' and NgayTH = '" + ngay + "';";
                try
                {
                    cmd = new SqlCommand(sqlStr, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    DGV_LSNhapKho.DataSource = dt;
                    gBoxContain.Text = "Lịch Sử Nhập Kho Ngày: " + ngay;
                    gBoxContain.Visible = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Không có lịch sử nhập kho của Nhân Viên " + manv + " vào ngày: " + ngay);
            }
        }

        private Boolean Check_CSDL()
        {
            conn.Open();
            manv = txtMaNV.Text;
            ngay = DTP_ChonNgay.Text;
            int flag = 0;
            String sqlStr = "Select TenNV from LSNhapKho, NhanVien where LSNhapKho.MaNV = NhanVien.MaNV and LSNhapKho.MaNV = '"
                        + manv + "' and NgayTH = '" + ngay + "';";
            try
            {
                cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    flag = 1;
                    tennv = rd.GetString(0);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            if (flag == 0)
                return false;
            return true;
        }

        private void UserControl_LSNK_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Server = RITA\\SQLEXPRESS; Database = CAFE; User Id = sa; pwd = 1234;");
                cmd = new SqlCommand("Select * from LSNhapKho", conn);
                gBoxContain.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                worksheet.Name = "Lịch Sử Nhập Kho";

                for(int i = 0; i < DGV_LSNhapKho.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = DGV_LSNhapKho.Columns[i].HeaderText;
                }

                for(int i = 0; i < DGV_LSNhapKho.Rows.Count - 1; i++)
                {
                    for(int j = 0; j < DGV_LSNhapKho.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = DGV_LSNhapKho.Rows[i].Cells[j].Value.ToString();
                    }
                }

                int y = DGV_LSNhapKho.ColumnCount + 2;

                worksheet.Cells[1, y] = "Thông tin người thực hiện: ";
                worksheet.Cells[2, y] = "Mã Nhân Viên:";
                worksheet.Cells[2, y + 1] = txtMa.Text;
                worksheet.Cells[3, y] = "Tên Nhân Viên:";
                worksheet.Cells[3, y + 1] = txtTen.Text;
                worksheet.Cells[4, y] = "Ngày Thực Hiện:";
                worksheet.Cells[4, y + 1] = txtNgay.Text;

                workbook.SaveAs(filename);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất file ra excel thành công.");

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
