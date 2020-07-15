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
    public partial class XoaDonHang : Form
    {
        public XoaDonHang()
        {
            InitializeComponent();
        }
        public string madh;

        private void XoaDonHang_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.Xóa;
            string sql = "select MaNhap from NhapHang order by MaNhap";
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbbMaNhap.Items.Add(dr[0].ToString());
            }
            dr.Close();

            if (madh != null)
            {
                this.cbbMaNhap.Text = madh;
                this.cbbMaNhap.Enabled = false;
            }
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("XoaDonHang", QLBH.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNhap", cbbMaNhap.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
