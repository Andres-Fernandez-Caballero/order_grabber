using Data_Service.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace Data_Service.Intefaz
{
    [ServiceContract]
    public interface IControllerProduct
    {
        [OperationContract]
        List<Product> GetAllProducts();

        [OperationContract]
        Product GetProductById(int id);

        [OperationContract]
        void CreateProduct(Product product);

        [OperationContract]
        void EditProduct(Product product);

        [OperationContract]
        void DeleteProduct(Product product);
    }
}
