using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EarthquakeContext:DbContext
    {
        protected static void OnConfigure(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server = DESKTOP - 8DD9NIJ; Database = Northwind; Trusted_Connection = true");

           
    } public DbSet<ColdVictim> ColdVictims { get; set; }
    }
}
