using Events.IO.Application.ViewModels;

namespace Events.IO.Application.Interfaces
{
    public interface IEventAppService : IDisposable
    {
         void Registry(EventViewModel eventViewModel);
        IEnumerable<EventViewModel> GetAll();    
        IEnumerable<EventViewModel> GetEventByHost(Guid hostId);
        EventViewModel GetById(Guid id);
        void Update(EventViewModel eventViewModel);
        void Delete(Guid id);
    }
}
