using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTO
{
    public class InvoiceDto
    {
        public decimal Tutar { get; set; }
        public string FaturaTuru { get; set; }
       // public DateTime Son_Odeme_Tarihi { get; set; }
      // public bool OdemeDurumu { get; set; }
        public int? UserId { get; set; } 
    }
}
