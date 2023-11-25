using Microsoft.AspNetCore.Mvc;
using Service_One_ClassLibrary1;
using Service_One_ClassLibrary2;
using Service_One_ClassLibrary3;

namespace Service_One.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult Class1Get()
        {
            return Ok(Service_One_ClassLibrary1.Class1.GetName());
        }

        [HttpGet]
        public IActionResult Class2Get()
        {
            return Ok(Service_One_ClassLibrary2.Class1.GetName());
        }

        [HttpGet]
        public IActionResult Class3Get()
        {
            return Ok(Service_One_ClassLibrary3.Class1.GetName());
        }
    }
}
