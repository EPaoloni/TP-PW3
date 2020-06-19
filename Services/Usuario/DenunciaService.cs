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

        public List<Denuncias> ObtenerTodos()
        {
            List<Denuncias> listaRepo = denunciaRepo.ObtenerTodos();
         
            return listaRepo;
        }

        public void Desestimar()
        {

        }

        public void Aceptar() 
        {
            
        }
    }
}
