using _05042022CinemaProjeOrigin;
using SinemaOtomasyonu.Models;
using sinematanıtımekranı;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class frmMusteriKayit : Form
    {
        public frmMusteriKayit()
        {
            InitializeComponent();
        }
        MBSinemaContext db=new MBSinemaContext();
        public void ListeleKullanici()
        {

            gridKullanici.DataSource = db.Kullanici.Select(x =>
                new
                {
                    x.kullaniciID,
                    x.ad,
                    x.soyad,
                    x.kayitTarihi
                }).ToList();
        }

        public void TemizleKullanici()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int kullaniciID = (int)gridKullanici.SelectedRows[0].Cells[0].Value;
            Kullanici kullanici = db.Kullanici.Where(x => x.kullaniciID == kullaniciID).SingleOrDefault();
            if (kullanici != null) //bulunduysa sil
            {
                DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Bilet Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes) //Silme işlemine evet denmesi durumunda gerçekleşecek.
                {
                    db.Kullanici.Remove(kullanici);
                    db.SaveChanges();
                    ListeleKullanici();
                    MessageBox.Show("Başarılı silme işlemi .", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else//Silme işlemine hayır denmesi durumunda gerçekleşecek.
                {
                    MessageBox.Show("İşlem İptal edildi.", "Bilet İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            TemizleKullanici();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            Program.kullanici1.ad = txtAd.Text;
            Program.kullanici1.soyad = txtSoyad.Text;
            Program.kullanici1.eposta = txtEposta.Text;
            Program.kullanici1.sifre = txtSifre.Text;
            Program.kullanici1.kayitTarihi = DateTime.Now;
            Program.kullanici1.yetkiID = 2;
            db.Kullanici.Add(Program.kullanici1);
            db.SaveChanges();

            MessageBox.Show(Program.kullanici1.kullaniciID+ " Kullanıcı başarılı bir şekilde kaydolmuştur.", "Kullanıcı Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);


            TemizleKullanici();
            ListeleKullanici();
            Frmgiris frm = new Frmgiris();
            frm.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int KullaniciID = (int)gridKullanici.SelectedRows[0].Cells[0].Value;
            Kullanici b = db.Kullanici.Where(x => x.kullaniciID== KullaniciID).SingleOrDefault();
            b.ad = txtAd.Text;
            b.soyad = txtSoyad.Text;
            b.eposta = txtEposta.Text;
            b.sifre = txtSifre.Text;
            b.kayitTarihi = DateTime.Now;
            db.SaveChanges();
            ListeleKullanici();
            TemizleKullanici();
            MessageBox.Show("Başarıyla Güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMusteriKayit_Load(object sender, EventArgs e)
        {
            ListeleKullanici();
        }

        private void gridKullanici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = gridKullanici.SelectedRows[0].Cells[0].Value.ToString();
            txtSoyad.Text = gridKullanici.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void pcrGeri_Click(object sender, EventArgs e)
        {
            frmDeneme frm = new frmDeneme();
            frm.Show();
            this.Hide();
        }
    }
}
