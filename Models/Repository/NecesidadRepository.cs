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
    public class NecesidadRepository : BaseRepository<ORM.Necesidades>
    {
        private static readonly int ESTADOACTIVA = 1;
        private static readonly int ESTADOINACTIVA = 2;

        public NecesidadRepository(PandemiaEntities context) : base(context)
        {

        }

        public void CrearNecesidadesDonacionesInsumos(List<NecesidadDonacionInsumo> necesidadesDonacionesInsumos, int idNecesidad)
        {
            foreach(NecesidadDonacionInsumo necesidadDonacionInsumo in necesidadesDonacionesInsumos)
            {
                NecesidadesDonacionesInsumos necesidadDonacionAGuardar = new NecesidadesDonacionesInsumos();
                necesidadDonacionAGuardar.IdNecesidad = idNecesidad;
                necesidadDonacionAGuardar.Nombre = necesidadDonacionInsumo.Nombre;
                necesidadDonacionAGuardar.Cantidad = necesidadDonacionInsumo.Cantidad;
                necesidadDonacionAGuardar.FechaCreacion = DateTime.Now;

                this.context.NecesidadesDonacionesInsumos.Add(necesidadDonacionAGuardar);
            }

            SaveChanges(context);
        }

        public void CrearNecesidadesDonacionesMonetarias(NecesidadDonacionMonetaria necesidadesDonacionesMonetarias, int idNecesidad)
        {
            NecesidadesDonacionesMonetarias necesidadDonacionAGuardar = new NecesidadesDonacionesMonetarias();
            necesidadDonacionAGuardar.IdNecesidad = idNecesidad;
            necesidadDonacionAGuardar.Dinero = necesidadesDonacionesMonetarias.Dinero;
            necesidadDonacionAGuardar.CBU = necesidadesDonacionesMonetarias.CBU;
            this.context.NecesidadesDonacionesMonetarias.Add(necesidadDonacionAGuardar);

            SaveChanges(context);
        }

        public List<ORM.Necesidades> ObtenerTopNecesidades()
        {
            var TopNecesidades = context.Necesidades.OrderByDescending(necesidad => necesidad.Valoracion).Take(5);

            List<ORM.Necesidades> necesidades = new List<ORM.Necesidades>(TopNecesidades);

            return necesidades;
        }


        public void Modificar(ORM.Necesidades necesidad)
        {
            var necesidadOriginal = dbSet.Find(necesidad.IdNecesidad);

            if(necesidadOriginal != null)
            {
                necesidadOriginal = necesidad;
                SaveChanges(context);
            }
        }

        public void BajaNecesidad(int idNecesidad)
        {
            Necesidades necesidad = context.Necesidades.SingleOrDefault(o => o.IdNecesidad == idNecesidad);

            necesidad.Estado = ESTADOINACTIVA;

            SaveChanges(context);
        }

        /// <summary>
        /// Devuelve todas las necesidades que contengan el nombre ingresado, de no existir ninguna devuelve null
        /// </summary>
        /// <param name="nombreABuscar"></param>
        /// <returns></returns>
        public List<ORM.Necesidades> BuscarPorNombre(string nombreABuscar)
        {
            var necesidadesObtenidas = dbSet.Where(necesidad => necesidad.Nombre.Contains(nombreABuscar));

            if(necesidadesObtenidas != null)
            {
                List<ORM.Necesidades> necesidades = new List<ORM.Necesidades>(necesidadesObtenidas);
                return necesidades;
            } else
            {
                return null;
            }
        }

        public List<ORM.Necesidades> BuscarPorCreador(int idUsuarioCreador)
        {
            var necesidadesObtenidas = dbSet.Where(necesidad => necesidad.IdUsuarioCreador.Equals(idUsuarioCreador));

            if(necesidadesObtenidas != null)
            {
                List<ORM.Necesidades> necesidades = new List<ORM.Necesidades>(necesidadesObtenidas);
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

        public Necesidades BuscarPorId(int idNecesidad)
        {
            Necesidades necesidad = context.Necesidades.Find(idNecesidad);

            if(necesidad != null)
            {
                context.Entry(necesidad).Collection(o => o.NecesidadesReferencias).Load();
            }

            return necesidad;
        }

        public Necesidades BuscarPorNombreExacto(string nombre)
        {
            Necesidades necesidad = context.Necesidades.SingleOrDefault(o => o.Nombre == nombre);

            return necesidad;
        }

        public bool ExisteNombreExacto(string nombre)
        {
            bool existeRegistro = context.Necesidades.Any(o => o.Nombre == nombre);

            if ( existeRegistro )
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void AltaDonacionMonetaria(DonacionesMonetarias donacionMonetaria)
        {
            context.DonacionesMonetarias.Add(donacionMonetaria);
            SaveChanges(context);
        }

        public NecesidadesDonacionesMonetarias BuscarNecesidadDonacionMonetariaPorIdNecesidad(int idNecesidad)
        {
            NecesidadesDonacionesMonetarias necesidadesDonacionesMonetarias = context.NecesidadesDonacionesMonetarias.First(o => o.IdNecesidad == idNecesidad);

            return necesidadesDonacionesMonetarias;
        }

        public List<NecesidadesDonacionesInsumos> BuscarNecesidadesDonacionesInsumosPorIdNecesidad(int idNecesidad)
        {
            var resultado = context.NecesidadesDonacionesInsumos.Where(o => o.IdNecesidad == idNecesidad);

            List<NecesidadesDonacionesInsumos> necesidadesDonacionesInsumos = new List<NecesidadesDonacionesInsumos>(resultado);

            return necesidadesDonacionesInsumos;
        }
    }
}
