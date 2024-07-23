using Events.IO.Domain.Hosts;
using Events.IO.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.IO.Infra.Data.Mappings
{
	public class HostMapping : EntityTypeConfiguration<Host>
    {
        public override void Map(EntityTypeBuilder<Host> builder)
        {
            builder
                .Property(e => e.Name)
                .HasColumnType("varchar(150)")
                .IsRequired();
            builder
               .Property(e => e.Email)
               .HasColumnType("varchar(100)")
               .IsRequired();
            builder
               .Property(e => e.CPF)
               .HasColumnType("varchar(11)")
               .IsRequired();
            builder
            .Ignore(e => e.ValidationResult);

            builder
            .Ignore(e => e.CascadeMode);

            builder
                .ToTable("Hosts");
        }
    }
}
