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
    public partial class ThemNCC : Form
    {
        public ThemNCC()
        {
            InitializeComponent();
        }
        void BindData()
        {
            //cnn.Open();
            string sql = string.Format ("select * from Search_NCC ('"+txtSearch.Text+"')");  // lay het du lieu trong bang san pham
         
            SqlCommand com = new SqlCommand(sql, QLBH.cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            //cnn.Close();  // đóng kết nối
            dgvNCC.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void ThemNCC_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnThemNCC;
            BindData();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ThemNCC", QLBH.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@HoTen", txtHoTen.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@SDT", txtSDT.Text));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", txtDiaChi.Text));
                cmd.ExecuteNonQuery();
                this.txtHoTen.Text = "";
                this.txtDiaChi.Text = "";
                this.txtSDT.Text= "";
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            BindData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            SuaNCC sncc = new SuaNCC();
            sncc.ShowDialog();
            BindData();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            XoaNCC x = new XoaNCC();
            x.ShowDialog();
            BindData();
        }

        private void dgvNCC_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SuaNCC s = new SuaNCC();
            s.mncc = dgvNCC.Rows[e.RowIndex].Cells[0].Value.ToString();
            s.ShowDialog();
            BindData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
