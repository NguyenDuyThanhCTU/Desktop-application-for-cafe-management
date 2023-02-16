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
    public partial class Xuat_NhapKho_Form : Form
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        private Boolean Data = false;
        private int soluongdaco;


        public Xuat_NhapKho_Form()
        {
            InitializeComponent();
        }

        //xử lý xự kiện nút chọn nhập kho
        private void rbtnNK_CheckedChanged(object sender, EventArgs e)
        {
            txtMaVP.ReadOnly = true;
            txtTenVP.ReadOnly = false;
            cmbPhanLoai.Enabled = true;
            resetField();

        }

        //xử lý sự kiện load from
        private void NhapKho_Form_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Server = RITA\\SQLEXPRESS; Database = CAFE; User Id = sa; pwd = 1234");
                cmd = new SqlCommand("Select * from Kho;", conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btnLamMoi.Enabled = false;
        }

        //xử lý sự kiện nút xuất kho
        private void rbtnXK_CheckedChanged(object sender, EventArgs e)
        {
            txtTenVP.ReadOnly = true;
            txtMaVP.ReadOnly = false;;
            cmbPhanLoai.Enabled = false;
            resetField();
        }

        //xử lý sự kiện nút làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            resetField();
            if(rbtnNK.Checked == true)
            {
                txtTenVP.Focus();
            }
            else if(rbtnXK.Checked == true)
            {
                txtMaVP.Focus();
            }

            btnLamMoi.Enabled = false;
        }

        //xử lý sự kiện nút hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Data = false;
            this.Close();
        }

        //xử lý sự kiện load tên khi nhập mã nhân viên
        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            String sqlStr = "Select TenNV from NhanVien where MaNV = '" + txtMa.Text + "';";
            try
            {
                cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtTen.Text = sdr[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        //tạo ra mã vật phẩm theo từ loại 
        private String createMaVP(int so )
        {
            if (so < 10)
            {
                return "VP0" + so;
            }
            else return "VP" + so;
        }

        //lấy số lượng trong csdl để tạo mã vật phẩm mới
        private int getSL()
        {
            int so = 0;
            conn.Open();
            String sqlStr = "Select count(MaVP) from Kho;";
            try
            {
                cmd = new SqlCommand(sqlStr, conn);
                so = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            so++;
            conn.Close();
            return so;
        }

        //xử lý sự kiện nút xác nhận
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem đang chọn thao tác nhập kho hay xuất kho
            if(rbtnNK.Checked == true)
            {
                //Kiểm tra xem vật phẩm đã tồn tại trên csdl hay chưa. Trả về true nếu đã tồn tại
                if(Data == true)
                {
                    updateVP(numUpDow_SL.Value);
                }
                else
                {
                    insertVP();
                }
                //Lưu lịch sử nhập kho
                Luu_LSNK();
                MessageBox.Show("Vật phẩm được thêm vào kho thành công.");
            }
            else if(rbtnXK.Checked == true)
            {
                update_sl_VP(numUpDow_SL.Value);
                //Lưu lịch sử xuất kho
                Luu_LSXK();
                MessageBox.Show("Cập nhật lại kho thành công.");
            }
            btnLamMoi.Enabled = true;
        }

        //xử lý việc update vật phẩm đã có trong csdl
        private void updateVP(decimal sl)
        {
            conn.Open();
            String sqlStr1 = "select SoLuong from Kho where MaVP = '" + txtMaVP.Text + "';";
            try
            {
                cmd = new SqlCommand(sqlStr1, conn);
                soluongdaco =Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "o day ha");
            }

            String sqlStr2 = "Update Kho set SoLuong = " 
                        + (sl + soluongdaco) + " where MaVP = '" + txtMaVP.Text + "';";
            try
            {
                cmd = new SqlCommand(sqlStr2, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        //xử lý thêm vật phẩm mới vào csdl
        private void insertVP()
        {
            conn.Open();
            String sqlStr = "Insert into Kho values ('" + txtMaVP.Text + "', N'" + txtTenVP.Text + "', N'"
                            + cmbPhanLoai.Text + "', " + numUpDow_SL.Value + ", '" + DTPNgay.Text + "');"; 
            
            try
            {
                cmd = new SqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        //Lưu lại LS nhập kho vào csdl
        private void Luu_LSNK()
        {
            conn.Open();
            String sqlStr = "Insert into LSNhapKho values ('" + txtMa.Text + "', '" + txtMaVP.Text + "', '" 
                                + DTPNgay.Text + "', " + numUpDow_SL.Value + ");";
            try
            {
                cmd = new SqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        //Lưu lại LS xuất kho vào csdl
        private void Luu_LSXK()
        {
            conn.Open();
            String sqlStr = "Insert into LSXuatKho values ('" + txtMa.Text + "', '" + txtMaVP.Text + 
                            "', '" + DTPNgay.Text + "', " + numUpDow_SL.Value + ");";
            try
            {
                cmd = new SqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void resetField()
        {
            txtTenVP.Text = "";
            txtMaVP.Text = "";
            numUpDow_SL.Value = 1;
            cmbPhanLoai.Text = "";
        }

        //xử lý việc update vật phẩm đã có trong csdl
        private void update_sl_VP(decimal sl)
        {
            conn.Open();
            String sqlStr2 = "Update Kho set SoLuong = "
                        + (soluongdaco - sl) + "where MaVP = '" + txtMaVP.Text + "';";
            try
            {
                cmd = new SqlCommand(sqlStr2, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        //Setup maxmiximun  = số lượng đã có trên CSDL
        private void setupSL()
        {
            conn.Open();
            String sqlStr = "Select SoLuong from Kho where MaVP = '" + txtMaVP.Text + "';";
            try
            {
                cmd = new SqlCommand(sqlStr, conn);
                soluongdaco = Convert.ToInt32(cmd.ExecuteScalar());
                numUpDow_SL.Maximum = soluongdaco;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void txtMaVP_TextChanged(object sender, EventArgs e)
        {
            if(rbtnXK.Checked == true && txtMaVP.Text.Length >= 4)
            {
                conn.Open();
                int flag = 0;
                String sqlStr = "Select TenVP from Kho where MaVP = '" + txtMaVP.Text + "';";
                try
                {
                    cmd = new SqlCommand(sqlStr, conn);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        flag = 1;
                        txtTenVP.Text = sdr[0].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                if(flag == 0)
                {
                    MessageBox.Show("Vật phẩm không tồn tại trong kho.");
                }
                else
                {
                    setupSL();
                }
            }
        }

        private void txtTenVP_TextChanged(object sender, EventArgs e)
        {
            if(rbtnNK.Checked == true)
            {
                conn.Open();
                int flag = 0;
                String sqlStr = "Select MaVP from Kho where TenVP = '" + txtTenVP.Text + "';";
                try
                {
                    cmd = new SqlCommand(sqlStr, conn);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        flag = 1;
                        Data = true;
                        txtMaVP.Text = sdr[0].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                if(flag == 0)
                {
                    int so = getSL();
                    txtMaVP.Text = createMaVP(so);
                }
            }
        }
    }
}
