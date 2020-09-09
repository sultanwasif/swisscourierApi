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
using SwissCourierApi.Models;

namespace SwissCourierApi.Controllers
{
    public class tbl_ordersController : ApiController
    {
        private DB_A25ADE_unexEntities db = new DB_A25ADE_unexEntities();

        // GET: api/tbl_orders
        public IQueryable<tbl_orders> Gettbl_orders()
        {
            return db.tbl_orders;
        }

        // GET: api/tbl_orders/5
        [ResponseType(typeof(tbl_orders))]
        public IHttpActionResult Gettbl_orders(string id)
        {
            tbl_orders tbl_orders = db.tbl_orders.Find(id);
            if (tbl_orders == null)
            {
                return NotFound();
            }

            return Ok(tbl_orders);
        }

        // PUT: api/tbl_orders/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_orders(string id, tbl_orders tbl_orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_orders.ORDER_NO)
            {
                return BadRequest();
            }

            db.Entry(tbl_orders).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_ordersExists(id))
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

        // POST: api/tbl_orders
        [ResponseType(typeof(tbl_orders))]
        public IHttpActionResult Posttbl_orders(tbl_orders tbl_orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_orders.Add(tbl_orders);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tbl_ordersExists(tbl_orders.ORDER_NO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tbl_orders.ORDER_NO }, tbl_orders);
        }

        // DELETE: api/tbl_orders/5
        [ResponseType(typeof(tbl_orders))]
        public IHttpActionResult Deletetbl_orders(string id)
        {
            tbl_orders tbl_orders = db.tbl_orders.Find(id);
            if (tbl_orders == null)
            {
                return NotFound();
            }

            db.tbl_orders.Remove(tbl_orders);
            db.SaveChanges();

            return Ok(tbl_orders);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_ordersExists(string id)
        {
            return db.tbl_orders.Count(e => e.ORDER_NO == id) > 0;
        }
    }
}