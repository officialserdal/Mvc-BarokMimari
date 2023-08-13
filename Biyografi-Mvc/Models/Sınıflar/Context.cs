using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Biyografi_Mvc.Models.Sınıflar
{
    public class Context:DbContext
    {
        public DbSet<Heykeller> Heykellers { get; set; }
        public DbSet<Saraylar> Saraylars { get; set; }
       





    }
}