using Microsoft.EntityFrameworkCore;
using MyPortfolioWebAPI.Data;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
string ConnStr = builder.Configuration.GetConnectionString("addressDb");
// Add services to the container.

services.AddControllers();
services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(ConnStr));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

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
