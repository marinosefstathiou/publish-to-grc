using KubeTestAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace KubeTestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherRepository _repo;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet(Name = "GetLocations")]
        public IActionResult GetLocations()
        {
            var locations = _repo.GetLocations();
            return new OkObjectResult(locations);
        }

        [HttpGet(Name = "GetTemperatures")]
        public IActionResult GetTemperatures()
        {
            var x= "";
            var temps = _repo.GetTemperatures();
            return new OkObjectResult(temps);
        }
    }
}