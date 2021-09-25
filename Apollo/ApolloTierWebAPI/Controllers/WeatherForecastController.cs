﻿using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackExchange.Exceptional;

namespace ApolloTierWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

       // private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController()
        {
            
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            try
            {
               // throw new NotImplementedException();
                var rng = new Random();
                return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                })
                .ToArray();
            }
            catch
            {
                throw;
            }
            finally
            {
                //return null;
            }
        }
    }
}
