using SGKutuphane.Application.Screens.Kategories;
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
    public partial class FrmYazarListesi : FrmListBase<Yazarr>
    {
        public FrmYazarListesi()
        {
            InitializeComponent();
        }

        private void FrmYazarListesi_Load(object sender, EventArgs e)
        {

        }
        public override void Düzenle(int id)
        {
            var frm = new FrmYazarEkle();
            frm.yazarID = id;
            frm.ShowDialog();
        }
        public override void Oluştur()
        {
            //new FrmKategoriEkle().ShowDialog();

            FrmYazarEkle k = new FrmYazarEkle();
            k.ShowDialog();
        }
    }
}
