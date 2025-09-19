var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();  // Make sure to add controllers support
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Map controller routes with required parameters:
app.MapControllers();

string connectionString = "Host=dpg-d2oias7fte5s738b7nug-a.oregon-postgres.render.com;Port=5432;Username=pets;Password=8mPUBMxaTTBNRc4H9mGHc0EKSzSNIqy5;Database=pets_px49";
        var db = new ConnectBD(connectionString);
        db.TestConnection();



app.Run();
