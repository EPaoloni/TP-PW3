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
            int tipoDonacion = necesidadCreacion.TipoDonacion;

            bool tipoDonacionGuardado = false;

            // Uso If porque Switch molestaba al poner los statics de ID en los Case
            if(tipoDonacion == ID_NECESIDADINSUMO)
            {
                CrearNecesidadesDonacionesInsumos(necesidadCreacion.necesidadesDonacionesInsumos);
                tipoDonacionGuardado = true;

            } else if(tipoDonacion == ID_NECESIDADMONETARIA)
            {
                CrearNecesidadesDonacionesMonetarias(necesidadCreacion.necesidadesDonacionesMonetarias);
                tipoDonacionGuardado = true;
            }

            if (tipoDonacionGuardado)
            {
                DonacionTipo donacionTipo = new DonacionTipo();
                donacionTipo.IdDonacionTipo = necesidadCreacion.TipoDonacion;

                Necesidades necesidad = new Necesidades();
                necesidad.Descripcion = necesidadCreacion.Descripcion;
                necesidad.Estado = ESTADOACTIVA;
                necesidad.FechaCreacion = DateTime.Now;
                necesidad.FechaFin = necesidadCreacion.FechaFin;
                necesidad.Foto = necesidadCreacion.PathFoto;
                necesidad.IdUsuarioCreador = necesidadCreacion.IdUsuarioCreador;
                necesidad.Nombre = necesidadCreacion.Nombre;
                necesidad.TipoDonacion = necesidadCreacion.TipoDonacion;
                necesidad.TelefonoContacto = necesidadCreacion.TelefonoContacto;

                base.Crear(necesidad);

                context.SaveChanges();
            }

        }

        public void CrearNecesidadesDonacionesInsumos(List<NecesidadesDonacionesInsumos> necesidadesDonacionesInsumos)
        {
            foreach(NecesidadesDonacionesInsumos necesidadDonacionInsumo in necesidadesDonacionesInsumos)
            {
                this.context.NecesidadesDonacionesInsumos.Add(necesidadDonacionInsumo);
            }
        }

        public void CrearNecesidadesDonacionesMonetarias(NecesidadesDonacionesMonetarias necesidadesDonacionesMonetarias)
        {
                this.context.NecesidadesDonacionesMonetarias.Add(necesidadesDonacionesMonetarias);
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
    }
}
