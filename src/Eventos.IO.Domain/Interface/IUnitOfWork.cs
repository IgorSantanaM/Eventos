using Eventos.IO.Domain.Eventos.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.IO.Domain.Interface
{
    public interface IUnitOfWork
    {
        CommandResponse Commit();
    }
}
