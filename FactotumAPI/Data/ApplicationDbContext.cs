using System;
using System.Collections.Generic;
using System.Text;
using FactotumModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace FactotumAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<EDashBoardFact> Dashboard { get; set; }
        public DbSet<ETempDashBoardFact> TempDashboard { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder {
                DataSource = "FactotumDb.db"
            };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<EDashBoardFact>().HasData(
        //        new EDashBoardFact
        //        {
        //            Id = 1,
        //            FactId = Guid.NewGuid(),
        //            FactRating = 1,
        //            FactLastRateDate = DateTime.Now,
        //            FactTitle = "Fact number one",
        //            FactLink = "lipsum.com",
        //            FactHashTags = "#fno",
        //            FactCreateDate = DateTime.Now
        //        }
        //    );
        //}
    }
}
