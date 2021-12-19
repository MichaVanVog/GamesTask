using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Games.Data;
using Games.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<GamesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GamesContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Games}/{action=Index}/{id?}");

app.Run();
