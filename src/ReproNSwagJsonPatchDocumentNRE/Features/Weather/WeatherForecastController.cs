using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace ReproNSwagJsonPatchDocumentNRE.Features.Weather
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public ActionResult<WeatherForecast> Get()
        {
            return new WeatherForecast();
        }

        [HttpPatch]
        public ActionResult<WeatherForecast> PartialUpdate([FromBody] JsonPatchDocument<UpdateWeatherForecast> patchWeatherForecast)
        {
            return new WeatherForecast();
        }
    }
}
