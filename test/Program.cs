using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using Microsoft.IdentityModel.Tokens;
using Modelo;
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





builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
        .WithOrigins("http://localhost:5173", "http://localhost:5281", "https://localhost:7019")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()
        .WithExposedHeaders("Content-Disposition"));
});




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





builder.Services.AddIdentity<CusPersona, IdentityRole<int>>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 1;
    options.Password.RequireNonAlphanumeric = false;
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = false;
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;


})
    .AddEntityFrameworkStores<CustomDBContext>()
    .AddDefaultTokenProviders()
    .AddUserManager<ApplicationIdentityPersonaManager>();
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


    options.RequireHttpsMetadata = false;
    options.IncludeErrorDetails = true;

    var secretKey = config["SecretKey"] ?? " ";
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = config["Issuer"],
        ValidAudience = config["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
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

builder.Services.AddDbContext<CustomDBContext>(options =>
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

if (!app.Environment.IsDevelopment())
    app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware<ExceptionHandlerMiddleware>();
app.MapControllers();

app.Run();
