using ODataExample.EF;
using ODataExample.Repository;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Routing;

namespace ODataExample.Controllers
{
    [ODataRoutePrefix("Shifts")]
    public class ShiftsController : ODataController
    {
        private readonly IShiftRepository _shiftRepository ;
        public ShiftsController(IShiftRepository shiftRepository)
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


    }
}
