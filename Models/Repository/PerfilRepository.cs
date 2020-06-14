using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ORM;
using Models.Partial;

namespace Models.Repository
{
    public class PerfilRepository
    {
        PandemiaEntities db = new PandemiaEntities();
        public int ValidarNombreUsuario(string nombre, string apellido)
        {
            
            IQueryable<Usuarios> consulta = from u in db.Usuarios
                                            where u.Nombre == nombre &&
                                                  u.Apellido == apellido
                                            select u;

            return consulta.Count();
        }

        public void Guardar(PerfilMetaData perfil)
        {
            Usuarios usuario = db.Usuarios.Where(u => u.Email == perfil.Email).FirstOrDefault();

            if (usuario != null)
            {
                usuario.UserName = perfil.NombreUsuario;
                usuario.Nombre = perfil.Nombre;
                usuario.Apellido = perfil.Apellido;
                usuario.Foto = perfil.RutaFoto;
                usuario.FechaNacimiento = perfil.FechaNacimiento;

                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    Debug.WriteLine(ex.Message);

                    // Retrieve the error messages as a list of strings.
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join("; ", errorMessages);

                    // Combine the original exception message with the new one.
                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                }
            }  
            
        }
    }
}
