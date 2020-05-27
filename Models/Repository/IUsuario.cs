using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Partial;

namespace Models.Repository
{
    interface IUsuario:IGenericoRepository<UsuariosPartial>
    {
        // Otros metodos
        bool Registrar(string email, string password, DateTime fechaNacimiento);

        bool BuscarUsuarioLogin(string email, string password);

    }
}
