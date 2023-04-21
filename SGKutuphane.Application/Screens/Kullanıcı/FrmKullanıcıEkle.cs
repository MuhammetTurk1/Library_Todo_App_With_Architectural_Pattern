using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGKutuphane.Application.Screens.Kullanıcı
{
    public partial class FrmKullanıcıEkle : Form
    {
        public int KullanıcıID = -1;
        public FrmKullanıcıEkle()
        {
            InitializeComponent();
        }

        private void FrmKullanıcıEkle_Load(object sender, EventArgs e)
        {
            if (KullanıcıID != -1)
            {
                var a =new SGKutuphane.Bussiness.Repositories.BaseRepository<SGKutuphane.Bussiness.DomainObjects.Kullanıcı>();
                var  k = a.Getir(KullanıcıID);

                txtKullanıcıAdi.Text = k.KullanıcıAdi  ;
                txtAdi.Text = k.Adi;
                txtSifre.Text  = k.Sifre;
                txtSoyadı.Text = k.Soyadı;
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            var k = new SGKutuphane.Bussiness.DomainObjects.Kullanıcı();

            k.KullanıcıAdi = txtKullanıcıAdi.Text;
            k.Adi = txtAdi.Text;
            k.Sifre=txtSifre.Text;
            k.Soyadı = txtSoyadı.Text;

             
           var sent = new SGKutuphane.Bussiness.Repositories.BaseRepository<SGKutuphane.Bussiness.DomainObjects.Kullanıcı>();

            if(KullanıcıID== -1)
            {
                sent.Ekle(k);
            }
            if(KullanıcıID != -1)
            {
                sent.Guncelle(KullanıcıID, k);
            }
            this.Close();
        }



       

    }
}
