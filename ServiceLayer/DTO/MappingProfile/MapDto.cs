using AutoMapper;
using DomainLayer.Tablolar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTO.MappingProfile
{
    public class MapDto:Profile
    {
        public MapDto()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();
            CreateMap<Invoice, InvoiceDto>().ReverseMap();
            CreateMap<Housing, HousingDto>().ReverseMap();
            CreateMap<Dues, DuesDto>().ReverseMap();
            CreateMap<Housing, HousingUpdateDto>().ReverseMap();
            CreateMap<Housing, AddHousingUserDto>().ReverseMap();
            CreateMap<Invoice, UserWithInvoiceDto>().ReverseMap();
        }
    }
}
