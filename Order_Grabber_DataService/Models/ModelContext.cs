using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Order_Grabber_DataService.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("Name=ModelContext")
        {
        }

        public DbSet<Product> Products {get; set;}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> Order_Details { get; set; }

    }
}
