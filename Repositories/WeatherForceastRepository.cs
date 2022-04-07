using basic_webapi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class WeatherForecastRepository : IWeatherForecastRepository, IDisposable
{
    internal WeatherForecastDb _context;

    public WeatherForecastRepository(WeatherForecastDb context) 
    {
        _context = context;

    }
    public async Task<WeatherForecast> CreateAsync(WeatherForecast model)
    {
        _context.WeatherForecasts.Add(model);
        await _context.SaveChangesAsync();
        return null;
    }
    public WeatherForecast Create(WeatherForecast model)
    {
        _context.WeatherForecasts.Add(model);
        _context.SaveChanges();
        return null;
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
        
        return _context.WeatherForecasts.ToList();
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
                _context.Dispose();
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