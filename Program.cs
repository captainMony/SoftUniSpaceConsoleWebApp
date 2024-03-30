using Microsoft.EntityFrameworkCore;
using SoftUniSpaceConsoleWebApp.Data;
using SoftUniSpaceConsoleWebApp.Repositories;
using SoftUniSpaceConsoleWebApp.Repositories.Interfaces;
using SoftUniSpaceConsoleWebApp.Services;
using SoftUniSpaceConsoleWebApp.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);




//string connectionString = builder.Configuration.GetConnectionString("ApplicationContextConnectionString"); 
////???? ? ????? Configuration e appsettings.json


//if (connectionString != null )
//{
//    throw new InvalidDataException("COnnection string is not found bruh ApplicationContextConnectionString");
//}
//

string connectionString =
    builder.Configuration.GetConnectionString("ApplicationContextConnectionString") ?? //ona neraboti a tova da??
    throw new InvalidDataException("No connection string dude");


// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ApplicationContext>(context => context.UseMySQL(connectionString));

builder.Services.AddScoped<ICrewRepository, CrewRepository>();
builder.Services.AddScoped<ICrewService, CrewService>();

builder.Services.AddScoped<IShipRepository, ShipRepository>();
builder.Services.AddScoped<IShipService, ShipService>();    

builder.Services.AddScoped<ISolarSystemRepository, SolarSystemRepository>();
builder.Services.AddScoped<ISolarSystemService, SolarSystemService>(); //DONT FORGET 

builder.Services.AddScoped<IPlanetRepo, PlanetRepo>();
builder.Services.AddScoped<IPlanetService, PlanetServices>(); //why s?

builder.Services.AddScoped<IGalaxyReposiotry, GalaxyRepository>();
    builder.Services.AddScoped<IGalaxyService, GalaxyService>();

builder.Services.AddScoped<IMoonService, MoonService>();
builder.Services.AddScoped<IMoonRepository, MoonRepository>();







builder.Services.AddScoped<ISpaceStationRepository, SpaceStationRepository>();
builder.Services.AddScoped<ISpaceStationService, SpaceStationService>();




builder.Services.AddRazorPages(); // ok qasno?????????????????????????




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
