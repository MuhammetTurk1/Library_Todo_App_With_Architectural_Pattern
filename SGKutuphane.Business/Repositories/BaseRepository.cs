using SGKutuphane.Business.DomainObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Business.Repositories
{
    public class BaseRepository<T> : IDataRepository<T> where T : IDataObject
    {
        public void Ekle(T veri)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            var a = typeof(T);
            var propDizi = a.GetProperties();
            string tableName = "";
            var attributes = a.GetCustomAttributes(typeof(DisplayNameAttribute), true);
            if (attributes[0] is DisplayNameAttribute)
            {
                tableName = ((DisplayNameAttribute)attributes[0]).DisplayName;
            }
            for (int i = 0; i < propDizi.Length; i++)
            {
                if (propDizi[i].Name != "Id")
                    data.Add(propDizi[i].Name, propDizi[i].GetValue(veri, null));
            }

            SGKutuphane.Data.DataOptions.DataContext.Ekle(tableName, data);
        }

        public void Getir()
        {
            throw new NotImplementedException();
        }


        public void Guncelle(int id, T veri)
        {
            throw new NotImplementedException();
        }
    }
}
