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

<<<<<<< HEAD
<<<<<<< HEAD
        protected bool ValidateOperation()          
        {
            return (!_notifications.HasNotifications());
        }
        
=======
        protected bool ValidOperation()
        {
            return (!_notifications.HasNotifications());
        }
>>>>>>> TesteApi
=======
        protected bool ValidateOperation()          
        {
            return (!_notifications.HasNotifications());
        }
        
>>>>>>> master
    }
}
