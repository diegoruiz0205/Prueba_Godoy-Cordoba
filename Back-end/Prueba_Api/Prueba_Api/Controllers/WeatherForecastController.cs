using Microsoft.AspNetCore.Mvc;

namespace Prueba_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase{

        [HttpGet(Name = "WeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {

            return new List<WeatherForecast>();
          
        }




    }
}
