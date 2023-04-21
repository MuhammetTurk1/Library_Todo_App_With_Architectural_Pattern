using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace SGKutuphane.Business.DomainObjects
{
    [DisplayName("tblKategori")]
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public int OlusturanId { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
    }
}
