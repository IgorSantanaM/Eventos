using Events.IO.Domain.Core.Bus;
using Events.IO.Domain.Core.Notifications;
using Events.IO.Domain.Interface;
using FluentValidation.Results;

namespace Events.IO.Domain.CommandHandlers
{
    public abstract class CommandHandler
    {
        private readonly IUnitOfWork _uow;
        private readonly IBus _bus;
        private readonly IDomainNotificationHandler<DomainNotification> _notifications;

        protected CommandHandler(IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainNotification> notifications)
        {
            _uow = uow;
            _bus = bus;
            _notifications = notifications;
        }
        protected void NotificarValidacoesErro(ValidationResult validationResult)
        {
            foreach(var error in validationResult.Errors)
            {
                Console.WriteLine(error.ErrorMessage);
                _bus.RaiseEvent(new DomainNotification(error.PropertyName, error.ErrorMessage));
            }
        }

        protected bool Commit()
        {
            if (_notifications.HasNotifications()) return false;
            var commandReponse = _uow.Commit();
            if (commandReponse.Success) return true;
            Console.WriteLine("Erro when trying to save data in the Database");
            _bus.RaiseEvent(new DomainNotification("Commit", "Error when saving the data base"));

            return false;
        }
    }
}
