using Models.ORM;
using Models.Partial;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models.Repository
{
    public class UsuarioRepository : BaseRepository<Usuarios>
    {
        public UsuarioRepository(PandemiaEntities context) : base(context)
        {

        }

        public Usuarios BuscarUsuario(string email, string password)
        {
            Usuarios consulta = (from u in context.Usuarios
                                 where u.Email == email &&
                                       u.Password == password
                                 select u).FirstOrDefault();

            return consulta;
        }

        public void Activar(string token)
        {
            var usuario = (from us in context.Usuarios
                           where us.Token == token
                           select us).FirstOrDefault();

            if (usuario != null)
            {
                usuario.Activo = true;
                context.SaveChanges();
            }
        }

        public int BuscarTipoUsuario(string descripcion)
        {
            int idTipoUsuario = (from t in context.UsuariosTipo
                                 where t.Descripcion == descripcion
                                 select t.IdUsuarioTipo).FirstOrDefault();

            return idTipoUsuario;
        }

        public Usuarios ObtenerPorEmail(string email)
        {
            Usuarios usuario = context.Usuarios.Where(u => u.Email == email).FirstOrDefault();

            return usuario;
        }

        public string ObtenerNombreUsuario(string token)
        {
            return "userTest";
        }

        public string ObtenerToken(string email)
        {
            return "d1s24d5674e6";
        }

        public int ValidarNombreUsuario(string nombre, string apellido)
        {

            IQueryable<Usuarios> consulta = from u in context.Usuarios
                                            where u.Nombre == nombre &&
                                                  u.Apellido == apellido
                                            select u;

            return consulta.Count();
        }

        public void GuardarModificacion(PerfilMetaData usuarioAux)
        {
            Usuarios usuario = ObtenerPorEmail(usuarioAux.Email);

            usuario.UserName = usuarioAux.NombreUsuario;
            usuario.Nombre = usuarioAux.Nombre;
            usuario.Apellido = usuarioAux.Apellido;
            usuario.Foto = usuarioAux.RutaFoto;
            usuario.FechaNacimiento = DateTime.Parse(usuarioAux.FechaNacimiento);

            context.SaveChanges();
        }

    }
}
