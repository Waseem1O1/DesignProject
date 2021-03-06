// <auto-generated />
using System;
using DesignProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesignProject.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220414141442_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DesignProject.Models.Persons", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("dateofBirth")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.ToTable("Persons", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persons");
                });

            modelBuilder.Entity("DesignProject.Models.Employee", b =>
                {
                    b.HasBaseType("DesignProject.Models.Persons");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("startingDate")
                        .HasColumnType("datetime(6)");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("DesignProject.Models.Student", b =>
                {
                    b.HasBaseType("DesignProject.Models.Persons");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime(6)");

                    b.HasDiscriminator().HasValue("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
