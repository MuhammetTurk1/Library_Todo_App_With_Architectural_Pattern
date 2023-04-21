using SGKutuphane.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGKutuphane.Application.Screens
{
    public partial class FrmListBase<T> : Form where T : class, new()
    {
        public FrmListBase()
        {
            InitializeComponent();
        }

        private int GetSelectedRowsId()
        {
            if (dgData.SelectedRows.Count < 1) return 0;
            try
            {
                var dgRow = dgData.SelectedRows[0];
                var dgCell = dgRow.Cells["ıd"];
                return Convert.ToInt32(dgCell.Value);
            }
            catch (Exception)
            {
                return 0;
                
            }

        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydıSil_Click(object sender, EventArgs e)
        {
            int id = GetSelectedRowsId();
            if (id == 0)
            {
                MessageBox.Show("Lütfen bir satır Seciniz");
                return;
            }
          DialogResult dr =  MessageBox.Show(
                "Kaydı sildiğinizden emin misiniz ?",
                "Dikkat!",

            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (dr ==DialogResult.Yes)
            {
                var repo = new SGKutuphane.Bussiness.Repositories.BaseRepository<T>();
                repo.Sil(id);
                FillDataGrid();
            }

        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {

            int id = GetSelectedRowsId();
            if (id == 0)
            {
                MessageBox.Show("Lütfen bir satır Seciniz");
                return;
            }
            Düzenle( id);
            FillDataGrid();

        }

        public virtual void Düzenle(int id)
        {
            MessageBox.Show("Bu method Override edilmelidir!");

        }
        public virtual void Oluştur()
        {
            MessageBox.Show("Bu method Override edilmelidir!");

        }
        public virtual object GetData()
        {
            var repo = new SGKutuphane.Bussiness.Repositories.BaseRepository<T>();
            return repo.HepsiniGetir();
        }


        public virtual void FillDataGrid()
        {
            try
            { 
                dgData.DataSource = GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("mami haklıymış");
            }

        }
       

        private void btnYeniKayıt_Click(object sender, EventArgs e)
        {
            Oluştur();
            FillDataGrid();
        }

        private void FrmListBase_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }
    }
}
