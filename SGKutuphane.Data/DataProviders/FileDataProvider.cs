using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Data.DataProviders
{
    internal class FileDataProvider : IDataContext
    {
        public void Ekle(string dataName, Dictionary<string, object> veriler)
        {
            throw new NotImplementedException();
        }

        public DataTable Getir(string dataName, int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(string dataName, int id, Dictionary<string, object> veriler)
        {
            throw new NotImplementedException();
        }

        public DataTable HepsiniGetir(string dataName)
        {
            throw new NotImplementedException();
        }

        public void Sil(string dataName, int id)
        {
            throw new NotImplementedException();
        }
    }
}
