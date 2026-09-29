using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using test.Models;
using test.persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Version = "v1.0",
        Title = "Api de pruebas",
        Description = "Api de pruebas de conexion a dos bases de datos",
        TermsOfService = new Uri("https://images3.memedroid.com/images/UPLOADED101/64a2f63d562de.jpeg"),
    });
});




builder.Services.AddDbContext<BaseIntraLocalMatiContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddDbContext<customDBContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("customDB"), o =>
    {
        o.MigrationsHistoryTable("Migrations", "negocio");
    });
});




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
