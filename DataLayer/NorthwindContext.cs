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
        public DbSet<Director> Directors { get; set; }
        public DbSet<EpisodeInfo> EpisodeInfos { get; set; }
        public DbSet<KnownFor> KnownFors { get; set; }
        public DbSet<OMDBData> OMDBDatas { get; set; }
        public DbSet<Person> People { get; set; }

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

            modelBuilder.Entity<Director>().ToTable("directors");
            modelBuilder.Entity<Director>().Property(x => x.TConst).HasColumnName("tconst");
            modelBuilder.Entity<Director>().Property(x => x.NConst).HasColumnName("nconst");

            modelBuilder.Entity<EpisodeInfo>().ToTable("episode_info");
            modelBuilder.Entity<EpisodeInfo>().Property(x => x.TConst).HasColumnName("tconst");
            modelBuilder.Entity<EpisodeInfo>().Property(x => x.ParentTConst).HasColumnName("parentconst");
            modelBuilder.Entity<EpisodeInfo>().Property(x => x.SeasonNumber).HasColumnName("seasonnumber");
            modelBuilder.Entity<EpisodeInfo>().Property(x => x.EpisodeNumber).HasColumnName("episodenumber");

            modelBuilder.Entity<KnownFor>().ToTable("known_for");
            modelBuilder.Entity<KnownFor>().Property(x => x.NConst).HasColumnName("nconst");
            modelBuilder.Entity<KnownFor>().Property(x => x.Titles).HasColumnName("knowfortitles");

            modelBuilder.Entity<OMDBData>().ToTable("omdb_data");
            modelBuilder.Entity<OMDBData>().Property(x => x.TConst).HasColumnName("tconst");
            modelBuilder.Entity<OMDBData>().Property(x => x.Poster).HasColumnName("poster");
            modelBuilder.Entity<OMDBData>().Property(x => x.Plot).HasColumnName("plot");

            modelBuilder.Entity<Person>().ToTable("person");
            modelBuilder.Entity<Person>().Property(x => x.NConst).HasColumnName("nconst");
            modelBuilder.Entity<Person>().Property(x => x.Name).HasColumnName("primaryname");
            modelBuilder.Entity<Person>().Property(x => x.BirthYear).HasColumnName("birthyear");
            modelBuilder.Entity<Person>().Property(x => x.DeathYear).HasColumnName("deathyear");
        }
    }
}