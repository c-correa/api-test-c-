using ApiTest.Data;
using ApiTest.Mapping;
using ApiTest.Src.Appointment;
using ApiTest.Src.Customer;
using ApiTest.Src.InspectionType;
using ApiTest.Src.Inspector;
using ApiTest.Src.InspectorInspectionType;
using ApiTest.Src.Vehicle;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);


builder.Services.AddScoped<AppointmentServices>();
builder.Services.AddScoped<CustomerServices>();
builder.Services.AddScoped<InspectorServices>();
builder.Services.AddScoped<InspectorInspectionTypeServices>();
builder.Services.AddScoped<InspectionTypeServices>();
builder.Services.AddScoped<VehicleServices>();
builder.Services.AddAutoMapper(cfg => cfg.AddProfile<MappingProfile>());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
