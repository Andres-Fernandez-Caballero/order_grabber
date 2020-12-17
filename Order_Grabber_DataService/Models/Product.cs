using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Order_Grabber_DataService.Models
{
    [DataContract]
    public class Product
    {
        [Key]
        [DataMember]
        public int product_id { get; set; }
        [StringLength(50)]
        [DataMember]
        public String product_code { get; set; }
        [StringLength(100)]
        [DataMember]
        public String product_name { get; set; }
        [DataMember]
        public double cost_price { get; set; }
        [DataMember]
        public double gain { get; set; }
        [StringLength(50)]
        [DataMember]
        public String estado { get; set; }
    }
}
