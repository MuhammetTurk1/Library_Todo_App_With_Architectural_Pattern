using SGKutuphane.Application.Screens.Kullanıcı;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGKutuphane.Application
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SGKutuphane.Data.DataOptions.SetDataProvider(
                Data.DataProviderTypes.SqlServer,
                @"Data Source=.\; Initial Catalog=SGKutuphane; User ID=Muser; Password=123123;"
                );
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            new FrmLogin().ShowDialog();
            if(SGKutuphane.Bussiness.Repositories.UserRepository.loggedUser !=null )
            {

                System.Windows.Forms.Application.Run(new Form1());
            }

        }
    }
}
