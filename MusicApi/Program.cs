using Microsoft.EntityFrameworkCore;
using MusicApi.Models;
using MusicApi.Repositories;
using MusicApi.Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMusicianRepository,MusicianRepository>();
builder.Services.AddScoped<IMusicianService,MusicianService>();



builder.Services.AddControllers();


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));



WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseEndpoints(endpoints => endpoints.MapControllers());

app.Run();