using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Bussiness.DomainObjects
{

   // [DisplayName("tblYazar")]
    [DBNVNameAtribute("tblYazar", "View_Yazar")]
    public class Yazarr
    { 
        public int ıd { get; set; }
        public string YazarAdı2 { get; set; }
        public int OlusturanID2 { get; set; }
        public DateTime OlusturmaTarihi2 { get; set; }

    }
}
