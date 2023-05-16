using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kütüphanem
{
    public partial class Form1 : Form
    {
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void personelGirisbtn_Click(object sender, EventArgs e)
        {
            string gelenAd = adGiristxt.Text;
            string gelenSifre = sifreGiristxt.Text;

            var personel = db.Personeller.Where(x => x.personel_kullaniciAd.Equals(gelenAd) && x.personel_sifre.Equals(gelenSifre)).FirstOrDefault();
            if (personel == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
            else
            {
                MessageBox.Show("Giriş başarılı");
                islemPaneli panel = new islemPaneli();
                panel.Show();
                this.Hide();
            }
        }

        private void adGiristxt_Enter(object sender, EventArgs e)
        {
            if (adGiristxt.Text == "Kullanıcı Adınızı Girin:")
            {
                adGiristxt.Text = "";
            }
        }

        private void adGiristxt_Leave(object sender, EventArgs e)
        {
            if (adGiristxt.Text == "")
            {
                adGiristxt.Text = "Kullanıcı Adınızı Girin:";
            }
        }

        private void sifreGiristxt_Enter(object sender, EventArgs e)
        {
            if (sifreGiristxt.Text == "Parolayı Girin:")
            {
                sifreGiristxt.Text = "";
            }
        }

        private void sifreGiristxt_Leave(object sender, EventArgs e)
        {
            if (sifreGiristxt.Text == "")
            {
                sifreGiristxt.Text = "Parolayı Girin:";
            }
        }
    }
}
