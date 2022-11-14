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
    }
}

