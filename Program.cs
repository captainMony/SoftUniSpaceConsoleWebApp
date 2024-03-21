using Microsoft.EntityFrameworkCore;
using SoftUniSpaceConsoleWebApp.Data;

var builder = WebApplication.CreateBuilder(args);




//string connectionString = builder.Configuration.GetConnectionString("ApplicationContextConnectionString"); 
////???? ? ????? Configuration e appsettings.json
//if (connectionString != null )
//{
//    throw new InvalidDataException("COnnection string is not found bruh ApplicationContextConnectionString");
//}
//

string connectionString =
    builder.Configuration.GetConnectionString("ApplicationContextConnectionString") ??
    throw new InvalidDataException("No connection string dude");


// Add services to the container.
builder.Services.AddControllersWithViews();




builder.Services.AddDbContext<ApplicationContext>(context => context.UseMySQL(connectionString));




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
