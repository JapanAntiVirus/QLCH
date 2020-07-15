using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCuaHang
{
    public partial class SuaNCC : Form
    {
        public SuaNCC()
        {
            InitializeComponent();
        }
        public String mncc;

        private void SuaNCC_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnSua;
            string sql = "select MaNCC from NhaCungCap order by MaNCC";
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbbMaNCC.Items.Add(dr[0].ToString());
            }
            dr.Close();

            if (mncc != null)
            {
                this.cbbMaNCC.Text = mncc;
                this.cbbMaNCC.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SuaNCC", QLBH.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNCC", cbbMaNCC.Text));
                cmd.Parameters.Add(new SqlParameter("@HoTen", txtHoTen.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@SDT", txtSDT.Text));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", txtDiaChi.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select * from NhaCungCap where MaNCC={0}", cbbMaNCC.Text);
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            var dr = com.ExecuteReader();
            dr.Read();
            txtHoTen.Text = dr[1].ToString();
            txtSDT.Text = dr[2].ToString();
            txtDiaChi.Text = dr[3].ToString();
           
            dr.Close();
        }
    }
}
