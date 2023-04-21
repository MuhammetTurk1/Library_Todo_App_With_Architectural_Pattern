using System;

namespace SGKutuphane.Application.Screens.Ögrenci
{
    public partial class FrmÖgrenciListesi : FrmListBase<SGKutuphane.Bussiness.DomainObjects.Ögrenci>
    {
        public FrmÖgrenciListesi()
        {
            InitializeComponent();
        }

        private void FrmÖgrenciListesi_Load(object sender, EventArgs e)
        {

        }
        public override void Düzenle(int id)
        {
            var frm = new FrmÖgrenciEkle();
            frm.OgrenciID = id;
            frm.ShowDialog();
        }
        public override void Oluştur()
        {
            //new FrmKategoriEkle().ShowDialog();

            FrmÖgrenciEkle k = new FrmÖgrenciEkle();
            k.ShowDialog();
        }


    }
}
