using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sinema_Proje;
using SinemaOtomasyonu;
using SinemaOtomasyonu.Models;
using YiyecekİcecekFormu;

namespace _19042022_MBSinema_GP3Final_Vize
{
    public partial class frmBiletKesim : Form
    {
        public frmBiletKesim()
        {
            InitializeComponent();
        }
        MBSinemaContext db = new MBSinemaContext();
        
        private void frmBiletKesim_Load(object sender, EventArgs e)
        {

            
            lblToplamtutar.Text = Program.toplamtutar.ToString();
            lblYiyecekIcecekTutar.Text = Program.yiyecekicecektutar.ToString();
            
            //var kalanKoltukSayisi = db.Salon.ToList();
            //cmbSalon.DataSource = kalanKoltukSayisi;
            //cmbSalon.DisplayMember = "koltukSayisi";
            //cmbSalon.ValueMember = "salonID";
            //lblKalanKoltuk.Text = kalanKoltukSayisi.ToString();

        }
        
        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            if (cmbBiletTür.Text == "") { MessageBox.Show("Lütfen Bilet Türünüzü Seçiniz."); }
            else if (cmbSeans.Text == "") { MessageBox.Show("Lütfen Seans Aralığını Seçiniz."); }
            else if (cmbSalon.Text == "") { MessageBox.Show("Lütfen Salon Numarasını Seçiniz."); }
            else if (RdibErkek.Checked == false && RdibKadin.Checked == false) { MessageBox.Show("Lütfen Cinsiyetinizi Seçiniz.");}
            else
            {
                DialogResult sonuc = MessageBox.Show("Bileti onaylamak istediğinizden emin misiniz?", "Bilet Alım", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {


                    Guid biletNo = Guid.NewGuid();
                    //var deger = db.Bilet.Select(x => new { x.No, x.durum, x.tarih, x.cinsiyet }).ToList();
                    Bilet bilet = new Bilet();
                    //bilet.No = biletNo.ToString();
                    //bilet.durum = true; 
                    bilet.tarih = DateTime.Now;                     
                    bilet.seansID = ((Seans)cmbSeans.SelectedItem).seansID;

                    if (RdibErkek.Checked == true)
                        bilet.cinsiyet = "Erkek";
                    else
                        bilet.cinsiyet = "Kadın";

                    db.Bilet.Add(bilet);
                    db.SaveChanges();
                    MessageBox.Show("Biletiniz oluşturuldu. Bilet iptali ve ücret iadesi için admine başvurun. Makbuz Formuna Yönlendiriliyorsunuz.","Bilet Onaylandı",MessageBoxButtons.OK,MessageBoxIcon.Information);


                    frmMakbuz frm = new frmMakbuz();
                    frm.lblBiletTur.Text = cmbBiletTür.Text;
                    frm.lblSalon.Text = cmbSalon.Text;
                    frm.lblSeans.Text = cmbSeans.Text;
                    this.Hide();
                    frm.Show();
                }
                else
                    return;
                
            }

           
        }

        private void tmrKoltukSayisi_Tick(object sender, EventArgs e)
        {
            //lblKalanKoltuk.Text = db.Salon.Where(x => cmbSalon.Text == x.salonNo.ToString()).Select(x => new { x.koltukSayisi }).ToString();
        }
        int fiyat = 0;
        private void cmbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.toplamtutar = 0;
            int salonID = ((Salon) cmbSalon.SelectedItem).salonID;
            var seanslar = db.Seans.Where(x => x.salonID == salonID).ToList();
            cmbSeans.DataSource = seanslar;
            cmbSeans.DisplayMember = "seansBaslangicSaati";
            cmbSeans.ValueMember = "seansID";
            cmbSeans.Visible = true;


            int salonID1 = ((Salon)cmbSalon.SelectedItem).salonID;
            decimal ucret = (decimal)((Salon)cmbSalon.SelectedItem).ucret;
            var kalanKoltukSayisi = db.Salon.Where(x => x.salonID == salonID1).Select(x => new { x.koltukSayisi }).FirstOrDefault();
            lblKalanKoltuk.Text = kalanKoltukSayisi.koltukSayisi.ToString();
            string[] ucretler = ucret.ToString().Split(',');
            
            Program.toplamtutar +=Convert.ToDecimal( ucretler[0]);
            lblToplamtutar.Text = Program.toplamtutar.ToString();
            
        }
        int biletFiyat = 0;
        private void cmbBiletTür_SelectedIndexChanged(object sender, EventArgs e)
        {
            var salonKategori = db.Salon.ToList();
            cmbSalon.DataSource = salonKategori;
            cmbSalon.DisplayMember = "salonNo";
            cmbSalon.ValueMember = "salonID";
            cmbSalon.Visible = true;
            lblSalon.Visible = true;
            lblSeans.Visible = true;
            if(cmbBiletTür.Text == "Öğrenci")
            {
                biletFiyat += 12;
                Program.toplamtutar += biletFiyat;
                lblToplamtutar.Text = Program.toplamtutar.ToString();
                biletFiyat = 0;
            }
            else if (cmbBiletTür.Text == "Tam")
            {
                biletFiyat += 24;
                Program.toplamtutar += biletFiyat;
                lblToplamtutar.Text = Program.toplamtutar.ToString();
                biletFiyat = 0;

            }
            else if (cmbBiletTür.Text == "Gâzi")
            {
                biletFiyat += 14;
                Program.toplamtutar += biletFiyat;
                lblToplamtutar.Text = Program.toplamtutar.ToString();
                biletFiyat = 0;

            }
        }

        private void cmbSeans_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnYiyecekIcecek_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
    }
    }
}
