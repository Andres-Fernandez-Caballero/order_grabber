using Order_Grabber_Web.ServiceCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Order_Grabber_Web.Controllers
{
    /// <explicacion>
    /// dentro del servicio dejo la ruta larga para mostrar de donde viene el servicio sino es un caos.
    /// </explicacion>
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            using(var service = new CustomerControlClient())
            {
                var customers = service.GetAll();
                return View(customers);
            }
            
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer new_customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var service = new ServiceCustomer.CustomerControlClient())
                    {
                        service.Create(new_customer);
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                Console.WriteLine("Error al crear el modelo"); // TODO: deberia hacerse mas lindo mas tarde
                return RedirectToAction("index");
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
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

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
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
}
