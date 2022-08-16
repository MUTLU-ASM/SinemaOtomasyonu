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
using System.Windows;
using System.Windows.Forms;

namespace _05042022CinemaProjeOrigin
{
    public partial class frmDeneme : Form
    {
        public frmDeneme()
        {
            InitializeComponent();
        }
        public PictureBox pcrAfis1 = new PictureBox();
        int filmSayisi = 0;
        private void frmDeneme_Load(object sender, EventArgs e)
        {
            
            filmSayisi = db.Film.Select(x => new { x.filmID }).Count();
            Program.button = new Button[filmSayisi];
            Program.pcr = new PictureBox[filmSayisi];
            filmSayilari = new string[filmSayisi];
            diziOyuncular = new string[filmSayisi];
            pcrSayi = new string[filmSayisi];
            butonSayi = new string[filmSayisi];
            Doldur();
            //FilmDoldur(12);
            btnArama.Location = new Point(1455, 30);
            txtArama.Location = new Point(1250, 40);
            lblArama.Location = new Point(1190, 40);
            txtArama.Text = "Arama...";
            var kategori = db.FilmTur.ToList();
            cmbKategori.DataSource = kategori;
            cmbKategori.DisplayMember = "ad";
            cmbKategori.ValueMember = "filmTurID";
        }
        string[] afis = new string[15];
        string[] pcrSayi = new string[0];

        string[] butonSayi = new string[0];
        string[] filmSayilari = new string[0];
        string[] diziOyuncular = new string[0];

        string[] yonetmen = new string[15];
        
        string arama;
        

        Film film = new Film();
        MBSinemaContext db = new MBSinemaContext();

        private void Doldur()
        {
            int artis = 0;
            int butonSayisi = 0;
            int pictureBoxSayisi = 0;
            int labelSayisi = 0;
            
            var filmler = db.Film.ToList();
            foreach (var film in filmler)
            {
                
                #region GroupBox Oluşturma ve Özelliklerini Değiştirme
                GroupBox resim = new GroupBox();
                resim.Width = 332;
                resim.Height = 469;
                resim.Margin = new Padding(5);
                resim.Text = film.Ad;
                resim.Margin = new Padding(30, 10, 10, 30);
                resim.ForeColor = System.Drawing.Color.FromArgb(219, 0, 0);
                resim.Font = new Font("Comic Sans MS", 15, FontStyle.Regular);
                #endregion

                #region PictureBox Oluşturma ve Özelliklerini Değiştirme
                PictureBox pcrAfis = new PictureBox();
                pcrSayi[pictureBoxSayisi] = "Afis" + pictureBoxSayisi;
                pcrAfis.Name = pcrSayi[pictureBoxSayisi];
                pcrAfis.Width = 160;
                pcrAfis.Height = 255;
                pcrAfis.SizeMode = PictureBoxSizeMode.StretchImage;
                pcrAfis.ImageLocation = film.afis;
                pcrAfis.Location = new Point(13, 32);
                filmSayilari[artis] = pcrAfis.ImageLocation;
                artis++;
                Program.pcr[pictureBoxSayisi] = pcrAfis;
                pictureBoxSayisi++;

                #endregion

                #region  Label Oluşturma ve Özelliklerini Değiştirme

                Label lblBaslik = new Label();
                lblBaslik.ForeColor = System.Drawing.Color.FromArgb(219, 0, 0);
                lblBaslik.Text = "Oyuncular";
                lblBaslik.Location = new Point(174, 38);
                lblBaslik.Size = new System.Drawing.Size(139, 34);
                lblBaslik.Font = new Font("Comic Sans MS", 13, FontStyle.Regular);
                lblBaslik.BackColor = Color.Transparent;
                #endregion

                #region Foreach İle Labelları Veri Tabanından Çekme İşlemi
                var oyuncular = film.Oyuncu.Split(',');

                int[] konum = { 80, 120, 160 };
                int x = 0;
                int[] konumy = { 175, 175, 175 };
                int y = 0;
                foreach (var oyuncu in oyuncular)
                {
                    Label l1 = new Label();
                    l1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D6D3D1");
                    l1.Size = new System.Drawing.Size(500, 30);
                    l1.Location = new Point(konumy[y], konum[x]);
                    l1.Text = oyuncu.TrimStart();
                    l1.BackColor = Color.Transparent;
                    l1.Font = new Font("Comic Sans MS", 14, FontStyle.Regular);
                    x++;

                    resim.Controls.Add(l1);
                }
                #endregion

                #region Label Yönetmen Oluşturma Ve Özelleştirme
                Label lblYonetmenBslk = new Label();
                lblYonetmenBslk.ForeColor = System.Drawing.Color.FromArgb(219, 0, 0);
                lblYonetmenBslk.Text = "Yönetmen";
                lblYonetmenBslk.Font = new Font("Comic Sans MS", 15, FontStyle.Regular);
                lblYonetmenBslk.Location = new Point(175, 200);
                lblYonetmenBslk.Size = new System.Drawing.Size(137, 34);
                lblYonetmenBslk.BackColor = Color.Transparent;

                Label lblYonetmen = new Label();
                lblYonetmen.Location = new Point(175, 230);
                lblYonetmen.Text = film.yonetmen;
                lblYonetmen.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D6D3D1");
                lblYonetmen.Size = new System.Drawing.Size(155, 34);
                lblYonetmen.BackColor = Color.Transparent;
                lblYonetmen.Font = new Font("Comic Sans MS", 13, FontStyle.Regular);


                #endregion

                #region Label Açıklama Oluşturma Özelleştirme
                Label lblAciklama = new Label();
                lblAciklama.Font = new Font("Comic Sans MS", 12, FontStyle.Regular);
                lblAciklama.Text = film.Aciklama;
                lblAciklama.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D6D3D1");
                lblAciklama.BackColor = Color.Transparent;
                lblAciklama.Location = new Point(14, 300);
                lblAciklama.Size = new System.Drawing.Size(320, 120);
                #endregion

                #region Buton Oluşturma ve Özelliklerini Değiştirme
                Button butonBiletAl = new Button();
                
                butonSayi[butonSayisi] =  "Buton" + butonSayisi;
                butonBiletAl.Name = butonSayi[butonSayisi];
                
                butonBiletAl.Text = "Bilet Al";
                butonBiletAl.ForeColor = System.Drawing.Color.FromArgb(219, 0, 0);
                butonBiletAl.BackColor = Color.Black;
                butonBiletAl.FlatStyle = FlatStyle.Flat;
                butonBiletAl.Location = new Point(20, 390);
                butonBiletAl.Width = 293;
                butonBiletAl.Height = 69;
                butonBiletAl.Font = new Font(butonBiletAl.Font.FontFamily, 15);
                butonBiletAl.Click += ButonBiletAl_Click;


                Program.button[butonSayisi] = butonBiletAl;
                butonSayisi++;
                #endregion

                #region Oluşturulan Tool'ları Forma Ekleme
                flwlytpnlResim.Controls.Add(resim);
                resim.Controls.Add(pcrAfis);
                resim.Controls.Add(lblBaslik);
                resim.Controls.Add(butonBiletAl);
                resim.Controls.Add(lblYonetmenBslk);
                resim.Controls.Add(lblYonetmen);
                resim.Controls.Add(lblAciklama);
                
                #endregion
            }
        }
        void FilmDoldur(int resimsayisi )
        {

            for (int i = 0; i < resimsayisi; i++)
            {

                #region GroupBox Oluşturma ve Özelliklerini Değiştirme
                GroupBox resim = new GroupBox();
                resim.Width = 332;
                resim.Height = 469;
                resim.Margin = new Padding(5);
                resim.Text = i.ToString();
                resim.Margin = new Padding(30, 10, 10, 30);
                resim.ForeColor = System.Drawing.Color.FromArgb(219, 0, 0);
                #endregion

                #region PictureBox Oluşturma ve Özelliklerini Değiştirme
                var afisYolu = db.Film.Select(x => new { x.afis }).FirstOrDefault();
                afis[i] = afisYolu.afis.ToString();


                PictureBox pcrAfis = new PictureBox();
                pcrAfis.Width = 160;
                pcrAfis.Height = 255;
                pcrAfis.SizeMode = PictureBoxSizeMode.StretchImage;
                pcrAfis.ImageLocation = afis[i];
                pcrAfis.Location = new Point(13, 32);
                #endregion

                #region Label Oluşturma ve Özelliklerini Değiştirme

                Label lblBaslik = new Label();
                lblBaslik.ForeColor = System.Drawing.Color.FromArgb(219, 0, 0);
                lblBaslik.Text = "Oyuncular";
                lblBaslik.Location = new Point(174, 38);
                lblBaslik.Size = new System.Drawing.Size(139, 34);
                lblBaslik.Font = new Font("Comic Sans MS", 15, FontStyle.Regular);
                lblBaslik.BackColor = Color.Transparent;



                //***********LABEL OYUNCULAR KISMI*********

                //*****1******
                #region Oyuncu 1
                var oyuncular = db.Film.Select(x => new { x.Oyuncu }).FirstOrDefault();
                diziOyuncular[i] = oyuncular.Oyuncu.ToString();
                Label lblOyuncu1 = new Label();
                lblOyuncu1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D6D3D1");
                lblOyuncu1.Size = new System.Drawing.Size(500, 30);
                lblOyuncu1.Location = new Point(175, 80);
                int toplamOyuncu = diziOyuncular[i].ToString().Split(',').Length;
                string[] ayrikOyuncu = new string[toplamOyuncu];
                ayrikOyuncu = diziOyuncular[i].ToString().Split(',');
                if (ayrikOyuncu[0] != null)
                    lblOyuncu1.Text = ayrikOyuncu[0];
                else
                    lblOyuncu1.Text = "";
                lblOyuncu1.BackColor = Color.Transparent;
                lblOyuncu1.Font = new Font("Comic Sans MS", 14, FontStyle.Regular);
                #endregion

                //*******2*****

                #region Oyuncu 2
                Label lblOyuncu2 = new Label();
                lblOyuncu2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D6D3D1");
                lblOyuncu2.Size = new System.Drawing.Size(180, 30);
                lblOyuncu2.Location = new Point(175, 130);

                if (ayrikOyuncu[1] != null)
                    lblOyuncu2.Text = ayrikOyuncu[1];
                else
                    lblOyuncu2.Text = "";


                lblOyuncu2.BackColor = Color.Transparent;
                lblOyuncu2.Font = new Font("Comic Sans MS", 14, FontStyle.Regular);
                #endregion

                //*******3******

                #region Oyuncu 3
                Label lblOyuncu3 = new Label();
                lblOyuncu3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D6D3D1");
                lblOyuncu3.Size = new System.Drawing.Size(180, 30);
                lblOyuncu3.Location = new Point(175, 170);

                if (toplamOyuncu == 3)
                    lblOyuncu3.Text = ayrikOyuncu[2];
                else
                    lblOyuncu3.Text = "";

                lblOyuncu3.BackColor = Color.Transparent;
                lblOyuncu3.Font = new Font("Comic Sans MS", 14, FontStyle.Regular);
                #endregion


                //***********Yönetmen Adı***********

                #region Label Yönetmen Oluşturma Ve Özelleştirme
                Label lblYonetmenBslk = new Label();
                lblYonetmenBslk.ForeColor = System.Drawing.Color.FromArgb(219, 0, 0);
                lblYonetmenBslk.Text = "Yönetmen";
                lblYonetmenBslk.Font = new Font("Comic Sans MS", 15, FontStyle.Regular);
                lblYonetmenBslk.Location = new Point(175, 200);
                lblYonetmenBslk.Size = new System.Drawing.Size(137, 34);
                lblYonetmenBslk.BackColor = Color.Transparent;

                #endregion

                //************Yönetmen**********

                var diziYonetmen = db.Film.Select(x => new { x.yonetmen }).FirstOrDefault();
                yonetmen[i] = diziYonetmen.yonetmen.ToString();


                Label lblYonetmen = new Label();
                lblYonetmen.Location = new Point(175, 230);
                lblYonetmen.Text = yonetmen[i];
                lblYonetmen.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D6D3D1");
                lblYonetmen.Size = new System.Drawing.Size(180, 34);
                lblYonetmen.BackColor = Color.Transparent;
                lblYonetmen.Font = new Font("Comic Sans MS", 14, FontStyle.Regular);




                //**********LABEL AÇIKLAMA KISMI*******************

                Label lblAciklama = new Label();
                lblAciklama.Font = new Font("Comic Sans MS", 13, FontStyle.Regular);
                lblAciklama.Text = "  -Taşradan gelen genç bir oğlan olan \n Merlin, hayat dolu Camelot şehrine \n gelir ve bir idama tanık olur.";
                lblAciklama.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D6D3D1");
                lblAciklama.BackColor = Color.Transparent;
                lblAciklama.Location = new Point(14, 300);
                lblAciklama.Size = new System.Drawing.Size(379, 120);
                #endregion

            }

        }

        private void ButonBiletAl_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            foreach (var buton in Program.button)
            {
                
                buton.Click += Buton_Click;
                foreach (var pcr in Program.pcr)
                {
                    buton.Controls.Add(pcr);
                    sayi++;
                    if (buton.Name == butonSayi[0])
                    {
                       
                        if (pcr.Name == "Afis0")
                        {

                            frmBiletKesim frm = new frmBiletKesim();
                            
                            this.Hide();
                            frm.Show();
                        }
                    }
                    
                }
                
            }
            
        }

        private void Buton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtArama_Click(object sender, EventArgs e)
        {
            txtArama.Clear();
        }

        int i = 0;
        private void btnArama_Click(object sender, EventArgs e)
        {
            arama = txtArama.Text;
            var film = db.Film.Where(x => x.Ad == arama).ToList();
            flwlytpnlResim.Controls.Clear();
            foreach (var secilenFilm in film)
            {
                #region GroupBox Oluşturma ve Özelliklerini Değiştirme
                GroupBox resim = new GroupBox();
                resim.Width = 332;
                resim.Height = 469;
                resim.Margin = new Padding(5);
                resim.Text = secilenFilm.Ad;
                resim.Margin = new Padding(30, 10, 10, 30);
                resim.ForeColor = System.Drawing.Color.FromArgb(219, 0, 0);
                resim.Font = new Font("Comic Sans MS", 15, FontStyle.Regular);
                #endregion
                #region PictureBox Oluşturma ve Özelliklerini Değiştirme
                PictureBox pcrAfis = new PictureBox();
                pcrAfis.Width = 160;
                pcrAfis.Height = 255;
                pcrAfis.SizeMode = PictureBoxSizeMode.StretchImage;
                pcrAfis.ImageLocation = secilenFilm.afis;
                pcrAfis.Location = new Point(13, 32);
                #endregion

                #region  Label Oluşturma ve Özelliklerini Değiştirme

                Label lblBaslik = new Label();
                lblBaslik.ForeColor = System.Drawing.Color.FromArgb(219, 0, 0);
                lblBaslik.Text = "Oyuncular";
                lblBaslik.Location = new Point(174, 38);
                lblBaslik.Size = new System.Drawing.Size(139, 34);
                lblBaslik.Font = new Font("Comic Sans MS", 13, FontStyle.Regular);
                lblBaslik.BackColor = Color.Transparent;
                #endregion

                #region Foreach İle Labelları Veri Tabanından Çekme İşlemi
                var oyuncular = secilenFilm.Oyuncu.Split(',');

                int[] konum = { 80, 120, 160 };
                int x = 0;
                int[] konumy = { 175, 175, 175 };
                int y = 0;
                foreach (var oyuncu in oyuncular)
                {
                    Label l1 = new Label();
                    l1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D6D3D1");
                    l1.Size = new System.Drawing.Size(500, 30);
                    l1.Location = new Point(konumy[y], konum[x]);
                    l1.Text = oyuncu.TrimStart();
                    l1.BackColor = Color.Transparent;
                    l1.Font = new Font("Comic Sans MS", 14, FontStyle.Regular);
                    x++;

                    resim.Controls.Add(l1);
                }
                #endregion

                #region Label Yönetmen Oluşturma Ve Özelleştirme
                Label lblYonetmenBslk = new Label();
                lblYonetmenBslk.ForeColor = System.Drawing.Color.FromArgb(219, 0, 0);
                lblYonetmenBslk.Text = "Yönetmen";
                lblYonetmenBslk.Font = new Font("Comic Sans MS", 15, FontStyle.Regular);
                lblYonetmenBslk.Location = new Point(175, 200);
                lblYonetmenBslk.Size = new System.Drawing.Size(137, 34);
                lblYonetmenBslk.BackColor = Color.Transparent;

                Label lblYonetmen = new Label();
                lblYonetmen.Location = new Point(175, 230);
                lblYonetmen.Text = secilenFilm.yonetmen;
                lblYonetmen.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D6D3D1");
                lblYonetmen.Size = new System.Drawing.Size(155, 34);
                lblYonetmen.BackColor = Color.Transparent;
                lblYonetmen.Font = new Font("Comic Sans MS", 13, FontStyle.Regular);


                #endregion

                #region Label Açıklama Oluşturma Özelleştirme
                Label lblAciklama = new Label();
                lblAciklama.Font = new Font("Comic Sans MS", 12, FontStyle.Regular);
                lblAciklama.Text = secilenFilm.Aciklama;
                lblAciklama.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D6D3D1");
                lblAciklama.BackColor = Color.Transparent;
                lblAciklama.Location = new Point(14, 300);
                lblAciklama.Size = new System.Drawing.Size(320, 120);
                #endregion

                #region Buton Oluşturma ve Özelliklerini Değiştirme
                Button butonBiletAl = new Button();
                butonBiletAl.Text = "Bilet Al";
                butonBiletAl.ForeColor = System.Drawing.Color.FromArgb(219, 0, 0);
                butonBiletAl.BackColor = Color.Black;
                butonBiletAl.FlatStyle = FlatStyle.Flat;
                butonBiletAl.Location = new Point(20, 390);
                butonBiletAl.Width = 293;
                butonBiletAl.Height = 69;
                butonBiletAl.Font = new Font(butonBiletAl.Font.FontFamily, 15);
                butonBiletAl.Click += ButonBiletAl_Click;
                #endregion

                #region Oluşturulan Tool'ları Forma Ekleme
                flwlytpnlResim.Controls.Add(resim);
                resim.Controls.Add(pcrAfis);
                resim.Controls.Add(lblBaslik);
                resim.Controls.Add(butonBiletAl);
                resim.Controls.Add(lblYonetmenBslk);
                resim.Controls.Add(lblYonetmen);
                resim.Controls.Add(lblAciklama);

                #endregion
            }
        }

        int okuma = 0;
        int artis = 0;

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (okuma != 1 && okuma != 0)
            {
                int seansID = 0;


                var filmTurID = ((FilmTur)cmbKategori.SelectedItem).filmTurID;

                var filmler = db.Film.Where(x => x.filmTurID == filmTurID).ToList();
                int[] filmID = new int[filmler.Count];
                foreach (var item in filmler)
                {

                    var seanslar = db.Seans.Where(x => x.filmID == item.filmID).ToList();
                    for (int i = 0; i < filmID.Length; i++)
                    {
                        foreach (var film in filmID)
                        {
                            string[] seans = new string[seanslar.Count];
                            foreach (var seanss in seanslar)
                            {

                                for (int k = 0; k < seanslar.Count; k++)
                                {
                                    seans[k] = (seanss.seansBaslangicSaati + " " + seanss.seansBitisSaati).ToString();

                                }

                                if (artis != seanslar.Count)
                                {
                                    cmbSeans.Items.Add(seans[artis].ToString());
                                    artis++;
                                }

                            }
                        }

                    }





                    //var seans = db.Seans.Where(x => x.salonID == 1/*x.filmID == filmID*/).ToList();

                    //place:
                    //if( i != filmID[i]-1)
                    //while ( i < filmIDs.Count)
                    //{                        
                    //    filmID[i] = item.filmID;
                    //        i++;
                    //    goto place;
                    //}

                }
                //filmID = Convert.ToInt32(filmIDs.filmTurID);



            }
            okuma++;
        }
    }
}
