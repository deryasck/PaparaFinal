
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DomainLayer.Tablolar
{ //: IdentityUser<int>
    public class User:BaseEntity
    {
        public string Name_Surname { get; set; }
        public string TcNo { get; set; }
        public string Gsm { get; set; }
        public string Mail { get; set; }
        public string Arac_Plaka { get; set; }

        //public string KullaniciAdi { get; set; }
        //public string Sifre { get; set; }}
        public ICollection<Housing> Housings { get; set; }//bir kişinin birden fazla dairesi olabilir
        public ICollection<Message>Messages { get; set; }// bir kullanıcın birden fazla mesajı olabilir
        public ICollection<Invoice> Invoices { get; set; }//bir dairenin birden fazla faturası olabilir
    }
}
