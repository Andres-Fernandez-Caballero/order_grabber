using ApiWeb.ServiceModeloNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiWeb.Controllers
{
    public class ProductsController : ApiController
    {
        // GET api/Products
        /// <summary>
        /// Trae todos los productos registrados
        /// </summary>
        /// <remarks>
        /// Trae todos los productos registrados activos e inactivos y sin stock
        /// </remarks>
        /// <returns>Products</returns>
        [HttpGet]
        public IList<Product> Get()
        {
            using(var service = new ServiceModeloNegocio.ServiceClient())
            {
                var products = service.GetAllProducts();
                return products;
            }
        }

        // GET api/Products/5
        /// <summary>
        /// Devuelve un producto
        /// </summary>
        /// <remarks>
        /// Devuelve un cliente en base a su id
        /// </remarks>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public Product Get(int id)
        {
            using(var service = new ServiceModeloNegocio.ServiceClient())
            {
                var product = service.GetProductById(id);
                return product;
            }
        }

        // POST api/Products
        /// <summary>
        /// Crea un producto nuevo
        /// </summary>
        /// <remarks>
        /// Crea un producto nuevo y su estado sera activo por defecto.
        /// </remarks>
        /// <param name="product"></param>
        [HttpPost]
        public HttpResponseMessage Post(Product product)
        {
            using(var service = new ServiceModeloNegocio.ServiceClient())
            {
                service.CreateProduct(product);
                return Request.CreateResponse<Product>(HttpStatusCode.Created, product);
            }
        }

        // PUT api/Products/5
        /// <summary>
        /// Edita un producto
        /// </summary>
        /// <remarks>
        /// Edita un producto
        /// Estados:
        /// * 0: Activo.
        /// * 1: Inactivo.
        /// * 3: Sin Stock.
        /// </remarks>
        /// <param name="product"></param>
        [HttpPut]
        public HttpResponseMessage Put(Product product)
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                service.EditProduct(product);
                return Request.CreateResponse<Product>(HttpStatusCode.OK, product);
            }
        }

        // DELETE api/Products/5
        /// <summary>
        /// Elimina un producto.
        /// </summary>
        /// <remarks>
        /// Elimina un producto especifico referenciado por su id.
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>Retorna en caso de exito un codigo 410(Gone) y el objeto eliminado</returns>
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            using(var service = new ServiceModeloNegocio.ServiceClient())
            {
                var product = service.GetProductById(id);
                service.DeleteProduct(product);
                return Request.CreateResponse<Product>(HttpStatusCode.Gone, product);
            }
        }
    }
}