using System;
using Microsoft.EntityFrameworkCore;

namespace EF
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseNpgsql("host=localhost;db=imdb;uid=postgres;pwd=paranormalA1");
        }
    }
}

