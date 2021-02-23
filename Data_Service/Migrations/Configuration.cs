namespace Data_Service.Migrations
{
    using Data_Service.Database;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Data_Service.Database.ContextGrabber>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Data_Service.Database.ContextGrabber context)
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

            var orderDetails = InicializadorBaseDatos.GetOrderDetails();
            orderDetails.ForEach(orderDetail => context.OrderDetails.Add(orderDetail));
            context.SaveChanges();
        }
    }
}
