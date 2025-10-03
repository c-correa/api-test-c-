using ApiTest.Data;
using ApiTest.Src.Owners.Service;
using ApiTest.Src.OwnersPets.Services;
using ApiTest.Src.Pets.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);


builder.Services.AddScoped<ServicesOwner>();
builder.Services.AddScoped<ServicesPet>();
builder.Services.AddScoped<ServicesOwnersPets>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
