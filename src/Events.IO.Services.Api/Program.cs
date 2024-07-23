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

builder.Services.AddOptions();
builder.Services.AddMvc(options =>
{
    options.OutputFormatters.Remove(new XmlDataContractSerializerOutputFormatter());
    options.UseCentralRoutePrefix(new RouteAttribute("api/v{version}"));
});

builder.Services.AddSwagger
(s =>
{
    s.SwaggerDoc("v1", new info
    {
        Version = "v1",
        Title = "Events.IO API",
        Description = "API of web Events.IO",
        TermsOfService = "None",
        Contact = new Contact { Name = "Igor Medeiros", Email = "email@events.io", Url= "http://events.IO.Com"},
        License = new License {  Name = "MIT", Url = "http://events.io/license"}
    });
});
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
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Events.IO API v1.0");
});

app.MapControllers();
app.UseStaticFiles();
app.UseMvc();

InMemoryBus.ContainerAccessor = () => app.Services.GetRequiredService<IHttpContextAccessor>().HttpContext.RequestServices;
app.Run();
static void RegisterServices(IServiceCollection services)
{
    NativeInjectorBootStrapper.RegisterServices(services);
}
