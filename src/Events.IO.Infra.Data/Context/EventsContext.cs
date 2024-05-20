using Events.IO.Domain.DEvents;
using Events.IO.Domain.Hosts;
using Events.IO.Infra.Data.Extensions;
using Events.IO.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Events.IO.Infra.Data.Context
{
    public class EventsContext : DbContext
    {
        public DbSet<DEvent> DEvents { get; set; }
        public DbSet<Host> Hosts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region FluentApi
            modelBuilder.AddConfiguration(new EventMapping());
            modelBuilder.AddConfiguration(new AddressMapping());
            modelBuilder.AddConfiguration(new HostMapping());
            modelBuilder.AddConfiguration(new CategoryMapping());
            #endregion
            base.OnModelCreating(modelBuilder);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
