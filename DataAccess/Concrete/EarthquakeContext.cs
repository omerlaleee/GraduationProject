using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EarthquakeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string omerConnectionString = @"Data Source=DESKTOP-L9ESE9R\OMER;Initial Catalog=GraduationProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Trusted_Connection=true";
            string mesutConnectionString = @"Data Source=DESKTOP-8DD9NIJ;Initial Catalog=GraduationProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(omerConnectionString);
        }

        public DbSet<Victim> Victims { get; set; }
        public DbSet<ColdVictim> ColdVictims { get; set; }
        public DbSet<FoodVictim> FoodVictims { get; set; }
        public DbSet<FoodHelper> FoodHelpers { get; set; }
        public DbSet<DebrisVictim> DebrisVictims { get; set; }
        // public DbSet<Helper> Helpers { get; set; }
        public DbSet<HouseHelper> HouseHelpers { get; set; }
        public DbSet<OperatorHelper> OperatorHelpers { get; set; }
        public DbSet<TentHelper> TentHelpers { get; set; }
        public DbSet<TransporterHelper> TransporterHelpers { get; set; }
        public DbSet<BuildReporter> BuildReporters { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}