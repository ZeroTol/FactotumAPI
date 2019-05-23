using System;
using FactotumModels;
using Microsoft.EntityFrameworkCore;

namespace FactotumAPI.Repository
{
    public class FMDataContext : DbContext
    {
        public DbSet<EMessage> Messages { get; set; }
        public DbSet<EUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:factotumdb.database.windows.net,1433;Initial Catalog=FactototumDB;Persist Security Info=False;User ID=factotum;Password=facapp123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}