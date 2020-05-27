using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository
{
    interface IGenericoRepository<Entity> where Entity:class
    {
        // Metodos genericos a todas las entidades
        bool Agregar(Entity entidad);
        bool Modificar(Entity entidad);
        bool Eliminar(int id);
        IEnumerable<Entity> ObtenerTodo();
    }
}
