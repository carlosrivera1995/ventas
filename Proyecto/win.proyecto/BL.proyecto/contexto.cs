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
            Database.SetInitializer(new DatosdeInicio());
         
            
        }
        public DbSet<producto> Productos { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
  
    }
}
