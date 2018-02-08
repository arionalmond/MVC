using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Store
    {
        public int ID { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public string BusinessHours { get; set; }
    }

    public class StoreDBContext : CardDBContext
    {
        public DbSet<Store> Stores { get; set; }
    }
}