using System.Collections.Generic;
using System.Web.Mvc;
using WebApp.ServiceModeloNegocio;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                var products = service.GetAllProducts();
                return View(products);
            }
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                var product = service.GetProductById(id);
                return View(product);
            }

        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.Estados = GetEstadosDisponibles();
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                using (var service = new ServiceModeloNegocio.ServiceClient())
                {
                    service.CreateProduct(product);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                //hacer algo si sale mal...
                return View("index");
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                var product = service.GetProductById(id);

                ViewBag.Estados = GetEstadosDisponibles();
                return View(product);
            }

        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                using (var service = new ServiceModeloNegocio.ServiceClient())
                {
                    service.EditProduct(product);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                var product = service.GetProductById(id);
                return View(product);
            }

        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (var service = new ServiceModeloNegocio.ServiceClient())
                {
                    var product = service.GetProductById(id);
                    service.DeleteProduct(product);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View("Index");
            }
        }

        private List<Estado> GetEstadosDisponibles()
        {
            return new List<Estado> { Estado.ACTIVO, Estado.INACTIVO, Estado.SIN_STOCK };
        }
    }
}
