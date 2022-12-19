using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Tablolar
{
    public class Invoice:BaseEntity
    {
        public decimal Tutar { get; set; }
        public string FaturaTuru { get; set; }
       // public DateTime Gelis_Tarihi { get; set; }
        public DateTime Son_Odeme_Tarihi { get; set; }
        public bool OdemeDurumu { get; set; }
        public int? UserId { get; set; }

        public User User;//bir fatura bir kullaniciya aittir

        //public int FaturaTurId { get; set; }
        //public InvoiceType InvoiceType { get; set; }

    }
}
