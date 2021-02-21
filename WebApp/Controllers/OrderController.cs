using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApp.ServiceModeloNegocio;

namespace WebApp.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                var orders = service.GetAllOrders();
                return View(orders);
            }

        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            using(var service = new ServiceModeloNegocio.ServiceClient())
            {
                var order = service.GetOrderById(id);
                return View(order);
            }
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            using(var service = new ServiceModeloNegocio.ServiceClient())
            {
                ViewBag.ProductosDisponibles = service.GetAllProductsDisponibles();
                ViewBag.CustomersList = service.GetListCustomersByEstado(Estado.INACTIVO);
                return View();
            }
            
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(Order order)
        {
            try
            {
                using(var service = new ServiceModeloNegocio.ServiceClient())
                {
                    order.Order_date = DateTime.Now;
                    service.CreateOrder(order);
                    return RedirectToAction("Index");
                }

                
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                ViewBag.ProductosDisponibles = service.GetAllProductsDisponibles();
                ViewBag.CustomersList = service.GetListCustomersByEstado(Estado.INACTIVO);
                return View();
            }
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(Order order)
        {
            try
            {
                using(var service = new ServiceModeloNegocio.ServiceClient())
                {
                    service.EditOrder(order); 
                    return RedirectToAction("Index");
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            using(var service = new ServiceModeloNegocio.ServiceClient())
            {
                var order = service.GetOrderById(id);
                return View(order);
            }
            
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
               using(var service = new ServiceModeloNegocio.ServiceClient())
                {
                    var order = service.GetOrderById(id);
                    service.DeleteOrder(order);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }
    }
}
