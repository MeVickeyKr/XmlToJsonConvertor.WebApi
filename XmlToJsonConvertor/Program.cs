using Microsoft.EntityFrameworkCore;
using XmlToJsonConvertor.Services.AutoMapper;
using XmlToJsonConvertor.Services.Implementations;
using XmlToJsonConvertor.Services.Interface;
using XmlToJsonConvertor.UserDetailsDb;
using XmlToJsonConvertor.UserDetailsDb.Repository.Implementations;
using XmlToJsonConvertor.UserDetailsDb.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<IXmlDataRepository, XmlDataRepository>();
builder.Services.AddTransient<IXmlToJsonServices, XmlToJsonServices>();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

builder.Services.AddDbContext<XMLToJsonConversionDbContext>(options =>
 options.UseSqlServer(builder.Configuration.GetConnectionString("Defaultconnection")));

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
