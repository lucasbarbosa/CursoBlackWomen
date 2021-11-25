﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudApi.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public string Get()
        {
            return "Oi";
        }

        [HttpPost]
        public string Post()
        {
            return "Oi";
        }

        [HttpPut]
        public string Put()
        {
            return "Oi";
        }

        [HttpDelete]
        public string Delete()
        {
            return "Oi";
        }
    }
}
