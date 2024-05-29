using Events.IO.Domain.Core.Events;

namespace Events.IO.Domain.Core.Notifications
{
    public class DomainNotification : Event
    {
        public Guid DomainNotificationId { get; private set; }
        public string Key { get; private set; }
        public string Price { get; private set; }
        public int Version { get; private set; }

        public DomainNotification(string key, string price) 
        {
            DomainNotificationId = Guid.NewGuid();
            Key = key;
            Price = price;
            Version = 1;
        }
    }
}
