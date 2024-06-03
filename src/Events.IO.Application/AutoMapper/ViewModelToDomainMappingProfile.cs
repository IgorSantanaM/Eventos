using AutoMapper;
using Events.IO.Application.ViewModels;
using Events.IO.Domain.DEvents.Commands;
using Events.IO.Domain.Hosts.Commands;

namespace Events.IO.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile() 
        {
            CreateMap<EventViewModel, RegistryEventCommand>()   
                .ConstructUsing(c => new RegistryEventCommand(c.Name, c.ShortDescription, c.LongDescription, c.BeginDate, c.EndDate, c.Free, c.Price, c.Online, c.CompanyName, c.HostId, c.CategoryId,
                new IncludeAddressEventCommand(c.Address.Id, c.Address.PublicPlace, c.Address.Number, c.Address.Complement, c.Address.Neighborhood, c.Address.ZipCode, c.Address.City, c.Address.State, c.Id)));

            CreateMap<AddressViewModel, IncludeAddressEventCommand>()
                .ConstructUsing(c => new IncludeAddressEventCommand(Guid.NewGuid(), c.PublicPlace, c.Number, c.Complement, c.Neighborhood, c.ZipCode, c.City, c.State, c.EventId));

            CreateMap<AddressViewModel, UpdateAddressEventCommand>()
               .ConstructUsing(c => new UpdateAddressEventCommand(Guid.NewGuid(), c.PublicPlace, c.Number, c.Complement, c.Neighborhood, c.ZipCode, c.City, c.State, c.EventId));

            CreateMap<EventViewModel, UpdateEventCommand>()
               .ConstructUsing(c => new UpdateEventCommand(c.Id, c.Name, c.ShortDescription, c.LongDescription, c.BeginDate, c.EndDate, c.Free, c.Price, c.Online, c.CompanyName, c.HostId, c.CategoryId));

            CreateMap<EventViewModel, DeleteEventCommand>()
                .ConstructUsing(c => new DeleteEventCommand(c.Id));

            //Host
            CreateMap<HostViewModel, RegistryHostCommand>()
                .ConstructUsing(c => new RegistryHostCommand(c.Id, c.Name, c.CPF, c.Email));
        }
    }
}
