using AutoMapper;
using Events.IO.Application.Interfaces;
using Events.IO.Application.ViewModels;
using Events.IO.Domain.Core.Bus;
using Events.IO.Domain.DEvents.Commands;
using Events.IO.Domain.DEvents.Repository;

namespace Events.IO.Application.Services
{
    public class EventAppService : IEventAppService
    {
        private readonly IBus _bus;
        private readonly IMapper _mapper;
        private readonly IEventRepository _eventRepository;
        public EventAppService(IBus bus, IMapper mapper, IEventRepository eventRepository)
        {
            _bus = bus;
            _mapper = mapper; 
            _eventRepository = eventRepository;
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

        public void Dispose()
        {
            _eventRepository.Dispose();
        }
    }
}
