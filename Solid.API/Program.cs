using Solid.Core.Repositories;
using Solid.Core.Services;
using Solid.Data;
using Solid.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IGirlService,GirlService >();
builder.Services.AddScoped<IGirlRepository, GirlRepository>();
builder.Services.AddScoped<IGuyService,GuyService >();
builder.Services.AddScoped<IGuyRepository, GuyRepository>();
builder.Services.AddScoped<IMatchmakerRepository, MatchmakerRepository>();
builder.Services.AddScoped<IMatchmakerService, MatchmakerService>();

builder.Services.AddDbContext<DataContext>();
//builder.Services.AddSingleton<DataContext>();

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

app.Run();
