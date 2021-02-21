using System.Collections.Generic;
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
            ViewBag.EstadosCustomer = GetEstadosCustomer();
            ViewBag.TipoDocumentos = GetTipoDocumentos();
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
                    customer.Estado = Estado.ACTIVO; //un cliente deberia estar activo cuando se crea...
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

                ViewBag.EstadosCustomer = GetEstadosCustomer();
                ViewBag.TipoDocumentos = GetTipoDocumentos();
                ViewBag.EstadoDelCustomer = customer.Estado;
                ViewBag.TipoDocumentoCustomer = customer.Document_type;

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

        private List<Estado> GetEstadosCustomer()
        {
            return new List<Estado> { Estado.ACTIVO, Estado.INACTIVO };
        }

        private List<TipoDocumento> GetTipoDocumentos()
        {
            return new List<TipoDocumento> { TipoDocumento.DNI, TipoDocumento.LIBRETA_ENROLAMIENTO };
        }
    }   
}
