using Serilog;
using SpacePortDockingAPI.Objects;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DBDriver>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

JSONHandler.appOptions = JSONHandler.LoadOptionsJson();

Log.Logger = new LoggerConfiguration()
                            .WriteTo.Console()
                            .MinimumLevel.Debug()
                            .WriteTo.File("logs/api-log.txt", rollingInterval: RollingInterval.Day)
                            .CreateLogger();

app.Run();
