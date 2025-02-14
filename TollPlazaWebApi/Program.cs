using Microsoft.EntityFrameworkCore;
using System;
using TollPlazaWebApi.Authentication;
using TollPlazaWebApi.Manager;
using TollPlazaWebApi.Models;
using TollPlazaWebApi.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddConsole();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<TollDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TollPlazaDbConnection"));
    
    options
        .EnableSensitiveDataLogging()
        .LogTo(Console.WriteLine, LogLevel.Warning);

});
builder.Services.AddScoped<ITollEntryRepository, TollEntryRepository>();
builder.Services.AddScoped<ITollExitRepository, TollExitRepository>();
builder.Services.AddScoped<IRepository<SpecialDiscountDay>, SpecialDiscountDayRepository>();
builder.Services.AddScoped<IRepository<TollRate>, TollRateRepository>();
builder.Services.AddScoped<IRepository<EntryPoint>, EntryPointRepository>();
builder.Services.AddSingleton<TollManager>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Toll Plaza API V1");
    });
}

app.UseHttpsRedirection();
app.UseMiddleware<ApiKeyMiddleware>();

app.MapControllers();

app.Run();
