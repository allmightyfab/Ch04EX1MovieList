﻿// <auto-generated />
using System;
using Ch04EX1MovieList.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ch04EX1MovieList.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ch04EX1MovieList.Models.Genre", b =>
                {
                    b.Property<string>("GenreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = "A",
                            Name = "Action"
                        },
                        new
                        {
                            GenreId = "C",
                            Name = "Comdey"
                        },
                        new
                        {
                            GenreId = "D",
                            Name = "Drama"
                        },
                        new
                        {
                            GenreId = "H",
                            Name = "Horror"
                        },
                        new
                        {
                            GenreId = "M",
                            Name = "Musical"
                        },
                        new
                        {
                            GenreId = "R",
                            Name = "RomCom"
                        },
                        new
                        {
                            GenreId = "S",
                            Name = "SciFi"
                        });
                });

            modelBuilder.Entity("Ch04EX1MovieList.Models.Moviecs", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<string>("GenreID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.HasIndex("GenreID");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            GenreID = "D",
                            Name = "Casablanka",
                            Rating = 5,
                            Year = 1942
                        },
                        new
                        {
                            MovieId = 2,
                            GenreID = "A",
                            Name = "Wonder Woman",
                            Rating = 3,
                            Year = 2017
                        },
                        new
                        {
                            MovieId = 3,
                            GenreID = "R",
                            Name = "Moonstruck",
                            Rating = 4,
                            Year = 1988
                        });
                });

            modelBuilder.Entity("Ch04EX1MovieList.Models.Moviecs", b =>
                {
                    b.HasOne("Ch04EX1MovieList.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
