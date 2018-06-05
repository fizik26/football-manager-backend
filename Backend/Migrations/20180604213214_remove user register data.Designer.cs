﻿// <auto-generated />
using System;
using Backend.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.Migrations
{
    [DbContext(typeof(FootballManagerContext))]
    [Migration("20180604213214_remove user register data")]
    partial class removeuserregisterdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Backend.Models.BuildingModels.Building", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("Level")
                        .HasColumnName("LEVEL");

                    b.HasKey("Id");

                    b.ToTable("BUILDINGS");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Building");
                });

            modelBuilder.Entity("Backend.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FoundationDate")
                        .HasColumnName("FOUNDATION_DATE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME")
                        .HasMaxLength(64);

                    b.Property<int>("UserId")
                        .HasColumnName("USER_ID");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("CLUBS");
                });

            modelBuilder.Entity("Backend.Models.PlayerModels.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnName("AGE");

                    b.Property<int>("BodyType")
                        .HasColumnName("BODY_TYPE");

                    b.Property<int>("ClubId")
                        .HasColumnName("CLUB_ID");

                    b.Property<int>("Country")
                        .HasColumnName("COUNTRY");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("FIRST_NAME")
                        .HasMaxLength(64);

                    b.Property<int>("FirstPosition")
                        .HasColumnName("FIRST_POSITION");

                    b.Property<int>("Height")
                        .HasColumnName("HEIGHT");

                    b.Property<int>("HeightType")
                        .HasColumnName("HEIGHT_TYPE");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("LAST_NAME")
                        .HasMaxLength(64);

                    b.Property<int>("SecondPosition")
                        .HasColumnName("SECOND_POSITION");

                    b.Property<int>("Talent")
                        .HasColumnName("TALENT");

                    b.Property<int>("ThirdPosition")
                        .HasColumnName("THIRD_POSITION");

                    b.Property<int>("Weight")
                        .HasColumnName("WEIGHT");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("PLAYERS");
                });

            modelBuilder.Entity("Backend.Models.PlayerModels.PlayerStats", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<float>("Acceleration")
                        .HasColumnName("ACCELERATION");

                    b.Property<float>("Agility")
                        .HasColumnName("AGILITY");

                    b.Property<float>("BallControl")
                        .HasColumnName("BALL_CONTROL");

                    b.Property<float>("Crossing")
                        .HasColumnName("CROSSING");

                    b.Property<float>("FreeKicks")
                        .HasColumnName("FREE_CICKS");

                    b.Property<float>("Heading")
                        .HasColumnName("HEADING");

                    b.Property<float>("Interceptions")
                        .HasColumnName("INTERCEPTIONS");

                    b.Property<float>("Jumping")
                        .HasColumnName("JUMPING");

                    b.Property<float>("LongPassing")
                        .HasColumnName("LONG_PASSING");

                    b.Property<float>("LongShots")
                        .HasColumnName("LONG_SHOTS");

                    b.Property<float>("Penalties")
                        .HasColumnName("PENALTIES");

                    b.Property<float>("ShortPassing")
                        .HasColumnName("SHORT_PASSING");

                    b.Property<float>("Shots")
                        .HasColumnName("SHOTS");

                    b.Property<float>("SlidingTackles")
                        .HasColumnName("SLIDING_TACKLES");

                    b.Property<float>("SprintSpeed")
                        .HasColumnName("SPRINT_SPEED");

                    b.Property<float>("Stamina")
                        .HasColumnName("STAMINA");

                    b.Property<float>("StandingTackles")
                        .HasColumnName("STANDING_TACKLES");

                    b.Property<float>("Strength")
                        .HasColumnName("STRENGTH");

                    b.Property<float>("Talent")
                        .HasColumnName("TALENT");

                    b.Property<float>("Tricks")
                        .HasColumnName("TRICKS");

                    b.HasKey("Id");

                    b.ToTable("PLAYER_STATS");
                });

            modelBuilder.Entity("Backend.Models.PlayerModels.PlayerTemporaryStats", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<int>("Injurie")
                        .HasColumnName("INJURY");

                    b.Property<DateTime>("InjurieDateTime")
                        .HasColumnName("INJURY_DATE_TIME");

                    b.Property<int>("Morale")
                        .HasColumnName("MORALE");

                    b.Property<DateTime>("MoraleDateTime")
                        .HasColumnName("MORALE_DATE_TIME");

                    b.Property<int>("Stamnia")
                        .HasColumnName("STAMNIA");

                    b.Property<DateTime>("StamniaDateTime")
                        .HasColumnName("STAMNIA_DATE_TIME");

                    b.HasKey("Id");

                    b.ToTable("PLAYER_TEMPORARY_STATS");
                });

            modelBuilder.Entity("Backend.Models.SquadModels.FormationData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Formation")
                        .HasColumnName("FORMATION");

                    b.Property<int>("SquadId")
                        .HasColumnName("SQUAD_ID");

                    b.HasKey("Id");

                    b.HasIndex("SquadId")
                        .IsUnique();

                    b.ToTable("FORMATION_DATA");
                });

            modelBuilder.Entity("Backend.Models.SquadModels.FormationPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FormationDataId")
                        .HasColumnName("FORMATION_DATA_ID");

                    b.Property<int>("FormationPositionType")
                        .HasColumnName("FORMATION_POSITION_TYPE");

                    b.Property<int>("PlayerId")
                        .HasColumnName("PLAYER_ID");

                    b.Property<int>("PlayerPosition")
                        .HasColumnName("PLAYER_POSITION");

                    b.HasKey("Id");

                    b.HasIndex("FormationDataId");

                    b.ToTable("FORMATION_POSITIONS");
                });

            modelBuilder.Entity("Backend.Models.SquadModels.Squad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClubId")
                        .HasColumnName("CLUB_ID");

                    b.Property<bool>("IsActive")
                        .HasColumnName("IS_ACTIVE");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("SQUADS");
                });

            modelBuilder.Entity("Backend.Models.StaffModels.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClubId");

                    b.Property<int>("Country")
                        .HasColumnName("COUNTRY");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("FIRST_NAME")
                        .HasMaxLength(64);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("LAST_NAME")
                        .HasMaxLength(64);

                    b.Property<int>("Level")
                        .HasColumnName("LEVEL");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("EMPLOYEES");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Employee");
                });

            modelBuilder.Entity("Backend.Models.UserModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Boosters")
                        .HasColumnName("BOOSTERS");

                    b.Property<int>("Coins")
                        .HasColumnName("COINS");

                    b.Property<int>("Country")
                        .HasColumnName("COUNTRY");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("FIRST_NAME")
                        .HasMaxLength(64);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("LAST_NAME")
                        .HasMaxLength(64);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnName("LOGIN")
                        .HasMaxLength(64);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("PASSWORD")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("USERS");
                });

            modelBuilder.Entity("Backend.Models.BuildingModels.Academy", b =>
                {
                    b.HasBaseType("Backend.Models.BuildingModels.Building");


                    b.ToTable("ACADEMIES");

                    b.HasDiscriminator().HasValue("Academy");
                });

            modelBuilder.Entity("Backend.Models.BuildingModels.FanClub", b =>
                {
                    b.HasBaseType("Backend.Models.BuildingModels.Building");

                    b.Property<int>("FansCount")
                        .HasColumnName("FANS_COUNT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME");

                    b.ToTable("FAN_CLUBS");

                    b.HasDiscriminator().HasValue("FanClub");
                });

            modelBuilder.Entity("Backend.Models.BuildingModels.MedicalCenter", b =>
                {
                    b.HasBaseType("Backend.Models.BuildingModels.Building");


                    b.ToTable("MEDICAL_CENTERS");

                    b.HasDiscriminator().HasValue("MedicalCenter");
                });

            modelBuilder.Entity("Backend.Models.BuildingModels.Stadium", b =>
                {
                    b.HasBaseType("Backend.Models.BuildingModels.Building");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME");

                    b.ToTable("STADIUMS");

                    b.HasDiscriminator().HasValue("Stadium");
                });

            modelBuilder.Entity("Backend.Models.BuildingModels.TrainingCenter", b =>
                {
                    b.HasBaseType("Backend.Models.BuildingModels.Building");


                    b.ToTable("TRAINING_CENTERS");

                    b.HasDiscriminator().HasValue("TrainingCenter");
                });

            modelBuilder.Entity("Backend.Models.StaffModels.HeadCoach", b =>
                {
                    b.HasBaseType("Backend.Models.StaffModels.Employee");


                    b.ToTable("HEAD_COACHES");

                    b.HasDiscriminator().HasValue("HeadCoach");
                });

            modelBuilder.Entity("Backend.Models.StaffModels.HeadCoachAssistent", b =>
                {
                    b.HasBaseType("Backend.Models.StaffModels.Employee");


                    b.ToTable("HEAD_COACH_ASSISTENTS");

                    b.HasDiscriminator().HasValue("HeadCoachAssistent");
                });

            modelBuilder.Entity("Backend.Models.StaffModels.Medic", b =>
                {
                    b.HasBaseType("Backend.Models.StaffModels.Employee");


                    b.ToTable("MEDICS");

                    b.HasDiscriminator().HasValue("Medic");
                });

            modelBuilder.Entity("Backend.Models.StaffModels.Psychologist", b =>
                {
                    b.HasBaseType("Backend.Models.StaffModels.Employee");


                    b.ToTable("PSYCHOLOGISTS");

                    b.HasDiscriminator().HasValue("Psychologist");
                });

            modelBuilder.Entity("Backend.Models.BuildingModels.Building", b =>
                {
                    b.HasOne("Backend.Models.Club", "Club")
                        .WithMany("Buildings")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.Club", b =>
                {
                    b.HasOne("Backend.Models.UserModels.User", "User")
                        .WithOne("Club")
                        .HasForeignKey("Backend.Models.Club", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.PlayerModels.Player", b =>
                {
                    b.HasOne("Backend.Models.Club", "Club")
                        .WithMany("Players")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.PlayerModels.PlayerStats", b =>
                {
                    b.HasOne("Backend.Models.PlayerModels.Player", "Player")
                        .WithOne("Stats")
                        .HasForeignKey("Backend.Models.PlayerModels.PlayerStats", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.PlayerModels.PlayerTemporaryStats", b =>
                {
                    b.HasOne("Backend.Models.PlayerModels.Player", "Player")
                        .WithOne("TemporaryStats")
                        .HasForeignKey("Backend.Models.PlayerModels.PlayerTemporaryStats", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.SquadModels.FormationData", b =>
                {
                    b.HasOne("Backend.Models.SquadModels.Squad", "Squad")
                        .WithOne("FormationData")
                        .HasForeignKey("Backend.Models.SquadModels.FormationData", "SquadId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.SquadModels.FormationPosition", b =>
                {
                    b.HasOne("Backend.Models.SquadModels.FormationData", "FormationData")
                        .WithMany("FormationPositions")
                        .HasForeignKey("FormationDataId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.SquadModels.Squad", b =>
                {
                    b.HasOne("Backend.Models.Club", "Club")
                        .WithMany("Squads")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Backend.Models.StaffModels.Employee", b =>
                {
                    b.HasOne("Backend.Models.Club")
                        .WithMany("Staff")
                        .HasForeignKey("ClubId");
                });
#pragma warning restore 612, 618
        }
    }
}
