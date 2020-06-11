using System;
using System.Collections.Generic;
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
                usuario.Nombre = perfil.Nombre;
                usuario.Apellido = perfil.Apellido;
                usuario.Foto = perfil.RutaFoto;
                usuario.FechaNacimiento = perfil.FechaNacimiento;
            }
            
        }
    }
}
