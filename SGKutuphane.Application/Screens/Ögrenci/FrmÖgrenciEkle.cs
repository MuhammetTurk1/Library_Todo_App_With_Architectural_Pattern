using SGKutuphane.Bussiness.DomainObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGKutuphane.Application.Screens.Ögrenci
{
    
    public partial class FrmÖgrenciEkle : Form
    {
        public int OgrenciID = -1;
        public FrmÖgrenciEkle()
        {
            InitializeComponent();
        }

        private void FrmÖgrenciEkle_Load(object sender, EventArgs e)
        {
            if(OgrenciID != -1)
            {
                var r = new SGKutuphane.Bussiness.Repositories.BaseRepository<SGKutuphane.Bussiness.DomainObjects.Ögrenci>();
                SGKutuphane.Bussiness.DomainObjects.Ögrenci a = r.Getir(OgrenciID);
                txtOgrenciAdı.Text =a.OgrenciAdı;
                 
            }
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SGKutuphane.Bussiness.DomainObjects.Ögrenci k = new SGKutuphane.Bussiness.DomainObjects.Ögrenci();
            k.OgrenciAdı = txtOgrenciAdı.Text;
            k.OgrenciSoyadı = txtOgrenciSoyadı.Text;
            k.OgrenciSınıfı = txtOgrenciSınıfı.Text;
            k.OgrenciAdresi = txtOgrenciAdresi.Text;
            k.Telefon = txtTelefon.Text;
            k.EmailAdresi = txtEmailAdresi.Text;
            k.OgrenciNumarasi = txtOgrenciNumarasi.Text;
            k.OkulAdı = txtOkulAdı.Text;

            var r = new SGKutuphane.Bussiness.Repositories.BaseRepository<SGKutuphane.Bussiness.DomainObjects.Ögrenci>();

            if (OgrenciID == -1)
            {
                r.Ekle(k);
            }
            else
            {
                r.Guncelle(OgrenciID, k);
            }
            this.Close();

        }
    }
}
