var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "Hello .NET!");
app.MapGet("/be1-1", () => "Hello Backend 1-1!");
app.MapGet("/be1-2", () => "Hello Backend 1-2!");
app.Run();