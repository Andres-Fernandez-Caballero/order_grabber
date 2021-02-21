using Data_Service.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace Data_Service.Intefaz
{
    [ServiceContract]
    public interface IControllerCustomer
    {
        [OperationContract]
        List<Customer> GetAllCustomers();

        [OperationContract]
        List<Customer> GetListCustomersByEstado(Estado estado);

        [OperationContract]
        Customer GetCustomerById(int id);

        [OperationContract]
        void CreateCustomer(Customer customer);

        [OperationContract]
        void EditCustomer(Customer customer);

        [OperationContract]
        void DeleteCustomer(Customer customer);
    }
}
