using DomainLayer.Tablolar;
using ServiceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interface
{
    public interface IHousing
    {
        public IQueryable<Housing> GetAll();
        public Housing GetHousingById(int id);
       // public IEnumerable<Housing> GetHousingById(int id);
        public void Add(Housing Housing);
        public void UpdateHousing(Housing Housing);
        public void DeleteHousing(Housing housing);
        public void Delete(Housing housing);
    }
}
