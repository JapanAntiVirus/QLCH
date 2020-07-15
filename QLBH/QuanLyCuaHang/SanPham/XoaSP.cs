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
    public partial class XoaSanPham : Form
    {
        public XoaSanPham()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("XoaSanPham", QLBH.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaSanPham", cbbMaSP.SelectedValue));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        class item
        {
            public int MaSP { get; set; }
            public String TenSP { get; set; }
            public item(int m, String t)
            {
                MaSP = m;
                TenSP = t;
            }
        }
        private void XoaSanPham_Load(object sender, EventArgs e)
        {
            cbbKieuXoa.Items.Add("Tên sản phẩm:");
            cbbKieuXoa.Items.Add("Mã sản phẩm:");
            cbbKieuXoa.SelectedIndex = 0;
            this.AcceptButton = this.btnXoaSP;
        }

        private void cbbKieuXoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select MaSanPham,TenSanPham from SanPham order by " + (cbbKieuXoa.SelectedIndex == 0 ? "TenSanPham" : "MaSanPham");  
            SqlCommand com = new SqlCommand(sql, QLBH.cnn); 
            com.CommandType = CommandType.Text;
            var dr = com.ExecuteReader();
            List<item> DanhSachSanPham = new List<item>();
            while (dr.Read())
            {
                DanhSachSanPham.Add(new item(Convert.ToInt32(dr[0]), dr[1].ToString()));
            }
            cbbMaSP.DataSource = DanhSachSanPham;
            cbbMaSP.DisplayMember = cbbKieuXoa.SelectedIndex == 0 ? "TenSP" : "MaSp";
            cbbMaSP.ValueMember = "MaSP";
            dr.Close();
        }
    }
}
