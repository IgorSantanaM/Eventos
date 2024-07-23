using Events.IO.Domain.DEvents;
using Events.IO.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
namespace Events.IO.Infra.Data.Mappings

{
	internal class EventMapping : EntityTypeConfiguration<DEvent>
    {
        public override void Map(EntityTypeBuilder<DEvent> builder)
        {
            builder
                .Property(e => e.Name)
                .HasColumnType("varchar(150)")
            .IsRequired();

            builder
                .Property(e => e.ShortDescription)
                .HasColumnType("varchar(150)");

            builder
                .Property(e => e.LongDescription)
                .HasColumnType("varchar(max)");

            builder
                 .Property(e => e.Price)
                .HasPrecision(18, 2);
            builder
                .Property(e => e.CompanyName)
                .HasColumnType("varchar(150 )")
            .IsRequired();

            builder
                .Ignore(e => e.ValidationResult);


            builder
            .Ignore(e => e.Tags);


<<<<<<< HEAD
<<<<<<< HEAD
=======
           builder
                .Ignore(e => e.CascadeMode);

>>>>>>> TesteApi
=======
>>>>>>> master
            builder
            .ToTable("Events");

            builder
                .HasOne(e => e.Host)
                .WithMany(o => o.DEvents)
                .HasForeignKey(e => e.HostId);

            builder
                .HasOne(e => e.Category)
                .WithMany(e => e.DEvents)
                .HasForeignKey(e => e.CategoryId)
                .IsRequired(false);
        }
    }
}
