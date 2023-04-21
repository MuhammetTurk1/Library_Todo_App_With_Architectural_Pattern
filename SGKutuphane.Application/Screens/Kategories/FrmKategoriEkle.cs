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

namespace SGKutuphane.Application.Screens.Kategories
{
    public partial class FrmKategoriEkle : Form
    {
        public int kategoriID = -1;
        public FrmKategoriEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kategori k = new Kategori();
            k.OlusturanId = SGKutuphane.Bussiness.Repositories.UserRepository.loggedUser.ıd;
            k.OlusturmaTarihi = DateTime.Now;
            k.KategoriAdı = txtKategori.Text;

            var r =new SGKutuphane.Bussiness.Repositories.BaseRepository<Kategori>();

            if (kategoriID == -1)
            {

                r.Ekle(k);

            }
            else
            {
                r.Guncelle(kategoriID, k);
            }

            this.Close();
            
        }

        private void FrmKategoriEkle_Load(object sender, EventArgs e)
        {
            if (kategoriID != -1)
            {
                var r = new SGKutuphane.Bussiness.Repositories.BaseRepository<Kategori>();
                Kategori k = r.Getir(kategoriID);
                txtKategori.Text = k.KategoriAdı;
            }

        }
    }
}
