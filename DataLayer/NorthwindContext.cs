using System;
using Microsoft.EntityFrameworkCore;
using DataLayer.Model;

namespace DataLayer
{
    public class NorthwindContext : DbContext
    {
        const string connectionString = "host=localhost;db=imdb;uid=postgres;pwd=paranormalA1";

        public DbSet<ShowInfo> ShowInfos { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ActorRating> ActorRatings { get; set; }
        public DbSet<Character> Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ShowInfo>().ToTable("show_info");
            modelBuilder.Entity<ShowInfo>().Property(x => x.TConst).HasColumnName("tconst");
            modelBuilder.Entity<ShowInfo>().Property(x => x.Type).HasColumnName("titletype");
            modelBuilder.Entity<ShowInfo>().Property(x => x.PrimaryTitle).HasColumnName("primarytitle");
            modelBuilder.Entity<ShowInfo>().Property(x => x.OriginalTitle).HasColumnName("originaltitle");
            modelBuilder.Entity<ShowInfo>().Property(x => x.IsAduldt).HasColumnName("isadult");
            modelBuilder.Entity<ShowInfo>().Property(x => x.StartYear).HasColumnName("startyear");
            modelBuilder.Entity<ShowInfo>().Property(x => x.EndYear).HasColumnName("endyear");
            modelBuilder.Entity<ShowInfo>().Property(x => x.RunTime).HasColumnName("runtimeminutes");

            modelBuilder.Entity<Genre>().ToTable("genres");
            modelBuilder.Entity<Genre>().Property(x => x.TConst).HasColumnName("tconst");
            modelBuilder.Entity<Genre>().Property(x => x.MovieGenre).HasColumnName("genre");

            modelBuilder.Entity<ActorRating>().ToTable("actor_rating");
            modelBuilder.Entity<ActorRating>().Property(x => x.NConst).HasColumnName("nconst");
            modelBuilder.Entity<ActorRating>().Property(x => x.Rating).HasColumnName("rating");

            modelBuilder.Entity<Character>().ToTable("characters").HasNoKey();
            modelBuilder.Entity<Character>().Property(x => x.TConst).HasColumnName("tconst");
            modelBuilder.Entity<Character>().Property(x => x.NConst).HasColumnName("nconst");
            modelBuilder.Entity<Character>().Property(x => x.CharacterPlayed).HasColumnName("character");
        }
    }
}