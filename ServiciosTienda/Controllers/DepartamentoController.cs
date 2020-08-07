using ServiciosTienda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ServiciosTienda.Controllers
{
    // GET: api/Departamento
    [EnableCors("*", headers:"*", methods:"*")]//para acceder solo desde esa ruta
    public class DepartamentoController : ApiController
    {
        public List<ConsultarTodosDepartamentos_Result> GetConsultarTodosDepartamentos()
        {
            using (TiendaRealEntities contexto = new TiendaRealEntities())
            {
                return contexto.ConsultarTodosDepartamentos().ToList();
            }
        }
    }
}
