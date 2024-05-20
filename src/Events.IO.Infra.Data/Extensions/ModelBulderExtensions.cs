using Microsoft.EntityFrameworkCore;

namespace Events.IO.Infra.Data.Extensions

{
	public static class ModelBulderExtensions
    {
        public static void AddConfiguration<TEntity>(this ModelBuilder modelBuilder, EntityTypeConfiguration<TEntity> configuration) where TEntity : class
        {
            configuration.Map(modelBuilder.Entity<TEntity>());
        }

    }
}
