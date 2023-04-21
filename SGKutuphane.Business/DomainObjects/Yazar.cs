using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Business.DomainObjects
{
    [DisplayName("tblYazar")]
    public class Yazar:IDataObject
    {
        public int Id { get; set; }
        public string YazarAdi { get; set; }
        public int OlusturanId { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
    }
}
