using Eventos.IO.Domain.Eventos.Commands;
using Eventos.IO.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.IO.Infra.Data.UoW
{
    public class UnitOfWork : IUnityOfWork
    {
        private readonly EventosContext _context;
        public UnitOfWork(EventosContext context)
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
