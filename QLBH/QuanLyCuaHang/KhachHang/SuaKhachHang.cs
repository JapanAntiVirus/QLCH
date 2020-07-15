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

namespace QuanLyCuaHang
{
    public partial class SuaKhachHang : Form
    {
        public SuaKhachHang()
        {
            InitializeComponent();
        }
        public String mkh;

        private void SuaKhachHang_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnSua;
            dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
            string sql = "select MaKhach from KhachHang order by MaKhach";
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbbMaKhach.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cbbGioiTinh.Items.Add("nam");
            cbbGioiTinh.Items.Add("nữ");
            cbbGioiTinh.SelectedIndex = 0;

            if (mkh != null)
            {
                this.cbbMaKhach.Text = mkh;
                this.cbbMaKhach.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SuaKhachHang", QLBH.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaKhach", cbbMaKhach.Text));
                cmd.Parameters.Add(new SqlParameter("@HoDem", txtHoDem.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Ten", txtTen.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", cbbGioiTinh.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", txtSDT.Text));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", dtpNgaySinh.Value));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbMaKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select * from KhachHang where MaKhach={0}", cbbMaKhach.Text);
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            var dr = com.ExecuteReader();
            dr.Read();
            txtHoDem.Text = dr[1].ToString();
            txtTen.Text = dr[2].ToString();
            cbbGioiTinh.Text = dr[3].ToString();
            txtSDT.Text = dr[4].ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dr[5]);
            txtDiaChi.Text = dr[6].ToString();
            dr.Close();
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void labSDT_Click(object sender, EventArgs e)
        {

        }

        private void labGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoDem_TextChanged(object sender, EventArgs e)
        {

        }

        private void labDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void labTen_Click(object sender, EventArgs e)
        {

        }

        private void labHoDem_Click(object sender, EventArgs e)
        {

        }

        private void labNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void labMaKhach_Click(object sender, EventArgs e)
        {

        }

        private void cbbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
