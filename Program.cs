using Microsoft.EntityFrameworkCore;
using basic_webapi;
using Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<WeatherForecastDb>(opt => opt.UseInMemoryDatabase("WeatherForecastList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Register providers
builder.Services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
