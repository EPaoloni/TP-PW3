using Models.Data;
using Models.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Models.Repository
{
    public class UsuarioRepository : IUsuario
    {
        Pandemia db = new Pandemia();
        public bool Agregar(UsuariosPartial entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(UsuariosPartial entidad)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuariosPartial> ObtenerTodo()
        {
            throw new NotImplementedException();
        }

        public bool Registrar(string email, string password, DateTime fechaNacimiento)
        {


            UsuariosPartial usuario = new UsuariosPartial();
            usuario.Email = email;
            usuario.Password = password;
            usuario.FechaNacimiento = fechaNacimiento;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }

            return true;
        }

        public bool BuscarUsuarioLogin(string email, string password)
        {
            var consulta = (from u in db.Usuarios
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
