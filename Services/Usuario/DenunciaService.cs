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
        DenunciaEstadoRepository estadoRepo;

        public enum Estado
        {
            Pendiente = 1,
            Aprobado = 2,
            Desestimado = 3
        }

        public DenunciaService()
        {
            PandemiaEntities context = new PandemiaEntities();
            denunciaRepo = new DenunciaRepository(context);
            estadoRepo = new DenunciaEstadoRepository(context);
        }

        public List<Denuncias> ObtenerTodosPendientes()
        {
            List<Denuncias> listaRepo = denunciaRepo.ObtenerTodos().
                                        Where(d => d.Estado == (int)Estado.Pendiente).ToList(); ;
         
            return listaRepo;
        }

        public Denuncias ObtenerPorId(int id)
        {
            Denuncias denuncia = denunciaRepo.ObtenerPorId(id);

            return denuncia;
        }

        public void Desestimar(int idDenuncia)
        {
            DenunciasEstado desestimado = estadoRepo.ObtenerPorId((int)Estado.Desestimado);
            denunciaRepo.Desestimar(idDenuncia, desestimado);
        }

        public void Aceptar(int idDenuncia) 
        {
            DenunciasEstado aprobado = estadoRepo.ObtenerPorId((int)Estado.Aprobado);
            
            denunciaRepo.Aceptar(idDenuncia, aprobado);
        }
    }
}
