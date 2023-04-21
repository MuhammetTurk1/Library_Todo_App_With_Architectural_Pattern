using SGKutuphane.Business.DomainObjects;
using SGKutuphane.Business.Repositories;
using SGKutuphane.Data;
using SGKutuphane.Data.DataProviders;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JavaScriptSerializer sr = new JavaScriptSerializer();
            string s = File.ReadAllText(Environment.CurrentDirectory + "/baglanti.txt");
            DataInfo di = sr.Deserialize<DataInfo>(s);
            ////Data Source=.\;Initial Catalog=SGKutuphane;User ID=kuser;Password = 123123;
            SGKutuphane.Data.DataOptions.SetDataProvider(
                di.Baglanti == "SQL" ? DataProviderTypes.SqlServer : DataProviderTypes.File,
                di.VeriYeri
                );

            //IDataContext dc = SGKutuphane.Data.DataOptions.DataContext;
            BaseRepository<Yazar> r = new BaseRepository<Yazar>();
            //Dictionary<string, object> data = dc.Getir("tblKategori", 2);
            //foreach (var item in data)
            //{
            //    Console.WriteLine("Sütun Adı : " + item.Key + ", Değeri : " + item.Value);
            //}

            //Kategori k = new Kategori();
            //k.KategoriAdi = "Roman";
            //k.OlusturanId = 0;
            //k.OlusturmaTarihi = DateTime.Now;

            Yazar y = new Yazar();
            y.YazarAdi = "Semih KARDUZ";
            y.OlusturmaTarihi = DateTime.Now;
            y.OlusturanId = 3;


            r.Ekle(k);

            //SqlConnection cnn = new SqlConnection();
            //cnn.ConnectionString = @"Data Source=.\;Initial Catalog=SGKutuphane;User ID=kuser;Password = 123123;";
            //cnn.Open();

            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = cnn;
            //cmd.CommandText = "DELETE FROM tblKategori WHERE Id = @paratreid";

            //cmd.Parameters.AddWithValue("@paratreid", 1);

            //cmd.ExecuteNonQuery();
            Console.ReadKey();

        }
    }
}
