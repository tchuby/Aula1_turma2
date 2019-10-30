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
using RegistraImoveis.Models;

namespace RegistraImoveis.Controllers
{
    public class TitularsController : ApiController
    {
        private MigrationContext db = new MigrationContext();

        // GET: api/Titulars
        public IQueryable<Titular> GetTitualres()
        {
            return db.Titualres;
        }

        // GET: api/Titulars/5
        [ResponseType(typeof(Titular))]
        public IHttpActionResult GetTitular(int id)
        {
            Titular titular = db.Titualres.Find(id);
            if (titular == null)
            {
                return NotFound();
            }

            return Ok(titular);
        }

        // PUT: api/Titulars/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTitular(int id, Titular titular)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != titular.Id)
            {
                return BadRequest();
            }

            db.Entry(titular).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TitularExists(id))
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

        // POST: api/Titulars
        [ResponseType(typeof(Titular))]
        public IHttpActionResult PostTitular(Titular titular)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Titualres.Add(titular);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = titular.Id }, titular);
        }

        // DELETE: api/Titulars/5
        [ResponseType(typeof(Titular))]
        public IHttpActionResult DeleteTitular(int id)
        {
            Titular titular = db.Titualres.Find(id);
            if (titular == null)
            {
                return NotFound();
            }

            db.Titualres.Remove(titular);
            db.SaveChanges();

            return Ok(titular);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TitularExists(int id)
        {
            return db.Titualres.Count(e => e.Id == id) > 0;
        }
    }
}