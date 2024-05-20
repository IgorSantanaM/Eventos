using Events.IO.Domain.DEvents;
using Events.IO.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.IO.Infra.Data.Mappings
{
	public class CategoryMapping : EntityTypeConfiguration<Category>
    {
        public override void Map(EntityTypeBuilder<Category> builder)
        {
            builder
                .Property(e => e.Name)
                .HasColumnType("varchar(150)")
                .IsRequired();
            builder
            .Ignore(e => e.ValidationResult);

            builder
            .Ignore(e => e.CascadeMode);

            builder
                .ToTable("Categories");
        }
    }
}
