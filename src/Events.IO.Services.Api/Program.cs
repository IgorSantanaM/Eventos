using Events.IO.Application.AutoMapper;
using Events.IO.Infra.CrossCutting.Bus;
using Events.IO.Infra.CrossCutting.Identity.Data;
using Events.IO.Infra.CrossCutting.IoC;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationDbContext, Microsoft.AspNet.Identity.EntityFramework.IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddMvc();
//register all DI
RegisterServices(builder.Services);


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
app.UseStaticFiles();
app.UseMvc();

InMemoryBus.ContainerAccessor = () => app.Services.GetRequiredService<IHttpContextAccessor>().HttpContext.RequestServices;
app.Run();
static void RegisterServices(IServiceCollection services)
{
    NativeInjectorBootStrapper.RegisterServices(services);
}
