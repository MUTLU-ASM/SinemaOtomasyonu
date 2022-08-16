using _05042022CinemaProjeOrigin;
using Sinema_Proje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinematanıtımekranı
{
    public partial class Frmgiris : Form
    {
        public Frmgiris()
        {
            InitializeComponent();
         
        }


        private void btnVizyon_Click(object sender, EventArgs e)
        {
            frmAdminGiris frm = new frmAdminGiris();
            frm.label2.Text = "KULLANICI GİRİŞİ";
            this.Close();
            frm.Show();
        }

        private void pctrAdmin_Click(object sender, EventArgs e)
        {
            frmAdminGiris frm = new frmAdminGiris();
            frm.label2.Text = "YÖNETİCİ GİRİŞİ";
            this.Close();
            frm.Show();
        }
    }
}
