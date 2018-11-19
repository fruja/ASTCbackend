﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ASTC.Models;

namespace ASTC.Controllers
{
    public class OffersController : ApiController
    {
        private ASTCContext db = new ASTCContext();

        // GET: api/Offers
        public IQueryable<Offer> GetOffers()
        {
            return db.Offers;
        }

        // GET: api/Offers/5
        [ResponseType(typeof(Offer))]
        public IHttpActionResult GetOffer(int id)
        {
            Offer offer = db.Offers.Find(id);
            if (offer == null)
            {
                return NotFound();
            }

            return Ok(offer);
        }

        // PUT: api/Offers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOffer(int id, Offer offer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != offer.ID)
            {
                return BadRequest();
            }

            db.Entry(offer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfferExists(id))
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

        // POST: api/Offers
        [ResponseType(typeof(Offer))]
        public IHttpActionResult PostOffer(Offer offer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Offers.Add(offer);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = offer.ID }, offer);
        }

        // DELETE: api/Offers/5
        [ResponseType(typeof(Offer))]
        public IHttpActionResult DeleteOffer(int id)
        {
            Offer offer = db.Offers.Find(id);
            if (offer == null)
            {
                return NotFound();
            }

            db.Offers.Remove(offer);
            db.SaveChanges();

            return Ok(offer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OfferExists(int id)
        {
            return db.Offers.Count(e => e.ID == id) > 0;
        }
    }
}