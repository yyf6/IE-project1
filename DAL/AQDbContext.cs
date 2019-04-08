using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityModel;

namespace DAL
{
    public class AQDbContext : DbContext
    {
        public AQDbContext() : base("AQDbConnection")
        {

        }

        public DbSet<Emission> Emissions { get; set; }
    }
}
