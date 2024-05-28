using Events.IO.Domain.Core.Notifications;
using Events.IO.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Events.IO.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly IDomainNotificationHandler<DomainNotification> _notifications;
        private readonly IUser _user;
        public Guid HostId { get; set; }

        public BaseController(IDomainNotificationHandler<DomainNotification> notifications, IUser user)
        {
            _notifications = notifications;
            _user = user;
            if (_user.IsAuthenticated())
            {
                HostId = _user.GetUserID();
            }
        }

        protected bool ValidOperation()
        {
            return (!_notifications.HasNotifications());
        }
    }
}
