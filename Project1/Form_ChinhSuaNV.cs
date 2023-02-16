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
    public partial class Form_ChinhSuaNV : Form
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        private int GT;

        public Form_ChinhSuaNV()
        {
            InitializeComponent();
        }

        private void Form_ChinhSuaNV_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server = RITA\\SQLEXPRESS; Database = CAFE; User Id = sa; pwd = 1234");
            cmd = new SqlCommand("Select * from NhanVien", conn);
            conn.Open();
            btnXacNhan.Enabled = false;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            String sqlStr = "Select * from NhanVien where MaNV = '" + txtMaNV.Text + "';";
            cmd = new SqlCommand(sqlStr, conn);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtTenNV.Text = dr.GetString(1);
                    txtSDT.Text = dr.GetString(3);
                    cmbChucVU.Text = dr.GetString(4);
                    txtDiaChi.Text = dr.GetString(5);
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            btnXacNhan.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            String sqlStr = "Update NhanVien set TenNV = N'" + txtTenNV.Text + "', GT = "
                        + GT + ", SDT = '" + txtSDT.Text + "', ChucVu = N'" + cmbChucVU.Text
                            + "', DiaChi = N'" + txtDiaChi.Text + "' where MaNV = '" + txtMaNV.Text + "';";
            DialogResult mess = MessageBox.Show("Xác nhận thông tin đã nhập đúng?","Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(mess == DialogResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhật thông tin thành công.");
                    resetField();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }    
        }

        private void cmbGT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGT.SelectedItem.ToString() == "Nam")
            {
                GT = 1;
            }
            else if(cmbGT.SelectedItem.ToString() == "Nữ")
            {
                GT = 0;
            }
        }

        private void resetField()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            btnXacNhan.Enabled = false;
        }
    }
}
