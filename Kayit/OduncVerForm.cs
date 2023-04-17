using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphanem.Kayit
{
    public partial class OduncVerForm : Form
    {
        public OduncVerForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        private void OduncVerForm_Load(object sender, EventArgs e)
        {
            var kayitList = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();

            var kaynakList = db.Kaynaklar.ToList();
            dataGridView2.DataSource = kaynakList.ToList();

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Kullanıcı ID";
            dataGridView1.Columns[2].HeaderText = "Kaynak ID";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String arananSecilen = TCBultxt.Text;
            var araKullanici = db.Kullanicilar.Where(x=> x.kullanici_tc == arananSecilen).FirstOrDefault();

            if (araKullanici != null)
                label2.Text = araKullanici.kullanici_ad + " " + araKullanici.kullanici_soyad;
            else
                label2.Text = "Böyle bir kullanıcı bulunamadı";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String gelenAd = textBox1.Text;
            var bulunanKaynaklar = db.Kaynaklar.Where(x=> x.kaynak_ad.Contains(gelenAd)).ToList();
            dataGridView2.DataSource = bulunanKaynaklar;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
