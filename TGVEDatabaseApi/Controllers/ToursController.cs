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
using TGVEDatabaseApi.Models;

namespace TGVEDatabaseApi.Controllers
{
    public class ToursController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Tours
        public IQueryable<Tour> GetTour()
        {
            return db.Tour;
        }

        // GET: api/Tours/5
        [ResponseType(typeof(Tour))]
        public IHttpActionResult GetTour(int id)
        {
            Tour tour = db.Tour.Find(id);
            if (tour == null)
            {
                return NotFound();
            }

            return Ok(tour);
        }

        // PUT: api/Tours/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTour(int id, Tour tour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tour.TourID)
            {
                return BadRequest();
            }

            db.Entry(tour).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TourExists(id))
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

        // POST: api/Tours
        [ResponseType(typeof(Tour))]
        public IHttpActionResult PostTour(Tour tour)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tour.Add(tour);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (TourExists(tour.TourID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tour.TourID }, tour);
        }

        // DELETE: api/Tours/5
        [ResponseType(typeof(Tour))]
        public IHttpActionResult DeleteTour(int id)
        {
            Tour tour = db.Tour.Find(id);
            if (tour == null)
            {
                return NotFound();
            }

            db.Tour.Remove(tour);
            db.SaveChanges();

            return Ok(tour);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TourExists(int id)
        {
            return db.Tour.Count(e => e.TourID == id) > 0;
        }
    }
}