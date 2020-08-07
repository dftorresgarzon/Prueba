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
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.RegistroAlmacen = new HashSet<RegistroAlmacen>();
        }
    
        public decimal IdProducto { get; set; }
        public decimal IdTipoEmpaque { get; set; }
        public decimal IdFabricante { get; set; }
        public Nullable<decimal> IdSubdepartamento { get; set; }
        public string NombreProducto { get; set; }
        public decimal TamanioCm3 { get; set; }
        public decimal Precio { get; set; }
        public string Caracteristicas { get; set; }
        public string UrlImagen { get; set; }
    
        public virtual Empaque Empaque { get; set; }
        public virtual Fabricante Fabricante { get; set; }
        public virtual SubdepartamentosProductos SubdepartamentosProductos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroAlmacen> RegistroAlmacen { get; set; }
    }
}
