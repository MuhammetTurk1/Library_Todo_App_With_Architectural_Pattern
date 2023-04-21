using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGKutuphane.Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yazarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Screens.Kategories.FrmKategoriListesi().ShowDialog();
        }

        private void yazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new Screens.Yazar.FrmYazarListesi().ShowDialog();
        }

        private void yayınEviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Screens.YayınEvi.FrmYayınEviListesi().ShowDialog();
        }

        private void öğreciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Screens.Ögrenci.FrmÖgrenciListesi().ShowDialog();
        }

        private void kullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Screens.Kullanıcı.FrmKullanıcıListesi().ShowDialog();
        }
    }
}
