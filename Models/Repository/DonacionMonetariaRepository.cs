﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ORM;

namespace Models.Repository
{
    public class DonacionMonetariaRepository : BaseRepository<DonacionesMonetarias>
    {
        public DonacionMonetariaRepository(PandemiaEntities context) : base(context)
        {

        }
    }
}