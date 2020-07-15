﻿using System;
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
    public partial class ThemKhachHang : Form
    {
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        void BindData()
        {
            string sql = string.Format("select * from Search_KhachHang('"+txtSearch.Text+"')");
            //string sql = string.Format("select * from NhaCungCap where MaNCC like '%{0}%' or TenNCC like '%{0}%'order by TenNCC", txtSearch.Text);  // lay het du lieu trong bang san pham
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSanPham.DataSource = dt;
        }

        private void ThemKhachHangcs_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnThemKhachHang;
            dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
            cbbGioiTinh.Items.Add("nam");
            cbbGioiTinh.Items.Add("nữ");
            cbbGioiTinh.Text = "nam";
            BindData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ThemKhachHang", QLBH.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@HoDem", txtHoDem.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@Ten", txtTen.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", cbbGioiTinh.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", txtSDT.Text));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh",dtpNgaySinh.Value.ToString("yyyy-MM-dd")));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", txtDiaChi.Text));
                cmd.ExecuteNonQuery();
                this.txtHoDem.Text = "";
                this.txtTen.Text = "";
                this.cbbGioiTinh.Text = "nam";
                this.txtSDT.Text = "";
                this.dtpNgaySinh.Text = "01-01-1998";
                this.txtDiaChi.Text = "";

                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            BindData();
        }


        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            XoaKhachHang xkh = new XoaKhachHang();
            xkh.ShowDialog();
            BindData();
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            SuaKhachHang sua = new SuaKhachHang();
            sua.ShowDialog();
            BindData();
        }

        private void dvtSanPham_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SuaKhachHang sua = new SuaKhachHang();
                sua.mkh = dgvSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();

                sua.ShowDialog();
                BindData();
            }
            catch { };

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
