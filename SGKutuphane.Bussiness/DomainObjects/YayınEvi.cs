using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Bussiness.DomainObjects
{
    //[DisplayName("tblYayınevi")]
    [DBNVNameAtribute("tblYayınevi", "View_YayınEvi")]
    public class YayınEvi : IDataObject
    {
        public int ıd { get; set; }
        public string YayınEviAdı { get; set; }
        public int OlusturmaID { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
    }
}
