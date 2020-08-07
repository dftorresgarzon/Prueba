using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ServiciosTienda.Models;

namespace ServiciosTienda.Controllers
{
    public class CiudadsController : ApiController
    {
        private TiendaRealEntities db = new TiendaRealEntities();

        // GET: api/Ciudads
        public List<Ciudad> GetCiudad()
        {
            return db.Ciudad.ToList();
        }

        // GET: api/Ciudads/5
        [ResponseType(typeof(Ciudad))]
        public IHttpActionResult GetCiudad(decimal id)
        {
            Ciudad ciudad = db.Ciudad.Find(id);
            if (ciudad == null)
            {
                return NotFound();
            }

            return Ok(ciudad);
        }

        // PUT: api/Ciudads/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCiudad(decimal id, Ciudad ciudad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ciudad.IdCiudad)
            {
                return BadRequest();
            }

            db.Entry(ciudad).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CiudadExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Ciudads
        [ResponseType(typeof(Ciudad))]
        public IHttpActionResult PostCiudad(Ciudad ciudad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ciudad.Add(ciudad);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ciudad.IdCiudad }, ciudad);
        }

        // DELETE: api/Ciudads/5
        [ResponseType(typeof(Ciudad))]
        public IHttpActionResult DeleteCiudad(decimal id)
        {
            Ciudad ciudad = db.Ciudad.Find(id);
            if (ciudad == null)
            {
                return NotFound();
            }

            db.Ciudad.Remove(ciudad);
            db.SaveChanges();

            return Ok(ciudad);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CiudadExists(decimal id)
        {
            return db.Ciudad.Count(e => e.IdCiudad == id) > 0;
        }
    }
}