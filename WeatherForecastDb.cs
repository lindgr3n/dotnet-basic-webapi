using Microsoft.EntityFrameworkCore;

namespace basic_webapi
{
    public class WeatherForecastDb : DbContext
    {
        public WeatherForecastDb(DbContextOptions<WeatherForecastDb> options)
            : base(options) { }

        public DbSet<WeatherForecast> WeatherForecasts => Set<WeatherForecast>();
    }
}