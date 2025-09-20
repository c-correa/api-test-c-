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


app.Run();
