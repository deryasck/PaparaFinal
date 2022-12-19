using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Tablolar
{
    public class Message:BaseEntity
    {
        public string Konu { get; set; }
        public string Acıklama { get; set; }
        public int OkunduBilgisi { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }

    }
}
