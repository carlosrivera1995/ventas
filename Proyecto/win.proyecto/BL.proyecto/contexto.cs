using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BL.proyecto
{
    public class Contexto: DbContext
    {
        public Contexto(): base("Ferreteria")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
        }
        public DbSet<producto> Productos { get; set; }
    }
}
