using Data_Service.Database;
using System.Linq;
using Data_Service.Interfaz;
using Data_Service.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Data_Service
{

    public class ServiceModeloNegocio : IService
    {
        public void CreateCustomer(Customer customer)
        {
            using (var context = new ContextGrabber())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public void CreateOrder(Order order)
        {
            using (var context = new ContextGrabber())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public void CreateProduct(Product product)
        {
            using (var context = new ContextGrabber())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            using (var context = new ContextGrabber())
            {
                context.Customers.Attach(customer);
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }

        public void DeleteOrder(Order order)
        {
            using (var context = new ContextGrabber())
            {

                var orderContext = context.Orders.Find(order.OrderID);

                foreach (var detail in order.Details.ToList())
                {
                    var detailContext = context.OrderDetails.Find(detail.OrderDetailID);
                    context.OrderDetails.Attach(detailContext);
                    context.OrderDetails.Remove(detailContext);
                    context.SaveChanges();
                }

                context.Orders.Attach(orderContext);
                context.Orders.Remove(orderContext);
                context.SaveChanges();


                /*
                var orders = context.Orders.ToList();
                //context.Orders.Attach(order);
                
                // elimino uno por uno los detalles de la orden
                foreach (var detail in order.Details)
                {
                    var detalle = context.OrderDetails.Find(detail.OrderDetailID);
                    context.OrderDetails.Attach(detalle);
                    context.OrderDetails.Remove(detalle);
                    context.SaveChanges();
                }
                context.Entry(order).State = EntityState.Deleted;
                context.SaveChanges();
                */
            }
        }

        public void DeleteProduct(Product product)
        {
            using (var context = new ContextGrabber())
            {
                context.Products.Attach(product);
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public void EditCustomer(Customer customer)
        {
            using (var context = new ContextGrabber())
            {
                context.Customers.Add(customer);
                context.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void EditOrder(Order order)
        {
            using (var context = new ContextGrabber())
            {
                context.Orders.Add(order);
                context.Entry(order).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void EditProduct(Product product)
        {
            using (var context = new ContextGrabber())
            {
                context.Products.Add(product);
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Customer> GetAllCustomers()
        {
            using (var context = new ContextGrabber())
            {
                var Customers = context.Customers.ToList();
                return Customers;
            }
        }

        public List<Customer> GetListCustomersByEstado(Estado estado)
        {
            using(var context = new ContextGrabber())
            {
                var customers = context.Customers.Where(c => c.Estado == estado);
                return customers.ToList();
            }
        }

        public List<Order> GetAllOrders()
        {
            using (var context = new ContextGrabber())
            {
                var customer = context.Customers.ToList();
                var orders = context.Orders.ToList();
                return orders;
            }
        }

        public List<Product> GetAllProducts()
        {
            using (var context = new ContextGrabber())
            {
                var Products = context.Products.ToList();
                return Products;
            }
        }

        /*** Este metodo devolvera una lista de productos con estado ACTIVO ***/
        public List<Product> GetAllProductsDisponibles()
        {
            using(var context = new ContextGrabber())
            {

                var products = context.Products.Where(p => p.Estado == Estado.ACTIVO);
                return products.ToList();
            }
        }

        public Customer GetCustomerById(int id)
        {
            using (var context = new ContextGrabber())
            {
                var customer = context.Customers.Find(id);
                return customer;
            }
        }

        public Order GetOrderById(int id)
        {
            using (var context = new ContextGrabber())
            {
                var products = context.Products.ToList();
                var orderDetail = context.OrderDetails.ToList();
                var customer = context.Customers.ToList();
                var order = context.Orders.Find(id);
                return order;
            }
        }

        public Product GetProductById(int id)
        {
            using (var context = new ContextGrabber())
            {
                var product = context.Products.Find(id);
                return product;
            }
        }
    }
}
