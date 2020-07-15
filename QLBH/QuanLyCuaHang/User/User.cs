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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        void BindData()
        {
            string sql = "select TenTK,MatKhau from TaiKhoan order by TenTK";
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUser.DataSource = dt;
        }

        private void User_Load(object sender, EventArgs e)
        {
            BindData();
            string sql = "select TenTk from TaiKhoan order by TenTK";
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbbTaiKhoan.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void dgvUser_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {   
            dgvUser.Rows[e.RowIndex].Selected = true;
            cbbTaiKhoan.Text = dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            try
            { 
                SqlCommand cmd = new SqlCommand("DoiMatKhau", QLBH.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@username", cbbTaiKhoan.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@password", txtMatKhau.Text.Trim()));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đổi mật khẩu thành công");
                BindData();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại");
            }
        }

        private void dgvUser_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvUser.Rows[e.RowIndex].Selected = true;
            cbbTaiKhoan.Text = dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
