using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExploreTours.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base(nameOrConnectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\goran\Documents\GitHub\PlayingWithAsp.NetMvcFramework\ExploreTours\App_Data\ExploreTours.mdf;Integrated Security=True")
        {

        }

        public DbSet<Tour> Tours { get; set; }
    }
}