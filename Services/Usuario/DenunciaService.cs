using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Partial;
using Models.Repository;
using Models.ORM;

namespace Services.Usuario
{
    public class DenunciaService
    {
        DenunciaRepository denunciaRepo;
        public DenunciaService()
        {
            PandemiaEntities context = new PandemiaEntities();
            denunciaRepo = new DenunciaRepository(context);
        }

        public List<DenunciaMetaData> ObtenerTodos()
        {
            List<Denuncias> listaRepo = denunciaRepo.ObtenerTodos();

            List<DenunciaMetaData> listaMetaData = new List<DenunciaMetaData>();

            foreach (Denuncias regRepo in listaRepo)
            {
                DenunciaMetaData regMetaData = new DenunciaMetaData();

                regMetaData.FechaCreacion = regRepo.FechaCreacion;
                regMetaData.MotivoDenuncia = regRepo.MotivoDenuncia.Descripcion;
                //regMetaData.Estado = regRepo.Estado;
                regMetaData.DenunciasComentario.Add(regRepo.DenunciasComentario.Descripcion);
                regMetaData.Necesidad.Nombre = regRepo.Necesidades.Nombre;

            }

            return listaMetaData;
        }

        //public UsuariosMetaData ObtenerDenunciaUsuario()
        //{
        //    UsuariosMetaData usuario = new UsuariosMetaData();
        //}
    }
}
