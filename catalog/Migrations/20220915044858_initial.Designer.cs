﻿// <auto-generated />
using System;
using GloboTicket.Catalog.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GloboTicket.Catalog.Migrations
{
    [DbContext(typeof(EventCatalogDbContext))]
    [Migration("20220915044858_initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GloboTicket.Catalog.Model.Concert", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ConcertId");

                    b.ToTable("Concerts");

                    b.HasData(
                        new
                        {
                            EventId = new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                            Artist = "John Egbert",
                            Date = new DateTime(2023, 3, 15, 6, 48, 58, 835, DateTimeKind.Local).AddTicks(9742),
                            Description = "Join John for his farwell tour across 15 continents. John really needs no introduction since he has already mesmerized the world with his banjo.",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/banjo.jpg",
                            Name = "John Egbert Live",
                            Price = 65
                        },
                        new
                        {
                            EventId = new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                            Artist = "Michael Johnson",
                            Date = new DateTime(2023, 6, 15, 6, 48, 58, 835, DateTimeKind.Local).AddTicks(9806),
                            Description = "Michael Johnson doesn't need an introduction. His 25 concert across the globe last year were seen by thousands. Can we add you to the list?",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/michael.jpg",
                            Name = "The State of Affairs: Michael Live!",
                            Price = 85
                        },
                        new
                        {
                            EventId = new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                            Artist = "DJ 'The Mike'",
                            Date = new DateTime(2023, 1, 15, 6, 48, 58, 835, DateTimeKind.Local).AddTicks(9815),
                            Description = "DJs from all over the world will compete in this epic battle for eternal fame.",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/dj.jpg",
                            Name = "Clash of the DJs",
                            Price = 85
                        },
                        new
                        {
                            EventId = new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                            Artist = "Manuel Santinonisi",
                            Date = new DateTime(2023, 1, 15, 6, 48, 58, 835, DateTimeKind.Local).AddTicks(9849),
                            Description = "Get on the hype of Spanish Guitar concerts with Manuel.",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/guitar.jpg",
                            Name = "Spanish guitar hits with Manuel",
                            Price = 25
                        },
                        new
                        {
                            EventId = new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                            Artist = "Nick Sailor",
                            Date = new DateTime(2023, 5, 15, 6, 48, 58, 835, DateTimeKind.Local).AddTicks(9857),
                            Description = "The critics are over the moon and so will you after you've watched this sing and dance extravaganza written by Nick Sailor, the man from 'My dad and sister'.",
                            ImageUrl = "/img/musical.jpg",
                            Name = "To the Moon and Back",
                            Price = 135
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
