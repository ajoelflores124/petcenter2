//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pet.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sede
    {
        public Sede()
        {
            this.Equipo_Sede = new HashSet<Equipo_Sede>();
            this.Solicitud = new HashSet<Solicitud>();
        }
    
        public int CodigoSede { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public Nullable<System.DateTime> FechaHoraActualizacion { get; set; }
        public Nullable<bool> EstadoRegistro { get; set; }
    
        public virtual ICollection<Equipo_Sede> Equipo_Sede { get; set; }
        public virtual ICollection<Solicitud> Solicitud { get; set; }
    }
}
