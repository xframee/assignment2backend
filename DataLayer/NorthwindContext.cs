using System;
using Microsoft.EntityFrameworkCore;
using DataLayer.Model;

namespace DataLayer
{
    public class NorthwindContext : DbContext
    {
        // const string connectionString = "host=localhost;db=imdb;uid=postgres;pwd=paranormalA1";

        const string connectionString = "host=localhost; db=imdb; uid=postgres; pwd=chili321";

        public DbSet<ShowInfo> ShowInfos { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ActorRating> ActorRatings { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<EpisodeInfo> EpisodeInfos { get; set; }
        public DbSet<KnownFor> KnownFors { get; set; }
        public DbSet<OMDBData> OMDBDatas { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<RecentlyVisited> RecentlyVisiteds { get; set; }
        public DbSet<SearchHistory> SearchHistories { get; set; }
        public DbSet<ShowPrincipal> ShowPrincipals { get; set; }
        public DbSet<ShowRating> ShowRatings { get; set; }
        public DbSet<UserBookmark> UserBookmarks { get; set; }
        public DbSet<UserRating> UserRatings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wi> Wis { get; set; }
        public DbSet<Writer> Writers { get; set; }

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
            modelBuilder.Entity<ShowInfo>().Property(x => x.IsAdult).HasColumnName("isadult");
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

            modelBuilder.Entity<Profession>().ToTable("profession");
            modelBuilder.Entity<Profession>().Property(x => x.NConst).HasColumnName("nconst");
            modelBuilder.Entity<Profession>().Property(x => x.PersonProfession).HasColumnName("profession");

            modelBuilder.Entity<RecentlyVisited>().ToTable("recently_visited");
            modelBuilder.Entity<RecentlyVisited>().Property(x => x.Username).HasColumnName("username");
            modelBuilder.Entity<RecentlyVisited>().Property(x => x.TConst).HasColumnName("tconst");

            modelBuilder.Entity<SearchHistory>().ToTable("search_history");
            modelBuilder.Entity<SearchHistory>().Property(x => x.Username).HasColumnName("username");
            modelBuilder.Entity<SearchHistory>().Property(x => x.SearchedTerm).HasColumnName("searchedterm");

            modelBuilder.Entity<ShowPrincipal>().ToTable("show_principals");
            modelBuilder.Entity<ShowPrincipal>().Property(x => x.TConst).HasColumnName("tconst");
            modelBuilder.Entity<ShowPrincipal>().Property(x => x.NConst).HasColumnName("nconst");
            modelBuilder.Entity<ShowPrincipal>().Property(x => x.Ordering).HasColumnName("ordering");
            modelBuilder.Entity<ShowPrincipal>().Property(x => x.Category).HasColumnName("category");
            modelBuilder.Entity<ShowPrincipal>().Property(x => x.Job).HasColumnName("job");

            modelBuilder.Entity<ShowRating>().ToTable("show_ratings");
            modelBuilder.Entity<ShowRating>().Property(x => x.TConst).HasColumnName("tconst");
            modelBuilder.Entity<ShowRating>().Property(x => x.AverageRating).HasColumnName("averagerating");
            modelBuilder.Entity<ShowRating>().Property(x => x.NumVotes).HasColumnName("numvotes");


            modelBuilder.Entity<UserBookmark>().ToTable("user_bookmarks");
            modelBuilder.Entity<UserBookmark>().Property(x => x.Username).HasColumnName("username");
            modelBuilder.Entity<UserBookmark>().Property(x => x.TConst).HasColumnName("tconst");

            modelBuilder.Entity<UserRating>().ToTable("user_ratings");
            modelBuilder.Entity<UserRating>().Property(x => x.Username).HasColumnName("username");
            modelBuilder.Entity<UserRating>().Property(x => x.TConst).HasColumnName("tconst");
            modelBuilder.Entity<UserRating>().Property(x => x.Rating).HasColumnName("rating");

            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<User>().Property(x => x.Username).HasColumnName("username");
            modelBuilder.Entity<User>().Property(x => x.Password).HasColumnName("password");

            modelBuilder.Entity<Wi>().ToTable("wi");
            modelBuilder.Entity<Wi>().Property(x => x.TConst).HasColumnName("tconst");
            modelBuilder.Entity<Wi>().Property(x => x.Word).HasColumnName("word");
            modelBuilder.Entity<Wi>().Property(x => x.Field).HasColumnName("field");
            modelBuilder.Entity<Wi>().Property(x => x.Lexeme).HasColumnName("lexeme");

            modelBuilder.Entity<Writer>().ToTable("writers");
            modelBuilder.Entity<Writer>().Property(x => x.TConst).HasColumnName("tconst");
            modelBuilder.Entity<Writer>().Property(x => x.NConst).HasColumnName("nconst");


        }

    }
}