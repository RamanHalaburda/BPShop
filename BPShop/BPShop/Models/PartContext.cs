using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BPShop.Models
{
    public class PartContext : DbContext
    {
        public PartContext() : base("BPShop")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Parts> Parts { get; set; }
    }
}