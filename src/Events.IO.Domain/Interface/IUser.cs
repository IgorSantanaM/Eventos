using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Events.IO.Domain.Interface
{
    public interface IUser
    {
        string Name { get; }
        Guid GetUserID();
        bool IsAuthenticated();
        IEnumerable<Claim> GetClaimsIdentity(); 
    }
}
