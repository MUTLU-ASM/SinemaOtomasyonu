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

namespace SinemaOtomasyonu
{
    public partial class frmYoneticiSayfasi : Form
    {
        public frmYoneticiSayfasi()
        {
            InitializeComponent();
        }

        MBSinemaContext db = new MBSinemaContext();

        private void lblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ListeleBilet()
        {
            ////gridBilet.DataSource = db.Bilet.ToList(); tümünü listelemek için.
            gridBilet.DataSource = db.Bilet.Select(x =>
                new
                {
                    x.biletID,
                     x.No,
                      x.durum,
                       x.tarih,
                         x.cinsiyet
                }).ToList();
        }
        public void ListeleFilm()
        {
            ////gridBilet.DataSource = db.Bilet.ToList(); tümünü listelemek için.
            gridFilm.DataSource = db.Film.Select(x =>
                new
                {
                    x.filmID,
                     x.Ad,
                      x.Sure,
                       x.Aciklama,
                        x.Konu,
                         x.Puan,
                          x.Oyuncu,
                          x.yonetmen,
                           FilmTur=x.FilmTur.ad,
                             x.afis,
                              x.vizyonBasTarihi,
                               x.vizyonBitTarihi
                }).ToList();
        }

        public void TemizleFilm()
        {
            txtFilmID.Text = "";
            txtYonetmen.Text = "";
            txtAd.Text = "";
            txtSure.Text = "";
            txtKonu.Text = "";
            txtPuan.Text = "";
            txtAfis.Text = "";
            btnSil.Text = "";
            txtTur.Text = "";
            txtBaslangic.Text = "";
            txtBitis.Text = "";
            rchtxtAciklama.Text = "";
            txtOyuncu.Text = "";
            txtAd.Focus();
        }
        public void TemizleBilet()
        {
            txtBiletID.Text = "";
            txtNo.Text = "";
            txtDurum.Text = "";
            txtTarih.Text = "";
            txtCinsiyet.Text = "";
            txtNo.Focus();
        }

        private void frmYoneticiSayfasi_Load(object sender, EventArgs e)
        {
            ListeleBilet();
            ListeleFilm();
        }

        private void gridBilet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Grid'de seçilen satırı textbox lara geçirme. CurrentRow.Cells[0]
            txtBiletID.Text = gridBilet.SelectedRows[0].Cells[0].Value.ToString();
            txtNo.Text = gridBilet.SelectedRows[0].Cells[1].Value.ToString();
            txtDurum.Text = gridBilet.SelectedRows[0].Cells[2].Value.ToString();
            txtTarih.Text = gridBilet.SelectedRows[0].Cells[3].Value.ToString();
            txtCinsiyet.Text = gridBilet.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Bilet b = new Bilet();
            b.No = Convert.ToInt16(txtNo.Text);
            b.durum = txtDurum.Text;
            b.tarih = DateTime.Now;
            b.cinsiyet = txtCinsiyet.Text;
            db.Bilet.Add(b);
            db.SaveChanges();

            MessageBox.Show(b.No + " No'lu bilet başarılı bir şekilde kaydolmuştur.", "Bilet Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);


            TemizleBilet();
            ListeleBilet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int BiletID = (int)gridBilet.SelectedRows[0].Cells[0].Value;
            Bilet biletID= db.Bilet.Where(x => x.biletID == BiletID).SingleOrDefault();
            if (biletID!=null) //bulunduysa sil
            {
                DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Bilet Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc==DialogResult.Yes) //Silme işlemine evet denmesi durumunda gerçekleşecek.
                {
                    db.Bilet.Remove(biletID);
                    db.SaveChanges();
                    ListeleBilet();
                    MessageBox.Show("Başarılı silme işlemi .", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else//Silme işlemine hayır denmesi durumunda gerçekleşecek.
                {
                  MessageBox.Show("İşlem İptal edildi.", "Bilet İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            TemizleBilet();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int BiletID = (int)gridBilet.SelectedRows[0].Cells[0].Value;
            Bilet b = db.Bilet.Where(x => x.biletID == BiletID).SingleOrDefault();
            b.biletID = Convert.ToInt16(txtBiletID.Text);
            b.No =Convert.ToInt16(txtNo.Text);
            b.durum = txtDurum.Text;
            b.tarih = Convert.ToDateTime(txtTarih.Text);
            b.cinsiyet = txtCinsiyet.Text;
            db.SaveChanges();
            ListeleBilet();
            TemizleBilet();
            MessageBox.Show("Başarıyla Güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Film Bilgisi Kısmı

        private void btnAfisEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pctrAfis.ImageLocation = openFileDialog1.FileName;
            txtAfis.Text = openFileDialog1.FileName;
        }

        private void btnFilmSil_Click(object sender, EventArgs e)
        {
            int filmID = (int)gridFilm.SelectedRows[0].Cells[0].Value;
            Film film = db.Film.Where(x => x.filmID == filmID).SingleOrDefault();
            if (film != null) //bulunduysa sil
            {
                DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Film Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes) //Silme işlemine evet denmesi durumunda gerçekleşecek.
                {
                    db.Film.Remove(film);
                    db.SaveChanges();
                    ListeleFilm();
                    MessageBox.Show("Başarılı silme işlemi .", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else//Silme işlemine hayır denmesi durumunda gerçekleşecek.
                {
                    MessageBox.Show("İşlem İptal edildi.","Film İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            TemizleFilm();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            Film f = new Film();
            f.Ad = txtAd.Text;
            f.Sure = Convert.ToInt16(txtSure.Text);
            f.Konu = txtKonu.Text;
            f.Puan = Convert.ToInt16(txtPuan.Text);
            f.afis = txtAfis.Text;
            f.Oyuncu = txtOyuncu.Text;
            //f.FilmTur = txtTur.Text;
            //f.vizyonBasTarihi =Convert.ToString( msktxtBaslangıc.Text);
            //f.vizyonBitTarihi = msktxtBitis.Text;
            f.Aciklama = rchtxtAciklama.Text;
            db.Film.Add(f);
            db.SaveChanges();

            MessageBox.Show(f.Ad + " Ad'lı Film başarılı bir şekilde kaydolmuştur.", "Film Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);


            TemizleFilm();
            ListeleFilm();
        }

        private void btnFilmGuncelle_Click(object sender, EventArgs e)
        {
            int filmID = (int)gridFilm.SelectedRows[0].Cells[0].Value;
            Film f = db.Film.Where(x => x.filmID == filmID).SingleOrDefault();
            f.Ad = txtAd.Text;
            f.Sure = Convert.ToInt16(txtSure.Text);
            f.Konu = txtKonu.Text;
            f.Puan = Convert.ToInt16(txtPuan.Text);
            f.afis = txtAfis.Text;
            f.Oyuncu = txtOyuncu.Text;
            //f.FilmTur = txtTur.Text;
            //f.vizyonBasTarihi = Convert.ToString(msktxtBaslangıc.Text);
            //f.vizyonBitTarihi = txtBitis.Text;
            f.Aciklama = rchtxtAciklama.Text;
            db.SaveChanges();
            ListeleFilm();
            TemizleFilm();
            MessageBox.Show("Başarıyla Güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridFilm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFilmID.Text = gridFilm.SelectedRows[0].Cells[0].Value.ToString();
            txtAd.Text = gridFilm.SelectedRows[0].Cells[1].Value.ToString();
            txtSure.Text = gridFilm.SelectedRows[0].Cells[2].Value.ToString();
            rchtxtAciklama.Text = gridFilm.SelectedRows[0].Cells[3].Value.ToString();
            txtKonu.Text = gridFilm.SelectedRows[0].Cells[4].Value.ToString();
            txtPuan.Text = gridFilm.SelectedRows[0].Cells[5].Value.ToString();
            txtOyuncu.Text = gridFilm.SelectedRows[0].Cells[6].Value.ToString();
            txtYonetmen.Text = gridFilm.SelectedRows[0].Cells[7].Value.ToString();
            txtTur.Text = gridFilm.SelectedRows[0].Cells[8].Value.ToString();
            txtAfis.Text = gridFilm.SelectedRows[0].Cells[9].Value.ToString();
            txtBaslangic.Text = gridFilm.SelectedRows[0].Cells[10].Value.ToString();
            txtBitis.Text = gridFilm.SelectedRows[0].Cells[11].Value.ToString();
            pctrAfis.ImageLocation = gridFilm.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMusteriKayit frm = new frmMusteriKayit();
            frm.Show();
            this.Hide();
        }

        private void gridBilet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
