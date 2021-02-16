using Order_Grabber_DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Order_Grabber_DataService.Interfaz
{
    [ServiceContract] // si hereda de un service contract deberia ser un service contract pero tira error si no lo pongo...
    public interface ICustomerControl: IControlable<Customer>
    {
        /*
        [OperationContract]
        List<Order> GetAllOrders();
        [OperationContract]
        Order GetOrderBy(int id);
        */

    }
}
