using AutoMapper;
using DomainLayer.Tablolar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO;
using ServiceLayer.Interface;
using System.Collections.Generic;

namespace SiteYonetimiProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //private readonly IUserService _userService;
        private IMapper _mapper;

        private readonly IUsersServices _usersServices;

        public UsersController(IUsersServices usersServices, IMapper mapper)
        {
            _usersServices = usersServices;
            _mapper = mapper;
        }

        [Route("GetAllUsers")]
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var result = _usersServices.GetUsers();
            return Ok(result);
            //var result = _userService.GetAll();
            //var resultDto = _mapper.Map<List<UserDto>>(result);
            //return Ok(resultDto);
        }

    }
}
