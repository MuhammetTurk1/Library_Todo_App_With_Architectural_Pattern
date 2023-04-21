using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Bussiness.DomainObjects
{
    //[DisplayName("tblKAtegori")]
    [DBNVNameAtribute ("tblKAtegori", "View_Kategori")]

    public class Kategori :IDataObject
    {
         

        public int ıd { get; set; }
        public string KategoriAdı { get; set; }
        public int OlusturanId { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

    }

    [DBNVNameAtribute ("tblKAtegori", "View_Kategori")]
    public class KategoriView : IDataObject
    { 

        public int ıd { get; set; }
        public string KategoriAdı { get; set; }
        public string OlusturanAdı { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

    }
}
