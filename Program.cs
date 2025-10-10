using ApiTest.Data;
using ApiTest.Services;
using ApiTest.Src.Appointments;
using ApiTest.Src.AvailabilitySchedules;
using ApiTest.Src.DoctorDetails;
using ApiTest.Src.Doctors;
using ApiTest.Src.HistoryRecords;
using ApiTest.Src.OwnerPets;
using ApiTest.Src.Owners;
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
builder.Services.AddScoped<ServicesHistoryRecord>();
builder.Services.AddScoped<ServicesDoctor>();
builder.Services.AddScoped<ServicesDoctorDetails>();
builder.Services.AddScoped<ServicesAvailabilitySchedule>();
builder.Services.AddScoped<ServicesAppointments>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
