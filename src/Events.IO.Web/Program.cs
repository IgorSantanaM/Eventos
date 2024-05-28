using Events.IO.Domain.Interface;
using Events.IO.Infra.CrossCutting.Bus;
using Events.IO.Infra.CrossCutting.IoC;
using Events.IO.Web.Data;
using Events.IO.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddScoped<IUser, AspNetUser>();

RegisterServices(builder.Services);

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

InMemoryBus.ContainerAccessor = () => app.Services.GetRequiredService<IHttpContextAccessor>().HttpContext.RequestServices;

app.Run();

static void RegisterServices(IServiceCollection services)
{
    NativeInjectorBootStrapper.RegisterServices(services);
}
