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
    public partial class ViewHoaDon : Form
    {
        public ViewHoaDon()
        {
            InitializeComponent();
        }

        private void ViewHoaDon_Load(object sender, EventArgs e)
        {
            string sql = "select distinct convert(date,NgayHoaDon) as NgayHD from HoaDon order by NgayHD desc";
            SqlCommand cmd = new SqlCommand(sql, QLBH.cnn);
            cmd.CommandType = CommandType.Text;
            var DanhSacNgayhHD= cmd.ExecuteReader();
            while (DanhSacNgayhHD.Read())
            {
                treeViewHD.Nodes.Add(Convert.ToDateTime( DanhSacNgayhHD[0]).ToString("dd-MM-yyyy"));
            }
            DanhSacNgayhHD.Close();

            for(int i=0; i < treeViewHD.Nodes.Count; i++)
            {
                string ngayHD= DateTime.ParseExact(treeViewHD.Nodes[i].Text,"dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                sql = string.Format("select NgayHoaDon,SoHoaDon from HoaDon where convert(date,NgayHoaDon) = '{0}' order by NgayHoaDon desc",ngayHD);
                cmd = new SqlCommand(sql, QLBH.cnn);
                cmd.CommandType = CommandType.Text;
                DanhSacNgayhHD = cmd.ExecuteReader();
                while (DanhSacNgayhHD.Read())
                {
                    treeViewHD.Nodes[i].Nodes.Add(DanhSacNgayhHD[1].ToString(), Convert.ToDateTime(DanhSacNgayhHD[0]).ToShortTimeString());
                }
                DanhSacNgayhHD.Close();
            }

            if(treeViewHD.Nodes.Count!=0)
                treeViewHD.SelectedNode = treeViewHD.Nodes[0].Nodes[0];
        }

        private void treeViewHD_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewHD.SelectedNode.Nodes.Count == 0) {
                string sql1 = string.Format("select * from ViewChiTietHD where SoHoaDon = '{0}'", treeViewHD.SelectedNode.Name);
                SqlCommand com1 = new SqlCommand(sql1, QLBH.cnn);
                com1.CommandType = CommandType.Text;
                SqlDataAdapter da1 = new SqlDataAdapter(com1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dgvChiTietHD.DataSource = dt1;

                string sql = string.Format("select * from ViewHD where SoHoaDon = '{0}'",treeViewHD.SelectedNode.Name);
                SqlCommand com = new SqlCommand(sql, QLBH.cnn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHD.DataSource = dt;
            }
        }
    }
}
