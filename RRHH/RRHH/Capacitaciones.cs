//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RRHH
{
    using System;
    using System.Collections.Generic;
    
    public partial class Capacitaciones
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int IdNivelCapacitacion { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFinalizacion { get; set; }
        public string Institucion { get; set; }
        public int Idiomas { get; set; }
    
        public virtual Idiomas Idiomas1 { get; set; }
        public virtual NivelCapacitacion NivelCapacitacion { get; set; }
    }
}
