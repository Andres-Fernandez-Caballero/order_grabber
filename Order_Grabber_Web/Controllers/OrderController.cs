using Order_Grabber_Web.ServiceOrder;
using Order_Grabber_Web.ServiceProduct;
using Order_Grabber_Web.ServiceCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Order_Grabber_Web.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            using(var service = new ServiceCustomer.CustomerControlClient())
            {
                var orders = service.GetAllOrders();
              
                return View(orders);
            }
            
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            var customersAndProducts = new CustomersAndProducts();
            using(var service_customer = new ServiceCustomer.CustomerControlClient())
            {
                customersAndProducts.customers = service_customer.GetAll();
            }
            using(var service_product = new ServiceProduct.ProductControlClient())
            {
                customersAndProducts.products = service_product.GetAll();
            }

            return View(customersAndProducts);
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(String client_id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var new_order = new ServiceOrder.Order();
                    new_order.client_id = int.Parse(client_id);
                    new_order.order_date = DateTime.Now;

                    using (var service = new ServiceOrder.OrderControlClient())
                    {
                        service.Create(new_order);
                    }
                }
                
                return RedirectToAction("Index");
            }
            catch
            {
                Console.WriteLine("Error al crar modelo");
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }

    public class CustomersAndProducts
    {
        public ServiceCustomer.Customer[] customers { get; set; }
        public Product[] products { get; set; }
    }
}
