using SGKutuphane.Bussiness.DomainObjects;
using System;

namespace SGKutuphane.Application.Screens.Kategories
{
    public partial class FrmKategoriListesi : FrmListBase<Kategori>
    {
        public FrmKategoriListesi()
        {
            InitializeComponent();
        }

        private void FrmKategoriListesi_Load(object sender, EventArgs e)
        {

        }
        public override void Düzenle(int id)
        {
            var frm = new FrmKategoriEkle();
            frm.kategoriID = id;
            frm.ShowDialog();
        }
        public override void Oluştur()
        {
            //new FrmKategoriEkle().ShowDialog();

            FrmKategoriEkle k = new FrmKategoriEkle();
            k.ShowDialog();
        }

        public override object GetData()
        {
            var repo = new SGKutuphane.Bussiness.Repositories.BaseRepository<KategoriView>();
           return repo.HepsiniGetir(true);
        }
    }
}
