﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer.EntityFramework.Context;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(FootballManagerContext))]
    partial class FootballManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainModels.Models.BuildingEntities.Building", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ClubId")
                        .HasColumnName("CLUB_ID");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("Level")
                        .HasColumnName("LEVEL");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("BUILDINGS");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Building");
                });

            modelBuilder.Entity("DomainModels.Models.ClubEntities.Club", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Country")
                        .HasColumnName("COUNTRY");

                    b.Property<DateTime>("FoundationDate")
                        .HasColumnName("FOUNDATION_DATE");

                    b.Property<int>("Level")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LEVEL")
                        .HasDefaultValue(1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME")
                        .HasMaxLength(64);

                    b.Property<long>("UserId")
                        .HasColumnName("USER_ID");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("CLUBS");
                });

            modelBuilder.Entity("DomainModels.Models.ClubEntities.ClubHistory", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("ID");

                    b.HasKey("Id");

                    b.ToTable("CLUBS_HISTORY");
                });

            modelBuilder.Entity("DomainModels.Models.ClubEntities.HollOfFame", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("ID");

                    b.HasKey("Id");

                    b.ToTable("HOLLS_OF_FAME");
                });

            modelBuilder.Entity("DomainModels.Models.ClubEntities.SeasonResult", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ClubHistoryId")
                        .HasColumnName("CLUB_HISTORY_ID");

                    b.Property<int>("LeaguePlace")
                        .HasColumnName("LEAGUE_PLACE");

                    b.Property<int>("SuperleagueStage")
                        .HasColumnName("SUPERLEAGUE_STAGE");

                    b.HasKey("Id");

                    b.HasIndex("ClubHistoryId");

                    b.ToTable("SEASON_RESULTS");
                });

            modelBuilder.Entity("DomainModels.Models.EmployeeEntities.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ClubId")
                        .HasColumnName("CLUB_ID");

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

            modelBuilder.Entity("DomainModels.Models.PlayerEntities.Legend", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("HollOfFameId")
                        .HasColumnName("HOLL_OF_FAME_ID");

                    b.Property<int>("LegendType")
                        .HasColumnName("LEGEND_TYPE");

                    b.Property<int>("Matches")
                        .HasColumnName("MATCHES");

                    b.Property<long>("PlayerId")
                        .HasColumnName("PLAYER_ID");

                    b.Property<int>("Result")
                        .HasColumnName("RESULT");

                    b.HasKey("Id");

                    b.HasIndex("HollOfFameId");

                    b.ToTable("LEGENDS");
                });

            modelBuilder.Entity("DomainModels.Models.PlayerEntities.Player", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnName("AGE");

                    b.Property<int>("BodyType")
                        .HasColumnName("BODY_TYPE");

                    b.Property<long>("ClubId")
                        .HasColumnName("CLUB_ID");

                    b.Property<int>("Country")
                        .HasColumnName("COUNTRY");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("FIRST_NAME")
                        .HasMaxLength(64);

                    b.Property<int>("Height")
                        .HasColumnName("HEIGHT");

                    b.Property<int>("HeightType")
                        .HasColumnName("HEIGHT_TYPE");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("LAST_NAME")
                        .HasMaxLength(64);

                    b.Property<int>("Position")
                        .HasColumnName("POSITION");

                    b.Property<int>("Talent")
                        .HasColumnName("TALENT");

                    b.Property<int>("Weight")
                        .HasColumnName("WEIGHT");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("PLAYERS");
                });

            modelBuilder.Entity("DomainModels.Models.PlayerEntities.PlayerScores", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("ID");

                    b.Property<int>("CurrentLeagueAssists")
                        .HasColumnName("CURRENT_LEAGUE_ASSISTS");

                    b.Property<int>("CurrentLeagueMatches")
                        .HasColumnName("CURRENT_LEAGUE_MATCHES");

                    b.Property<float>("CurrentLeagueRating")
                        .HasColumnName("CURRENT_LEAGUE_RATING");

                    b.Property<int>("CurrentLeagueScores")
                        .HasColumnName("CURRENT_LEAGUE_SCORES");

                    b.Property<int>("CurrentSuperleagueAssists")
                        .HasColumnName("CURRENT_SUPERLEAGUE_ASSISTS");

                    b.Property<int>("CurrentSuperleagueMatches")
                        .HasColumnName("CURRENT_SUPERLEAGUE_MATCHES");

                    b.Property<float>("CurrentSuperleagueRating")
                        .HasColumnName("CURRENT_SUPERLEAGUE_RATING");

                    b.Property<int>("CurrentSuperleagueScores")
                        .HasColumnName("CURRENT_SUPERLEAGUE_SCORES");

                    b.Property<int>("TotalLeagueAssists")
                        .HasColumnName("TOTAL_LEAGUE_ASSISTS");

                    b.Property<int>("TotalLeagueMatches")
                        .HasColumnName("TOTAL_LEAGUE_MATCHES");

                    b.Property<float>("TotalLeagueRating")
                        .HasColumnName("TOTAL_LEAGUE_RATING");

                    b.Property<int>("TotalLeagueScores")
                        .HasColumnName("TOTAL_LEAGUE_SCORES");

                    b.Property<int>("TotalSuperleagueAssists")
                        .HasColumnName("TOTAL_SUPERLEAGUE_ASSISTS");

                    b.Property<int>("TotalSuperleagueMatches")
                        .HasColumnName("TOTAL_SUPERLEAGUE_MATCHES");

                    b.Property<float>("TotalSuperleagueRating")
                        .HasColumnName("TOTAL_SUPERLEAGUE_RATING");

                    b.Property<int>("TotalSuperleagueScores")
                        .HasColumnName("TOTAL_SUPERLEAGUE_SCORES");

                    b.HasKey("Id");

                    b.ToTable("PLAYER_SCORES");
                });

            modelBuilder.Entity("DomainModels.Models.PlayerEntities.PlayerStats", b =>
                {
                    b.Property<long>("Id")
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
                        .HasColumnName("FREE_KICKS");

                    b.Property<float>("HandPlay")
                        .HasColumnName("HAND_PLAY");

                    b.Property<float>("Heading")
                        .HasColumnName("HEADING");

                    b.Property<float>("Interceptions")
                        .HasColumnName("INTERCEPTIONS");

                    b.Property<float>("Jumping")
                        .HasColumnName("JUMPING");

                    b.Property<float>("Kicking")
                        .HasColumnName("KICKING");

                    b.Property<float>("LongPassing")
                        .HasColumnName("LONG_PASSING");

                    b.Property<float>("LongShots")
                        .HasColumnName("LONG_SHOTS");

                    b.Property<float>("Penalties")
                        .HasColumnName("PENALTIES");

                    b.Property<float>("Positioning")
                        .HasColumnName("POSITIONING");

                    b.Property<float>("Reflexes")
                        .HasColumnName("REFLEXES");

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

                    b.Property<float>("Tricks")
                        .HasColumnName("TRICKS");

                    b.HasKey("Id");

                    b.ToTable("PLAYER_STATS");
                });

            modelBuilder.Entity("DomainModels.Models.PlayerEntities.PlayerTemporaryStats", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("ID");

                    b.Property<int>("Injury")
                        .HasColumnName("INJURY");

                    b.Property<DateTime>("InjuryDateTime")
                        .HasColumnName("INJURY_DATE_TIME");

                    b.Property<int>("Morale")
                        .HasColumnName("MORALE");

                    b.Property<DateTime>("MoraleDateTime")
                        .HasColumnName("MORALE_DATE_TIME");

                    b.Property<int>("Stamina")
                        .HasColumnName("STAMINA");

                    b.Property<DateTime>("StaminaDateTime")
                        .HasColumnName("STAMINA_DATE_TIME");

                    b.HasKey("Id");

                    b.ToTable("PLAYER_TEMPORARY_STATS");
                });

            modelBuilder.Entity("DomainModels.Models.SquadEntities.FormationPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FormationPositionType")
                        .HasColumnName("FORMATION_POSITION_TYPE");

                    b.Property<long?>("PlayerId")
                        .HasColumnName("PLAYER_ID");

                    b.Property<int>("PlayerPosition")
                        .HasColumnName("PLAYER_POSITION");

                    b.Property<long>("SquadId")
                        .HasColumnName("SQUAD_ID");

                    b.HasKey("Id");

                    b.HasIndex("SquadId");

                    b.ToTable("FORMATION_POSITIONS");
                });

            modelBuilder.Entity("DomainModels.Models.SquadEntities.Squad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ClubId")
                        .HasColumnName("CLUB_ID");

                    b.Property<int>("Formation")
                        .HasColumnName("FORMATION");

                    b.Property<bool>("IsActive")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("SQUADS");
                });

            modelBuilder.Entity("DomainModels.Models.TournamentEntities.Match", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Group")
                        .HasColumnName("GROUP");

                    b.Property<long>("HomeId")
                        .HasColumnName("HOME_ID");

                    b.Property<int>("Number")
                        .HasColumnName("NUMBER");

                    b.Property<int>("Stage")
                        .HasColumnName("STAGE");

                    b.Property<DateTime>("StartTime")
                        .HasColumnName("START_TIME");

                    b.Property<int>("SubStage")
                        .HasColumnName("SUB_STAGE");

                    b.Property<long>("TournamentId")
                        .HasColumnName("TOURNAMENT_ID");

                    b.Property<int>("TournamentType")
                        .HasColumnName("TOURNAMENT_TYPE");

                    b.Property<long>("VisitorsId")
                        .HasColumnName("VISITORS_ID");

                    b.HasKey("Id");

                    b.HasIndex("TournamentId");

                    b.ToTable("MATCHES");
                });

            modelBuilder.Entity("DomainModels.Models.TournamentEntities.MatchEvent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MatchEventType")
                        .HasColumnName("FORMATION");

                    b.Property<long>("MatchId")
                        .HasColumnName("MATCH_ID");

                    b.Property<long>("PlayerId")
                        .HasColumnName("PLAYER_ID");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.ToTable("MATCH_EVENTS");
                });

            modelBuilder.Entity("DomainModels.Models.TournamentEntities.Tournament", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentStage")
                        .HasColumnName("CURRENT_STAGE");

                    b.Property<bool>("IsFinished")
                        .HasColumnName("IS_FINISHED");

                    b.Property<int>("Level")
                        .HasColumnName("LEVEL");

                    b.Property<int>("TournamentType")
                        .HasColumnName("TOURNAMENT_TYPE");

                    b.HasKey("Id");

                    b.ToTable("TOURNAMENTS");
                });

            modelBuilder.Entity("DomainModels.Models.TournamentEntities.TournamentClub", b =>
                {
                    b.Property<long>("TournamentId")
                        .HasColumnName("TOURNAMENT_ID");

                    b.Property<long>("ClubId")
                        .HasColumnName("CLUB_ID");

                    b.HasKey("TournamentId", "ClubId");

                    b.HasIndex("ClubId");

                    b.ToTable("TOURNAMENT_CLUBS");
                });

            modelBuilder.Entity("DomainModels.Models.TournamentEntities.TournamentPlayer", b =>
                {
                    b.Property<long>("TournamentId")
                        .HasColumnName("TOURNAMENT_ID");

                    b.Property<long>("PlayerId")
                        .HasColumnName("PLAYER_ID");

                    b.HasKey("TournamentId", "PlayerId");

                    b.ToTable("TOURNAMENT_PLAYERS");
                });

            modelBuilder.Entity("DomainModels.Models.UserEntities.User", b =>
                {
                    b.Property<long>("Id")
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

            modelBuilder.Entity("DomainModels.Models.BuildingEntities.Academy", b =>
                {
                    b.HasBaseType("DomainModels.Models.BuildingEntities.Building");


                    b.ToTable("Academy");

                    b.HasDiscriminator().HasValue("Academy");
                });

            modelBuilder.Entity("DomainModels.Models.BuildingEntities.FanClub", b =>
                {
                    b.HasBaseType("DomainModels.Models.BuildingEntities.Building");

                    b.Property<int>("FansCount")
                        .HasColumnName("FANS_COUNT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME")
                        .HasMaxLength(64);

                    b.ToTable("FanClub");

                    b.HasDiscriminator().HasValue("FanClub");
                });

            modelBuilder.Entity("DomainModels.Models.BuildingEntities.MedicalCenter", b =>
                {
                    b.HasBaseType("DomainModels.Models.BuildingEntities.Building");


                    b.ToTable("MedicalCenter");

                    b.HasDiscriminator().HasValue("MedicalCenter");
                });

            modelBuilder.Entity("DomainModels.Models.BuildingEntities.Stadium", b =>
                {
                    b.HasBaseType("DomainModels.Models.BuildingEntities.Building");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME")
                        .HasMaxLength(64);

                    b.ToTable("Stadium");

                    b.HasDiscriminator().HasValue("Stadium");
                });

            modelBuilder.Entity("DomainModels.Models.BuildingEntities.TrainingCenter", b =>
                {
                    b.HasBaseType("DomainModels.Models.BuildingEntities.Building");


                    b.ToTable("TrainingCenter");

                    b.HasDiscriminator().HasValue("TrainingCenter");
                });

            modelBuilder.Entity("DomainModels.Models.EmployeeEntities.HeadCoach", b =>
                {
                    b.HasBaseType("DomainModels.Models.EmployeeEntities.Employee");


                    b.ToTable("HeadCoach");

                    b.HasDiscriminator().HasValue("HeadCoach");
                });

            modelBuilder.Entity("DomainModels.Models.EmployeeEntities.HeadCoachAssistent", b =>
                {
                    b.HasBaseType("DomainModels.Models.EmployeeEntities.Employee");


                    b.ToTable("HeadCoachAssistent");

                    b.HasDiscriminator().HasValue("HeadCoachAssistent");
                });

            modelBuilder.Entity("DomainModels.Models.EmployeeEntities.Medic", b =>
                {
                    b.HasBaseType("DomainModels.Models.EmployeeEntities.Employee");


                    b.ToTable("Medic");

                    b.HasDiscriminator().HasValue("Medic");
                });

            modelBuilder.Entity("DomainModels.Models.EmployeeEntities.Psychologist", b =>
                {
                    b.HasBaseType("DomainModels.Models.EmployeeEntities.Employee");


                    b.ToTable("Psychologist");

                    b.HasDiscriminator().HasValue("Psychologist");
                });

            modelBuilder.Entity("DomainModels.Models.EmployeeEntities.Scout", b =>
                {
                    b.HasBaseType("DomainModels.Models.EmployeeEntities.Employee");


                    b.ToTable("Scout");

                    b.HasDiscriminator().HasValue("Scout");
                });

            modelBuilder.Entity("DomainModels.Models.BuildingEntities.Building", b =>
                {
                    b.HasOne("DomainModels.Models.ClubEntities.Club", "Club")
                        .WithMany("Buildings")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.ClubEntities.Club", b =>
                {
                    b.HasOne("DomainModels.Models.UserEntities.User", "User")
                        .WithOne("Club")
                        .HasForeignKey("DomainModels.Models.ClubEntities.Club", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.ClubEntities.ClubHistory", b =>
                {
                    b.HasOne("DomainModels.Models.ClubEntities.Club", "Club")
                        .WithOne("History")
                        .HasForeignKey("DomainModels.Models.ClubEntities.ClubHistory", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.ClubEntities.HollOfFame", b =>
                {
                    b.HasOne("DomainModels.Models.ClubEntities.Club", "Club")
                        .WithOne("HollOfFame")
                        .HasForeignKey("DomainModels.Models.ClubEntities.HollOfFame", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.ClubEntities.SeasonResult", b =>
                {
                    b.HasOne("DomainModels.Models.ClubEntities.ClubHistory", "ClubHistory")
                        .WithMany("SeasonResults")
                        .HasForeignKey("ClubHistoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.EmployeeEntities.Employee", b =>
                {
                    b.HasOne("DomainModels.Models.ClubEntities.Club", "Club")
                        .WithMany("Employees")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.PlayerEntities.Legend", b =>
                {
                    b.HasOne("DomainModels.Models.ClubEntities.HollOfFame", "HollOfFame")
                        .WithMany("Legends")
                        .HasForeignKey("HollOfFameId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.PlayerEntities.Player", b =>
                {
                    b.HasOne("DomainModels.Models.ClubEntities.Club", "Club")
                        .WithMany("Players")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.PlayerEntities.PlayerScores", b =>
                {
                    b.HasOne("DomainModels.Models.PlayerEntities.Player", "Player")
                        .WithOne("Scores")
                        .HasForeignKey("DomainModels.Models.PlayerEntities.PlayerScores", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.PlayerEntities.PlayerStats", b =>
                {
                    b.HasOne("DomainModels.Models.PlayerEntities.Player", "Player")
                        .WithOne("Stats")
                        .HasForeignKey("DomainModels.Models.PlayerEntities.PlayerStats", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.PlayerEntities.PlayerTemporaryStats", b =>
                {
                    b.HasOne("DomainModels.Models.PlayerEntities.Player", "Player")
                        .WithOne("TemporaryStats")
                        .HasForeignKey("DomainModels.Models.PlayerEntities.PlayerTemporaryStats", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.SquadEntities.FormationPosition", b =>
                {
                    b.HasOne("DomainModels.Models.SquadEntities.Squad", "Squad")
                        .WithMany("FormationPositions")
                        .HasForeignKey("SquadId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.SquadEntities.Squad", b =>
                {
                    b.HasOne("DomainModels.Models.ClubEntities.Club", "Club")
                        .WithMany("Squads")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.TournamentEntities.Match", b =>
                {
                    b.HasOne("DomainModels.Models.TournamentEntities.Tournament", "Tournament")
                        .WithMany("Matches")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.TournamentEntities.MatchEvent", b =>
                {
                    b.HasOne("DomainModels.Models.TournamentEntities.Match", "Match")
                        .WithMany("MatchEvents")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.TournamentEntities.TournamentClub", b =>
                {
                    b.HasOne("DomainModels.Models.ClubEntities.Club", "Club")
                        .WithMany("TournamentClubs")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomainModels.Models.TournamentEntities.Tournament", "Tournament")
                        .WithMany("TournamentClubs")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Models.TournamentEntities.TournamentPlayer", b =>
                {
                    b.HasOne("DomainModels.Models.TournamentEntities.Tournament", "Tournament")
                        .WithMany("TournamentPlayers")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
