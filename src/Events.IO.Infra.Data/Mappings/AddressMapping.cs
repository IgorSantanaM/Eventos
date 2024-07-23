using Events.IO.Domain.DEvents;
using Events.IO.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.IO.Infra.Data.Mappings
{
    public class AddressMapping : EntityTypeConfiguration<Address>
    {
        public override void Map(EntityTypeBuilder<Address> builder)
        {
            builder.Property(e=> e.PublicPlace)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar(150)");

            builder.Property(e => e.Number)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("varchar(20)");

            builder.Property(e => e.Neighborhood)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");

            builder.Property(e => e.ZipCode)
                .IsRequired()
                .HasMaxLength(8)
                .HasColumnType("varchar(8)");

            builder.Property(e => e.Complement)
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");


            builder.Property(e => e.State)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");
            
               builder
                .Ignore(e => e.ValidationResult);

            builder
            .Ignore(e => e.CascadeMode);

            builder
               .HasOne(c => c.DEvent)
               .WithOne(c => c.Address)
               .HasForeignKey<Address>(c => c.EventId)
               .IsRequired(false);

<<<<<<< HEAD
<<<<<<< HEAD
            builder 
=======
            builder
>>>>>>> TesteApi
=======
            builder 
>>>>>>> master
                .ToTable("Addresses");
        }
    }
}
