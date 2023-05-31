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
            //var kayitList = from kayit in db.Kayitlar select new
            //    {
            //        kayit.Kullanicilar.kullanici_ad, kayit.Kaynaklar.kaynak_ad, kayit.alis_tarihi, kayit.son_tarih,
            //        kayit.durum
            //    };
            var kayitList = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Kullanıcı ID";
            dataGridView1.Columns[2].HeaderText = "Kaynak ID";
            dataGridView1.Columns[3].HeaderText = "Alış Tarihi";
            dataGridView1.Columns[4].HeaderText = "Son Tarih";
            dataGridView1.Columns[5].HeaderText = "Durum";

            var kaynakList = db.Kaynaklar.ToList();
            dataGridView2.DataSource = kaynakList.ToList();

            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[6].Visible = false;

            dataGridView2.Columns[1].HeaderText = "Ad";
            dataGridView2.Columns[2].HeaderText = "Yazar";
            dataGridView2.Columns[3].HeaderText = "Yayınevi";
            dataGridView2.Columns[4].HeaderText = "Sayfa";
            dataGridView2.Columns[5].HeaderText = "Basım";

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

        private void button2_Click(object sender, EventArgs e)
        {
            String secilenKisiTC = TCBultxt.Text;
            var secilenKisi = db.Kullanicilar.Where(x=> x.kullanici_tc.Equals(secilenKisiTC)).FirstOrDefault();
            int secilenKitapId = Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenKitap = db.Kaynaklar.Where(x=> x.kaynak_id == secilenKitapId).FirstOrDefault();

            Kayitlar yeniKayit = new Kayitlar();
            yeniKayit.kitap_id = secilenKitap.kaynak_id;
            yeniKayit.kullanici_id = secilenKisi.kullanici_id;
            yeniKayit.alis_tarihi = DateTime.Today;
            yeniKayit.son_tarih = DateTime.Today.AddDays(15);
            yeniKayit.durum = false;
            db.Kayitlar.Add(yeniKayit);
            db.SaveChanges();
            var kayitList = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
