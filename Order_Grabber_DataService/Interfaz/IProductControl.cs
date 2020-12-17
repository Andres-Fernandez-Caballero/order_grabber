using Order_Grabber_DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Order_Grabber_DataService.Interfaz
{
    [ServiceContract]
    interface IProductControl: IControlable<Product>
    {
        
    }
}
