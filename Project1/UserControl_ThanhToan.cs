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
    public partial class UserControl_ThanhToan : UserControl
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private decimal soban = 1;
        private String masp;
        private decimal sl = 1;
        private decimal gia;
        private double tongcong = 0;

        public UserControl_ThanhToan()
        {
            InitializeComponent();
        }

        private void UserControl_ThanhToan_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server = RITA\\SQLEXPRESS; Database = CAFE; User Id = sa; pwd = 1234;");
            conn.Open();
            try
            {
                cmd = new SqlCommand("Select TenSP from Menu_DoUong", conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cmbTenSP.Items.Add(rd.GetString(0));
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " o day hay gi");
            }
            conn.Close();
            btnTaoHD.Enabled = false;
            btnXoa.Enabled = false;
            btnXuatHD.Enabled = false;
            btnSave.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void danhSáchSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DSSP dssp = new Form_DSSP();
            dssp.Show();
        }

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
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void cmbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            String sqlStr = "Select MaSP, Gia from Menu_DoUong where TenSP = N'" + cmbTenSP.Text + "';";
            try
            {
                cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    masp = rd.GetString(0);
                    gia = rd.GetDecimal(1);
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMa.Text == "")
            {
                MessageBox.Show("Mã người thực hiện không được bỏ trống !!!");
            }
            else
            {
                btnTaoHD.Enabled = true;
                decimal giaban = gia;
                if (cmbKC.Text == "Size L")
                {
                    giaban = gia + 3000;
                }
                double tien =(double)(giaban * sl);
                tongcong += tien;
                DGVSP.Rows.Add(masp, cmbTenSP.Text, cmbKC.Text, giaban, sl, tien);
            }
            
        }

        private void ChinhSua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = DGVSP.Rows[e.RowIndex];

            String tensp = Convert.ToString(row.Cells[1].Value);
            String size = Convert.ToString(row.Cells[2].Value);
            String sl = Convert.ToString(row.Cells[4].Value);
            String tt = Convert.ToString(row.Cells[5].Value);

            cmbTenSP.Text = tensp;
            cmbKC.Text = size;
            NUDsl.Value = Convert.ToDecimal(sl);
            tongcong -= Convert.ToDouble(tt);

            DGVSP.Rows.RemoveAt(DGVSP.CurrentRow.Index);

        }

        private void NUDsl_ValueChanged(object sender, EventArgs e)
        {
            sl = NUDsl.Value;
        }

        private void numBan_ValueChanged(object sender, EventArgs e)
        {
            soban = numBan.Value;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DGVSP.Rows.Clear();
            btnXoa.Enabled = false;
            cmbTenSP.Text = "";
            cmbKC.Text = "";
            numBan.Value = 1;
            NUDsl.Value = 1;
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = createMaHD(getSL());
            txtTongCong.Text = tongcong.ToString();
            txtThanhTien.Text = (tongcong - (tongcong * ((double)(numChietKhau.Value) / 100))).ToString();
            btnTaoHD.Enabled = false;
            btnSave.Enabled = true;
            btnXuatHD.Enabled = true;
            btnHuy.Enabled = true;
            txtTienKhach.Focus();
        }

        private int getSL()
        {
            int so = 0;
            conn.Open();
            String sqlStr = "Select count(MaHD) from HoaDon;";
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

        private String createMaHD(int so)
        {
            if (so < 10)
            {
                return "HD0" + so + " - " + txtMa.Text + " - " + soban;
            }
            else return "HD" + so + " - " + txtMa.Text + " - " + soban;
        }

        private void txtTienKhach_TextChanged(object sender, EventArgs e)
        {
            if(txtTienKhach.Text.Length >= 5)
            {
                double thanhtien = Convert.ToDouble(txtThanhTien.Text);
                double tienkhach = Convert.ToDouble(txtTienKhach.Text);
                txtTienThua.Text = (tienkhach - thanhtien).ToString();
            }
        }

        private void numChietKhau_ValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (tongcong - (tongcong * ((double)(numChietKhau.Value) / 100))).ToString();

        }

        private void resetField()
        {
            txtTongCong.Text = "";
            txtThanhTien.Text = "";
            numChietKhau.Value = 0;
            txtTienKhach.Text = "";
            txtTienThua.Text = "";
            txtMaHD.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn hủy hóa đơn này ?.", "Thông Báo"
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                resetField();
                btnXoa.Enabled = true;
                btnSave.Enabled = false;
                btnXuatHD.Enabled = false;
                btnTaoHD.Enabled = true;
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LuuHD();
            LuuCT_HD();
            MessageBox.Show("Hóa đơn và chi tiết của hóa đơn đã được lưu.");
            resetField();
            btnXoa.Enabled = true;
            btnXuatHD.Enabled = true;
            btnSave.Enabled = false;
            tongcong = 0;
        }

        private void LuuCT_HD()
        {
            String mahd = txtMaHD.Text;
            conn.Open();
            for(int i = 0; i < DGVSP.Rows.Count - 1; i++)
            {
                String masp = DGVSP.Rows[i].Cells[0].Value.ToString();
                String sl = DGVSP.Rows[i].Cells[4].Value.ToString();
                String gia = DGVSP.Rows[i].Cells[3].Value.ToString();
                //MessageBox.Show(mahd + ", " + masp + ", " + sl + ", " + gia);

                String sqlStr = "Insert into ChiTietHD values ('" + mahd + "', '" + masp +
                        "', " + Convert.ToInt32(sl) + ", " + Convert.ToDecimal(gia) + ");";
                try
                {
                    cmd = new SqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            conn.Close();
        }

        private void LuuHD()
        {
            conn.Open();
            String sqlStr = "Insert into HoaDon values ('" + txtMaHD.Text + "', '" + txtMa.Text
                        + "', '" + DTPChonNgay.Text + "', " + Convert.ToDecimal(txtThanhTien.Text) +");";
            try
            {
                cmd = new SqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ChiTietHD chitiet = new Form_ChiTietHD();
            chitiet.Show();
        }
    }
}
