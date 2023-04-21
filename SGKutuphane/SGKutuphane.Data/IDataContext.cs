using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Data
{
    public interface IDataContext
    {
        void Ekle(string dataName,Dictionary<string,object> veriler);
        void Guncelle(string dataName, int id, Dictionary<string, object> veriler);
        void Sil(string dataName, int id);
        Dictionary<string, object> Getir(string dataName, int id);
        void HepsiniGetir(string dataName);
    }
}
