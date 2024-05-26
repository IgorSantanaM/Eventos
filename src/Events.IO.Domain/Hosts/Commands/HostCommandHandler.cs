using Events.IO.Domain.CommandHandlers;
using Events.IO.Domain.Core.Bus;
using Events.IO.Domain.Core.Events;
using Events.IO.Domain.Core.Notifications;
using Events.IO.Domain.Hosts.Repository;
using Events.IO.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.IO.Domain.Hosts.Commands
{
    public class HostCommandHandler : CommandHandler,
        IHandler<RegistryHostCommand>
    {
        private readonly IBus _bus;
        private readonly IHostRepository _hostRepository;
        public HostCommandHandler(IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainNotification> notifications, IHostRepository hostRepository) : base(uow, bus, notifications)
        {
            _bus = bus;
            _hostRepository = hostRepository;
        }

        public void Handle(RegistryHostCommand message)
        {
            Host host = new(message.Id, message.Name, message.CPF, message.Email);

            if (!host.IsValidate())
            {
                NotifyErrorValidations(host.ValidationResult);
                return;
            }

            IEnumerable<Host> existenceHost = _hostRepository.Find(o=> o.CPF == host.CPF || o.Email == host.Email);

            if (existenceHost.Any())
            {
                _bus.RaiseEvent(new DomainNotification(message.MessageType, "CPF or email already taken"));
            }

            _hostRepository.Add(host);

            if (Commit())
            {
                
            }
        }
    }
}
