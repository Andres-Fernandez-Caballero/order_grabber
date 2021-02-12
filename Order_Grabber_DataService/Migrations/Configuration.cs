namespace Order_Grabber_DataService.Migrations
{
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
        }

        protected override void Seed(ModelContext context)
        {

            var products = new List<Product>
            {
                new Product(){product_name = "hilo", cost_price = 100, gain = 100, product_code = "m-001", estado = "a"},
                new Product(){product_name = "Rollo cinta", cost_price = 25, gain = 200, product_code = "m-002", estado = "a"},
                new Product(){product_name = "elastico", cost_price = 50, gain = 50, product_code = "m-003", estado = "a"},
                new Product(){product_name = "Aguja_maquina", cost_price = 10, gain = 200, product_code = "m-004", estado = "a"}
            };

            foreach(var product in products)
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
