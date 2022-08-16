using _19042022_MBSinema_GP3Final_Vize;
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

namespace YiyecekİcecekFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MBSinemaContext db = new MBSinemaContext();
        public void Yiyecek()
        {
            var misir = db.Urun.Where(x => x.ad == lblMisir.Text).Select(x => new { x.ad, x.fiyat ,x.resim}).SingleOrDefault();
                string[] misirfiyat = misir.fiyat.ToString().Split(',');
                lblMisir.Text = misir.ad.ToString() + " " + misirfiyat[0] + " TL";
            pcrMisir.ImageLocation = misir.resim;
            

            var biskuvi = db.Urun.Where(x => x.ad == lblBiskuvi.Text).Select(x => new { x.ad, x.fiyat,x.resim }).SingleOrDefault();
            string[] biskuvifiyat = biskuvi.fiyat.ToString().Split(',');
            lblBiskuvi.Text = biskuvi.ad.ToString() + " " + biskuvifiyat[0] + " TL";
            pcrBiskuvi.ImageLocation = biskuvi.resim;

            var tatli = db.Urun.Where(x => x.ad == lblTatli.Text).Select(x => new { x.ad, x.fiyat ,x.resim}).SingleOrDefault();
            string[] tatlifiyat = tatli.fiyat.ToString().Split(',');
            lblTatli.Text = tatli.ad.ToString() + " " + tatlifiyat[0] + " TL";
            pcrTatli.ImageLocation = tatli.resim;

            var cips = db.Urun.Where(x => x.ad == lblCips.Text).Select(x => new { x.ad, x.fiyat,x.resim }).SingleOrDefault();
            string[] cipsfiyat = cips.fiyat.ToString().Split(',');
            lblCips.Text = cips.ad.ToString() + " " + cipsfiyat[0] + " TL";
            pcrCips.ImageLocation = cips.resim;

            var cikolata = db.Urun.Where(x => x.ad == lblCikolata.Text).Select(x => new { x.ad, x.fiyat ,x.resim}).SingleOrDefault();
            string[] cikolatafiyat = cikolata.fiyat.ToString().Split(',');
            lblCikolata.Text = cikolata.ad.ToString() + " " + cikolatafiyat[0] + " TL";
            pcrCikolata.ImageLocation = cikolata.resim;

            var dondurma = db.Urun.Where(x => x.ad == lblDondurma.Text).Select(x => new { x.ad, x.fiyat,x.resim }).SingleOrDefault();
            string[] dondurmafiyat = dondurma.fiyat.ToString().Split(',');
            lblDondurma.Text = dondurma.ad.ToString() + " " + dondurmafiyat[0] + " TL";
            pcrDondurma.ImageLocation = dondurma.resim;


            misir1 = (decimal)misir.fiyat;
            cikolata1 = (decimal)cikolata.fiyat;
            dondurma1 = (decimal)dondurma.fiyat;
            tatli1 = (decimal)tatli.fiyat;
            cips1 = (decimal)cips.fiyat;
            biskuvi1 = (decimal)biskuvi.fiyat;

        }

        public void İcecek()
        {
            var cay = db.Urun.Where(x => x.ad == lblCay.Text).Select(x => new { x.ad, x.fiyat,x.resim }).SingleOrDefault();
            string[] cayfiyat = cay.fiyat.ToString().Split(',');
            lblCay.Text = cay.ad.ToString() + " " + cayfiyat[0] + " TL";
            pcrCay.ImageLocation = cay.resim;


            var kola = db.Urun.Where(x => x.ad == lblKola.Text).Select(x => new { x.ad, x.fiyat, x.resim }).SingleOrDefault();
            string[] kolafiyat = kola.fiyat.ToString().Split(',');
            lblKola.Text = kola.ad.ToString() + " " + kolafiyat[0] + " TL";
            pcrKola.ImageLocation = kola.resim;


            var monster = db.Urun.Where(x => x.ad == lblMonster.Text).Select(x => new { x.ad, x.fiyat, x.resim }).SingleOrDefault();
            string[] monsterfiyat = monster.fiyat.ToString().Split(',');
            lblMonster.Text = monster.ad.ToString() + " " + monsterfiyat[0] + " TL";
            pcrMonster.ImageLocation = monster.resim;


            var soda = db.Urun.Where(x => x.ad == lblSoda.Text).Select(x => new { x.ad, x.fiyat, x.resim }).SingleOrDefault();
            string[] sodafiyat = soda.fiyat.ToString().Split(',');
            lblSoda.Text = soda.ad.ToString() + " " + sodafiyat[0] + " TL";
            pcrSoda.ImageLocation = soda.resim;


            var fanta = db.Urun.Where(x => x.ad == lblFanta.Text).Select(x => new { x.ad, x.fiyat, x.resim }).SingleOrDefault();
            string[] fantafiyat = fanta.fiyat.ToString().Split(',');
            lblFanta.Text = fanta.ad.ToString() + " " + fantafiyat[0] + " TL";
            pcrFanta.ImageLocation = fanta.resim;

            var su = db.Urun.Where(x => x.ad == lblSu.Text).Select(x => new { x.ad, x.fiyat, x.resim }).SingleOrDefault();
            string[] sufiyat = su.fiyat.ToString().Split(',');
            lblSu.Text = su.ad.ToString() + " " + sufiyat[0] + " TL";
            pcrSu.ImageLocation = su.resim;


            su1 = (decimal)su.fiyat;
            fanta1 = (decimal)fanta.fiyat;
            kola1 = (decimal)kola.fiyat;
            cay1 = (decimal)cay.fiyat;
            soda1 = (decimal)soda.fiyat;
            monster1 = (decimal)monster.fiyat;

        }
        decimal Tutar = 0;
        decimal cay1, kola1, fanta1, su1, misir1, monster1, biskuvi1, soda1, dondurma1, tatli1, cikolata1, cips1 = 0;

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            Tutar += NmCay.Value * cay1;
            Tutar += NmKola.Value * kola1;
            Tutar += NmMonster.Value * monster1;
            Tutar += NmSoda.Value * soda1;
            Tutar += NmFanta.Value * fanta1;
            Tutar += NmSu.Value * su1;
            Tutar += NmMısır.Value * misir1;
            Tutar += NmBisküvi.Value * biskuvi1;
            Tutar += NmTatlı.Value * tatli1;
            Tutar += NmCips.Value * cips1;
            Tutar += NmCikolata.Value * cikolata1;
            Tutar += NmDondurma.Value * dondurma1;

            NmCay.Value = 0;
            NmKola.Value = 0;
            NmMonster.Value = 0;
            NmSoda.Value = 0;
            NmFanta.Value = 0;
            NmSu.Value = 0;
            NmMısır.Value = 0;
            NmBisküvi.Value = 0;
            NmTatlı.Value = 0;
            NmCips.Value = 0;
            NmCikolata.Value = 0;
            NmDondurma.Value = 0;



            string[] tutar = Tutar.ToString().Split(',');
            lblTutar.Text = tutar[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yiyecek();
            İcecek();
           
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            Tutar = 0;
            lblTutar.Text = Tutar.ToString();
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {

        }


        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            frmBiletKesim frm = new frmBiletKesim();
            frm.cmbSalon.Visible = true;
            frm.lblSalon.Visible = true;
            frm.lblSeans.Visible = true;
            frm.cmbSeans.Visible = true;
            if (lblTutar.Text == "Tutar")
                Program.yiyecekicecektutar = 0;
            else
            Program.yiyecekicecektutar +=Convert.ToDecimal(lblTutar.Text);
            Program.toplamtutar += Program.yiyecekicecektutar;
            this.Hide();
            frm.Show();
        }
    }
}
