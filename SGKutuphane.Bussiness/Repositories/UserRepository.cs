using SGKutuphane.Bussiness.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKutuphane.Bussiness.Repositories
{
    public class UserRepository :BaseRepository<Kullanıcı>
    {

        public static Kullanıcı loggedUser { get; set; }
        public Kullanıcı Login(string username, string password)
        {

           var userList= HepsiniGetir();

            foreach (var item in userList)
            {
                if (item.KullanıcıAdi == username && item.Sifre == password)
                {
                    return item;
                }
            }
            return null;

        }
    }
}
