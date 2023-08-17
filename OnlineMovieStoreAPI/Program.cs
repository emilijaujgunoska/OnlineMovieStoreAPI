using Microsoft.EntityFrameworkCore;
using OnlineMovieStore.
using OnlineMovieStore.Repositories;
using OnlineMovieStoreAPI.Repository.Interfaces;
using OnlineMovieStoreAPI.Service.Interfaces;
using OnlineMovieStoreAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ConfigurationManager configuration = builder.Configuration; 
IWebHostEnvironment environment = builder.Environment;

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
