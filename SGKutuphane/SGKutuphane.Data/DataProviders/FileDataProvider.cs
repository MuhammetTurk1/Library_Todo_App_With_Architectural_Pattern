using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SGKutuphane.Data.DataProviders
{
    internal class FileDataProvider : IDataContext
    {
        public void Ekle(string dataName, Dictionary<string, object> veriler)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            string data = sr.Serialize(veriler);

            File.WriteAllText(DataOptions.ConnectionText + "/" + dataName + ".txt", data);
        }

        public Dictionary<string, object> Getir(string dataName, int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(string dataName, int id, Dictionary<string, object> veriler)
        {
            throw new NotImplementedException();
        }

        public void HepsiniGetir(string dataName)
        {
            throw new NotImplementedException();
        }

        public void Sil(string dataName, int id)
        {
            throw new NotImplementedException();
        }
    }
}
