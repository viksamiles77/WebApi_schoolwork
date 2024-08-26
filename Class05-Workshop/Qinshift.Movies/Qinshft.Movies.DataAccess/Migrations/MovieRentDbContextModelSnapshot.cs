﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Qinshft.Movies.DataAccess;

#nullable disable

namespace Qinshft.Movies.DataAccess.Migrations
{
    [DbContext(typeof(MovieRentDbContext))]
    partial class MovieRentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Qinshift.Movies.DomainModels.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2024, 8, 26, 19, 41, 0, 247, DateTimeKind.Local).AddTicks(6207),
                            Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.",
                            Genre = 3,
                            Title = "Inception",
                            Year = 2010
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2024, 8, 26, 19, 41, 0, 247, DateTimeKind.Local).AddTicks(6242),
                            Description = "Teddy Daniels and Chuck Aule, two US marshals, are sent to an asylum on a remote island in order to investigate the disappearance of a patient, where Teddy uncovers a shocking truth about the place.",
                            Genre = 4,
                            Title = "Shutter Island",
                            Year = 2010
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2024, 8, 26, 19, 41, 0, 247, DateTimeKind.Local).AddTicks(6245),
                            Description = "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in South Boston.",
                            Genre = 5,
                            Title = "The Departed",
                            Year = 2006
                        },
                        new
                        {
                            Id = 4,
                            CreatedOn = new DateTime(2024, 8, 26, 19, 41, 0, 247, DateTimeKind.Local).AddTicks(6247),
                            Description = "An astronaut becomes stranded on Mars after his team assume him dead, and must rely on his ingenuity to find a way to signal to Earth that he is alive and can survive until a potential rescue.",
                            Genre = 2,
                            Title = "The Martian",
                            Year = 2015
                        },
                        new
                        {
                            Id = 5,
                            CreatedOn = new DateTime(2024, 8, 26, 19, 41, 0, 247, DateTimeKind.Local).AddTicks(6249),
                            Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.",
                            Genre = 1,
                            Title = "The Dark Knight",
                            Year = 2008
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
