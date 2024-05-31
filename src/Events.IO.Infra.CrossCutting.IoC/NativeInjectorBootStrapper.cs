using AutoMapper;
using Events.IO.Application.AutoMapper;
using Events.IO.Application.Interfaces;
using Events.IO.Application.Services;
using Events.IO.Domain.Core.Bus;
using Events.IO.Domain.Core.Events;
using Events.IO.Domain.Core.Notifications;
using Events.IO.Domain.DEvents.Commands;
using Events.IO.Domain.DEvents.Events;
using Events.IO.Domain.DEvents.Repository;
using Events.IO.Domain.Hosts.Commands;
using Events.IO.Domain.Hosts.Events;
using Events.IO.Domain.Hosts.Repository;
using Events.IO.Domain.Interface;
using Events.IO.Infra.CrossCutting.Bus;
using Events.IO.Infra.CrossCutting.Identity.Models;
using Events.IO.Infra.Data.Context;
using Events.IO.Infra.Data.Repository;
using Events.IO.Infra.Data.UoW;
using FluentValidation.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace Events.IO.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            //ASPNET
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Application
            services.AddAutoMapper(Assembly.GetExecutingAssembly(), typeof(AutoMapperConfiguration).GetTypeInfo().Assembly);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddScoped<IEventAppService, EventAppService>();
            services.AddScoped<IHostAppService, HostAppService>();


            //Domain - Commands
            services.AddScoped<IHandler<RegistryEventCommand>, EventCommandHandler>();
            services.AddScoped<IHandler<UpdateEventCommand>, EventCommandHandler>();
            services.AddScoped<IHandler<DeleteEventCommand>, EventCommandHandler>();
            services.AddScoped<IHandler<RegistryHostCommand>, HostCommandHandler>();


            //Domain - Events
            services.AddScoped<IDomainNotificationHandler<DomainNotification>, DomainNotificationHandler>();
            services.AddScoped<IHandler<EventRegistradeEvent>, EventEventHandler>();
            services.AddScoped<IHandler<EventUpdatedEvent>, EventEventHandler>();
            services.AddScoped<IHandler<EventDeletedEvent>, EventEventHandler>();
            services.AddScoped<IHandler<HostRegistredEvent>, HostEventHandler>();


            //Infra - Data
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IHostRepository, HostRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<EventsContext>();

            //Infra - Bus
            services.AddScoped<IBus, InMemoryBus>();

            //Infra - Identity

            services.AddScoped<IUser, AspNetUser>();


        }
    }
}
