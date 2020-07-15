using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            while (Login.isLogin || QLBH.isDangXuat)
            { 
                if (Login.isLogin)
                {
                    Login.isLogin = false;
                    Application.Run(new QLBH());
                }
                if (QLBH.isDangXuat)
                {
                    QLBH.isDangXuat = false;
                    Application.Run(new Login());
                }
            }
        }
    }
}
