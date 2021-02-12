using Order_Grabber_DataService.Interfaz;
using Order_Grabber_DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Order_Grabber_DataService
{
    public class ServiceProduct : IProductControl
    {
        public void Create(Product new_element)
        {
            using (var db = new ModelContext())
            {
                db.Products.Add(new_element);
                db.SaveChanges();
            }
        }

        public void Delete(Product element)
        {
            throw new NotImplementedException();
        }

        public void Edit(Product element)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            using(var db = new ModelContext())
            {
                var products = db.Products.ToList();
                return products;
            }
        }

        public Product GetBy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
