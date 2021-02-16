using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Order_Grabber_DataService.Models
{
    [DataContract]
    public class Order
    {
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
        [DataMember]
        public virtual Customer Customer { get; set; }
        //public virtual ICollection<OrderDetail> details { get; set; }
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
        public Product product { get; set; }
    }
}
