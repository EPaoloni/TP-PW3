﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class Referencia
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Telefono { get; set; }
    }
}
