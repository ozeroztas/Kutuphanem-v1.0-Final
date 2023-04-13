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
        }

        private void Kullanicibtn_Click(object sender, EventArgs e)
        {
            if (ekleKullanicibtn.Visible == false)
            {
                ekleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
            }

            KullaniciListeForm klisteForm = new KullaniciListeForm();
            klisteForm.MdiParent = this;
            klisteForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {

        }
    }
}
