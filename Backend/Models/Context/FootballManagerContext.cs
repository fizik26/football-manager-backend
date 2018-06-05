﻿using Backend.Models.BuildingModels;
using Backend.Models.PlayerModels;
using Backend.Models.SquadModels;
using Backend.Models.StaffModels;
using Backend.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models.Context
{
    public class FootballManagerContext : DbContext
    {
        public enum Mode
        {
            Home, Work
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Club> Clubs { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<PlayerStats> PlayerStats { get; set; }

        public DbSet<PlayerTemporaryStats> PlayerTemporaryStats { get; set; }

        public DbSet<Squad> Squads { get; set; }

        public DbSet<FormationData> FormationData { get; set; }

        public DbSet<FormationPosition> FormationPositions { get; set; }

        #region Buildings

        public DbSet<Building> Buildings { get; set; }

        public DbSet<Stadium> Stadiums { get; set; }

        public DbSet<FanClub> FanClubs { get; set; }

        public DbSet<Academy> Academies { get; set; }

        public DbSet<MedicalCenter> MedicalCenters { get; set; }

        public DbSet<TrainingCenter> TrainingCenters { get; set; }

        #endregion

        #region Staff

        public DbSet<HeadCoach> HeadCoaches { get; set; }

        public DbSet<HeadCoachAssistent> HeadCoachAssistents { get; set; }

        public DbSet<Medic> Medics { get; set; }

        public DbSet<Psychologist> Psychologists { get; set; }

        public DbSet<Employee> Employees { get; set; }

        #endregion

        public FootballManagerContext(DbContextOptions<FootballManagerContext> options) : base(options)
        {
            
        }

    }
}
