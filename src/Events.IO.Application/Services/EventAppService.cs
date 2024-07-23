using AutoMapper;
using Events.IO.Application.Interfaces;
using Events.IO.Application.ViewModels;
using Events.IO.Domain.Core.Bus;
using Events.IO.Domain.Interface;
using Events.IO.Domain.DEvents.Commands;
using Events.IO.Domain.DEvents.Repository;

namespace Events.IO.Application.Services
{
    public class EventAppService : IEventAppService
    {
        private readonly IBus _bus;
        private readonly IUser _user;
        private readonly IMapper _mapper;
        private readonly IEventRepository _eventRepository;
        public EventAppService(IBus bus, IMapper mapper, IEventRepository eventRepository, IUser user)
        {
            _bus = bus;
            _mapper = mapper; 
            _eventRepository = eventRepository;
            _user = user;
        }
        
        public void Delete(Guid id)
        {
            _bus.SendCommand(new DeleteEventCommand(id));
        }

        public IEnumerable<EventViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<EventViewModel>>(_eventRepository.GetAll());
        }

        public EventViewModel GetById(Guid id)
        {
            return _mapper.Map<EventViewModel>(_eventRepository.GetById(id));
        }

        public IEnumerable<EventViewModel> GetEventByHost(Guid hostId)
        {
            return _mapper.Map<IEnumerable<EventViewModel>>(_eventRepository.GetEventByHost(hostId));
        }

        public void Registry(EventViewModel eventViewModel)
        {
            var registryCommand = _mapper.Map<RegistryEventCommand>(eventViewModel);
            _bus.SendCommand(registryCommand);
        }

        public void Update(EventViewModel eventViewModel)
        {
            var updateEventCommand = _mapper.Map<UpdateEventCommand>(eventViewModel);
            _bus.SendCommand(updateEventCommand);
        }

        

        public void AddAddress(AddressViewModel addressViewModel)
        {
            var addressCommand = _mapper.Map<IncludeAddressEventCommand>(addressViewModel);
            _bus.SendCommand(addressCommand);
        }

        public void UpdateAddress(AddressViewModel addressViewModel)
        {
            var addressCommand = _mapper.Map<UpdateAddressEventCommand>(addressViewModel);
            _bus.SendCommand(addressCommand);
        }

        public AddressViewModel GetAddressById(Guid id)
        {
            return _mapper.Map<AddressViewModel>(_eventRepository.GetAddressById(id));
        }
        public void Dispose()
        {
            _eventRepository.Dispose();
        }
    }
}
