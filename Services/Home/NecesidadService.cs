using Models.ORM;
using Models.Repository;
using Models.ViewModels;
using Services.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Home
{
    enum EstadoNecesidad
    {
        Activo = 1,
        Bloqueado = 2
    }

    public class NecesidadService
    {
        NecesidadRepository necesidadRepository;
        UsuarioRepository usuarioRepository;

        public NecesidadService(PandemiaEntities context)
        {
            necesidadRepository = new NecesidadRepository(context);
            usuarioRepository = new UsuarioRepository(context);
        }
        public List<Necesidades> GetNecesidades(PandemiaEntities context)
        {
            return necesidadRepository.GetAll();
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
                    if(necesidadCreacion.TipoDonacion == 1)
                    {
                        if(necesidadCreacion.NecesidadDonacionMonetaria == null)
                        {
                            return "Falta introducir los datos para las donaciones";
                        }
                    } else if(necesidadCreacion.NecesidadesDonacionesInsumos == null)
                    {
                        return "Falta introducir los datos para las donaciones";
                    }

                    string pathArchivo = GuardarArchivo(necesidadCreacion);

                    necesidadCreacion.Path = pathArchivo;

                    necesidadRepository.Crear(GenerarNecesidades(necesidadCreacion));

                    Necesidades necesidad = necesidadRepository.BuscarPorNombreExacto(necesidadCreacion.Nombre);

                    CrearNecesidadesDonacion(necesidadCreacion, necesidad.IdNecesidad);
                    return "";
                } else
                {
                    return "Ya existe una necesidad con ese nombre";
                }
            } else
            {
                return "El usuario lleg� al l�mite de necesidades";
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

        public void ModificarNecesidad(NecesidadModificacion necesidadModificacion)
        {
            Necesidades necesidad = GenerarNecesidades(necesidadModificacion);

            necesidad.IdNecesidad = necesidadModificacion.IdNecesidad;

            if (necesidadModificacion.NecesidadDonacionMonetaria != null)
            {
                NecesidadesDonacionesMonetarias necesidadesDonacionesMonetarias = necesidadRepository.BuscarNecesidadDonacionMonetariaPorIdNecesidad(necesidadModificacion.IdNecesidad);
                necesidadesDonacionesMonetarias.CBU = necesidadModificacion.NecesidadDonacionMonetaria.CBU;
                necesidadesDonacionesMonetarias.Dinero = necesidadModificacion.NecesidadDonacionMonetaria.Dinero;
                necesidad.NecesidadesDonacionesMonetarias.Add(necesidadesDonacionesMonetarias);
            }
            //else
            //{
            //    List<NecesidadesDonacionesInsumos> necesidadesDonacionesInsumos = necesidadRepository.BuscarTodasLasNecesidadDonacionInsumosPorIdNecesidad(necesidadModificacion.IdNecesidad);
            //    foreach (NecesidadesDonacionesInsumos necesidadDonacion in necesidadesDonacionesInsumos)
            //    {
            //        NecesidadDonacionInsumo item = necesidadModificacion.NecesidadesDonacionesInsumos.SingleOrDefault(o => o.Nombre == necesidadDonacion.Nombre);
            //        if (item != null)
            //        {
            //            necesidadDonacion.Cantidad = item.Cantidad;
            //        }
            //        else
            //        {
            //            necesidadesDonacionesInsumos.Remove(necesidadDonacion);
            //        }
            //    }
            //}

            necesidadRepository.Modificar(necesidad);
        }

        public void BajaNecesidad(int idNecesidad, int usuarioSession)
        {
            Necesidades necesidad = GetNecesidadPorId(idNecesidad);

            int idUsuarioLogueado = usuarioSession;

            if (necesidad.IdUsuarioCreador == idUsuarioLogueado)
            {
                necesidadRepository.BajaNecesidad(idNecesidad);
            }
        }

        public void AgregarValoracionNecesidad(NecesidadesValoraciones necesidadesValoraciones, PandemiaEntities context)
        {
            NecesidadesValoracionesRepository necesidadesValoracionesRepository = new NecesidadesValoracionesRepository(context);

            int cantidadValoraciones = necesidadesValoracionesRepository.ContarValoracionesNecesidad(necesidadesValoraciones.IdNecesidad);

            Necesidades necesidad = necesidadRepository.BuscarPorId(necesidadesValoraciones.IdNecesidad);

            necesidadesValoracionesRepository.Crear(necesidadesValoraciones);

            bool votoPositivo = necesidadesValoraciones.Valoracion;

            decimal? nuevoPromedio = 0;
            cantidadValoraciones++;
            
            if (votoPositivo)
            {
                nuevoPromedio = necesidad.Valoracion + ((1 - necesidad.Valoracion) / cantidadValoraciones);
            } else
            {
                nuevoPromedio = necesidad.Valoracion + ((0 - necesidad.Valoracion) / cantidadValoraciones);
            }

            nuevoPromedio = Math.Round(nuevoPromedio.Value, 2);

            necesidad.Valoracion = nuevoPromedio;

            necesidadRepository.Modificar(necesidad);

        }

        public void RealizarDonacionMonetaria(DonacionesMonetarias donacionesMonetarias)
        {
            int idNecesidad = donacionesMonetarias.NecesidadesDonacionesMonetarias.IdNecesidad;
            NecesidadesDonacionesMonetarias necesidadDonacionMonetaria = necesidadRepository.BuscarNecesidadDonacionMonetariaPorIdNecesidad(idNecesidad);

            donacionesMonetarias.IdNecesidadDonacionMonetaria = necesidadDonacionMonetaria.IdNecesidadDonacionMonetaria;

            necesidadRepository.AltaDonacionMonetaria(donacionesMonetarias);
        }

        /// <summary>
        /// Devuelve las necesidades que contengan el nombre introducido, si no hay ninguna devuelve null.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public List<Necesidades> GetNecesidadesPorNombre(string nombre)
        {
            List<Necesidades> necesidades = necesidadRepository.BuscarPorNombre(nombre);

            necesidades.Sort(new OrdenFechaFinValoracion());

            return necesidades;
        }

        public List<Necesidades> GetNecesidadesPorNombreUsuario(string nombre)
        {
            List<int> listaIdUsuarios = usuarioRepository.BuscarIdUsuariosPorNombre(nombre);

            List<Necesidades> necesidades = necesidadRepository.BuscarPorNombreUsuario(listaIdUsuarios);
            return necesidades;
        }

        public List<Necesidades> GetNecesidadesPorNombreYUsuario(string nombre)
        {
            List<Necesidades> necesidadesPorNombre = GetNecesidadesPorNombre(nombre);
            List<Necesidades> necesidadesPorUsuario = GetNecesidadesPorNombreUsuario(nombre);

            // Armo una lista nueva con las necesidades por nombre, y luego veo si estan las de usuario y las agrego
            List<Necesidades> necesidadesARetornar = new List<Necesidades>(necesidadesPorNombre);

            foreach(Necesidades necesidad in necesidadesPorUsuario)
            {
                if (!necesidadesARetornar.Contains(necesidad))
                {
                    necesidadesARetornar.Add(necesidad);
                }
            }

            necesidadesARetornar.Sort(new OrdenFechaFinValoracion());

            return necesidadesARetornar;
        }

        public Necesidades GetNecesidadPorId(int idNecesidad)
        {
            return necesidadRepository.BuscarPorId(idNecesidad);
        }

        public NecesidadesDonacionesMonetarias GetNecesidadesDonacionesMonetarias(int idNecesidad)
        {
            return necesidadRepository.BuscarNecesidadDonacionMonetariaPorIdNecesidad(idNecesidad);
        }

        public NecesidadesDonacionesInsumos GetNecesidadesDonacionesInsumos(int idNecesidad, int insumo)
        {
            return necesidadRepository.BuscarNecesidadDonacionInsumosPorIdNecesidad(idNecesidad, insumo)[0];
        }

        public void CrearNecesidadesDonacion(NecesidadCreacion necesidadCreacion, int idNecesidad)
        {
            int tipoDonacion = necesidadCreacion.TipoDonacion;

            // Uso If porque Switch molestaba al poner los statics de ID en los Case
            if (tipoDonacion == 1)
            {
                necesidadRepository.CrearNecesidadesDonacionesMonetarias(necesidadCreacion.NecesidadDonacionMonetaria, idNecesidad);
            }
            else if (tipoDonacion == 2)
            {
                necesidadRepository.CrearNecesidadesDonacionesInsumos(necesidadCreacion.NecesidadesDonacionesInsumos, idNecesidad);
            }
        }

        public NecesidadModificacion GenerarNecesidadModificacion(Necesidades necesidad)
        {
            NecesidadModificacion necesidadModificacion = new NecesidadModificacion();

            necesidadModificacion.IdNecesidad = necesidad.IdNecesidad;
            necesidadModificacion.Nombre = necesidad.Nombre;
            necesidadModificacion.TelefonoContacto = necesidad.TelefonoContacto;
            necesidadModificacion.Descripcion = necesidad.Descripcion;
            necesidadModificacion.FechaFin = necesidad.FechaFin;
            necesidadModificacion.TipoDonacion = necesidad.TipoDonacion;

            if (necesidadModificacion.TipoDonacion == 1)
            {
                NecesidadesDonacionesMonetarias necesidadesDonacionesMonetarias = GetNecesidadesDonacionesMonetarias(necesidad.IdNecesidad);

                necesidadModificacion.NecesidadDonacionMonetaria = new NecesidadDonacionMonetaria();

                necesidadModificacion.NecesidadDonacionMonetaria.CBU = necesidadesDonacionesMonetarias.CBU;
                necesidadModificacion.NecesidadDonacionMonetaria.Dinero = necesidadesDonacionesMonetarias.Dinero;
            }
            else
            {
                necesidadModificacion.NecesidadesDonacionesInsumos = necesidadModificacion.NecesidadesDonacionesInsumos;
            }

            necesidadModificacion.Referencia = new List<Referencia>();

            foreach(NecesidadesReferencias necesidadReferencia in necesidad.NecesidadesReferencias)
            {
                Referencia referencia = new Referencia() { Nombre = necesidadReferencia.Nombre, Telefono = necesidadReferencia.Telefono };
                necesidadModificacion.Referencia.Add(referencia);
            }

            necesidadModificacion.Path = necesidad.Foto;

            return necesidadModificacion;
        }

        public Necesidades GenerarNecesidades(NecesidadCreacion necesidadCreacion)
        {

            DonacionesTipo donacionTipo = new DonacionesTipo();
            donacionTipo.IdDonacionTipo = necesidadCreacion.TipoDonacion;

            Necesidades necesidad = new Necesidades();
            necesidad.Nombre = necesidadCreacion.Nombre;
            necesidad.Descripcion = necesidadCreacion.Descripcion;
            necesidad.FechaCreacion = DateTime.Now;
            necesidad.FechaFin = necesidadCreacion.FechaFin;
            necesidad.TelefonoContacto = necesidadCreacion.TelefonoContacto;
            necesidad.TipoDonacion = necesidadCreacion.TipoDonacion;
            necesidad.Foto = necesidadCreacion.Path;
            necesidad.IdUsuarioCreador = necesidadCreacion.IdUsuarioCreador;
            necesidad.Estado = 1;
            necesidad.Valoracion = 0;

            necesidad.NecesidadesReferencias = new List<NecesidadesReferencias>();

            foreach (Referencia referencia in necesidadCreacion.Referencia)
            {
                NecesidadesReferencias necesidadReferencia = new NecesidadesReferencias()
                {
                    IdNecesidad = necesidad.IdNecesidad,
                    Nombre = referencia.Nombre,
                    Telefono = referencia.Telefono,
                };
                necesidad.NecesidadesReferencias.Add(necesidadReferencia);
            }

            return necesidad;
        }

        public Necesidades ObtenerPorId(int id)
        {
            Necesidades necesidad = necesidadRepository.ObtenerPorId(id);

            return necesidad;
        }

        public List<Necesidades> ObtenerPorUsuario(int idUsuario)
        {
            List<Necesidades> necesidad = necesidadRepository.GetAll()
                                          .Where(n => n.IdUsuarioCreador == idUsuario && n.Estado != (int)EstadoNecesidad.Bloqueado)                                          
                                          .ToList();

            return necesidad;
        }

        public void Modificar(Necesidades necesidad)
        {
            necesidadRepository.Actualizar(necesidad);
        }


        public string GuardarArchivo(NecesidadCreacion necesidadCreacion)
        {
            ArchivoService archivoService = new ArchivoService();

            string rutaAux = archivoService.Guardar(necesidadCreacion.Foto, necesidadCreacion.Nombre, "necesidad");

            return rutaAux;
        }

        public List<Necesidades> OtrasNecesidades(int idUsuario)
        {
            List<Necesidades> lista = necesidadRepository.GetAll()
                                                .Where(n => n.IdUsuarioCreador != idUsuario && n.Estado != (int)EstadoNecesidad.Bloqueado)
                                                .ToList();

            return lista;
        }
    }

    public class OrdenFechaFinValoracion : IComparer<Necesidades>
    {
        public int Compare(Necesidades x, Necesidades y)
        {
            if(x.FechaFin == y.FechaFin)
            {
                return x.Valoracion.Value.CompareTo(y.Valoracion.Value);
            } else
            {
                return x.FechaFin.CompareTo(y.FechaFin);
            }
        }
    }
}
