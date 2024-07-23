﻿// <auto-generated />
using System;
using Events.IO.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Events.IO.Infra.Data.Migrations
{
    [DbContext(typeof(EventsContext))]
    partial class EventsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Events.IO.Domain.DEvents.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("ClassLevelCascadeMode")
                        .HasColumnType("int");

                    b.Property<string>("Complement")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid?>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("PublicPlace")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<int>("RuleLevelCascadeMode")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.HasKey("Id");

                    b.HasIndex("EventId")
                        .IsUnique()
                        .HasFilter("[EventId] IS NOT NULL");

                    b.ToTable("Addresses", (string)null);
                });

            modelBuilder.Entity("Events.IO.Domain.DEvents.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CascadeMode")
                        .HasColumnType("int");

                    b.Property<int>("ClassLevelCascadeMode")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<int>("RuleLevelCascadeMode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("Events.IO.Domain.DEvents.DEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("datetime2");

<<<<<<< HEAD
                    b.Property<int>("CascadeMode")
                        .HasColumnType("int");

=======
>>>>>>> TesteApi
                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ClassLevelCascadeMode")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("varchar(150 )");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Free")
                        .HasColumnType("bit");

                    b.Property<Guid?>("HostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LongDescription")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<bool>("Online")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RuleLevelCascadeMode")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("HostId");

                    b.ToTable("Events", (string)null);
                });

            modelBuilder.Entity("Events.IO.Domain.Hosts.Host", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<int>("ClassLevelCascadeMode")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<int>("RuleLevelCascadeMode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hosts", (string)null);
                });

            modelBuilder.Entity("Events.IO.Domain.DEvents.Address", b =>
                {
                    b.HasOne("Events.IO.Domain.DEvents.DEvent", "DEvent")
                        .WithOne("Address")
                        .HasForeignKey("Events.IO.Domain.DEvents.Address", "EventId");

                    b.Navigation("DEvent");
                });

            modelBuilder.Entity("Events.IO.Domain.DEvents.DEvent", b =>
                {
                    b.HasOne("Events.IO.Domain.DEvents.Category", "Category")
                        .WithMany("DEvents")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Events.IO.Domain.Hosts.Host", "Host")
                        .WithMany("DEvents")
                        .HasForeignKey("HostId");

                    b.Navigation("Category");

                    b.Navigation("Host");
                });

            modelBuilder.Entity("Events.IO.Domain.DEvents.Category", b =>
                {
                    b.Navigation("DEvents");
                });

            modelBuilder.Entity("Events.IO.Domain.DEvents.DEvent", b =>
                {
<<<<<<< HEAD
                    b.Navigation("Address");
=======
                    b.Navigation("Address")
                        .IsRequired();
>>>>>>> TesteApi
                });

            modelBuilder.Entity("Events.IO.Domain.Hosts.Host", b =>
                {
                    b.Navigation("DEvents");
                });
#pragma warning restore 612, 618
        }
    }
}
