//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosTienda.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Barrio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Barrio()
        {
            this.Sucursal = new HashSet<Sucursal>();
        }
    
        public decimal IdBarrio { get; set; }
        public decimal IdCiudad { get; set; }
        public string NombreBarrio { get; set; }
    
        public virtual Ciudad Ciudad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sucursal> Sucursal { get; set; }
    }
}