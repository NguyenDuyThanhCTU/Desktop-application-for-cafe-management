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
    public partial class Form_DSSP : Form
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        private int flag = 0;

        public Form_DSSP()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            gBoxThemMoi.Visible = true;
            txtMa.Text = createMaSP(getSL());
            btnLoad.Enabled = true;
        }

        private void Form_DSSP_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server = RITA\\SQLEXPRESS; Database = CAFE; User Id = sa; pwd = 1234");
            conn.Open();

            try
            {
                cmd = new SqlCommand("Select * from Menu_DoUong;", conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                DGV_Menu.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            btnLoad.Enabled = false;
            btnCapNhat.Enabled = false;
            gBoxChinhSua.Visible = false;
            gBoxThemMoi.Visible = false;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            gBoxChinhSua.Visible = true;
            flag = 1;
            btnLoad.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sqlStr = "Update Menu_DoUong set TenSP = N'" + txtTenSP.Text + "', Gia = " + Convert.ToDecimal(txtGia.Text)
                           + "where MaSP = '" + txtMaSP.Text + "';";
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
            MessageBox.Show("Cập nhật sản phẩm thành công.");
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGia.Text = "";
            btnCapNhat.Enabled = false;
        }

        private int getSL()
        {
            int so = 0;
            conn.Open();
            String sqlStr = "Select count(MaSP) from Menu_DoUong;";
            try
            {
                cmd = new SqlCommand(sqlStr, conn);
                so = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            so++;
            conn.Close();
            return so;
        }

        private String createMaSP(int so)
        {
            if (so < 10)
            {
                return "SP0" + so;
            }
            else return "SP" + so;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sqlStr = "Insert into Menu_DoUong values ('" + txtMa.Text + "', N'" + txtTen.Text
                    + "', " + Convert.ToDecimal(txtDonGia.Text) + ");";
            try
            {
                cmd = new SqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Thêm sản phẩm thành công.");
            conn.Close();
            txtTen.Text = "";
            txtDonGia.Text = "";
            txtMa.Text = createMaSP(getSL());
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sqlStr = "Select * from Menu_DoUong;";
            try
            {
                cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                DGV_Menu.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void ChinhSua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == 1)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = DGV_Menu.Rows[e.RowIndex];

                String ma = Convert.ToString(row.Cells[0].Value);
                String ten = Convert.ToString(row.Cells[1].Value);
                String gia = Convert.ToString(row.Cells[2].Value);

                txtMaSP.Text = ma;
                txtTenSP.Text = ten;
                txtGia.Text = gia;

                btnCapNhat.Enabled = true;
            }
        }
    }
}
