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
    
    public partial class SubdepartamentosProductos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubdepartamentosProductos()
        {
            this.Producto = new HashSet<Producto>();
        }
    
        public decimal IdSubdepartamento { get; set; }
        public Nullable<decimal> IdDepartamento { get; set; }
        public string NombreSubdepartamento { get; set; }
    
        public virtual DepartamentosProductos DepartamentosProductos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
