﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HorseShowAPI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QrecApiEntities : DbContext
    {
        public QrecApiEntities()
            : base("name=QrecApiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Championship> Championships { get; set; }
        public DbSet<ChampionshipClass> ChampionshipClasses { get; set; }
        public DbSet<ChampionshipMethod> ChampionshipMethods { get; set; }
        public DbSet<ChampionshipRating> ChampionshipRatings { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<EcahoClass> EcahoClasses { get; set; }
        public DbSet<Horse> Horses { get; set; }
        public DbSet<HorseRegistration> HorseRegistrations { get; set; }
        public DbSet<Judge> Judges { get; set; }
        public DbSet<MainClass> MainClasses { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<RegistrationForApproval> RegistrationForApprovals { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleMenuAuthorization> RoleMenuAuthorizations { get; set; }
        public DbSet<ScoreSystem> ScoreSystems { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<ShowChampionship> ShowChampionships { get; set; }
        public DbSet<ShowChampionshipJudge> ShowChampionshipJudges { get; set; }
        public DbSet<ShowClass> ShowClasses { get; set; }
        public DbSet<ShowClassHors> ShowClassHorses { get; set; }
        public DbSet<ShowClassJudge> ShowClassJudges { get; set; }
        public DbSet<ShowForm> ShowForms { get; set; }
        public DbSet<ShowHors> ShowHorses { get; set; }
        public DbSet<ShowIpadUdid> ShowIpadUdids { get; set; }
        public DbSet<ShowJudgeCode> ShowJudgeCodes { get; set; }
        public DbSet<ShowJudge> ShowJudges { get; set; }
        public DbSet<ShowType> ShowTypes { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WinnerType> WinnerTypes { get; set; }
        public DbSet<ChampionshipWinnertype> ChampionshipWinnertypes { get; set; }
    }
}
