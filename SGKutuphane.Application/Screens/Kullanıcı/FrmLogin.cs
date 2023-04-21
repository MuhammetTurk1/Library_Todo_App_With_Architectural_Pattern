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

namespace SGKutuphane.Application.Screens.Kullanıcı
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txtKullanıcı.Text;
            string password = txt_Şifre.Text;
            var rr = new SGKutuphane.Bussiness.Repositories.UserRepository();

            SGKutuphane.Bussiness.DomainObjects.Kullanıcı k = rr.Login(username, password);

            if (k == null)
            {

                MessageBox.Show("hatalı giriş");
                return;
            }
            SGKutuphane.Bussiness.Repositories.UserRepository.loggedUser = k;
            this.Close();
        }

       
    }
}

