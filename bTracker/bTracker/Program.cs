using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using bTracker.Data;
using bTracker.Models;
using MvcMovie.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<bTrackerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("bTrackerContext") ?? throw new InvalidOperationException("Connection string 'bTrackerContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


//runs code from models -> seedData. and adds a few placeholder 'issues' into the database
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

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
