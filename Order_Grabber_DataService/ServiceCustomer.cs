using Order_Grabber_DataService.Interfaz;
using Order_Grabber_DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity;

namespace Order_Grabber_DataService
{
    public class ServiceCustomer : ICustomerControl
    {
        public void Create(Customer new_element)
        {
            using(var db = new ModelContext())
            {
                db.Customers.Add(new_element);
                db.SaveChanges();
            }
        }

        public void Delete(Customer element)
        {
            throw new NotImplementedException();
        }

        public void Edit(Customer element)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            using(var db = new ModelContext())
            {
                var customers = db.Customers.ToList();
                return customers;
            }
        }
        
        public List<Order> GetAllOrders()
        {
            using (var db = new ModelContext())
            {
                

                return null;
            }
        }
       
        public Order GetOrderBy(int id)
        {
            using(var db = new ModelContext())
            {
                var order = db.Orders.Find(id);
                return order;
            }
        }

        public Customer GetBy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
