using _05042022CinemaProjeOrigin;
using _19042022_MBSinema_GP3Final_Vize;
using SinemaOtomasyonu.Models;
using sinematanıtımekranı;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YiyecekİcecekFormu;

namespace SinemaOtomasyonu
{
    static class Program
    {
        internal static Kullanici kullanici;
        public static string filmYolu;
        public static string butonName;
        public static Button[] button;
        public static PictureBox[] pcr;
        public static decimal toplamtutar;
        public static decimal yiyecekicecektutar;
        public static Kullanici kullanici1 = new Kullanici();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frmgecis());
        }
    }
}
