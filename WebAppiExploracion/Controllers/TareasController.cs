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
using WebAppiExploracion.Models;

namespace WebAppiExploracion.Controllers
{
    public class TareasController : ApiController
    {
        private WebAppiExploracionContext db = new WebAppiExploracionContext();

        // GET: api/Tareas
        public IQueryable<Tarea> GetTareas()
        {
            return db.Tareas;
        }

        // GET: api/Tareas/5
        [ResponseType(typeof(Tarea))]
        public IHttpActionResult GetTarea(string id)
        {
            Tarea tarea = db.Tareas.Find(id);
            if (tarea == null)
            {
                return NotFound();
            }

            return Ok(tarea);
        }

        // PUT: api/Tareas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTarea(string id, Tarea tarea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tarea.id)
            {
                return BadRequest();
            }

            db.Entry(tarea).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TareaExists(id))
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

        // POST: api/Tareas
        [ResponseType(typeof(Tarea))]
        public IHttpActionResult PostTarea(Tarea tarea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tareas.Add(tarea);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (TareaExists(tarea.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tarea.id }, tarea);
        }

        // DELETE: api/Tareas/5
        [ResponseType(typeof(Tarea))]
        public IHttpActionResult DeleteTarea(string id)
        {
            Tarea tarea = db.Tareas.Find(id);
            if (tarea == null)
            {
                return NotFound();
            }

            db.Tareas.Remove(tarea);
            db.SaveChanges();

            return Ok(tarea);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TareaExists(string id)
        {
            return db.Tareas.Count(e => e.id == id) > 0;
        }
    }
}