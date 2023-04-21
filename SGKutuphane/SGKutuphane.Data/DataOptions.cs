using SGKutuphane.Data.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Data
{
    public class DataOptions
    {
        public static IDataContext DataContext { get; set; }
        public static string ConnectionText { get; set; }
        public static void SetDataProvider(DataProviderTypes types,string connectionText) {
            ConnectionText = connectionText;

            if (types == DataProviderTypes.SqlServer)
                DataContext = new SqlDataProvider();
            else if (types == DataProviderTypes.File)
                DataContext = new FileDataProvider();
            else
                throw new Exception("Deger Girmedin");
        }
    }
}
