using Events.IO.Domain.Core.Notifications;
using Microsoft.AspNetCore.Mvc;

namespace Events.IO.Web.ViewComponents
{
	public class SummaryViewComponent : ViewComponent
	{
		private readonly IDomainNotificationHandler<DomainNotification> _notifications;

        public SummaryViewComponent(IDomainNotificationHandler<DomainNotification> notifications)
        {
            _notifications = notifications;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notifications = await Task.FromResult(_notifications.GetNotifications());
            notifications.ForEach(c => ViewData.ModelState.AddModelError(string.Empty, c.Price));

            return View(); 
        }
    }
}
