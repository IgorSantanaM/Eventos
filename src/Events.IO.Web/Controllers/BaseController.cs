using Events.IO.Domain.Core.Notifications;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sql;

namespace Events.IO.Web.Controllers
{
	public class BaseController : Controller
	{
		private readonly IDomainNotificationHandler<DomainNotification> _notifications;

        public BaseController(IDomainNotificationHandler<DomainNotification> notifications)
        {
            _notifications = notifications;
        }

        protected bool ValidOperation()
        {
            return (!_notifications.HasNotifications());
        }
    }
}
