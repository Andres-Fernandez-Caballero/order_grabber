using System.Web.Mvc;
using WebApp.ServiceModeloNegocio;

namespace WebApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                var Customers = service.GetAllCustomers();


                return View(Customers);
            }
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                var customer = service.GetCustomerById(id);
                return View(customer);
            }
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                using (var service = new ServiceModeloNegocio.ServiceClient())
                {
                    service.CreateCustomer(customer);
                    return RedirectToAction("Index");
                }

            }
            catch
            {
                return View("Index");
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                var customer = service.GetCustomerById(id);
                return View(customer);
            }

        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(Customer Customer)
        {
            try
            {
                using (var service = new ServiceModeloNegocio.ServiceClient())
                {
                    service.EditCustomer(Customer);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                var customer = service.GetCustomerById(id);
                return View(customer);
            }

        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (var service = new ServiceModeloNegocio.ServiceClient())
                {
                    var customer = service.GetCustomerById(id);
                    service.DeleteCustomer(customer);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View("Index");
            }
        }
    }
}
