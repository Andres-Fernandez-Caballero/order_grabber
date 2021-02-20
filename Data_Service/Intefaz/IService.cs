using Data_Service.Intefaz;
using System.ServiceModel;

namespace Data_Service.Interfaz

{
    [ServiceContract]
    public interface IService : IControllerCustomer, IControllerProduct, IControllerOrder
    {
    }
}
