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
    public partial class XoaKhachHang : Form
    {
        public XoaKhachHang()
        {
            InitializeComponent();
        }

        private void XoaKhachHang_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnXoaKhachHang;
            string sql = "select MaKhach from KhachHang order by MaKhach";
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbbMaKhach.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("XoaKhachHang", QLBH.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaKhach", cbbMaKhach.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
