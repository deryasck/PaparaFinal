using AutoMapper;
using DomainLayer.Tablolar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO;
using ServiceLayer.Interface;
using System.Collections.Generic;

namespace SiteYonetimiProje.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class ExecutiveController : ControllerBase
    {

        private readonly IHousing _housing;
        private readonly IUserService _userService;
        private readonly IInvoice _ınvoice;
        private readonly IDues _dues;
        private IMapper _mapper;

        public ExecutiveController(IHousing housing, IMapper mapper, IUserService userService = null, IInvoice ınvoice = null, IDues dues = null)
        {
            _housing = housing;
            _mapper = mapper;
            _userService = userService;
            _ınvoice = ınvoice;
            _dues = dues;
        }
     
        [Route("InsertHousing")]
        [HttpPost]
        public IActionResult AddHousing(HousingDto HousingDto)
        {

            var mappedModel = _mapper.Map<Housing>(HousingDto);
            _housing.Add(mappedModel);
            return Ok("Success");
        }

        [Route("GetHousingById")]
        [HttpGet]
        public IActionResult GetHousingById(int id)
        {
            var result = _housing.GetHousingById(id);
            var resultDto=_mapper.Map<HousingDto>(result); 
            return Ok(resultDto);
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
        public IActionResult UpdateHosing(HousingUpdateDto housingUpdateDto, int id)
        {
            var result = _housing.GetHousingById(id);
            _mapper.Map(housingUpdateDto, result);
            _housing.UpdateHousing(result);
            return Ok(result);

        }

        [Route("DeleteHousing")]
        [HttpDelete]
        public IActionResult DeleteHousing(int id)
        {
            var result = _housing.GetHousingById(id);
            if (result != null)
            {
                _housing.Delete(result);
                return Ok();

            }
            return NotFound("id bulunamadı");

        }

        [Route("InsertUser")]
        [HttpPost]
        public IActionResult AddUser(UserDto Userdto)
        {
            var model = _mapper.Map<User>(Userdto);
            _userService.Add(model);
            return Ok("Success");
        }

        [Route("GetAllUser")]
        [HttpGet]
        public IActionResult GetAllUser()
        {
            var result = _userService.GetAll();
            var resultDto = _mapper.Map<List<UserDto>>(result);
            return Ok(resultDto);
        }

        [Route("GetUserById")]
        [HttpGet]
        public IActionResult GetUserById(int id)
        {
            var result = _userService.GetUserById(id);
            var resultDto = _mapper.Map<UserDto>(result);
            return Ok(resultDto);
        }


        [Route("UpdateUsers")]
        [HttpPut]
        public IActionResult UpdateUsers(UserUpdateDto userDto, int id)
        {
            var result = _userService.GetUserById(id);
            _mapper.Map(userDto, result);
            _userService.UpdateUser(result);
            return Ok(result);

        }

        [Route("DeleteUsers")]
        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            var result = _userService.GetUserById(id);

            if (result != null)
            {
                _userService.DeleteUser(result);
                return Ok();
            }
            return NotFound("id bulunamadı");
        }


        [Route("AddHousingUser")]
        [HttpPut]
        public IActionResult AddHousingUser(AddHousingUserDto add)
        {
            var result = _housing.GetHousingById(add.ID);
            _mapper.Map(add, result);
             result.Durum = true;
            _housing.UpdateHousing(result);
            return Ok(result);

        }


        [Route("InsertInvoice")]
        [HttpPost]
        public IActionResult AddInvoice(InvoiceDto invoiceDto)
        {

            var mappedModel = _mapper.Map<Invoice>(invoiceDto);
            _ınvoice.Add(mappedModel);
            return Ok("Success");
        }

        [Route("InsertDues")]
        [HttpPost]
        public IActionResult AddDues(DuesDto duesDto)
        {

            var mappedModel = _mapper.Map<Dues>(duesDto);
            _dues.Add(mappedModel);
            return Ok("Success");
        }


    }
}
