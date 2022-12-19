using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceWeather.Context;

namespace ServiceWeather.Controllers
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
        private readonly WeatherContext _context;

        public WeatherForecastController(WeatherContext context, ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _context.WeatherForecasts.ToList();
        }
        
        [HttpPost]
        public IActionResult Add([FromBody] WeatherForecast weatherForecast)
        {
            _context.WeatherForecasts.Add(weatherForecast);
            _context.SaveChanges();
            return Ok(_context.SaveChanges());
        }
    }
}