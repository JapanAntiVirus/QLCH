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
    public partial class XoaNhanVien : Form
    {
        public XoaNhanVien()
        {
            InitializeComponent();
        }

        private void XoaNhanVien_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnXoaNV;
            cbbKieuXoa.Items.Add("Xóa theo tên");
            cbbKieuXoa.Items.Add("Xóa theo mã");
            cbbKieuXoa.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        class item
        {
            public int MaNV { get; set; }
            public String HoTen { get; set; }
            public item(int m, String t)
            {
                MaNV = m;
                HoTen = t;
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("XoaNhanVien", QLBH.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNV", cbbMaNV.SelectedValue));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbbKieuXoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select MaNV,HoDem,Ten from NhanVien order by " + (cbbKieuXoa.SelectedIndex == 0 ? "Ten" : "MaNV");
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            var dr = com.ExecuteReader();
            List<item> DanhSachSanPham = new List<item>();
            while (dr.Read())
            {
                DanhSachSanPham.Add(new item(Convert.ToInt32(dr[0]), dr[1].ToString() +" " + dr[2].ToString()));
            }
            cbbMaNV.DataSource = DanhSachSanPham;
            cbbMaNV.DisplayMember = cbbKieuXoa.SelectedIndex == 0 ? "HoTen" : "MaNV";
            cbbMaNV.ValueMember = "MaNV";
            dr.Close();
        }
    }
}
