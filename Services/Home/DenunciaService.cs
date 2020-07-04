using Models.ORM;
using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Home
{
    public class DenunciaService
    {
        DenunciaRepository denunciaRepository;
        public DenunciaService(PandemiaEntities context)
        {
            denunciaRepository = new DenunciaRepository(context);
        }

        public void Crear(int idNecesidad, int motivoDenuncia, string comentario, int idUsuario)
        {
            //TODO: Ver como manejar esto de los comentarios
            //List<Comentarios> comentarios = new List<Comentarios>();
            //Comentarios comentario = new Comentarios() { Descripcion = descripcion };
            //comentarios.Add(comentario);

            //Habria que cambiar esto en la DB y hacer que IdDenuncia sea identity
            int idUltimaDenuncia = denunciaRepository.GetIdUltimaDenuncia();

            Denuncias denuncia = new Denuncias();
            denuncia.IdDenuncia = idUltimaDenuncia + 1;
            denuncia.IdNecesidad = idNecesidad;
            denuncia.IdMotivo = motivoDenuncia;
            denuncia.Cometario = comentario;
            denuncia.IdUsuario = idUsuario;
            denuncia.FechaCreacion = DateTime.Now;
            denuncia.Estado = 1;

            denunciaRepository.Crear(denuncia);

            int cantidadDenunciasMismaNecesidad = denunciaRepository.GetCantidadDenunciasMismaNecesidad(idNecesidad);

            if(cantidadDenunciasMismaNecesidad >= 5)
            {
                denunciaRepository.PasarNecesidadARevision(idNecesidad);
            }
        }
    }
}
