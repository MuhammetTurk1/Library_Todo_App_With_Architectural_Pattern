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

namespace SGKutuphane.Application.Screens.Yazar
{
    public partial class FrmYazarEkle : Form
    {
        public int yazarID = -1;
        public FrmYazarEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet1_Click(object sender, EventArgs e)
        {
            Yazarr k = new Yazarr();
            k.OlusturanID2 = SGKutuphane.Bussiness.Repositories.UserRepository.loggedUser.ıd;
            k.OlusturmaTarihi2 = DateTime.Now;
            k.YazarAdı2 = txtYazar1.Text;

            var r = new SGKutuphane.Bussiness.Repositories.BaseRepository<Yazarr>();

            if (yazarID ==-1 )
            {

                r.Ekle(k);
            }
            else
            {
                r.Guncelle(yazarID, k);
            }

            this.Close();

        }

        private void FrmYazarEkle_Load(object sender, EventArgs e)
        {
            if (yazarID != -1)
            {
                var r = new SGKutuphane.Bussiness.Repositories.BaseRepository<Yazarr>();
                Yazarr k = r.Getir(yazarID);
                txtYazar1.Text = k.YazarAdı2;
            }
        }
    }
}
