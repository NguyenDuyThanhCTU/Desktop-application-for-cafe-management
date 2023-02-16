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
    public partial class Form_ThemMoiNV : Form
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        private int so;
        private int GT;

        public Form_ThemMoiNV()
        {
            InitializeComponent();
        }

        private void Form_ThemMoiNV_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Server = RITA\\SQLEXPRESS; Initial Catalog = CAFE; User Id = sa; pwd = 1234;");
                cmd = new SqlCommand("Select * from NhanVien", conn);
                conn.Open();
                btnLamMoi.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            setup_txtMaNV(cmd, conn, so);
        }

        private String setMA(int so)
        {
            String ma;
            so++;
            if (so < 10)
            {
                ma = "NV0" + so;
            }
            else ma = "NV" + so;

            return ma;
        }

        private void setup_txtMaNV(SqlCommand cmd, SqlConnection conn,int so)
        {
            cmd = new SqlCommand("Select COUNT(MaNV) from NhanVien", conn);
            try
            {
                so = Convert.ToInt32(cmd.ExecuteScalar());
                txtMaNV.Text = setMA(so);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            String SqlString = "Insert into NhanVien values('" + txtMaNV.Text + "', N'" +
                                txtTenNV.Text + "', " + GT + ", '" + txtSDT.Text + "', N'"
                                + cmbChucVU.Text + "', N'" + txtDiaChi.Text + "');";
            DialogResult dlr = MessageBox.Show("Xác nhận các thông tin đã được nhập đúng?", "Thông Báo"
                                                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlr == DialogResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand(SqlString, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thông tin đã được thêm vào!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            btnLamMoi.Enabled = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cmbGT.Text = "";
            txtSDT.Text = "";
            cmbChucVU.Text = "";
            txtDiaChi.Text = "";
            setup_txtMaNV(cmd, conn, so);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
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
    }
}
