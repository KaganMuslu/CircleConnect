using CircleConnect.Data;
using CircleConnect.Extentions;
using CircleConnect.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Redis connection
var redisConnection = ConnectionMultiplexer.Connect(builder.Configuration.GetConnectionString("rediscache"));
builder.Services.AddSingleton<IConnectionMultiplexer>(redisConnection);


builder.Services.AddSingleton<RedisManager>(sp => new RedisManager(redisConnection));

// Notification service injections for Redis
builder.Services.AddSingleton<NotificationService>();
builder.Services.AddSingleton<NotificationListener>();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("sqlConnection")));
//builder.Services.AddStackExchangeRedisCache(options => options.Configuration = builder.Configuration.GetConnectionString("rediscache"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
