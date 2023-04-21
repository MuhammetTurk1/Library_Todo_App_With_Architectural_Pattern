using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Bussiness.DomainObjects
{
    [DisplayName("tblOgrenci")]
    public class Ögrenci
    {
        public int ıd { get; set; }
        public string OgrenciAdı { get; set; }
        public string OgrenciSoyadı { get; set; }
        public string OgrenciSınıfı { get; set; }
        public string OgrenciAdresi { get; set; }
        public string Telefon { get; set; }
        public string EmailAdresi { get; set; }
        public string OgrenciNumarasi { get; set; }
        public string OkulAdı { get; set; }


    }
}
