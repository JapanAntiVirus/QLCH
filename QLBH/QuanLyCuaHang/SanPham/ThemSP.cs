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
    public partial class ThemSanPham : Form
    {
        public ThemSanPham()
        {
            InitializeComponent();
        }
        void BindData()
        {
            string sql = string.Format("select * from dbo.Search ('"+txtSearch.Text+"') ");
            SqlCommand com = new SqlCommand(sql, QLBH.cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); 
            DataTable dt = new DataTable(); 
            da.Fill(dt); 
            dgvSanPham.DataSource = dt; 
        }
        private void ThemSanPham_Load(object sender, EventArgs e)
        {
                BindData();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ThemSanPham", QLBH.cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenSanPham", txtTenSP.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@DonViTinh", txtDonViTinh.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@DonGia", numDonGia.Value));
                cmd.Parameters.Add(new SqlParameter("@SoLuongTon", numSLT.Value));
                cmd.ExecuteNonQuery();
                this.txtDonViTinh.Text = "";
                this.txtTenSP.Text = "";
                this.numDonGia.Value = 0;
                this.numSLT.Value = 0;
                MessageBox.Show("Thêm thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            BindData();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            XoaSanPham xoa = new XoaSanPham();
            xoa.ShowDialog();
            BindData();
        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            SuaSanPham sua = new SuaSanPham();
            sua.ShowDialog();
            BindData();
        }

        private void dvtSanPham_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try { 
                SuaSanPham sua = new SuaSanPham();
                sua.msp = dgvSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
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
