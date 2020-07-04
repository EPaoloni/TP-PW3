﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Models.Partial;
using Models.ORM;

namespace Models.Repository
{
    public class NecesidadRepository : BaseRepository<Necesidades>
    {
        public NecesidadRepository(PandemiaEntities context) : base(context)
        {

        }

        public List<Necesidades> GetAll()
        {
            return context.Necesidades.ToList();
        }

        public void Actualizar(Necesidades necesidad)
        {
            Necesidades necesidadAux = ObtenerPorId(necesidad.IdNecesidad);

            necesidadAux.Nombre = necesidad.Nombre;
            necesidadAux.TelefonoContacto = necesidad.TelefonoContacto;
            necesidadAux.FechaFin = necesidad.FechaFin;
            necesidadAux.Descripcion = necesidad.Descripcion;

            SaveChanges(context);
        }
    }
}
