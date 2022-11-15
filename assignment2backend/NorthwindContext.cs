using System;
using Microsoft.EntityFrameworkCore;

namespace EF
{
    public class NorthwindContext : DbContext
    {
        const string connectionString = "host=localhost;db=imdb;uid=postgres;pwd=paranormalA1";

        public DbSet<ShowInfo> ShowInfos { get; set; }

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
        }
    }
}