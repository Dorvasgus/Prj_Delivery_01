using Delivery.Configuration;
using Delivery.Helpers;
using Delivery.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


//builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Clase03", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {{ new OpenApiSecurityScheme { Reference = new OpenApiReference{
                    Type = ReferenceType.SecurityScheme,
                     Id = "Bearer"}
                    },
                     new string[] { }
                  } });
});

//automapper
builder.Services.AddAutoMapper(typeof(Program));

//inyeccion de la base de datos
builder.Services
    .AddDbContext<deliveryContext>
    (options => options.UseSqlServer(configuration.GetConnectionString("Default")));

//inyeccion de paquete de seguridad - JWT

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
     options.TokenValidationParameters = new TokenValidationParameters
     {
         ValidateIssuer = false,
         ValidateAudience = false,
         ValidateLifetime = true,
         ValidateIssuerSigningKey = true,
         IssuerSigningKey = new SymmetricSecurityKey(
         Encoding.UTF8.GetBytes(configuration["jwt:key"])),
         ClockSkew = TimeSpan.Zero
     }
    );
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
