﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieManagement.DataAccess;

#nullable disable

namespace MovieManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MovieManagement.Model.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Khanh"
                        },
                        new
                        {
                            Id = 2,
                            Name = "James Cameron"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Joss Whedon"
                        });
                });

            modelBuilder.Entity("MovieManagement.Model.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Viet Nam",
                            DirectorId = 1,
                            Name = "C# Fuck My Life Every Days",
                            ReleaseDate = new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Country = "US",
                            DirectorId = 2,
                            Name = "Avatar",
                            ReleaseDate = new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Country = "US",
                            DirectorId = 2,
                            Name = "Avatar 2: The ways of water",
                            ReleaseDate = new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Country = "US",
                            DirectorId = 3,
                            Name = "Justice League",
                            ReleaseDate = new DateTime(2023, 9, 13, 20, 53, 39, 800, DateTimeKind.Local).AddTicks(7944)
                        },
                        new
                        {
                            Id = 5,
                            Country = "US",
                            DirectorId = 3,
                            Name = "The flash",
                            ReleaseDate = new DateTime(2023, 9, 13, 20, 53, 39, 800, DateTimeKind.Local).AddTicks(7954)
                        });
                });

            modelBuilder.Entity("MovieManagement.Model.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Haha",
                            MovieId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "Haha",
                            MovieId = 2
                        },
                        new
                        {
                            Id = 3,
                            Content = "Haha",
                            MovieId = 3
                        },
                        new
                        {
                            Id = 4,
                            Content = "Haha",
                            MovieId = 4
                        },
                        new
                        {
                            Id = 5,
                            Content = "Haha",
                            MovieId = 5
                        });
                });

            modelBuilder.Entity("MovieManagement.Model.Movie", b =>
                {
                    b.HasOne("MovieManagement.Model.Director", "Director")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");
                });

            modelBuilder.Entity("MovieManagement.Model.Review", b =>
                {
                    b.HasOne("MovieManagement.Model.Movie", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieManagement.Model.Director", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("MovieManagement.Model.Movie", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
