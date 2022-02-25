using SwaggerJsonViewer;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerJsonViewer();

var app = builder.Build();
app.MapGet("users", () => JsonSerializer.Deserialize<object>(File.ReadAllText("response.json")));

app.UseStaticFiles();
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.AddJsonViewer();
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.Run();
