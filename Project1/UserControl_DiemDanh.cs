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
    public partial class UserControl_DiemDanh : UserControl
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        private String ten;
        private String SDT;
        private String calam;
        private String ngay;
        private String ma;

        public UserControl_DiemDanh()
        {
            InitializeComponent();
        }

        private void UserControl_DiemDanh_Load(object sender, EventArgs e)
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
            btnLuuTru.Enabled = false;
            btnXuatFile.Enabled = false;
            btnDiemDanh.Enabled = false;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Select TenNV, SDT from NhanVien where MaNV = '" + txtMaNV.Text + "';", conn);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ten = rd.GetString(0);
                    SDT = rd.GetString(1);
                }
                txtHoTen.Text = ten;
                btnDiemDanh.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            conn.Close();
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            String Ma = txtMaNV.Text;
            String Ten = txtHoTen.Text;
            String CaLV = cbo_CaLV.Text;
            String NgayLV = DTP_Ngaylamviec.Text;

            DGV_BangCLV.Rows.Add(Ma, Ten, SDT, CaLV, NgayLV);

            resetFiled();
            btnLuuTru.Enabled = true;
            btnXuatFile.Enabled = true;
            btnDiemDanh.Enabled = false;
        }

        private void resetFiled()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            cbo_CaLV.Text = "";
            SDT = null;
            ten = "";
            txtMaNV.Focus();
        }

        private void ChinhSua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = DGV_BangCLV.Rows[e.RowIndex];

            String ma = Convert.ToString(row.Cells[0].Value);
            String calv = Convert.ToString(row.Cells[3].Value);
            String ngay = Convert.ToString(row.Cells[4].Value);

            txtMaNV.Text = ma;
            cbo_CaLV.Text = calv;
            DTP_Ngaylamviec.Text = ngay;

            DGV_BangCLV.Rows.RemoveAt(DGV_BangCLV.CurrentRow.Index);
            
        }

        private void btnLuuTru_Click(object sender, EventArgs e)
        {
            conn.Open();
            for(int i = 0; i < DGV_BangCLV.Rows.Count - 1; i++)
            {
                ma = DGV_BangCLV.Rows[i].Cells[0].Value.ToString();
                ten = DGV_BangCLV.Rows[i].Cells[1].Value.ToString();
                SDT = DGV_BangCLV.Rows[i].Cells[2].Value.ToString();
                calam = DGV_BangCLV.Rows[i].Cells[3].Value.ToString();
                ngay = DGV_BangCLV.Rows[i].Cells[4].Value.ToString();

                String sqlStr = "Insert into CaLamViec values ('" + ma + "', N'" + ten + "', '" + SDT + "', N'" + calam + "', '" + ngay + "');";
                try
                {
                    cmd = new SqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            MessageBox.Show("Đã lưu trữ các ca làm việc của ngày hôm nay thành công!!!");
            DGV_BangCLV.Rows.Clear();
            lblLuutru.Text = DateTime.Now.ToString();
            btnLuuTru.Enabled = false;
            conn.Close();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            if(savefiledialog.ShowDialog() == DialogResult.OK)
            {
                ToExcel(savefiledialog.FileName);
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
                worksheet.Name = "Ca làm việc";

                //Thêm tiêu đề vào excel
                for (int i = 0; i < DGV_BangCLV.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = DGV_BangCLV.Columns[i].HeaderText;
                }

                //Thêm nội dung vào excel 
                for (int i = 0; i < DGV_BangCLV.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < DGV_BangCLV.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = DGV_BangCLV.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(fileName);

                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra file excel thành công!!!");
                btnXuatFile.Enabled = false;
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
