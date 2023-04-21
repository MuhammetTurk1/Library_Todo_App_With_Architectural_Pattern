using SGKutuphane.Application.Screens.Kategories;
using System;

namespace SGKutuphane.Application.Screens.YayınEvi
{
    public partial class FrmYayınEviListesi : FrmListBase<SGKutuphane.Bussiness.DomainObjects.YayınEvi>
    {
        public FrmYayınEviListesi()
        {
            InitializeComponent();
        }

        private void FrmYayınEviListesi_Load(object sender, EventArgs e)
        {

        }
        public override void Düzenle(int id)
        {
            var frm = new FrmYayınEviEkle();
            frm.YayınEviId = id;
            frm.ShowDialog();
        }
        public override void Oluştur()
        {
            //new FrmKategoriEkle().ShowDialog();

            FrmYayınEviEkle k = new FrmYayınEviEkle();
            k.ShowDialog();
        }

    }
}
