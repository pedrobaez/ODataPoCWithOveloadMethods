using ODataExample.EF;
using ODataExample.Models;
using ODataExample.Repository;
using ODataExample.Repository.AddressRepository;
using System.Linq;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Routing;


namespace ODataExample.Controllers.OData
{
    [ODataRoutePrefix("Shifts")]
    public class ShiftsODataController : ODataController
    {
        private readonly IShiftRepository _shiftRepository;
        public ShiftsODataController(IShiftRepository shiftRepository)
        {
            _shiftRepository = shiftRepository;
          
        }
        [HttpGet]
        [EnableQuery]
        public IHttpActionResult Get()
        {
            var data = _shiftRepository.GetAll();
            return Ok(data);
        }
       
        [HttpGet]
        [EnableQuery]
        public IHttpActionResult GetAll()
        {
            var data = _shiftRepository.GetAll();
            return Ok(data);
        }

        [HttpGet]
        [EnableQuery]
        public IHttpActionResult GetById(int key)
        {
            var data = _shiftRepository.GetById(key);
            return Ok(data);
        }


    }
}
