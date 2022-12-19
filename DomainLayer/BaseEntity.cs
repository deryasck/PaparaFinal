using System;

namespace DomainLayer
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime GuncellmeTarihi { get; set; }

    }
}
