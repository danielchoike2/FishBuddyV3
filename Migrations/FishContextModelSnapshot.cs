﻿// <auto-generated />
using FishBuddy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FishBuddy.Migrations
{
    [DbContext(typeof(FishContext))]
    partial class FishContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FishBuddy.Models.FishLog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FishName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaxLength")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaxWeight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("FishList");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FishName = "Largemouth Bass",
                            Location = "Ransom Lake",
                            MaxLength = "27 Inches",
                            MaxWeight = "11.94 Pounds"
                        },
                        new
                        {
                            ID = 2,
                            FishName = "Northern Pike",
                            Location = "Bronson Lake",
                            MaxLength = "51.5 Inches",
                            MaxWeight = "39 Pounds"
                        },
                        new
                        {
                            ID = 3,
                            FishName = "Walleye",
                            Location = "Long Lake",
                            MaxLength = "35 Inches",
                            MaxWeight = "17.19 Pounds"
                        });
                });

            modelBuilder.Entity("FishBuddy.Models.FishLure", b =>
                {
                    b.Property<int>("FishLureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FishLureId"), 1L, 1);

                    b.Property<string>("FishLureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FishSpeciesId")
                        .HasColumnType("int");

                    b.HasKey("FishLureId");

                    b.HasIndex("FishSpeciesId");

                    b.ToTable("FishLure");

                    b.HasData(
                        new
                        {
                            FishLureId = 1,
                            FishLureName = "Fake Worms, Jigs, Topwater Lures, Paddletail Swimbaits",
                            FishSpeciesId = 1
                        },
                        new
                        {
                            FishLureId = 2,
                            FishLureName = "Tubes, Jigs, Topwater Lures, Paddletail Swimbaits",
                            FishSpeciesId = 2
                        },
                        new
                        {
                            FishLureId = 3,
                            FishLureName = "Spoons, Crankbaits, Jerkbaits, Large Soft Swimbaits",
                            FishSpeciesId = 3
                        },
                        new
                        {
                            FishLureId = 4,
                            FishLureName = "Spoons & Tubes",
                            FishSpeciesId = 4
                        });
                });

            modelBuilder.Entity("FishBuddy.Models.FishSpecies", b =>
                {
                    b.Property<int>("FishSpeciesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FishSpeciesId"), 1L, 1);

                    b.Property<string>("FishCommonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FishHabitat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FishSpeciesName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordLength")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordWeight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FishSpeciesId");

                    b.ToTable("FishSpecies");

                    b.HasData(
                        new
                        {
                            FishSpeciesId = 1,
                            FishCommonName = "Largemouth Bass",
                            FishHabitat = "Ponds, Swamps, Lakes, Creeks, Rivers",
                            FishSpeciesName = "Micropterus salmoides",
                            RecordLength = "25.59 inches",
                            RecordWeight = "22 Pounds 4 Ounces"
                        },
                        new
                        {
                            FishSpeciesId = 2,
                            FishCommonName = "Smallmouth Bass",
                            FishHabitat = "Ponds, Lakes, Creeks, Rivers",
                            FishSpeciesName = "Micropterus salmoides",
                            RecordLength = "27 inches",
                            RecordWeight = "11 Pounds 15 Ounces"
                        },
                        new
                        {
                            FishSpeciesId = 3,
                            FishCommonName = "Northern Pike",
                            FishHabitat = "Ponds, Lakes, Creeks, Rivers",
                            FishSpeciesName = "Esox lucius",
                            RecordLength = "52 Inches",
                            RecordWeight = "55 Pounds"
                        },
                        new
                        {
                            FishSpeciesId = 4,
                            FishCommonName = "Lake Trout",
                            FishHabitat = "Lakes",
                            FishSpeciesName = "Salvelinus namaycush",
                            RecordLength = "47 Inches",
                            RecordWeight = "73 Pounds 29 Ounces"
                        });
                });

            modelBuilder.Entity("FishBuddy.Models.FishLure", b =>
                {
                    b.HasOne("FishBuddy.Models.FishSpecies", "FishSpecies")
                        .WithMany()
                        .HasForeignKey("FishSpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FishSpecies");
                });
#pragma warning restore 612, 618
        }
    }
}
