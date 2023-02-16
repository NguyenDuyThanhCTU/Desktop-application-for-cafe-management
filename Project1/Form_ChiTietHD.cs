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
    public partial class Form_ChiTietHD : Form
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        private String maHD;

        public Form_ChiTietHD()
        {
            InitializeComponent();
        }

        private void Form_ChiTietHD_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Server = RITA\\SQLEXPRESS; Database = CAFE; User Id = sa; pwd = 1234;");
                cmd = new SqlCommand("Select * from HoaDon", conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnXuatFile.Enabled = false;
            btnXF.Enabled = false;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sqlStr = "Select * from HoaDon where NgayLap = '" + DTPChonNgay.Text + "';";
            try
            {
                cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                DGV_DSHD.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            String sqlStr1 = "Select sum(DonGia) from HoaDon;";
            try
            {
                cmd = new SqlCommand(sqlStr1, conn);
                txtDoanhThu.Text = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            btnXuatFile.Enabled = true;
        }

        private void ChiTiet_CellClick(Object sender, DataGridViewCellEventArgs e)
        {
            maHD = null;

            DataGridViewRow row = new DataGridViewRow();
            row = DGV_DSHD.Rows[e.RowIndex];

            String mahd = Convert.ToString(row.Cells[0].Value);
            String manv = Convert.ToString(row.Cells[1].Value);
            String doanhthu = Convert.ToString(row.Cells[3].Value);

            maHD = mahd;

            GBoxChiTiet.Text = "Chi Tiết Của Hóa Đơn " + mahd;
            txtTTHD.Text = doanhthu;
            txtTen.Text = getNametoCSDL(manv);

            conn.Open();
            String sqlStr = "Select m.MaSP, m.TenSP, c.SoLuong, c.Gia from Menu_DoUong as m, ChiTietHD as c " +
                                "where m.MaSP = c.MaSP and MaHD = '" + mahd +"' order by m.MaSP";
            try
            {
                cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                DGV_ChiTiet.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            btnXF.Enabled = true;
        }

        private String getNametoCSDL(String manv)
        {
            String name = "";
            conn.Open();
            String sqlStr = "Select TenNV from NhanVien where MaNV = '" + manv +"';";
            try
            {
                cmd = new SqlCommand(sqlStr, conn);
                name = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            return name;
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                DSHDToExcel(save.FileName);
            }
        }

        private void DSHDToExcel(String fileName)
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
                worksheet.Name = "Danh Sách Hóa Đơn";

                //Thêm tiêu đề vào excel
                for (int i = 0; i < DGV_DSHD.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = DGV_DSHD.Columns[i].HeaderText;
                }

                //Thêm nội dung vào excel
                for (int i = 0; i < DGV_DSHD.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < DGV_DSHD.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = DGV_DSHD.Rows[i].Cells[j].Value.ToString();
                    }
                }

                int y = DGV_DSHD.ColumnCount + 2;

                worksheet.Cells[1, y] = "Hóa Đơn Của Ngày: ";
                worksheet.Cells[1, y + 1] = DTPChonNgay.Text;
                worksheet.Cells[2, y] = "Tổng Doanh Thu Trong Ngày:";
                worksheet.Cells[2, y + 1] = txtDoanhThu.Text;

                //Sử dụng phương thức SaveAs() để lưu workbook với fileName
                workbook.SaveAs(fileName);

                //Đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!!!");
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

        private void btnXF_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if(save.ShowDialog() == DialogResult.OK)
            {
                DSChiTietToExcel(save.FileName);
            }
        }

        private void DSChiTietToExcel(String fileName)
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
                worksheet.Name = "Danh Sách Hóa Đơn";

                //Thêm tiêu đề vào excel
                for (int i = 0; i < DGV_ChiTiet.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = DGV_ChiTiet.Columns[i].HeaderText;
                }

                //Thêm nội dung vào excel
                for (int i = 0; i < DGV_ChiTiet.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < DGV_ChiTiet.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = DGV_ChiTiet.Rows[i].Cells[j].Value.ToString();
                    }
                }

                int y = DGV_DSHD.ColumnCount + 2;

                worksheet.Cells[1, y] = "Mã Hóa Đơn: ";
                worksheet.Cells[1, y + 1] = maHD;
                worksheet.Cells[2, y] = "Người Thực Hiện:";
                worksheet.Cells[2, y + 1] = txtTen.Text;
                worksheet.Cells[3, y] = "Ngày Lập Hóa Đơn:";
                worksheet.Cells[3, y + 1] = DTPChonNgay.Text;
                worksheet.Cells[4, y] = "Tổng Tiền Của Hóa Đơn:";
                worksheet.Cells[4, y + 1] = txtTTHD.Text;

                //Sử dụng phương thức SaveAs() để lưu workbook với fileName
                workbook.SaveAs(fileName);

                //Đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!!!");
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
