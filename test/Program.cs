using Microsoft.EntityFrameworkCore;
using Microsoft.FeatureManagement;
using Persistencia.Data;
using Servicios;
using Servicios.interfaces;
using System.Reflection;
using test;
using test.middleware;
using test.swagger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddFeatureManagement();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Version = "v1.0",
        Title = "Api de pruebas",
        Description = "Api de pruebas de conexion a dos bases de datos",
        TermsOfService = new Uri("https://images3.memedroid.com/images/UPLOADED101/64a2f63d562de.jpeg"),
    });
    options.EnableAnnotations();
    options.DocumentFilter<FeatureGateFilter>();
});

var servicesAssembly = Assembly.Load("Servicios");

var serviceInterfaces = servicesAssembly.GetTypes().Where(
        x => x.IsInterface && x.Namespace?.Contains("Servicios.interfaces") == true
    );

var serviceImplementacion = servicesAssembly.GetTypes().Where(
        x => x.IsClass && x.Name.EndsWith("Service") && x.Namespace?.Equals("Servicios") == true
    );

foreach (var interfaceService in serviceInterfaces){
    var servicioImplementacion = serviceImplementacion.FirstOrDefault(t => interfaceService.IsAssignableFrom(t));

    if(servicioImplementacion != null)
        builder.Services.AddScoped(interfaceService, servicioImplementacion);
}



builder.Services.AddDbContext<BaseIntraLocalMatiContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddDbContext<customDBContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("customDB"), o =>
    {
        o.MigrationsHistoryTable("Migrations", "negocio");
    });
});

builder.Services.AddScoped<IPersonaService, PersonasService>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseMiddleware<ExceptionHandlerMiddleware>();
app.MapControllers();

app.Run();
