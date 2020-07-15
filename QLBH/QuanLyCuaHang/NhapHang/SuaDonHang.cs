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
    public partial class SuaDonHang : Form
    {
        public SuaDonHang()
        {
            InitializeComponent();
        }
        public string mncc, masp,madh;

        private void SuaDonHang_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnSua;
            dtpNgayNhap.CustomFormat = "dd-MM-yyyy";
            string sql = "select MaNhap from NhapHang order by MaNhap";
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            var dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbbDonHang.Items.Add(dr[0].ToString());
            }
            dr.Close();
            if (madh != null)
            {
                this.cbbDonHang.Text = madh;
                this.cbbDonHang.Enabled = false;
            }
            string sql2 = "select MaNCC from NhaCungCap order by MaNCC";
            SqlCommand com2 = new SqlCommand(sql2, QLBH.cnn);
            com.CommandType = CommandType.Text;
            var dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                cbbMaNCC.Items.Add(dr2[0].ToString());
            }
            dr2.Close();

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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbMaNCC_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cbbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
           string sql = string.Format("select * from NhapHang where MaNhap={0}", cbbDonHang.Text);
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            var dr = com.ExecuteReader();
            dr.Read();
            cbbMaNCC.Text = dr[1].ToString();
            cbbMaSP.Text = dr[2].ToString();
            dtpNgayNhap.Value = Convert.ToDateTime(dr[3]);
            numSoLuong.Value = Convert.ToInt32(dr[4]);
            dr.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SuaDonHang", QLBH.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNhap", cbbDonHang.Text));
                cmd.Parameters.Add(new SqlParameter("@MaNCC", cbbDonHang.Text));
                cmd.Parameters.Add(new SqlParameter("@MaSP", cbbMaSP.Text));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", dtpNgayNhap.Value.ToString("yyyy-MM-dd")));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", numSoLuong.Value));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
