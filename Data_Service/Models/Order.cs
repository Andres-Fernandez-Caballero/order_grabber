using Data_Service.Database;
using System;
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
        //public virtual ICollection<OrderDetail> details { get; set; }
        [OperationContract]
       
        public Customer GetCustomer()
        {
            return this.Customer;
        }
    }

    public class OrderDetail
    {
        [DataMember]
        public int OrderDetailID { get; set; }
        [DataMember]
        public int order_id { get; set; }
        [ForeignKey("order_id")]
        [DataMember]
        public Order order { get; set; }
        [DataMember]
        public int quantity { get; set; }
        [DataMember]
        public int product_id { get; set; }
        [ForeignKey("product_id")]
        [DataMember]
        public virtual Product product { get; set; }

       
    }
}
