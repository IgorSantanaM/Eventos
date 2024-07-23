using System.Threading.Tasks;
using Events.IO.Domain.Core.Notifications;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Events.IO.Web.ViewComponents
{
    public class SummaryViewComponent : ViewComponent
    {
        private readonly IDomainNotificationHandler<DomainNotification> _notifications;
<<<<<<< HEAD
=======

>>>>>>> TesteApi
        public SummaryViewComponent(IDomainNotificationHandler<DomainNotification> notifications)
        {
            _notifications = notifications;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notifications = await Task.FromResult(_notifications.GetNotifications());
<<<<<<< HEAD
            notifications.ForEach(c => ViewData.ModelState.AddModelError(string.Empty, c.Value));
=======
            notifications.ToList().ForEach(c => ViewData.ModelState.AddModelError(string.Empty, c.Value));
>>>>>>> TesteApi

            return View();
        }
    }
}
