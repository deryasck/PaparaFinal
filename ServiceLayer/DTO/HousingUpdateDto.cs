using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTO
{
    public class HousingUpdateDto
    { 
        public string BlokNo { get; set; }
        public string Tip { get; set; }
        public int Kat { get; set; }
        public int DaireNo { get; set; }
        public bool Durum { get; set; }

    }
}
