using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Data
{
    public interface IDataContext
    {
        void Ekle(string dataName, Dictionary<string, object> veriler);
        void Guncelle(string dataName,int id, Dictionary<string, object> veriler);
        void Sil(string dataName, int id);
        DataTable Getir(string dataName, int id);
        DataTable HepsiniGetir(string dataName);

    }
}
