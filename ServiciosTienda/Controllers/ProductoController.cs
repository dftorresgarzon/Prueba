using ServiciosTienda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiciosTienda.Controllers
{
    public class ProductoController : ApiController
    {
        // GET: api/Producto
        public List<ConsultarTodosProductos_Result> GetConsultarTodosProductos()
        {
            using (TiendaRealEntities contexto = new TiendaRealEntities())
            {
                return contexto.ConsultarTodosProductos().ToList();
            }
        }
        // GET: api/Producto/5
        public ConsultarPorIdProducto_Result GetConsultarPorIdProducto(int Id)
        {
            using (TiendaRealEntities contexto = new TiendaRealEntities())
            {
                return contexto.ConsultarPorIdProducto(Id).FirstOrDefault();
            }
        }

       
        // POST: api/Productos
        /*{   json para prueba en postman
            "IdTipoEmpaque": 1,
            "IdFabricante": 2,
            "IdSubdepartamento": 3,
            "NombreProducto": "sample string 4",
            "TamanioCm3": 5,
            "Precio": 6,
            "Caracteristicas": "sample string 7",
            "UrlImagen": "sample string 8"
        }*/
        [HttpPost]
        public IHttpActionResult Add(Models.Request.ProductoRequest model)
        {
            using (TiendaRealEntities contexto = new TiendaRealEntities())
            {
                contexto.GuardarProducto(model.IdTipoEmpaque,
                                         model.IdFabricante,
                                         model.IdSubdepartamento,
                                         model.NombreProducto,
                                         model.TamanioCm3,
                                         model.Precio,
                                         model.Caracteristicas,
                                         model.UrlImagen);
                contexto.SaveChanges();
            }
            return Ok("Guardado con exito");
        }

        // PUT: api/Productos/5 -modificar producto
        /*
         { --json para prueba en postman
          "IdProducto": 12,
          "IdTipoEmpaque": 4,
          "IdFabricante": 6,
          "IdSubdepartamento": 14,
          "NombreProducto": "galletas saltino noel",
          "TamanioCm3": 500,
          "Precio": 6000,
          "Caracteristicas": "4 galletas saladas",
          "UrlImagen": "https://jumbocolombiafood.vteximg336542930000"
        }
         */
        [HttpPut]
        public IHttpActionResult Update(Models.Request.ProductoRequest model)
        {
            using (TiendaRealEntities contexto = new TiendaRealEntities())
            {
                contexto.ModificarProducto(model.IdProducto,
                                           model.IdTipoEmpaque,
                                           model.IdFabricante,
                                           model.IdSubdepartamento,
                                           model.NombreProducto,
                                           model.TamanioCm3,
                                           model.Precio,
                                           model.Caracteristicas,
                                           model.UrlImagen);
                contexto.SaveChanges();
            }
            return Ok("Modificado con exito");
        }

        // DELETE: api/Productos/5
        /*
         { --json para prueba en postman
           "IdProducto": 12
         }
         */
        [HttpDelete]
        public IHttpActionResult Delete(Models.Request.ProductoRequest model)
        {
            using (TiendaRealEntities contexto = new TiendaRealEntities())
            {
                contexto.EliminarProducto(model.IdProducto);
                contexto.SaveChanges();
            }
            return Ok("Eliminado con exito");
        }
    }

}
