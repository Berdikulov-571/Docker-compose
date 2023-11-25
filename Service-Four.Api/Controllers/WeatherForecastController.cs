using Microsoft.AspNetCore.Mvc;
using Service_Four_ClassLibrary1;
using Service_Four_ClassLibrary2;
using Service_Four_ClassLibrary3;

namespace Service_Four.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult Class1Get()
        {
            return Ok(Class1.GetName());
        }

        [HttpGet]
        public IActionResult Class2Get()
        {
            return Ok(Class2.GetName());
        }

        [HttpGet]
        public IActionResult Class3Get()
        {
            return Ok(Class3.GetName());
        }
    }
}
