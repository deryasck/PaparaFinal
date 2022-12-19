using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Tablolar
{
    public class Payment:BaseEntity
    {
        //public int KullaniciId { get; set; }
        public int? UserId { get; set; }
        public int? FaturaId { get; set; }
        public int? AidatId { get; set; }
        public bool Durum { get; set; }

    }
}
