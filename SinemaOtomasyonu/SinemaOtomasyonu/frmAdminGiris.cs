using _05042022CinemaProjeOrigin;
using SinemaOtomasyonu;
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

namespace Sinema_Proje
{
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }

        MBSinemaContext db = new MBSinemaContext();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string eposta, sifre;
            eposta=txtEposta.Text;
            sifre=txtSifre.Text;

            

             Kullanici k = db.Kullanici.Where(x => x.eposta == eposta && x.sifre == sifre).SingleOrDefault();
            if (k == null) // KAYIT BULUNAMADI
                 MessageBox.Show("Eposta veya Şifre Hatalı");
            else if (k!= null && k.yetkiID == 1)
            {   

                
                Program.kullanici = k;
                frmYoneticiSayfasi frm= new frmYoneticiSayfasi();
                frm.Show();
            }
            else if (k!=null && k.yetkiID == 2)
            {

                Program.kullanici = k;
                frmDeneme frm = new frmDeneme();
                frm.Show();
            }

            


        }
        
        private void txtEposta_Enter(object sender, EventArgs e)
        {
            if (txtEposta.Text == "Eposta Giriniz")
            {
                txtEposta.Text = "";
                txtEposta.ForeColor= Color.DarkRed;
            }
        }

        private void txtEposta_Leave(object sender, EventArgs e)
        {
            if (txtEposta.Text == "")
            {
                txtEposta.Text = "Eposta Giriniz";
                txtEposta.ForeColor = Color.DarkRed;
            }

        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre Giriniz")
            {
                txtSifre.Text = "";
                txtSifre.ForeColor = Color.DarkRed;
            }
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Şifre Giriniz";
                txtSifre.ForeColor = Color.DarkRed;
            }




        }
        
        private void lblKapat_Click(object sender, EventArgs e)
        {
            #region ÇIKIŞ
            Application.Exit();
            #endregion 

        }

        private void lblGeriDon_Click(object sender, EventArgs e)
        {
            Frmgiris frm = new Frmgiris();
            frm.Show();
            this.Hide();
        }
    }
}
