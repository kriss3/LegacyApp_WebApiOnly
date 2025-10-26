using Yarp.ReverseProxy;

var builder = WebApplication.CreateBuilder(args);
// Add Yarp
builder.Services.AddReverseProxy()
	.LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.MapOpenApi();
}

app.MapGet("/api/v1/ping", () => Results.Ok(new { source = "new API", mesage = "Pong"  }));

app.MapReverseProxy();

app.MapGet("/health", () => Results.Ok("OK"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
