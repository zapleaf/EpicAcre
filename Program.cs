using EpicAcre.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Tell application to use DbContext, using AppDbContext class file,
// and DefaultConnection string defined in appsettings (passed as options)
// install EntityFrameworkCore.SqlServer
// GetConnectionStrings looks in the ConnectionsStrings block of the appsettings json file
// Add EntityFrameworkCore.Tools NuGet to use Migrations in PM Console
//    1.) "add-migrations <name>" creates the Migrations folder and migration class
//    2.) "update-database" updates database
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));
// added so when view is updated it updates in brwoser without restarting applicaiton
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

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
