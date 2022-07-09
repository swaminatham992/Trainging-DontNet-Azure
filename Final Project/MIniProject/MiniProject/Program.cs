using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication8_Products_APi.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebApplication8_Products_APiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplication8_Products_APiContext") ?? throw new InvalidOperationException("Connection string 'WebApplication8_Products_APiContext' not found.")));

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();
app.UseCors(builder=> builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

app.Run();
