using Events.IO.Domain.Core.Bus;
using Events.IO.Domain.Core.Notifications;
using Events.IO.Domain.Interface;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Events.IO.Services.Api.Controllers
{
    [Produces("application/json")]
    public abstract class ControllerBase : Controller
    {
        private readonly IDomainNotificationHandler<DomainNotification> _notifications;
        private readonly IBus _bus;

        protected Guid HostId { get; set; }
        public ControllerBase(IDomainNotificationHandler<DomainNotification> notifications,
                               Domain.Interface.IUser user,
                               IBus bus)
        {
            _notifications = notifications;
            _bus = bus;

            if (user.IsAuthenticated())
            {
                HostId = user.GetUserID();
            }

        }
        protected new IActionResult Response(object result = null)
        {
            if (ValideOperation())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = _notifications.GetNotifications().Select(n => n.Value)
            });
        }
        protected bool ValideOperation()
        {
            return (!_notifications.HasNotifications());
        }
        protected void NotifyErrorInvalidModel()
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            foreach (var error in errors)
            {
                NotifyErrors(string.Empty, error.ErrorMessage);
            }
        }
        protected void NotifyErrors(string code, string message)
        {
            _bus.RaiseEvent(new DomainNotification(code, message));
        }
        
    }
}
