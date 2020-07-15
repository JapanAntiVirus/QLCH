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
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
        }
        public String mncc, masp;

        private void NhapHang_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnNhapHang;
            this.dtpNgayNhap.Value = DateTime.Now;
            dtpNgayNhap.CustomFormat = "dd-MM-yyyy";
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
            string sql1 = "select MaSanPham from SanPham order by MaSanPham";
            SqlCommand com1 = new SqlCommand(sql1, QLBH.cnn);
            com1.CommandType = CommandType.Text;
            var dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                cbbMaSP.Items.Add(dr1[0].ToString());
            }
            dr1.Close();

            if (masp != null)
            {
                this.cbbMaSP.Text = masp;
                this.cbbMaSP.Enabled = false;
            }
            BindData();
        }
        void BindData()
        {
            //cnn.Open();
            string sql = "select * from NhapHang order by MaNhap";  // lay het du lieu trong bang san pham
            SqlCommand com = new SqlCommand(sql, QLBH.cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            //cnn.Close();  // đóng kết nối
            dgvNhapHang.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ThemDonHang", QLBH.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNCC", cbbMaNCC.Text));
                cmd.Parameters.Add(new SqlParameter("@MaSP", cbbMaSP.Text));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", dtpNgayNhap.Value.ToString("yyyy-MM-dd")));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", numSoLuong.Value));
                cmd.ExecuteNonQuery();
                this.cbbMaNCC.Text = "";
                this.cbbMaSP.Text = "";
                this.dtpNgayNhap.Value = DateTime.Now;
                this.numSoLuong.Value = 1;
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            BindData();
  
        }

        private void btnSuaDonHang_Click(object sender, EventArgs e)
        {
            SuaDonHang sdh = new SuaDonHang();
            sdh.ShowDialog();
            BindData();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaDonHang_Click(object sender, EventArgs e)
        {
            XoaDonHang xdh = new XoaDonHang();
            xdh.ShowDialog();
            BindData();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
