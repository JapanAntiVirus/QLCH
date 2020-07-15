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
    public partial class SuaNhanVien : Form
    {
        public SuaNhanVien()
        {
            InitializeComponent();
        }
        public string MaNV;
        private void SuaNhanVien_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnSuaNhanVien;
            dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
            cbbGioiTinh.Items.Add("nam");
            cbbGioiTinh.Items.Add("nữ");
            cbbChucVu.Items.Add("nhân viên");
            cbbChucVu.Items.Add("quản lý");
            cbbChucVu.Items.Add("kế toán");
            cbbChucVu.Items.Add("bảo vệ");
            string sql = "select MaNV from NhanVien order by MaNV";
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbbMaNV.Items.Add(dr[0].ToString());
            }
            dr.Close();

            if (MaNV != null)
            {

                this.cbbMaNV.Text = MaNV;
                this.cbbMaNV.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select * from NhanVien where MaNV={0}", cbbMaNV.Text);
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            var dr = com.ExecuteReader();
            dr.Read();
            txtHoDem.Text = dr[1].ToString();
            txtTen.Text = dr[2].ToString();
            cbbGioiTinh.Text = dr[3].ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dr[4]);
            txtDiaChi.Text = dr[5].ToString();
            txtSDT.Text = dr[6].ToString();
            txtCMND.Text = dr[7].ToString();
            numLuong.Value = Convert.ToInt32(dr[8]);
            cbbChucVu.Text = dr[10].ToString();
            dr.Close();
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SuaNhanVien", QLBH.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNV", cbbMaNV.Text));
                cmd.Parameters.Add(new SqlParameter("@HoDem", txtHoDem.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Ten", txtTen.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", cbbGioiTinh.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", txtSDT.Text));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", dtpNgaySinh.Value));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@CMND", txtCMND.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Luong ", numLuong.Value));
                cmd.Parameters.Add(new SqlParameter("@ChucVu", cbbChucVu.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNhanVien_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
