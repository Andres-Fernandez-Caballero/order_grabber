using ApiWeb.ServiceModeloNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiWeb.Controllers
{
    public class CustomersController : ApiController
    {
        // GET api/Customers
        /// <summary>
        /// Trae todos los clientes registrados.
        /// </summary>
        /// <remarks>
        /// Trae todos los clientes registados en la plataforma.
        /// </remarks>
        /// <returns>customers</returns>
        [HttpGet]
        public IList<Customer> Get()
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                var customers = service.GetAllCustomers();
                return customers;
            }
        }

        // GET api/Customer
        /// <summary>
        /// Devuelve un cliente 
        /// </summary>
        /// <remarks>Devuelve un cliente en base a su id</remarks>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public Customer Get(int id)
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                var customer = service.GetCustomerById(id);
                return customer;
            }
        }

        // POST api/Customers
        /// <summary>
        /// Crea un cliente nuevo
        /// </summary>
        /// <remarks>
        /// Crea un cliente nuevo y su estado sera activo sin ordenes relacionadas.
        /// Tipo de documento:
        /// * o => DNI
        /// * 1 => LIBRETA_ENRROLAMIENTO
        /// </remarks>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage Post( Customer customer
            /*
              string Customer_name
            , string Customer_address
            , TipoDocumento tipoDocumento
            , string document_nro
            , string Email
            , string Phone
            */
            )
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                try
                {   /*
                    var customer = new Customer
                    {
                        Customer_name = Customer_name,
                        Address = Customer_address,
                        Document_type = tipoDocumento,
                        Document_nro = document_nro,
                        Email = Email,
                        Phone = Phone,
                        Estado = Estado.ACTIVO
                    };
                   */
                    customer.Estado = Estado.ACTIVO;

                    service.CreateCustomer(customer);
                    return Request.CreateResponse<Customer>(HttpStatusCode.Created, customer);
                    
                }catch(Exception e)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
                }
            }
        }

        // PUT api/Customers/5
        /// <summary>
        /// Edita un cliente
        /// </summary>
        /// <remarks>
        /// Edita un cliente especifico sin afectar sus ordenes.
        /// </remarks>
        /// <param name="customer"></param>
        [HttpPut]
        public HttpResponseMessage Put([FromBody] Customer customer)
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                service.EditCustomer(customer);
                return Request.CreateResponse<Customer>(HttpStatusCode.OK, customer);
            }
        }

        // DELETE api/Customers/5
        /// <summary>
        /// Elimina un cliente.
        /// </summary>
        /// <remarks>
        /// Elimina un cliente especifico por referencia de su id.
        /// </remarks>
        /// <param name="id"></param>
        /// /// <returns>Retorna en caso de exito un codigo 410(Gone) y el objeto eliminado</returns>
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            using (var service = new ServiceModeloNegocio.ServiceClient())
            {
                var customer = service.GetCustomerById(id);
                service.DeleteCustomer(customer);
                return Request.CreateResponse(HttpStatusCode.Gone);
            }
        }
    }
}