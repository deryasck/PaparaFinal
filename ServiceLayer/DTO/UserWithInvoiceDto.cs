using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTO
{
    public class UserWithInvoiceDto:InvoiceDto
    {
        public UserDto User { get; set; }//ınvoicedto mu aldım
    }
}
