using System;
using System.Data.Entity;

namespace MVC.Models
{
    public class Card
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }

    public class CardDBContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
    }
}