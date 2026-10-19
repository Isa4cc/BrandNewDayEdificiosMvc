using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BrandNewDayEdificiosMvc.Models
{
    public class BrandNewDayDbContext : DbContext
    {
        public BrandNewDayDbContext() : base("name=BrandNewDayDbContext")
        {

        }

        public DbSet<Barrio> Barrios { get; set; }
        public DbSet<Edificio> Edificios { get; set; }
    }
}