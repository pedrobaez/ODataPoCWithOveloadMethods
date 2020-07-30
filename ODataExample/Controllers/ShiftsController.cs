using ODataExample.Repository;
using ODataExample.Repository.AddressRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ODataExample.Controllers.WebApi
{
    [RoutePrefix("Shifts")]
    public class ShiftsController : ApiController
    {
        private readonly IShiftRepository _shiftRepository;
        public ShiftsController(IShiftRepository shiftRepository)
        {
            _shiftRepository = shiftRepository;
        }
        [HttpGet]
       
        public IHttpActionResult Get()
        {
            var data = _shiftRepository.GetAll();
            return Ok(data);
        }
        [HttpGet]
        [Route("GetAllPlain")]
        public IHttpActionResult GetAll()
        {
            var data = _shiftRepository.GetAll();
            return Ok(data);
        }
    }
}
