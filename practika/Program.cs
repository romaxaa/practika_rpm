<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using practika.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
DotNetEnv.Env.Load();
var connectionString = $"Host={Environment.GetEnvironmentVariable("DB_HOST")};" +
$"Port={Environment.GetEnvironmentVariable("DB_PORT")};" +
$"Database={Environment.GetEnvironmentVariable("DB_NAME")};" +
$"Username={Environment.GetEnvironmentVariable("DB_USER")};" +
$"Password={Environment.GetEnvironmentVariable("DB_PASSWORD")}";
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseNpgsql(connectionString));
=======
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
>>>>>>> 8c13d2d005e2ea695a9633ba22b744c2128c1777

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
<<<<<<< HEAD
app.UseRouting();
=======
>>>>>>> 8c13d2d005e2ea695a9633ba22b744c2128c1777

app.MapControllers();

app.Run();
