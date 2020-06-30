using Models.ORM;
using Models.Repository;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Home
{
    public class NecesidadService
    {
        NecesidadRepository necesidadRepository;
        public NecesidadService(PandemiaEntities context)
        {
            necesidadRepository = new NecesidadRepository(context);
        }
        public List<Necesidades> GetNecesidades()
        {
            return necesidadRepository.ObtenerTodos();
        }

        public List<Necesidades> GetTopNecesidades()
        {
            return necesidadRepository.ObtenerTopNecesidades();
        }

        public string CrearNecesidad(NecesidadCreacion necesidadCreacion)
        {
            bool usuarioPuedeCrear = UsuarioPuedeCrearNecesidad(necesidadCreacion.IdUsuarioCreador);

            if (usuarioPuedeCrear)
            {
                bool existeMismoNombre = ExisteNecesidadMismoNombre(necesidadCreacion.Nombre);

                if( !existeMismoNombre)
                {
                    necesidadRepository.Crear(necesidadCreacion);
                    return "";
                } else
                {
                    return "Ya existe una necesidad con ese nombre";
                }
            } else
            {
                return "El usuario llegó al límite de necesidades";
            }
        }

        public bool UsuarioPuedeCrearNecesidad(int usuarioId)
        {
            return necesidadRepository.UsuarioTieneMenosDelLimite(usuarioId);
        }

        public bool ExisteNecesidadMismoNombre(string nombre)
        {
            return necesidadRepository.ExisteNombreExacto(nombre);
        }

        public void ModificarNecesidad(Necesidades necesidad)
        {
            necesidadRepository.Modificar(necesidad);
        }

        /// <summary>
        /// Devuelve las necesidades que contengan el nombre introducido, si no hay ninguna devuelve null.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public List<Necesidades> GetNecesidadesPorNombre(string nombre)
        {
            return necesidadRepository.BuscarPorNombre(nombre);
        }

        public Necesidades GetNecesidadPorId(int idNecesidad)
        {
            return necesidadRepository.BuscarPorId(idNecesidad);
        }
    }
}
