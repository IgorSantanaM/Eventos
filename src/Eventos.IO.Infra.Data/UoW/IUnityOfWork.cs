using Eventos.IO.Domain.Eventos.Commands;

namespace Eventos.IO.Infra.Data.UoW
{
    internal interface IUnityOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}
