using Order_Grabber_DataService.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Order_Grabber_DataService.Database
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("Name=ModelContext")
        {
            System.Data.Entity.Database.SetInitializer(new InicializadorBaseDatos());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderDetail> Order_Details { get; set; }

    }
}