namespace Order_Grabber_DataService.Migrations
{
    using Order_Grabber_DataService.Database;
    using Order_Grabber_DataService.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Order_Grabber_DataService.Database.ModelContext";
        }

        protected override void Seed(ModelContext context)
        {
            var products = InicializadorBaseDatos.GetProducts();
            products.ForEach(product => context.Products.Add(product));
            context.SaveChanges();

            var customers = InicializadorBaseDatos.GetCustomers();
            customers.ForEach(customer => context.Customers.Add(customer));
            context.SaveChanges();

            var orders = InicializadorBaseDatos.GetOrders();
            orders.ForEach(order => context.Orders.Add(order));
            context.SaveChanges();
        }
            
    }
}
