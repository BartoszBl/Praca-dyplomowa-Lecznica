using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecznica.Models
{
    public class Clients
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Telefon { get; set; }
       
    }

    public class LecznicaDBContext : DbContext
    {
        public DbSet<Clients> Clients { get; set; }
    }
}
