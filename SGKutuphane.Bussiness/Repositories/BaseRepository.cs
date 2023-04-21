using SGKutuphane.Bussiness.DomainObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Bussiness.Repositories
{
    public class BaseRepository<T> : IDataRepository<T> where T : class,new()
    {
   
        private Dictionary<string, object> objectToDictionary(T veri)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            var a = typeof(T);
            var propDizi = a.GetProperties();



            for (int i = 0; i < propDizi.Length; i++)
            {
                if (propDizi[i].Name != "Id" && propDizi[i].Name != "ıd")
                    data.Add(propDizi[i].Name, propDizi[i].GetValue(veri, null));
            }
            return data;
        }

        private T DataTableToObject(DataRow satir)
        { 
            

            var a = typeof(T);
            var propDizi = a.GetProperties();

            T objemiz = Activator.CreateInstance<T>();
            // T objemiz = new T()

                for (int j = 0; j < satir.Table.Columns.Count; j++) //satırın tablosunun sutunlarını gez dedik
                {
                    DataColumn sutun = satir.Table.Columns[j];
                    object veri = satir[sutun];

                if(DBNull.Value!=veri)
                 a.GetProperty(sutun.ColumnName).SetValue(objemiz,veri);
                }
            
            return objemiz;
        }
        private string GetViewName()
        {
            var a = typeof(T);
            string tableName = "";
            var attributes = a.GetCustomAttributes(typeof(DBNVNameAtribute), true);
            if (attributes[0] is DBNVNameAtribute)
            {
                tableName = ((DBNVNameAtribute)attributes[0]).ViewName;
            }
            return tableName;

        }
        private string GetTableName()
        {
            var a = typeof(T);
            string tableName = "";
            var attributes = a.GetCustomAttributes(typeof(DBNVNameAtribute), true);
            if (attributes[0] is DBNVNameAtribute)
            {
                tableName = ((DBNVNameAtribute)attributes[0]).TableName;
            }
            return tableName;

        }
        public void Ekle(T veri)
        {
            Dictionary<string, object> data = objectToDictionary(veri);
            string tableName = GetTableName();
            

            SGKutuphane.Data.DataOptions.DataContext.Ekle(tableName, data);

             


            //Dictionary<string, Object> data = new Dictionary<string, Object>();
            //data.Add("KategoriAdı", veri.KategoriAdı);
            //data.Add("OlusturanId", veri.OlusturanId);
            //data.Add("OlusturmaTarihi", veri.OlusturmaTarihi);

            //SGKutuphane.Data.DataOptions.DataContext.Ekle("tblKAtegori", data);


        }

        public T Getir(int id)
        {

            string tableName = GetTableName();
           DataTable dt= SGKutuphane.Data.DataOptions.DataContext.Getir(tableName, id);
            T obj = new T();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                obj = DataTableToObject(dt.Rows[i]);
            }

            return obj;

           } 

        //public void Guncelle(int id, Kategori veri)
        //{
        //    Dictionary<string, object> data = new Dictionary<string, object>();
        //    data.Add("KategoriAdı", veri.KategoriAdı);

        //    SGKutuphane.Data.DataOptions.DataContext.Guncelle("tblKAtegori", id, data);

        //}

        public void Guncelle(int id, T veri)
        {
            Dictionary<string, object> data = objectToDictionary(veri);
            string tableName = GetTableName();
           
            SGKutuphane.Data.DataOptions.DataContext.Guncelle(tableName, id, data);
        }

        public List<T> HepsiniGetir(bool isWiew=false)
        {
            string tableName = "";

            if(isWiew==true)
                tableName=GetViewName();
            else
                tableName = GetTableName();

            List<T> Datalist = new List<T>();
           DataTable dt = SGKutuphane.Data.DataOptions.DataContext.HepsiniGetir(tableName);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                T obj = DataTableToObject(dr);
                Datalist.Add(obj);
            }

            return Datalist;
        }

        public void Sil(int id)
        {
            string tableName = GetTableName();
            SGKutuphane.Data.DataOptions.DataContext.Sil(tableName,id);
        }
    }
}
