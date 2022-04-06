using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace basic_webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherForecastRepository _weatherForecastRepository;

    public WeatherForecastController(IWeatherForecastRepository weatherForecastRepository)
    {
        _weatherForecastRepository = weatherForecastRepository;
    }

    [HttpGet]
    public List<WeatherForecast> Get()
    {
        return _weatherForecastRepository.GetWeatherForecastsAsync();
    }

    [HttpPost]
    public void Create([FromBody] WeatherForecast weatherForecast)
    {
        _weatherForecastRepository.CreateAsync(weatherForecast);
    }
}
