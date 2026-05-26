using ASP.NETCoreAPI.Configurations;
using ASP.NETCoreAPI.Models.Context;
using ASP.NETCoreAPI.Repositories;
using ASP.NETCoreAPI.Repositories.Implementations;
using ASP.NETCoreAPI.Services;
using ASP.NETCoreAPI.Services.Implementations;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//INJEÇÃO DE DEPENDENCIAS Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSingleton<IMathService, MathService>();
builder.Services.AddScoped<IMessageServices, MessageServicesImpl>();
builder.Services.AddScoped<ITodoItemServices, TodoItemServicesImpl>();
builder.Services.AddScoped<IBookServices, BooksServicesImpl>();
builder.Services.AddScoped<IPersonServices, PersonServicesImpl>();

//builder.Services.AddScoped<IPersonRepository, PersonRepositoryImpl>();
//builder.Services.AddScoped<IBookRepository, BookRepositoryImpl>();

// Registrando o repositório genérico para as entidades
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));




// Registro do mapeamento do AutoMapper para a versão 16+
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<ASP.NETCoreAPI.Profiles.MappingProfile>();
});



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
