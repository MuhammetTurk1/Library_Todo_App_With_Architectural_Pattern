using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Bussiness
{
    public interface IDataRepository<T> where T : class
    {
        void Ekle(T veri);

        void Guncelle(int id, T veri);

        void Sil(int id);
        T Getir(int id);
        List<T> HepsiniGetir(bool isWiew = false);//list yaptık cunkü artık t değil birden fazla getireceği için list oldu
    }
}
