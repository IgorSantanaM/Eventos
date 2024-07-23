using AutoMapper;
using Events.IO.Application.Interfaces;
using Events.IO.Application.ViewModels;
using Events.IO.Domain.Core.Bus;
using Events.IO.Domain.Hosts.Commands;
using Events.IO.Domain.Hosts.Repository;

namespace Events.IO.Application.Services
{
    public class HostAppService : IHostAppService
    {

        private readonly IBus _bus;
        private readonly IHostRepository _hostRepository;
        private readonly IMapper _mapper;

        public HostAppService(IMapper mapper, IHostRepository hostRepository, IBus bus)
        {
            _mapper = mapper;
            _hostRepository = hostRepository;
            _bus = bus;
        }

        public void Registry(HostViewModel hostViewModel)
        {
            RegistryHostCommand registryCommand = _mapper.Map<RegistryHostCommand>(hostViewModel);
            _bus.SendCommand(registryCommand);
        }

        public void Dispose()
        {
            _hostRepository.Dispose();
        }
    }
}
