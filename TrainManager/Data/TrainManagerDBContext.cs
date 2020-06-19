using System;
using System.Linq;
using TrainManager.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TrainManager.Data
{
    public class TrainManagerDBContext : IdentityDbContext<User>
    {
        public TrainManagerDBContext(DbContextOptions<TrainManagerDBContext> options)
            : base(options)
        {
        }

        public DbSet<Line> Lines { get; set; }

        public DbSet<Train> Trains { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Line>()
                .HasOne(f => f.Train);
        }
    }
}
