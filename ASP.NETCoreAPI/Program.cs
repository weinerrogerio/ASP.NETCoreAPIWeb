using ASP.NETCoreAPI.Configurations;
using ASP.NETCoreAPI.Models.Context;
using ASP.NETCoreAPI.Services;
using ASP.NETCoreAPI.Services.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//INJEÇÃO DE DEPENDENCIAS Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSingleton<IMathService, MathService>();
builder.Services.AddScoped<IPersonServices, PersonServicesImpl>();
builder.Services.AddScoped<IMessageServices, MessageServicesImpl>();
builder.Services.AddScoped<ITodoItemServices, TodoItemServicesImpl>();

//Configurando o logging
builder.AddSerilogLogging();

//Conexão com o banco
builder.Services.AddDataBaseConfig(builder.Configuration);
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
