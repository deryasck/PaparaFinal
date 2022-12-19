using AutoMapper;
using DataLayer.Contex;
using DataLayer.Interface;
using DataLayer.IRepository;
using DataLayer.Repository;
using DomainLayer.Tablolar;
using ServiceLayer.DTO;
using ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class UsersServices : Service<Invoice>, IUsersServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersServices(IRepository<Invoice> repository, SiteAppDbContext siteAppDbContext, IUserRepository userRepository, IMapper mapper) : base(repository, siteAppDbContext)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        //public IQueryable<UserWithInvoiceDto> GetUserInvoices()
        //{
        //    var users = _userRepository.GetUserInvoices();
        //    var resultDto = _mapper.Map<List<UserWithInvoiceDto>>(users);
        //    return (IQueryable<UserWithInvoiceDto>)resultDto;
        //}


        public List<UserWithInvoiceDto> GetUsers()
        {
            var users = _userRepository.GetUserInvoices();
            var resultDto = _mapper.Map<List<UserWithInvoiceDto>>(users);
            return resultDto;
        }
    }
}
