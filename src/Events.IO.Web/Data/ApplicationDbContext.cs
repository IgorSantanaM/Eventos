using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Events.IO.Application.ViewModels;

namespace Events.IO.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Events.IO.Application.ViewModels.EventViewModel> EventViewModel { get; set; } = default!;
    }
}
