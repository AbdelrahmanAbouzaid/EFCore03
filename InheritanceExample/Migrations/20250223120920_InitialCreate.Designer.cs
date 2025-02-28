﻿// <auto-generated />
using InheritanceExample.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InheritanceExample.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250223120920_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InheritanceExample.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employee", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("InheritanceExample.Models.FullTimeEmployee", b =>
                {
                    b.HasBaseType("InheritanceExample.Models.Employee");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.ToTable("FullTimeEmployee", (string)null);
                });

            modelBuilder.Entity("InheritanceExample.Models.PartTimeEmployee", b =>
                {
                    b.HasBaseType("InheritanceExample.Models.Employee");

                    b.Property<double>("HourRate")
                        .HasColumnType("float");

                    b.Property<int>("NumberOfHours")
                        .HasColumnType("int");

                    b.ToTable("PartTimeEmployee", (string)null);
                });

            modelBuilder.Entity("InheritanceExample.Models.FullTimeEmployee", b =>
                {
                    b.HasOne("InheritanceExample.Models.Employee", null)
                        .WithOne()
                        .HasForeignKey("InheritanceExample.Models.FullTimeEmployee", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InheritanceExample.Models.PartTimeEmployee", b =>
                {
                    b.HasOne("InheritanceExample.Models.Employee", null)
                        .WithOne()
                        .HasForeignKey("InheritanceExample.Models.PartTimeEmployee", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
