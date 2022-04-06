using basic_webapi;
namespace Repositories;

public interface IWeatherForecastRepository
{
    Task<WeatherForecast> GetByIdAsync(dynamic id);
    List<WeatherForecast> GetWeatherForecastsAsync();
    Task DeleteByIdAsync(dynamic id);
    Task<WeatherForecast> CreateAsync(WeatherForecast model);
    Task<WeatherForecast> UpdateAsync(WeatherForecast model, bool upsert = true);
}