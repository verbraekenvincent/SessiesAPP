using SessiesAPP.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SessiesAPP.DAL
{
    public class SessionContext
    {
        public class SchoolContext : DbContext
        {

            public SchoolContext() : base("SchoolContext")
            {
            }

            public DbSet<Session> Sessions { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
    }
}