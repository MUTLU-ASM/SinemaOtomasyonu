using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace sinematanıtımekranı
{
    public partial class Frmgecis : Form
    {
        public Frmgecis()
        {
            InitializeComponent();
        }

       

 

        private void Frmgecis_Load(object sender, EventArgs e)
        {
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "//song.wav";
            ses.SoundLocation = dizin;
            ses.Play();
            timer1.Interval = 6000;
            timer1.Enabled = true;
       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Frmgiris frm = new Frmgiris();
            frm.Show();
            this.Hide();
            timer1.Stop();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
