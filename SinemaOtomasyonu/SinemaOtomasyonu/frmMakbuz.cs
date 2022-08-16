using SinemaOtomasyonu;
using SinemaOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Proje
{
    public partial class frmMakbuz : Form
    {
        public frmMakbuz()
        {
            InitializeComponent();
        }
        MBSinemaContext db = new MBSinemaContext();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnIslemBitir_Click(object sender, EventArgs e)
        {
            Adisyon a = new Adisyon();
            a.toplamUcret = Program.toplamtutar;
            a.tarih = DateTime.Now;
            //a.kullaniciID = db.Kullanici.Where(x=> x.kullaniciID==Program.kullanici1.kullaniciID).Select(x=>x.kullaniciID).SingleOrDefault();
            //AdisyonDetay d = new AdisyonDetay();
            var AdisyonDetay = db.AdisyonDetay.Where(x => x.Adisyon.kullaniciID == a.kullaniciID).Select(x => x.adisyonID).SingleOrDefault();
        }

        private void frmMakbuz_Load(object sender, EventArgs e)
        {
            lblTutar.Text = Program.yiyecekicecektutar.ToString();
            lblTopTutar.Text = Program.toplamtutar.ToString();
        }
    }
}
