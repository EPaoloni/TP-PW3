using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Models.Partial;
using Models.ORM;
using System.Collections;
using Models.ViewModels;
using System.CodeDom;

namespace Models.Repository
{
    public class NecesidadRepository : BaseRepository<Necesidades>
    {
        private static readonly int ID_NECESIDADINSUMO = 0;
        private static readonly int ID_NECESIDADMONETARIA = 1;
        private static readonly int ESTADOACTIVA = 1;

        public NecesidadRepository(PandemiaEntities context) : base(context)
        {

        }

        public void Crear(NecesidadCreacion necesidadCreacion)
        {
            DonacionTipo donacionTipo = new DonacionTipo();
            donacionTipo.IdDonacionTipo = necesidadCreacion.TipoDonacion;

            Necesidades necesidad = new Necesidades();
            necesidad.Nombre = necesidadCreacion.Nombre;
            necesidad.Descripcion = necesidadCreacion.Descripcion;
            necesidad.FechaCreacion = DateTime.Now;
            necesidad.FechaFin = necesidadCreacion.FechaFin;
            necesidad.TelefonoContacto = necesidadCreacion.TelefonoContacto;
            necesidad.TipoDonacion = necesidadCreacion.TipoDonacion;
            necesidad.Foto = necesidadCreacion.PathFoto;
            necesidad.IdUsuarioCreador = necesidadCreacion.IdUsuarioCreador;
            necesidad.Estado = ESTADOACTIVA;
            necesidad.Valoracion = 0;

            base.Crear(necesidad);

            int idNecesidad = necesidad.IdNecesidad;
            int tipoDonacion = necesidadCreacion.TipoDonacion;

            // Uso If porque Switch molestaba al poner los statics de ID en los Case
            if(tipoDonacion == ID_NECESIDADINSUMO)
            {
                CrearNecesidadesDonacionesInsumos(necesidadCreacion.NecesidadesDonacionesInsumos, idNecesidad);

            } else if(tipoDonacion == ID_NECESIDADMONETARIA)
            {
                CrearNecesidadesDonacionesMonetarias(necesidadCreacion.NecesidadDonacionMonetaria, idNecesidad);
            }

            context.SaveChanges();

        }

        public void CrearNecesidadesDonacionesInsumos(List<NecesidadDonacionInsumo> necesidadesDonacionesInsumos, int idNecesidad)
        {
            foreach(NecesidadDonacionInsumo necesidadDonacionInsumo in necesidadesDonacionesInsumos)
            {
                NecesidadesDonacionesInsumos necesidadDonacionAGuardar = new NecesidadesDonacionesInsumos();
                necesidadDonacionAGuardar.IdNecesidad = idNecesidad;
                this.context.NecesidadesDonacionesInsumos.Add(necesidadDonacionAGuardar);
            }
        }

        public void CrearNecesidadesDonacionesMonetarias(NecesidadDonacionMonetaria necesidadesDonacionesMonetarias, int idNecesidad)
        {
            NecesidadesDonacionesMonetarias necesidadDonacionAGuardar = new NecesidadesDonacionesMonetarias();
            necesidadDonacionAGuardar.IdNecesidad = idNecesidad;
            this.context.NecesidadesDonacionesMonetarias.Add(necesidadDonacionAGuardar);
        }

        public List<Necesidades> ObtenerTopNecesidades()
        {
            var TopNecesidades = context.Necesidades.OrderByDescending(necesidad => necesidad.Valoracion).Take(5);

            List<Necesidades> necesidades = new List<Necesidades>(TopNecesidades);

            return necesidades;
        }


        public override void Modificar(Necesidades necesidad)
        {
            var necesidadOriginal = dbSet.Find(necesidad.IdNecesidad);

            if(necesidadOriginal != null)
            {
                necesidadOriginal = necesidad;
                SaveChanges(context);
            }
        }

        /// <summary>
        /// Devuelve todas las necesidades que contengan el nombre ingresado, de no existir ninguna devuelve null
        /// </summary>
        /// <param name="nombreABuscar"></param>
        /// <returns></returns>
        public List<Necesidades> BuscarPorNombre(string nombreABuscar)
        {
            var necesidadesObtenidas = dbSet.Where(necesidad => necesidad.Nombre.Contains(nombreABuscar));

            if(necesidadesObtenidas != null)
            {
                List<Necesidades> necesidades = new List<Necesidades>(necesidadesObtenidas);
                return necesidades;
            } else
            {
                return null;
            }
        }

        public List<Necesidades> BuscarPorCreador(int idUsuarioCreador)
        {
            var necesidadesObtenidas = dbSet.Where(necesidad => necesidad.IdUsuarioCreador.Equals(idUsuarioCreador));

            if(necesidadesObtenidas != null)
            {
                List<Necesidades> necesidades = new List<Necesidades>(necesidadesObtenidas);
                return necesidades;
            } else
            {
                return null;
            }
        }

        public bool UsuarioTieneMenosDelLimite(int idUsuarioCreador)
        {
            // Valido que la necesidad tenga el mismo IdUsuarioCreador y este activa
            var cantidadDePublicacionesActivasDelUsuario = dbSet.Where((necesidad) => (necesidad.IdUsuarioCreador.Equals(idUsuarioCreador) && necesidad.Estado.Equals(ESTADOACTIVA))).Count();

            if(cantidadDePublicacionesActivasDelUsuario >= 3)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
