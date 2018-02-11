using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExploreTours.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base(nameOrConnectionString: "ExploreTours")
        {

        }

        public DbSet<Tour> Tours { get; set; }
    }
}