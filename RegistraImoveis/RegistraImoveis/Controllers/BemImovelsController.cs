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
    public class BemImovelsController : ApiController
    {
        private MigrationContext db = new MigrationContext();

        // GET: api/BemImovels
        public IQueryable<BemImovel> GetImoveis()
        {
            return db.Imoveis;
        }

        // GET: api/BemImovels/5
        [ResponseType(typeof(BemImovel))]
        public IHttpActionResult GetBemImovel(int id)
        {
            BemImovel bemImovel = db.Imoveis.Find(id);
            if (bemImovel == null)
            {
                return NotFound();
            }

            return Ok(bemImovel);
        }

        // PUT: api/BemImovels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBemImovel(int id, BemImovel bemImovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bemImovel.Id)
            {
                return BadRequest();
            }

            db.Entry(bemImovel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BemImovelExists(id))
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

        // POST: api/BemImovels
        [ResponseType(typeof(BemImovel))]
        public IHttpActionResult PostBemImovel(BemImovel bemImovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Imoveis.Add(bemImovel);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bemImovel.Id }, bemImovel);
        }

        // DELETE: api/BemImovels/5
        [ResponseType(typeof(BemImovel))]
        public IHttpActionResult DeleteBemImovel(int id)
        {
            BemImovel bemImovel = db.Imoveis.Find(id);
            if (bemImovel == null)
            {
                return NotFound();
            }

            db.Imoveis.Remove(bemImovel);
            db.SaveChanges();

            return Ok(bemImovel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BemImovelExists(int id)
        {
            return db.Imoveis.Count(e => e.Id == id) > 0;
        }
    }
}