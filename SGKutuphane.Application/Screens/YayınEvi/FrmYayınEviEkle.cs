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

namespace SGKutuphane.Application.Screens.YayınEvi
{
    public partial class FrmYayınEviEkle : Form
    {
        public int YayınEviId = -1;
        public FrmYayınEviEkle()
        {
            InitializeComponent();
        }

        private void FrmYayınEviEkle_Load(object sender, EventArgs e)
        {
            if (YayınEviId != -1)
            {
                var r = new SGKutuphane.Bussiness.Repositories.BaseRepository<SGKutuphane.Bussiness.DomainObjects.YayınEvi>();
                SGKutuphane.Bussiness.DomainObjects.YayınEvi k = r.Getir(YayınEviId);
                txtYayınEvi.Text = k.YayınEviAdı;
            }
        }

        private void btnKaydet11_Click(object sender, EventArgs e)
        {
            SGKutuphane.Bussiness.DomainObjects.YayınEvi k = new SGKutuphane.Bussiness.DomainObjects.YayınEvi();
            k.OlusturmaID = SGKutuphane.Bussiness.Repositories.UserRepository.loggedUser.ıd;
            k.OlusturmaTarihi = DateTime.Now;
            k.YayınEviAdı = txtYayınEvi.Text;

            var r = new SGKutuphane.Bussiness.Repositories.BaseRepository<SGKutuphane.Bussiness.DomainObjects.YayınEvi>();

            if (YayınEviId == -1)
            {

                r.Ekle(k);

            }
            else
            {
                r.Guncelle(YayınEviId, k);
            }

            this.Close();
        }
    }
}
