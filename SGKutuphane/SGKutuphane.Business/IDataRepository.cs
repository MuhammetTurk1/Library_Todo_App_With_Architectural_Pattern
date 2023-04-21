using SGKutuphane.Business.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Business
{
    public interface IDataRepository<T> where T:IDataObject
    {
        void Ekle(T veri);
        void Guncelle(int id,T veri);
        void Getir();
    }
}
