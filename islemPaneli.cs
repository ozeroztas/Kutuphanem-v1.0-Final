using Kütüphanem.Kayit;
using Kütüphanem.Kaynak;
using Kütüphanem.Kullanici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphanem
{
    public partial class islemPaneli : Form
    {
        public islemPaneli()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void islemPaneli_Load(object sender, EventArgs e)
        {
            ekleKullanicibtn.Visible = false;
            silKullanicibtn.Visible = false;
            guncelleKullanicibtn.Visible = false;

            ekleKaynakbtn.Visible = false;
            silKaynakbtn.Visible = false;
            guncelleKaynakbtn.Visible = false;
        }

        private KullaniciListeForm klisteForm;
        private void Kullanicibtn_Click(object sender, EventArgs e)
        {
            
            if (ekleKullanicibtn.Visible == false)
            {
                ekleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
                klisteForm = new KullaniciListeForm();
                klisteForm.MdiParent = this;
                klisteForm.Show();
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
                klisteForm.Close();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private KullaniciEkleForm ekleForm;

        private bool ekleKullaniciDurum = false;
        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            if (ekleKullaniciDurum == false)
            {
                ekleForm = new KullaniciEkleForm();
                ekleForm.MdiParent = this;
                ekleForm.Show();
                ekleKullaniciDurum = true;
            }
            else
            {
                ekleForm.Close();
                ekleKullaniciDurum = false;
            }

        }

        private KaynakListeForm kListe;
        private void button2_Click(object sender, EventArgs e)
        {
            if (ekleKaynakbtn.Visible == false)
            {
                ekleKaynakbtn.Visible = true;
                silKaynakbtn.Visible = true;
                guncelleKaynakbtn.Visible = true;
                kListe = new KaynakListeForm();
                kListe.MdiParent = this;
                kListe.Show();
            }
            else
            {
                ekleKaynakbtn.Visible = false;
                silKaynakbtn.Visible = false;
                guncelleKaynakbtn.Visible = false;
                kListe.Close();
            }
        }

        private KaynakEkleForm kEkle;
        private bool ekleKaynakDurum = false;
        private void ekleKaynakbtn_Click(object sender, EventArgs e)
        {
            if (ekleKaynakDurum == false)
            {
                kEkle = new KaynakEkleForm();
                kEkle.MdiParent = this;
                kEkle.Show();
                ekleKaynakDurum = true;
            }
            else
            {
                kEkle.Close();
                ekleKaynakDurum = false;
            }
        }

        private KaynakSilForm kaynakSil;
        private void silKaynakbtn_Click(object sender, EventArgs e)
        {
            if (ekleKaynakDurum == false)
            {
                kaynakSil = new KaynakSilForm();
                kaynakSil.MdiParent = this;
                kaynakSil.Show();
                ekleKaynakDurum = true;
            }
            else
            {
                kaynakSil.Close();
                ekleKaynakDurum = false;
            }
        }

        private KullaniciSilForm kSil;
        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            if (ekleKullaniciDurum == false)
            {
                kSil = new KullaniciSilForm();
                kSil.MdiParent = this;
                kSil.Show();
                ekleKullaniciDurum = true;
            }
            else
            {
                kSil.Close();
                ekleKullaniciDurum = false;
            }
        }

        private KullaniciGuncelleForm kGuncel;
        private void guncelleKullanicibtn_Click(object sender, EventArgs e)
        {
            if (ekleKullaniciDurum == false)
            {
                kGuncel = new KullaniciGuncelleForm();
                kGuncel.MdiParent = this;
                kGuncel.Show();
                ekleKullaniciDurum = true;
            }
            else
            {
                kGuncel.Close();
                ekleKullaniciDurum = false;
            }
        }

        private KaynakGuncelleForm kaynakGuncel;
        private void guncelleKaynakbtn_Click(object sender, EventArgs e)
        {
            if (ekleKaynakDurum == false)
            {
                kaynakGuncel = new KaynakGuncelleForm();
                kaynakGuncel.MdiParent = this;
                kaynakGuncel.Show();
                ekleKaynakDurum = true;
            }
            else
            {
                kaynakGuncel.Close();
                ekleKaynakDurum = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OduncVerForm odunc = new OduncVerForm();
            odunc.MdiParent = this;
            odunc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GeriAlForm geri = new GeriAlForm();
            geri.MdiParent = this;
            geri.Show();
        }
    }
}
