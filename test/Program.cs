using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using Microsoft.IdentityModel.Tokens;
using Persistencia.Data;
using Servicios;
using Servicios.interfaces;
using System.Reflection;
using System.Text;
using test;
using test.auth;
using test.middleware;
using test.swagger;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<JWTConfiguracion>(builder.Configuration.GetSection("JWT"));

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





builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{

    var config = builder.Configuration.GetSection("JWT");

    options.Events = new JwtBearerEvents
    {

        OnMessageReceived = context =>
        {
            context.Token = context.Request.Cookies["session-id"];
            return Task.CompletedTask;
        }

    };


    options.RequireHttpsMetadata = true;
    options.IncludeErrorDetails = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = config["JWT:Issuer"],
        ValidAudience = config["JWT:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:SecretKey"])),
        ClockSkew = TimeSpan.Zero
    };


});
builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
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
