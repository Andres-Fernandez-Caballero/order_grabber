using DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Controllers
{
    public class CustomerController
    {
        public void Create(Customer customer)
        {
            using(var service = new ServiceModeloNegocios.ServiceClient())
            {
                var c_database = new ServiceModeloNegocios.Customer()
                {
                    Customer_name = customer.Customer_name,
                    Address = customer.Address,
                    Document_type = (ServiceModeloNegocios.TipoDocumento)customer.Document_type,
                    Document_nro = customer.Document_nro,
                    Email = customer.Email,
                    Phone = customer.Phone,
                    Estado = ServiceModeloNegocios.Estado.ACTIVO
                };

                service.CreateCustomer(c_database);
            }
        }

        public void Delete(int id)
        {
            using(var service = new ServiceModeloNegocios.ServiceClient())
            {
                var customer = service.GetCustomerById(id);
                service.DeleteCustomer(customer);
            }
        }

        public void Edit(Customer customer)
        {
            using(var service = new ServiceModeloNegocios.ServiceClient())
            {
                var c_database = new ServiceModeloNegocios.Customer
                {
                    CustomerID = customer.CustomerID,
                    Customer_name = customer.Customer_name,
                    Address = customer.Address,
                    Document_type = (ServiceModeloNegocios.TipoDocumento)customer.Document_type,
                    Document_nro = customer.Document_nro,
                    Email = customer.Email,
                    Phone = customer.Phone,
                    Estado = (ServiceModeloNegocios.Estado)customer.Estado
                };

                service.EditCustomer(c_database);
            }
        }

        public ICollection<Customer> GetAll()
        {
            using(var service = new ServiceModeloNegocios.ServiceClient())
            {
                var cs_database = service.GetAllCustomers();

                var customers = new List<Customer>();

                foreach (var c_database in cs_database)
                {
                    customers.Add(
                        new Customer
                        {
                            CustomerID = c_database.CustomerID,
                            Customer_name = c_database.Customer_name,
                            Address = c_database.Address,
                            Document_type = (TipoDocumento)c_database.Document_type,
                            Document_nro = c_database.Document_nro,
                            Email = c_database.Email,
                            Phone = c_database.Phone,
                            Estado = (Estado)c_database.Estado
                        }
                    );
                }
                return customers;
            }
        }

        public Customer GetT(int id)
        {
            throw new NotImplementedException();
        }
    }
}
