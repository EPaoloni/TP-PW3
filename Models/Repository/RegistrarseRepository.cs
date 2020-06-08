using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Models.ORM;
using Models.Partial;

namespace Models.Repository
{
    public class RegistrarseRepository
    {
        PandemiaEntities db = new PandemiaEntities();
        public bool Agregar(RegistrarseMetaData entidad)
        {
            Usuarios usuario = new Usuarios();
            usuario.Email = entidad.Email;
            usuario.Password = entidad.Password;
            usuario.FechaNacimiento = entidad.FechaNacimiento;
            usuario.FechaCreacion = DateTime.Today;
            usuario.TipoUsuario = BuscarTipoUsuario("Normal");
            usuario.Token = entidad.Token;
            usuario.Activo = false;

            db.Usuarios.Add(usuario);

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
    
        private int BuscarTipoUsuario(string descripcion)
        {
            int idTipoUsuario = (from t in db.UsuariosTipo
                           where t.Descripcion == descripcion
                           select t.IdUsuarioTipo).FirstOrDefault();

            return idTipoUsuario;
        }

        public void Activar(string token)
        {
            var usuario = (from us in db.Usuarios
                           where us.Token == token
                           select us).FirstOrDefault();

            if (usuario != null)
            {
                usuario.Activo = true;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
                
            }

        }
    }
}
