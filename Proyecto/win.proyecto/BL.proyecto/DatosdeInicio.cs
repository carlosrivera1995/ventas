using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.proyecto
{
   public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.contrasena = "123";

            contexto.Usuarios.Add(usuarioAdmin);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Herramientas";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo1.Descripcion = "Electrico";
            contexto.Tipos.Add(tipo2);

            base.Seed(contexto);
        }
      
    }
}
