using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Bussiness.DomainObjects
{
    //[DisplayName("tblKullanıcı")]
    [DBNVNameAtribute("tblKullanıcı")]
    public class Kullanıcı
    {
        public int ıd { get; set; }
        public string KullanıcıAdi { get; set; }
        public string Adi { get; set; }
        public string Soyadı { get; set; }
        public string Sifre { get; set; }


    }
    
}
