using ApiWeb.ServiceModeloNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiWeb.Controllers
{
    public class OrdersController : ApiController
    {
        // GET api/Orders
        /// <summary>
        /// Trae todos las ordenes registradas en la plataforma.
        /// </summary>
        /// <remarks>
        /// Trae todas las ordenes y sus detalles anidados.
        /// </remarks>
        /// <returns>Order list</returns>
        [HttpGet]
        public IList<Order> Get()
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                var orders = service.GetAllOrders();
                return orders;
            }
        }

        // GET api/Orders/5
        /// <summary>
        /// Devuelve una orden.
        /// </summary>
        /// <remarks>
        /// Devuelve una orden y su lista de OrdenDetail asociada.
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>Order</returns>
        [HttpGet]
        public Order Get(int id)
        {
            using(var service = new ServiceModeloNegocio.ServiceClient())
            {
                var order = service.GetOrderById(id);
                return order;
            }    
        }

        // POST api/Orders
        /// <summary>
        /// Crea una Orden nueva
        /// </summary>
        /// <remarks>
        /// Crea una Orden nueva y los detalles asociados a ella.
        /// </remarks>
        /// <param name="order"></param>
        [HttpPost]
        public HttpResponseMessage Post(Order order)
        {
            using(var service = new ServiceModeloNegocio.ServiceClient())
            {
                order.Estado = Estado.ACTIVO; //TODO: ahora q lo pienso esto podria ponerlo en el service data...
                service.CreateOrder(order);
                return Request.CreateResponse<Order>(HttpStatusCode.Created, order);
            }
        }

        // PUT api/Orders/5
        /// <summary>
        /// Edita una orden
        /// </summary>
        /// <remarks>
        /// Edita una orden y sus respectivos detalles asociados.
        /// </remarks>
        /// <param name="order"></param>
        [HttpPut]
        public HttpResponseMessage Put(Order order)
        {
            using(var service = new ServiceModeloNegocio.ServiceClient())
            {
                service.EditOrder(order);
                return Request.CreateResponse<Order>(HttpStatusCode.OK, order);
            }
        }

        // DELETE api/Orders/5
        /// <summary>
        /// Elimina una orden
        /// </summary>
        /// <remarks>
        /// ELimina una orden y todos sus detalles sin afectar a los productos o clientes asociados.
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>Retrona en caso de exito un mensaje 410(Gone) y el objeto eliminado</returns>
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                var order = service.GetOrderById(id);
                service.DeleteOrder(order);
                return Request.CreateResponse<Order>(HttpStatusCode.Gone, order);
            }
        }
    }
}