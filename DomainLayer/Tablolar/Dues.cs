using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Tablolar
{
    public class Dues:BaseEntity
    {
        public decimal Tutar { get; set; }
        public DateTime Gelis_Tarihi { get; set; }
        public DateTime Odeme_Tarihi { get; set; }
        public bool Odeme_Durumu { get; set; }
        public int? HousingId { get; set; }
        public Housing Housing { get; set; }//bir aidat yalnızca bir daireye ait olabilir

    }
}
