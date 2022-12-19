using AutoMapper;
using DomainLayer.Tablolar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO;
using ServiceLayer.Interface;

namespace SiteYonetimiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IHousing _housing;
        private readonly IUserService _userService;
        private IMapper _mapper;

        public UserController(IHousing housing, IMapper mapper, IUserService userService = null)
        {
            _housing = housing;
            _mapper = mapper;
            _userService = userService;
        }
        [Route("GetHousingById")]
        [HttpGet]
        public IActionResult GetHousingById(int id)
        {
            var result = _housing.GetHousingById(id);
            return Ok(result);
        }
        [Route("InsertHousing")]
        [HttpPost]
        public IActionResult AddHousing(HousingDto HousingDto)
        {

            var mappedModel = _mapper.Map<Housing>(HousingDto);
            mappedModel.OlusturmaTarihi = System.DateTime.Now;

            _housing.Add(mappedModel);
            return Ok("Success");
        }
        [Route("GetAllHousing")]
        [HttpGet]
        public IActionResult GetAllHousing()
        {
            var result = _housing.GetAll();
            return Ok(result);
        }

        [Route("UpdateHousing")]
        [HttpPut]
        public IActionResult UpdateHousing(HousingDto HousingDto)
        {

            var mappedModel = _mapper.Map<Housing>(HousingDto);
            mappedModel.GuncellmeTarihi = System.DateTime.Now;
            _housing.UpdateHousing(mappedModel);
            return Ok("Success");
        }

        [Route("DeleteHousing")]
        [HttpDelete]
        public IActionResult DeleteHousing(Housing housing)
        {
            _housing.DeleteHousing(housing);
            return Ok("Succes");
        }
        [Route("InsertUser")]
        [HttpPost]
        public IActionResult AddUser(UserDto UserDto)
        {

            var model = _mapper.Map<User>(UserDto);

            _userService.Add(model);
            return Ok("Success");
        }
        [Route("GetAllHousing")]
        [HttpGet]
        public IActionResult GetAllUser()
        {
            var result = _userService.GetAll();
            return Ok(result);
        }
    }
}
