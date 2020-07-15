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
    public partial class XoaNCC : Form
    {
        public XoaNCC()
        {
            InitializeComponent();
        }
        public string mancc;
        private void XoaNCC_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.Xóa;
            string sql = "select MaNCC from NhaCungCap order by MaNCC";
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbbMaNCC.Items.Add(dr[0].ToString());
            }
            dr.Close();

            if (mancc != null)
            {
                this.cbbMaNCC.Text = mancc;
                this.cbbMaNCC.Enabled = false;
            }
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("XoaNCC", QLBH.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNCC", cbbMaNCC.Text));
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
