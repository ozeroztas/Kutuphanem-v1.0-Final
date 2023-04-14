using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphanem.Kaynak
{
    public partial class KaynakEkleForm : Form
    {
        public KaynakEkleForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kaynaklar kaynaklar = new Kaynaklar();
            kaynaklar.kaynak_ad = adKaynaktxt.Text;
            kaynaklar.kaynak_yazar = yazarKaynaktxt.Text;
            kaynaklar.kaynak_yayinevi = yayineviKaynaktxt.Text;
            kaynaklar.kaynak_sayfasayisi = Convert.ToInt16(numericUpDown1.Value);
            kaynaklar.kaynak_basimtarihi = dateTimePicker1.Value;
            db.Kaynaklar.Add(kaynaklar);
            db.SaveChanges();

            var kListe = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kListe.ToList();
        }
    }
}
