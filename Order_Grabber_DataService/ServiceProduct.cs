using Order_Grabber_DataService.Interfaz;
using Order_Grabber_DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Order_Grabber_DataService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ServiceProduct : IProductControl
    {
        public void Create(Product new_element)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product element)
        {
            throw new NotImplementedException();
        }

        public void Edit(Product element)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetBy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
