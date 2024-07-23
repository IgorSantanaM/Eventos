using Events.IO.Domain.DEvents.Commands;

namespace Events.IO.Domain.Interface
{
    public interface IUnitOfWork
    {
        CommandResponse Commit();
    }
}
