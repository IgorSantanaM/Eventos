using Events.IO.Domain.DEvents.Commands;

namespace Events.IO.Infra.Data.UoW
{
    public interface IUnityOfWork : IDisposable
    {
        CommandResponse Commit();
    }
}
