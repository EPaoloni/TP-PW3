//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.ORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Denuncias
    {
        public int IdDenuncia { get; set; }
        public int IdNecesidad { get; set; }
        public int IdMotivo { get; set; }
        public int IdUsuario { get; set; }
        public string Cometario { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public int Estado { get; set; }
    
        public virtual MotivoDenuncia MotivoDenuncia { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual DenunciasEstado DenunciasEstado { get; set; }
        public virtual MotivoDenuncia MotivoDenuncia1 { get; set; }
        public virtual Necesidades Necesidades { get; set; }
    }
}
