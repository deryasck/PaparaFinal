using System.Collections.Generic;

namespace DomainLayer.Tablolar
{
    public class Housing : BaseEntity
    {
        public string BlokNo { get; set; }
        public string Tip { get; set; }
        public int Kat { get; set; }
        public int DaireNo { get; set; }
        public bool Durum { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; } //bir daire yalnızca bir kişiye ait olabilir
        public ICollection<Dues> Dueses { get; set; } //bir dairenin birden fazla aidatı olabilir
        
        
    }
}
