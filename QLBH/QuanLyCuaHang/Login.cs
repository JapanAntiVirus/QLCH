﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Threading;

namespace QuanLyCuaHang
{
    public partial class Login : Form
    {
        public static bool isLogin = false;
        public class User
        {
            public string ServerName;
            public string Ten;
            public string NhomQuyen;
            public string MaNV;
        }
        public static User user = new User();
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            //chạy chậm
            //DataTable ServerName = SqlDataSourceEnumerator.Instance.GetDataSources();
            //foreach (DataRow server in ServerName.Rows)
            //{
            //    if (server["InstanceName"].ToString() != "")
            //    {
            //        cbbServer.Items.Add(server["ServerName"].ToString() + "\\" + server["InstanceName"].ToString());
            //    }
            //    else
            //    {
            //        cbbServer.Items.Add(server["ServerName"].ToString());
            //    }
            //    cbbServer.SelectedIndex = 0;
            //}

            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        cbbServer.Items.Add(Environment.MachineName + @"\" + instanceName);
                    }
                    cbbServer.SelectedIndex = 0;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            { 
                Login.user.ServerName = this.cbbServer.Text;
                QLBH.cnn = new SqlConnection(@"Server=" + Login.user.ServerName + @";database=QuanLyCuaHang;Integrated Security=True");
                QLBH.cnn.Open();
                //Login.user.UserName = this.txtUserName.Text;
                //Login.user.Password = this.txtPassword.Text;
                //QLBH.cnn = new SqlConnection(@"data source=" + Login.user.ServerName + @";initial catalog=QuanLyCuaHang;integrated security = False; User ID = " + Login.user.UserName + @"; Password=" + Login.user.Password);

                string sql = string.Format("select * from TaiKhoan Where TenTK = '{0}' and MatKhau = '{1}'",this.txtUserName.Text,this.txtPassword.Text);
                SqlCommand com = new SqlCommand(sql, QLBH.cnn);
                com.CommandType = CommandType.Text;
                var dr = com.ExecuteReader();
                if (!dr.Read())
                {
                    dr.Close();
                    throw new Exception();
                }
                else
                {
                    int MaNV=0;
                    if (dr[1].ToString() != "")
                    { 
                        MaNV = Convert.ToInt32(dr[1]);
                        dr.Close();
                        SqlCommand cmd = new SqlCommand(string.Format("select * from dbo.ThongTinNV({0})", MaNV), QLBH.cnn);
                        cmd.CommandType = CommandType.Text;
                        var x = cmd.ExecuteReader();
                        x.Read();
                        Login.user.Ten = x[0].ToString();
                        Login.user.NhomQuyen = x[1].ToString();
                        x.Close();
                    }
                    else
                    {
                        Login.user.Ten = "Admin";
                        Login.user.NhomQuyen = "Quản lý";
                        dr.Close();
                    }
                }
                if (txtUserName.Text.ToLower() != "admin")
                    Login.user.MaNV = txtUserName.Text.Substring(2);
                Login.isLogin = true;
                this.Close();
            }
            catch (Exception ex)
            {
                labThongBao.Text = "";
                Thread.Sleep(100);
                labThongBao.Text = "Sai mật khẩu";
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Login.isLogin == false)
                {
                    QLBH.cnn.Close();
                }
            }
            catch { };
        }

        private void cbbServer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
