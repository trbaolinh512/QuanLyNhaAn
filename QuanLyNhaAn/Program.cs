using Microsoft.Extensions.Configuration;
using PhanMemBaoCom.GUI.ManHinhChung;
using QuanLyNhaAn.GUI.ManHinhCBGV;
using QuanLyNhaAn.GUI.ManHinhQLHThong;
using System.Reflection;

namespace QuanLyNhaAn
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new DangNhap());

        }
    }
}