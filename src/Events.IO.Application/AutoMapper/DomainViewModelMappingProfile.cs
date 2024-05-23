using AutoMapper;
using Events.IO.Application.ViewModels;
using Events.IO.Domain.DEvents;

namespace Events.IO.Application.AutoMapper
{
    public class DomainViewModelMappingProfile : Profile
    {
        public DomainViewModelMappingProfile()
        {
            CreateMap<DEvent, EventViewModel>();
            CreateMap<Address,AddressViewModel>();
            CreateMap<Category, CategoryViewModel>();
        }
    }
}
