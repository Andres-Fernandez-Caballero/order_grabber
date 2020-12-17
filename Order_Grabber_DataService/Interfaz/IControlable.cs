using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Order_Grabber_DataService.Interfaz
{

    [ServiceContract]
    public interface IControlable<T>
    {
        [OperationContract]
        void Delete(T element);
        [OperationContract]
        void Edit(T element);
        [OperationContract]
        void Create(T new_element);
        [OperationContract]
        T GetBy(int id);
        [OperationContract]
        List<T> GetAll();
    }
}
