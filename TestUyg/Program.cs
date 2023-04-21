using SGKutuphane.Bussiness.DomainObjects;
using SGKutuphane.Bussiness.Repositories;
using SGKutuphane.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUyg
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SGKutuphane.Data.DataOptions.SetDataProvider(DataProviderTypes.SqlServer
                , @"Data Source=.\; Initial Catalog=SGKutuphane; User ID=Muser;
                  Password=123123;"
                );
            //IDataContext dc = SGKutuphane.Data.DataOptions.DataContext;
            //dc nin içinde bizim hangi data ya veri göndereceğimiz var

            BaseRepository<Yazarr> r = new BaseRepository<Yazarr>();
            //Kategori k = new Kategori();
            //k.KategoriAdı = "GALATASARAY";
            //k.OlusturanId = 1907;
            //k.OlusturmaTarihi = DateTime.Now;


            List<Yazarr> kk = r.HepsiniGetir();


            r.Sil(2);
            //int a = 0;




            //3 GETİR GÜNCELLE

            //Kategori kk = r.Getir(3);
            //kk.KategoriAdı = " macera";
            //r.Guncelle(3, kk);




            //GETİR2 
            //  Kategori kk= r.Getir(2);




            //Ekle
            // r.Ekle(k);




            // GÜNCELLE
            //r.Guncelle(4, k);

            // dc datamız ve ekle metodu ise ona interface olarak atadığımız classın içinde




            //Getir
            //Dictionary<string, object> data2 = dc.Getir("tbl_Kategori",2);

            //foreach (var item in data2)
            //{
            //    Console.WriteLine("Sutün adı : " + item.Key + "Sütun elemanları : " + item.Value);
            //}
            //Console.ReadKey();

        }
    }
}