using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Data.DataProviders
{
    internal class SqlDataProvider : IDataContext
    {
        private SqlCommand KomutOlustur (string sorgu)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = DataOptions.ConnectionText;
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText= sorgu;
            return cmd;
        }
        public void Ekle(string dataName, Dictionary<string, object> veriler)
        {

            SqlCommand cmd = KomutOlustur("");
                                         //KitapAdi    //@KitapAdi
            string sql = "INSERT INTO {0} ({1}) VALUES ({2})";
            string sutunlar = ""; 
            string sutunlarParametre = "";

            foreach (var item in veriler)
            {
                sutunlar += item.Key + ",";
                sutunlarParametre += "@" + item.Key + ",";
                cmd.Parameters.AddWithValue("@" + item.Key, item.Value); //keyimizi aynı zamanda bir değişken yaptık bir yukarda. sonra bu değişkenleri kullanalarak burada içine veri doldurduk.


            }
            sutunlar = sutunlar.TrimEnd(',');
            sutunlarParametre = sutunlarParametre.TrimEnd(',');

            sql = String.Format(sql, dataName, sutunlar, sutunlarParametre);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            cmd.Dispose();
        }
  
        
        public DataTable Getir(string dataName, int id)
        {
            //  string sql = "SELECT * FROM " + dataName + " where ıd=" + id;
            string sql = $"SELECT * FROM {dataName} where ıd={id}";
            var cmd = KomutOlustur(sql);

            SqlDataReader dr = cmd.ExecuteReader();


            DataTable dt = new DataTable(); ////yeni bir tablo oluşturmus gibi düşün
            dt.Load(dr);

            ////BURAYI ARTIK LOADLA YAPCAGIZ
            //while (dr.Read())
            //{
            //    Dictionary<string, object> data = new Dictionary<string, object>();
            //    data.Add("ıd", dr["ıd"]);
            //    data.Add("KategoriAdı", dr["KategoriAdı"]);
            //    data.Add("OlusturanId", dr["OlusturanId"]);
            //    data.Add("OlusturmaTarihi", dr["OlusturmaTarihi"]);
            //    return data;
            //}
            return dt;//eğerki bir kayıt bulmamasssan geriye reurn de;
        }

        public void Guncelle(string dataName, int id, Dictionary<string, object> veriler)
        {
            SqlCommand cmd = KomutOlustur("");

            string sql = "UPDATE {0} SET {1} WHERE ıd={2}";
            string sutunlar = "";

            foreach (var item in veriler)
            {
                sutunlar += item.Key + "=" + "@"+ item.Key +",";
                cmd.Parameters.AddWithValue("@" + item.Key, item.Value); //keyimizi aynı zamanda bir değişken yaptık bir yukarda. sonra bu değişkenleri kullanalarak burada içine veri doldurduk.


            }
            sutunlar = sutunlar.TrimEnd(',');

            sql = String.Format(sql, dataName, sutunlar,id);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            cmd.Dispose();
        }

        public DataTable HepsiniGetir(string dataName) //GETİRLE AYNI KOD İLE ÇALIŞIYOR AMA WHERE ŞARTI YOK .
        {
            string sql = $"SELECT * FROM {dataName} ";
            var cmd = KomutOlustur(sql);

            SqlDataReader dr = cmd.ExecuteReader();


            DataTable dt = new DataTable(); ////yeni bir tablo oluşturmus gibi düşün
            dt.Load(dr);
            return dt;
        }

        public void Sil(string dataName, int id)
        {

            string sql = $"DELETE FROM {dataName} WHERE ıd={id}";
            var cmd = KomutOlustur(sql);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            cmd.Dispose();

             
        }
    }
}
