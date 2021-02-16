using Order_Grabber_DataService.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity;
using Order_Grabber_DataService.Models;
using Order_Grabber_DataService.Database;

namespace Order_Grabber_DataService
{
    public class ServiceCustomer : ICustomerControl
    {
        public void Create(Customer new_element)
        {
            throw new NotImplementedException();
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
            using(var db = new ModelContext() )
            {
                var Customers = db.Customers.ToList();
                return Customers;
            }
        }

        public Customer GetBy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
