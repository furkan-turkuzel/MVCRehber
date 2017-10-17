using Entities.Entities;
using Entities.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.DBContext
{
    public class RehberDBContext:DbContext
    {
        public RehberDBContext():base("Server=.;Database=RehberimDB;Integrated Security=true")
        {
            Database.SetInitializer<RehberDBContext>(new CreateDatabaseIfNotExists<RehberDBContext>());
        }

        public DbSet<Kisiler> kisiler { get; set; }

        public DbSet<Adresler> adresler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdreslerMapping());
            modelBuilder.Configurations.Add(new KisilerMapping());
        }
    }
}
