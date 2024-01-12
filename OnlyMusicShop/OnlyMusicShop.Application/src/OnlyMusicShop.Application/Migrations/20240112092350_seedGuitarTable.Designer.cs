﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlyMusicShop.Application.Repositories;

#nullable disable

namespace OnlyMusicShop.Application.Migrations
{
    [DbContext(typeof(OnlyMusicDbContext))]
    [Migration("20240112092350_seedGuitarTable")]
    partial class seedGuitarTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnlyMusicShop.Domain.Entities.Guitar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Guitars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Satin Cherry",
                            Description = "Gitara elektryczna pół-hollow z przetwornikami skalibrowanymi typu T",
                            Manufacturer = "Gibson",
                            Model = "ES-335",
                            Name = "Gibson ES-335 Cherry",
                            Price = 12999m,
                            Type = "Semi-hollow"
                        },
                        new
                        {
                            Id = 2,
                            Color = "Flame Maple",
                            Description = "Gitara elektryczna sygnowana przez Guthriego Govana",
                            Manufacturer = "Charvel",
                            Model = "Guthrie Govan Signature",
                            Name = "Charvel Guthrie Govan HSH Flame Maple",
                            Price = 16690m,
                            Type = "Strat"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Saphire blue",
                            Description = "Gitara elektryczna sygnowana przez Guthriego Govana",
                            Manufacturer = "Kiesel",
                            Model = "JB200C",
                            Name = "Jason Becker signature Kiesel",
                            Price = 15999m,
                            Type = "Strat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}