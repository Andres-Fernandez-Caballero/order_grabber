using Order_Grabber_DataService.Interfaz;
using Order_Grabber_DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity;
using Order_Grabber_DataService.Database;

namespace Order_Grabber_DataService
{
    public class ServiceOrder : IOrderControl
    {
        public void Create(Order new_element)
        {
            using(var db = new ModelContext())
            {
                db.Orders.Add(new_element);
                db.SaveChanges();
            }
        }

        public void Delete(Order element)
        {
            using(var db = new ModelContext())
            {
                db.Orders.Remove(element);
                db.SaveChanges();
            }
        }

        

        public void Edit(Order element)
        {
            // hacer algo para editar aca
        }

        public List<Order> GetAll()
        {
            using(var db = new ModelContext())
            {
                var orders = db.Orders.ToList();
                return orders;
            }
        }

        public Order GetBy(int id)
        {
            using(var db = new ModelContext())
            {
                var order = db.Orders.Find(id);
                return order;
            }
        }

    }
}
