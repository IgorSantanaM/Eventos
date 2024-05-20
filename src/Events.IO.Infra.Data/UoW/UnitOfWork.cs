using Events.IO.Domain.DEvents.Commands;
using Events.IO.Infra.Data.Context;

namespace Events.IO.Infra.Data.UoW
{
    public class UnitOfWork : IUnityOfWork
    {
        private readonly EventsContext _context;
        public UnitOfWork(EventsContext context)
        {
            _context = context;
        }
        public CommandResponse Commit()
        {
            var rowsAffected = _context.SaveChanges();
            return new CommandResponse(rowsAffected > 0);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
