using Microsoft.AspNetCore.Mvc;

namespace Service_Two.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult Class1Get()
        {
            return Ok(Service_Two_ClassLibrary1.Class1.GetName());
        }

        [HttpGet]
        public IActionResult Class2Get()
        {
            return Ok(Service_Two_ClassLibrary2.Class2.GetName());
        }

        [HttpGet]
        public IActionResult Class3Get()
        {
            return Ok(Service_Two_ClassLibrary3.Class3.GetName());
        }
    }
}
