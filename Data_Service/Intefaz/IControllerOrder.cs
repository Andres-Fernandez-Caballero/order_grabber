using Data_Service.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace Data_Service.Intefaz
{
    [ServiceContract]
    public interface IControllerOrder
    {
        [OperationContract]
        List<Order> GetAllOrders();

        [OperationContract]
        Order GetOrderById(int id);

        [OperationContract]
        void CreateOrder(Order order);

        [OperationContract]
        void EditOrder(Order order);

        [OperationContract]
        void DeleteOrder(Order order);
    }
}
