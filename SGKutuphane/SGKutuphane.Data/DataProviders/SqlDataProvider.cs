using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Data.DataProviders
{
    internal class SqlDataProvider : IDataContext
    {
        private SqlCommand KomutOlustur(string sorgu)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = DataOptions.ConnectionText;
            cnn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = sorgu;
            return cmd;
        }
        public void Ekle(string dataName, Dictionary<string, object> veriler)
        {


            SqlCommand cmd = KomutOlustur("");

            string sql = "INSERT INTO {0} ({1}) VALUES ({2})";
            string sutunlar = "";
            string sutunlarParametre = "";

            foreach (var item in veriler)
            {
                sutunlar += item.Key + ",";
                sutunlarParametre += "@" + item.Key + ",";
                cmd.Parameters.AddWithValue("@" + item.Key, item.Value);
            }
            sutunlar = sutunlar.TrimEnd(',');
            sutunlarParametre = sutunlarParametre.TrimEnd(',');

            sql = String.Format(sql, dataName, sutunlar, sutunlarParametre);

            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            cmd.Dispose();

        }

        public Dictionary<string,object> Getir(string dataName, int id)
        {
            string sql = $"SELECT * FROM {dataName} WHERE Id={id}";
            var cmd = KomutOlustur(sql);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("Id", dr["Id"]);
                data.Add("KategoriAdi", dr["KategoriAdi"]);
                data.Add("OlusturanId", dr["OlusturanId"]);
                data.Add("OlusturmaTarihi", dr["OlusturmaTarihi"]);
                return data;
            }
            return null;
        }


        public void Guncelle(string dataName, int id, Dictionary<string, object> veriler)
        {

            

            SqlCommand cmd = KomutOlustur("");
            string sql = "UPDATE {0} SET {1} WHERE Id = {2}";
            string sutunlar = "";

            foreach (var item in veriler)
            {
                sutunlar += item.Key + " = " + "@"+item.Key + ",";
                cmd.Parameters.AddWithValue("@" + item.Key, item.Value);
            }
            sutunlar = sutunlar.TrimEnd(',');

            sql = String.Format(sql, dataName, sutunlar, id);

            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            cmd.Dispose();
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
