//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NecesidadesReferencia
    {
        public int IdReferencia { get; set; }
        public int IdNecesidad { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    
        public virtual Necesidade Necesidade { get; set; }
    }
}
