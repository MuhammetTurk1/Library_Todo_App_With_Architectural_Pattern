using SGKutuphane.Bussiness.DomainObjects;
using System;

namespace SGKutuphane.Application.Screens.Kullanıcı
{
    public partial class FrmKullanıcıListesi : FrmListBase<SGKutuphane.Bussiness.DomainObjects.Kullanıcı>
    {
        public FrmKullanıcıListesi()
        {
            InitializeComponent();
        }

        private void FrmKullanıcıListesi_Load(object sender, EventArgs e)
        {

        }
        public override void Düzenle(int id)
        {
            FrmKullanıcıEkle a = new FrmKullanıcıEkle();
            a.KullanıcıID = id;
            a.ShowDialog();
        }
        public override void Oluştur()
        {
            FrmKullanıcıEkle b = new FrmKullanıcıEkle();
            b.ShowDialog();
        }


    }
}
