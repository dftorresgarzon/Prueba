using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosTienda.Models.Request
{
    public class ProductoRequest
    {
        public int IdProducto { get; set; }
        public int IdTipoEmpaque { get; set; }
        public int IdFabricante { get; set; }
        public int IdSubdepartamento { get; set; }
        public string NombreProducto { get; set; }
        public int TamanioCm3 { get; set; }
        public int Precio { get; set; }
        public string Caracteristicas { get; set; }
        public string UrlImagen { get; set; }
    }
}