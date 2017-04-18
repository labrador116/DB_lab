using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace DataBaseConnection
{
    public class AccomondationDBContext : DbContext
    {
        public AccomondationDBContext(): base("accomondationDB")
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Project> Projects  { get; set; }
        public DbSet<SchemeOfBuilding> Schemes { get; set; }
        public DbSet<InstallationPosition> Positions { get; set; }
        public DbSet<PlacmentOfModules> Placements { get; set; }
        public DbSet<ModelsOfModules> Models { get; set; }
    }
}
