<<<<<<< HEAD
using Events.IO.Domain.Interface;
using Events.IO.Infra.CrossCutting.AspNetFilters;
using Events.IO.Infra.CrossCutting.Bus;
using Events.IO.Infra.CrossCutting.Identity.Data;
using Events.IO.Infra.CrossCutting.Identity.Models;
=======
using Events.IO.Infra.CrossCutting.AspNetFilters;
using Events.IO.Infra.CrossCutting.Bus;
using Events.IO.Infra.CrossCutting.Identity.Data;
>>>>>>> TesteApi
using Events.IO.Infra.CrossCutting.IoC;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
=======
>>>>>>> TesteApi

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("CanReadEvents", policy => policy.RequireClaim("Events", "Read"));
    options.AddPolicy("CanAddEvents", policy => policy.RequireClaim("Events", "Add"));
});

RegisterServices(builder.Services);

builder.Services.AddControllersWithViews();
builder.Services.AddLogging();
builder.Services.AddMvc(options =>
{
    options.Filters.Add(new ServiceFilterAttribute(typeof(GlobalExceptionHandlingFilter)));
<<<<<<< HEAD
=======
    options.Filters.Add(new ServiceFilterAttribute(typeof(GlobalActionLogger)));
>>>>>>> TesteApi
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/error-of-application");
    app.UseStatusCodePagesWithReExecute("/error-of-application/{0}");
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
