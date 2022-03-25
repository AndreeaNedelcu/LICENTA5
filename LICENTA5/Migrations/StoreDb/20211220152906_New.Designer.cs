﻿// <auto-generated />
using LICENTA5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LICENTA5.Migrations.StoreDb
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20211220152906_New")]
    partial class New
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LICENTA5.Models.Restaurant", b =>
                {
                    b.Property<long>("RestaurantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("closingHour")
                        .HasColumnType("int");

                    b.Property<int>("nrPersMax")
                        .HasColumnType("int");

                    b.Property<int>("openHour")
                        .HasColumnType("int");

                    b.HasKey("RestaurantID");

                    b.ToTable("Restaurants");
                });
#pragma warning restore 612, 618
        }
    }
}
