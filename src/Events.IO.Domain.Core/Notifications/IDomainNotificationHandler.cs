using Events.IO.Domain.Core.Events;

namespace Events.IO.Domain.Core.Notifications

{
	public interface IDomainNotificationHandler<T> : IHandler<T> where T : Message
    {
        bool HasNotifications();
        List<T> GetNotifications();
    }
}
