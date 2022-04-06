using basic_webapi;
using Microsoft.AspNetCore.Mvc;

namespace Repositories;

public class WeatherForecastRepository : IWeatherForecastRepository, IDisposable
{
    internal WeatherForecastDb context;

     private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public WeatherForecastRepository(WeatherForecastDb context) 
    {
        this.context = context;
    }
    public Task<WeatherForecast> CreateAsync(WeatherForecast model)
    {
        throw new NotImplementedException();
    }

    public Task DeleteByIdAsync(dynamic id)
    {
        throw new NotImplementedException();
    }

    public Task<WeatherForecast> GetByIdAsync(dynamic id)
    {
        throw new NotImplementedException();
    }

    public List<WeatherForecast> GetWeatherForecastsAsync()
    {
        List<WeatherForecast> list = new List<WeatherForecast>();


        var l = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        });
        for (int i = 0; i < l.Count(); i++)
        {
            list.Add(l.ElementAt(i));   
        }
        return list;
    }

    public Task<WeatherForecast> UpdateAsync(WeatherForecast model, bool upsert = true)
    {
        throw new NotImplementedException();
    }

    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}