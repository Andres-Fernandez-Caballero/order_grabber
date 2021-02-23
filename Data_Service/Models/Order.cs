using Data_Service.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Data_Service.Models
{
    [
        Serializable, 
        DataContractAttribute(IsReference =true)
    ]
    public class Order
    {

        public Order()
        {
            //Customer = new Customer();
        }


        // Clave Primaria
        [DataMember]
        public int OrderID { get; set; }

        // Fecha de creacion de la orden
        //[DataType(DataType.Date)]
        [DataMember]
        public DateTime Order_date { get; set; }

        // Estado de la orden
        [DataMember]
        public Estado Estado { get; set; }

        // clave foranea
        [DataMember]
        public int CustomerID { get; set; }

        // Referencia al cliente
        [ForeignKey(nameof(CustomerID)),DataMember]
        public Customer Customer { get; set; }
        [DataMember]
        public ICollection<OrderDetail> Details { get; set; }
        
    }

    public class OrderDetail
    {
        // Clave Primaria
        [DataMember]
        public int OrderDetailID { get; set; }
        
        // Clave Foranea hacia la tabla Orders
        [ForeignKey("Order"), DataMember]
        public int? OrderID { get; set; }
        [DataMember]
        public Order Order { get; set; }
        
        // Clave Foranea hacia la tabla Products
        [ForeignKey("Product"), DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public Product Product { get; set; }

        [DataMember]
        public int Quantity { get; set; }

    }
}
