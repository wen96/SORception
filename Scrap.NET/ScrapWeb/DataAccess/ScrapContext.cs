﻿using System;
using System.Security.Principal;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using ScrapWeb.Entities;

namespace ScrapWeb.DataAccess
{
    public class ScrapContext : 
        IdentityDbContext<IdentityUser>
    {
        public DbSet<TokenEntity> Token { get; set; }
        public DbSet<OrderEntity> Order { get; set; }
        public DbSet<OrderLineEntity> OrderLine { get; set; }
        public DbSet<OfferEntity> Offer { get; set; }
        public DbSet<OfferLineEntity> OfferLine { get; set; }
        public DbSet<AcceptedOfferLineEntity> AcceptedOfferLine { get; set; }

        // Override for created and modified dates
        public override int SaveChanges()
        {
            var trackables = ChangeTracker.Entries<AbstractEntity>();

            if(trackables != null)
            {
                foreach (var item in trackables.Where(t => t.State == EntityState.Added))
                {
                    item.Entity.creationDate = System.DateTime.Now;
                    item.Entity.updatedDate = System.DateTime.Now;

                    item.Entity.createdBy = HttpContext.Current.User.Identity.GetUserId();
                    item.Entity.updatedBy = HttpContext.Current.User.Identity.GetUserId();
                    
                }

                foreach(var item in trackables.Where(t => t.State == EntityState.Modified))
                {
                    item.Entity.updatedDate = System.DateTime.Now;
                    item.Entity.updatedBy = HttpContext.Current.User.Identity.GetUserId();
                }
            }

            return base.SaveChanges();
        }
    }
}