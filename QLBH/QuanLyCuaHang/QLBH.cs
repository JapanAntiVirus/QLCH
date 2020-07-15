﻿using System;
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
    public partial class QLBH : Form
    {
        public static SqlConnection cnn;
        //public static SqlConnection cnn = new SqlConnection(@"Server=" + Login.ServerName + @";database=QuanLyCuaHang;Integrated Security=True");
        //public static SqlConnection cnn = new SqlConnection(@"Server=hien-pc\DANGHIEN;database=QuanLyCuaHang;Integrated Security=True");
        private List<HoaDon> HD= new List<HoaDon>();    
        private HoaDon hd;
        public QLBH()
        {
            InitializeComponent();
        }

        private void thêmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemSanPham sp = new ThemSanPham();
            sp.ShowDialog();
            BindDataSP();
        }

        private void BindDataSP(string textSearch ="")
        {
            string sql = string.Format("select * from SanPham where MaSanPham like '%{0}%' or TenSanPham like '%{0}%'", textSearch);  
            SqlCommand com = new SqlCommand(sql, cnn); 
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable(); 
            da.Fill(dt);  
            dgvSanPham.DataSource = dt;
        }

        void BindDataMaK()
        {
            string sql = "select MaKhach from KhachHang order by MaKhach";
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            var dr = com.ExecuteReader();
            cbbMaK.Items.Clear();
            while (dr.Read())
            {
                cbbMaK.Items.Add(dr[0].ToString());
            }
            dr.Close();

        }
        private void QLBH_Load(object sender, EventArgs e)
        {
            BindDataSP();
            BindDataMaK();
            this.statusNTenNV.Text = "   Họ tên:  "+Login.user.Ten;
            this.statusNhomQuyen.Text = "          Chức vụ:  "+Login.user.NhomQuyen;
        }

        private void QLBH_FormClosed(object sender, FormClosedEventArgs e)
        {
            cnn.Close();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemKhachHang kh = new ThemKhachHang();
            kh.ShowDialog();
            BindDataMaK();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNhanVien nv = new ThemNhanVien();
            nv.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNCC ncc = new ThemNCC();
            ncc.ShowDialog();
            BindDataSP();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapHang n = new NhapHang();
            n.ShowDialog();
            BindDataSP();
        }

        private void BindDataHD()
        {
            this.dgvHoaDon.DataSource = null;
            if (HD.Count != 0)
                this.dgvHoaDon.DataSource = this.HD;
            this.dgvHoaDon.Refresh();
        }

        int kt(string msp)
        {
            for(int i = 0; i < HD.Count; i++)
            {
                if (HD[i].MaSanPham == msp)
                {
                    return i;
                }
            }
            return -1;
        }

        int IndexSelectSP, IndexSelectHD,IndexSelectSP_HD;
        private void btnThemSP_Click(object sender, EventArgs e)
        {
                try {
                if (hd == null)
                    MessageBox.Show("Chưa chọn sản phẩm");
                else
                { 
                    hd.SoLuong = Convert.ToInt32(numSoLuong.Value);
                    hd.ThanhTien = hd.SoLuong * hd.DonGia;
                    if (kt(hd.MaSanPham) != -1)
                    {
                        dgvSanPham.Rows[IndexSelectSP].Cells[4].Value = Convert.ToInt32(dgvSanPham.Rows[IndexSelectSP].Cells[4].Value) - hd.SoLuong;
                        if (Convert.ToInt32(dgvSanPham.Rows[IndexSelectSP].Cells[4].Value) < 0)
                        {
                            dgvSanPham.Rows[IndexSelectSP].Cells[4].Value = Convert.ToInt32(dgvSanPham.Rows[IndexSelectSP].Cells[4].Value) + hd.SoLuong;
                            MessageBox.Show("Hết hàng");
                            return;
                        }
                        else
                            HD[kt(hd.MaSanPham)].SoLuong += hd.SoLuong;
                    }
                    else
                    { 
                        dgvSanPham.Rows[IndexSelectSP].Cells[4].Value = Convert.ToInt32(dgvSanPham.Rows[IndexSelectSP].Cells[4].Value) - hd.SoLuong;
                        if (Convert.ToInt32(dgvSanPham.Rows[IndexSelectSP].Cells[4].Value) < 0)
                        {
                            dgvSanPham.Rows[IndexSelectSP].Cells[4].Value = Convert.ToInt32(dgvSanPham.Rows[IndexSelectSP].Cells[4].Value) + hd.SoLuong;
                            MessageBox.Show("Hết hàng");
                            return;
                        }
                        else
                            HD.Add(new HoaDon(hd));
                    }
                    this.numTienHang.Value += hd.ThanhTien;
                    numSoLuong.Value = 1;
                    BindDataHD();
                }
            }
            catch { }
        }

        private void dgvSanPham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                IndexSelectSP = e.RowIndex;
                this.hd = new HoaDon(dgvSanPham.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                 dgvSanPham.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                 Convert.ToInt32(numSoLuong.Value),
                                 dgvSanPham.Rows[e.RowIndex].Cells[2].Value.ToString(),
                                 Convert.ToInt32(dgvSanPham.Rows[e.RowIndex].Cells[3].Value),
                                 Convert.ToInt32(dgvSanPham.Rows[e.RowIndex].Cells[3].Value) * Convert.ToInt32(numSoLuong.Value));
                this.labTenSP.Text ="Sản phẩm đã chọn: " +  hd.TenSanPham;
                dgvSanPham.Rows[e.RowIndex].Selected = true;
            }
            catch { }
         }

        string mspSelected, tenSpSelected;
        private void dgvHoaDon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                mspSelected = dgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
                IndexSelectHD = e.RowIndex;
                for(int i=0; i < dgvSanPham.Rows.Count; i++)
                {
                    if (dgvSanPham.Rows[i].Cells[0].Value.ToString() == mspSelected)
                    {
                        IndexSelectSP_HD = i;
                        break;
                    }
                }
                tenSpSelected= dgvHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.labTenSP2.Text = "Sản phẩm đã chọn: " + tenSpSelected;
                dgvHoaDon.Rows[e.RowIndex].Selected = true;
            }
            catch { }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            if (kt(mspSelected) != -1)
            {
                dgvSanPham.Rows[IndexSelectSP_HD].Cells[4].Value = Convert.ToInt32(dgvSanPham.Rows[IndexSelectSP_HD].Cells[4].Value) -1;
                if (Convert.ToInt32(dgvSanPham.Rows[IndexSelectSP_HD].Cells[4].Value) < 0)
                {
                    dgvSanPham.Rows[IndexSelectSP_HD].Cells[4].Value = Convert.ToInt32(dgvSanPham.Rows[IndexSelectSP_HD].Cells[4].Value) + 1;
                    MessageBox.Show("Hết hàng");
                }
                else
                {
                    numTienHang.Value += HD[kt(mspSelected)].DonGia;
                    HD[kt(mspSelected)].SoLuong++;
                }
                BindDataHD();
            }
            else
                MessageBox.Show("Chưa chọn sản phẩm");
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (kt(mspSelected) != -1)
            {
                HD[kt(mspSelected)].SoLuong--;
                numTienHang.Value -= HD[kt(mspSelected)].DonGia;
                dgvSanPham.Rows[IndexSelectSP_HD].Cells[4].Value = Convert.ToInt32(dgvSanPham.Rows[IndexSelectSP_HD].Cells[4].Value) + 1;

                if (HD[kt(mspSelected)].SoLuong == 0)
                {
                    HD.RemoveAt(kt(mspSelected));
                }
                BindDataHD();
            }
            else
                MessageBox.Show("Chưa chọn sản phẩm");
        }

        private void numTienHang_ValueChanged(object sender, EventArgs e)
        {
            this.numTongTien.Value = this.numTienHang.Value - this.numTienHang.Value * this.numGiamGia.Value / 100;
        }

        private void numGiamGia_ValueChanged(object sender, EventArgs e)
        {
            this.numTongTien.Value = this.numTienHang.Value - this.numTienHang.Value * this.numGiamGia.Value / 100;
        }

        private void btnTaoLaiHD_Click(object sender, EventArgs e)
        {
            numTienHang.Value = 0;
            HD.Clear();
            BindDataHD();
            BindDataSP();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            BindDataSP(this.txtTimKiem.Text);
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvSanPham_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvSanPham.Rows[e.RowIndex].Selected = true;
            btnThemSP_Click(new object(), new EventArgs());
        }

        public static bool isDangXuat = false;
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDangXuat = true;
            this.Close();
        }

        private void đổiMâtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Login.user.NhomQuyen == "Quản lý")
            {
                User u = new User();
                u.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này");
            }
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (HD.Count == 0)
                    MessageBox.Show("Chưa chọn sản phẩm nào");
                else
                { 
                    SqlCommand cmd = new SqlCommand("ThemHD", QLBH.cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaKhach", cbbMaK.Text==""?null:cbbMaK.Text));
                    if (Login.user.MaNV != null)
                        cmd.Parameters.Add(new SqlParameter("@MaNV", Convert.ToInt32(Login.user.MaNV)));
                    cmd.Parameters.Add(new SqlParameter("@GiamGia", numGiamGia.Value));
                    cmd.ExecuteNonQuery();

                    SqlCommand selectMaxSHD = new SqlCommand("select * from dbo.SoHDMax()", QLBH.cnn);
                    selectMaxSHD.CommandType = CommandType.Text;
                    var dr = selectMaxSHD.ExecuteReader();
                    dr.Read();
                    int SoHoaDon = Convert.ToInt32(dr[0]);
                    dr.Close();
                    for (int i=0; i < HD.Count; i++)
                    {
                        SqlCommand cmd2 = new SqlCommand("ThemChiTietHD", QLBH.cnn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add(new SqlParameter("@SoHoaDon", SoHoaDon));
                        cmd2.Parameters.Add(new SqlParameter("@MaSanPham", HD[i].MaSanPham));
                        cmd2.Parameters.Add(new SqlParameter("@SoLuong", HD[i].SoLuong));
                        //cmd2.Parameters.Add(new SqlParameter("@ThanhTien", HD[i].ThanhTien));
                        cmd2.ExecuteNonQuery();
                    }
                    numTienHang.Value = 0;
                    HD.Clear();
                    BindDataHD();
                    MessageBox.Show("Tạo hóa đơn thành công");
                    ViewHoaDon v = new ViewHoaDon();
                    v.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lịchSửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewHoaDon v = new ViewHoaDon();
            v.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (kt(mspSelected) != -1)
            {
                dgvSanPham.Rows[IndexSelectSP_HD].Cells[4].Value = Convert.ToInt32(dgvSanPham.Rows[IndexSelectSP_HD].Cells[4].Value) + HD[kt(mspSelected)].SoLuong;
                numTienHang.Value -= HD[kt(mspSelected)].DonGia * HD[kt(mspSelected)].SoLuong;
                HD.RemoveAt(kt(mspSelected));
                BindDataHD();
            }
            else
                MessageBox.Show("Chưa chọn sản phẩm");
        }
    }
}
