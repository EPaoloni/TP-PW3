using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ORM;

namespace Models.Repository
{
    public class IngresarRepository
    {
        PandemiaEntities db = new PandemiaEntities();
        public bool BuscarUsuarioLogin(string email, string password)
        {
            Usuarios consulta = (from u in db.Usuarios
                                 where u.Email == email &&
                                       u.Password == password
                                 select u).FirstOrDefault();

            if (consulta != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
