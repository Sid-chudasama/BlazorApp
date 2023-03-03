using BlazorApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForecastController : ControllerBase
    {
        private readonly WeatherForecastService _weatherForecastService;
        public ForecastController(WeatherForecastService weatherForecastService) { 
            _weatherForecastService = weatherForecastService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WeatherForecast>>> GetForecastAsync()
        {
            return new OkObjectResult(await _weatherForecastService.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now)));
        }
    }
}
