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
        [Key]
        [DataMember]
        public int order_id { get; set; }
        [DataType(DataType.Date)]
        [DataMember]
        public DateTime order_date { get; set; }
        [StringLength(10)]
        [DataMember]
        public String estado { get; set; }
        [DataMember]
        public int client_id { get; set; }
        [ForeignKey("client_id")] 
        [DataMember]
        public Customer Customer { get; set; }
        public List<OrderDetail> details { get; set; }
    }

    public class OrderDetail
    {
        [Key]
        [DataMember]
        public int line_id { get; set; }
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
