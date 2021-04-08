﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tenta_Advnet_Jonathan_Kullman_2;

namespace Tenta_Advnet_Jonathan_Kullman_2.Migrations
{
    [DbContext(typeof(HamsterDbContext))]
    [Migration("20210408101219_FixedActivityAndLoggerMore")]
    partial class FixedActivityAndLoggerMore
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tenta_Advnet_Jonathan_Kullman_2.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActivityLoggerId")
                        .HasColumnType("int");

                    b.Property<int>("ActivityType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TimeOfEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("TimeOfStart")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ActivityLoggerId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Tenta_Advnet_Jonathan_Kullman_2.ActivityLogger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HamsterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HamsterId");

                    b.ToTable("Logger_Activities");
                });

            modelBuilder.Entity("Tenta_Advnet_Jonathan_Kullman_2.Cage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cage");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Gender = 0,
                            MaxCapacity = 3
                        },
                        new
                        {
                            Id = 2,
                            Gender = 0,
                            MaxCapacity = 3
                        },
                        new
                        {
                            Id = 3,
                            Gender = 0,
                            MaxCapacity = 3
                        },
                        new
                        {
                            Id = 4,
                            Gender = 0,
                            MaxCapacity = 3
                        },
                        new
                        {
                            Id = 5,
                            Gender = 0,
                            MaxCapacity = 3
                        },
                        new
                        {
                            Id = 6,
                            Gender = 1,
                            MaxCapacity = 3
                        },
                        new
                        {
                            Id = 7,
                            Gender = 1,
                            MaxCapacity = 3
                        },
                        new
                        {
                            Id = 8,
                            Gender = 1,
                            MaxCapacity = 3
                        },
                        new
                        {
                            Id = 9,
                            Gender = 1,
                            MaxCapacity = 3
                        },
                        new
                        {
                            Id = 10,
                            Gender = 1,
                            MaxCapacity = 3
                        });
                });

            modelBuilder.Entity("Tenta_Advnet_Jonathan_Kullman_2.ExerciseArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ExerciseAreas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MaxCapacity = 6
                        });
                });

            modelBuilder.Entity("Tenta_Advnet_Jonathan_Kullman_2.Hamster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("CageId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CheckInTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrentActivity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ExerciseAreaId")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OldCageId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TimeOfLastExercise")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CageId");

                    b.HasIndex("ExerciseAreaId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Hamsters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 4,
                            Gender = 0,
                            Name = "Rufus",
                            OwnerId = 1
                        },
                        new
                        {
                            Id = 2,
                            Age = 12,
                            Gender = 1,
                            Name = "Lisa",
                            OwnerId = 1
                        },
                        new
                        {
                            Id = 3,
                            Age = 11,
                            Gender = 0,
                            Name = "Fluff",
                            OwnerId = 2
                        },
                        new
                        {
                            Id = 4,
                            Age = 10,
                            Gender = 0,
                            Name = "Nibbler",
                            OwnerId = 2
                        },
                        new
                        {
                            Id = 5,
                            Age = 9,
                            Gender = 0,
                            Name = "Sneaky",
                            OwnerId = 3
                        },
                        new
                        {
                            Id = 6,
                            Age = 8,
                            Gender = 1,
                            Name = "Sussi",
                            OwnerId = 3
                        },
                        new
                        {
                            Id = 7,
                            Age = 7,
                            Gender = 1,
                            Name = "Mulan",
                            OwnerId = 4
                        },
                        new
                        {
                            Id = 8,
                            Age = 6,
                            Gender = 1,
                            Name = "Miss Diggy",
                            OwnerId = 5
                        },
                        new
                        {
                            Id = 9,
                            Age = 5,
                            Gender = 0,
                            Name = "Kalle",
                            OwnerId = 6
                        },
                        new
                        {
                            Id = 10,
                            Age = 4,
                            Gender = 0,
                            Name = "Kurt",
                            OwnerId = 7
                        },
                        new
                        {
                            Id = 11,
                            Age = 4,
                            Gender = 0,
                            Name = "Starlight",
                            OwnerId = 7
                        },
                        new
                        {
                            Id = 12,
                            Age = 3,
                            Gender = 0,
                            Name = "Chivas",
                            OwnerId = 8
                        },
                        new
                        {
                            Id = 13,
                            Age = 3,
                            Gender = 1,
                            Name = "Malin",
                            OwnerId = 9
                        },
                        new
                        {
                            Id = 14,
                            Age = 24,
                            Gender = 0,
                            Name = "Bulle",
                            OwnerId = 10
                        },
                        new
                        {
                            Id = 15,
                            Age = 23,
                            Gender = 0,
                            Name = "Beppe",
                            OwnerId = 11
                        },
                        new
                        {
                            Id = 16,
                            Age = 22,
                            Gender = 1,
                            Name = "Bobo",
                            OwnerId = 12
                        },
                        new
                        {
                            Id = 17,
                            Age = 21,
                            Gender = 1,
                            Name = "Robin",
                            OwnerId = 13
                        },
                        new
                        {
                            Id = 18,
                            Age = 20,
                            Gender = 1,
                            Name = "Amber",
                            OwnerId = 14
                        },
                        new
                        {
                            Id = 19,
                            Age = 19,
                            Gender = 1,
                            Name = "Kimber",
                            OwnerId = 15
                        },
                        new
                        {
                            Id = 20,
                            Age = 18,
                            Gender = 1,
                            Name = "Ruby",
                            OwnerId = 16
                        },
                        new
                        {
                            Id = 21,
                            Age = 16,
                            Gender = 1,
                            Name = "Fiffi",
                            OwnerId = 17
                        },
                        new
                        {
                            Id = 22,
                            Age = 16,
                            Gender = 1,
                            Name = "Neko",
                            OwnerId = 18
                        },
                        new
                        {
                            Id = 23,
                            Age = 15,
                            Gender = 0,
                            Name = "Clint",
                            OwnerId = 19
                        },
                        new
                        {
                            Id = 24,
                            Age = 14,
                            Gender = 0,
                            Name = "Sauron",
                            OwnerId = 20
                        },
                        new
                        {
                            Id = 25,
                            Age = 12,
                            Gender = 1,
                            Name = "Gittan",
                            OwnerId = 21
                        },
                        new
                        {
                            Id = 26,
                            Age = 110,
                            Gender = 0,
                            Name = "Crawler",
                            OwnerId = 22
                        },
                        new
                        {
                            Id = 27,
                            Age = 9,
                            Gender = 1,
                            Name = "Mimmi",
                            OwnerId = 23
                        },
                        new
                        {
                            Id = 28,
                            Age = 8,
                            Gender = 0,
                            Name = "Marvel",
                            OwnerId = 24
                        },
                        new
                        {
                            Id = 29,
                            Age = 7,
                            Gender = 0,
                            Name = "Storm",
                            OwnerId = 25
                        },
                        new
                        {
                            Id = 30,
                            Age = 6,
                            Gender = 1,
                            Name = "Busan",
                            OwnerId = 26
                        });
                });

            modelBuilder.Entity("Tenta_Advnet_Jonathan_Kullman_2.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kallegurra Aktersnurra"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Carl Hamilton"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lisa Nilsson"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Jan Hallgren"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Ottilla Murkwood"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Anfers Murkwood"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Anna Book"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Pernilla Wahlgren"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Bianca Ingrosso"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Lorenzo Lamas"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Bobby Ewing"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Hedy Lamar"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Bette Davis"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Kim Carnes"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Mork of Ork"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Mindy Mendel"
                        },
                        new
                        {
                            Id = 17,
                            Name = "GW Hansson"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Pia Hansson"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Bo Ek"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Anna Al"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Hans Björk"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Carita Gran"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Mia Eriksson"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Anna Linström"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Lennart Berg"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Bo Bergman"
                        });
                });

            modelBuilder.Entity("Tenta_Advnet_Jonathan_Kullman_2.Activity", b =>
                {
                    b.HasOne("Tenta_Advnet_Jonathan_Kullman_2.ActivityLogger", "ActivityLogger")
                        .WithMany("Activity")
                        .HasForeignKey("ActivityLoggerId");

                    b.Navigation("ActivityLogger");
                });

            modelBuilder.Entity("Tenta_Advnet_Jonathan_Kullman_2.ActivityLogger", b =>
                {
                    b.HasOne("Tenta_Advnet_Jonathan_Kullman_2.Hamster", "Hamster")
                        .WithMany("ActivityLogger")
                        .HasForeignKey("HamsterId");

                    b.Navigation("Hamster");
                });

            modelBuilder.Entity("Tenta_Advnet_Jonathan_Kullman_2.Hamster", b =>
                {
                    b.HasOne("Tenta_Advnet_Jonathan_Kullman_2.Cage", "Cage")
                        .WithMany()
                        .HasForeignKey("CageId");

                    b.HasOne("Tenta_Advnet_Jonathan_Kullman_2.ExerciseArea", "ExerciseArea")
                        .WithMany()
                        .HasForeignKey("ExerciseAreaId");

                    b.HasOne("Tenta_Advnet_Jonathan_Kullman_2.Owner", "Owner")
                        .WithMany("Hamsters")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cage");

                    b.Navigation("ExerciseArea");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Tenta_Advnet_Jonathan_Kullman_2.ActivityLogger", b =>
                {
                    b.Navigation("Activity");
                });

            modelBuilder.Entity("Tenta_Advnet_Jonathan_Kullman_2.Hamster", b =>
                {
                    b.Navigation("ActivityLogger");
                });

            modelBuilder.Entity("Tenta_Advnet_Jonathan_Kullman_2.Owner", b =>
                {
                    b.Navigation("Hamsters");
                });
#pragma warning restore 612, 618
        }
    }
}
