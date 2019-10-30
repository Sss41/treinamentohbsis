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
using WebApiimobiliaria.Models;

namespace WebApiimobiliaria.Controllers
{
    public class ImovelsController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Imovels
        public IQueryable<Imovel> GetImovel()
        {
            return db.Imovel;
        }

        // GET: api/Imovels/5
        [ResponseType(typeof(Imovel))]
        public IHttpActionResult GetImovel(int id)
        {
            Imovel imovel = db.Imovel.Find(id);
            if (imovel == null)
            {
                return NotFound();
            }

            return Ok(imovel);
        }

        // PUT: api/Imovels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutImovel(int id, Imovel imovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != imovel.Id)
            {
                return BadRequest();
            }

            db.Entry(imovel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImovelExists(id))
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

        // POST: api/Imovels
        [ResponseType(typeof(Imovel))]
        public IHttpActionResult PostImovel(Imovel imovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Imovel.Add(imovel);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = imovel.Id }, imovel);
        }

        // DELETE: api/Imovels/5
        [ResponseType(typeof(Imovel))]
        public IHttpActionResult DeleteImovel(int id)
        {
            Imovel imovel = db.Imovel.Find(id);
            if (imovel == null)
            {
                return NotFound();
            }

            db.Imovel.Remove(imovel);
            db.SaveChanges();

            return Ok(imovel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ImovelExists(int id)
        {
            return db.Imovel.Count(e => e.Id == id) > 0;
        }
    }
}