using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ORM;

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
    }
}
