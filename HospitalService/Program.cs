using AutoMapper;
using HospitalService.Data;
using HospitalService.Repositories;
using HospitalService.Services;
using HospitalService.utilities;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<HospitalDbContext>(options=>options.UseSqlServer( builder.Configuration.GetConnectionString("HospitalConn")));
builder.Services.AddScoped<IHospitalRepositery, HospitalRepositery>();
builder.Services.AddScoped<IHospitalService,HospitalServices>();
builder.Services.AddAutoMapper(typeof(AutoMapperService));
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
