using FactotumModels;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactotumModels.Context
{
    public class FtDbContext : DbContext
    {
        public DbSet<EDashBoardFact> Dashboard { get; set; }

        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "Factotum.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);


            optionsBuilder.UseSqlite(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EDashBoardFact>().HasData(
                new EDashBoardFact
                {
                    Id = 1,
                    FactId = Guid.NewGuid(),
                    FactRating = 1,
                    FactLastRateDate = DateTime.Now,
                    FactTitle = "Fact number one",
                    FactLink = "lipsum.com",
                    FactHashTags = "#fno",
                    FactCreateDate = DateTime.Now
                }
            );
            //modelBuilder.Entity<EDashBoardFact>()
            //    .HasKey(c => new
            //    {
            //        c.FactId,
            //        c.FactRating,
            //        c.FactCreateDate,
            //        c.FactLastRateDate
            //    });
        }


    }
}
