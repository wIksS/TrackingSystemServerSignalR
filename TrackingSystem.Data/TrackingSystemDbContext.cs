﻿using Microsoft.AspNet.Identity.EntityFramework;
using TrackingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Data.Migrations;

namespace TrackingSystem.Data
{
    public class TrackingSystemDbContext : IdentityDbContext
    {
        public TrackingSystemDbContext()
            : base("TrackingSystemConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TrackingSystemDbContext, Configuration>());
        }

        IDbSet<ApplicationUser> Users
        {
            get;
            set;
        }

        IDbSet<Coordinate> Coordinates
        {
            get;
            set;
        }


        public static TrackingSystemDbContext Create()
        {
            return new TrackingSystemDbContext();
        }
    }
}