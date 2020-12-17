using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Order_Grabber_DataService.Models
{
    [DataContract]
    public class Customer
    {
        [Key]
        [DataMember]
        public int client_id { get; set; }
        [StringLength(10)]
        [DataMember]
        public String document_type { get; set; }
        [StringLength(20)]
        [DataMember]
        public String document_nro { get; set; }
        [StringLength(255)]
        [DataMember]
        public String customer_name { get; set; }
        [StringLength(255)]
        [DataMember]
        public String address { get; set; }
        [StringLength(100)]
        [DataMember]
        public String phone { get; set; }
        [StringLength(255)]
        [DataMember]
        public String email { get; set; }
        [StringLength(10)]
        [DataMember]
        public String estado { get; set; }
        [DataMember]
        public List<Order> orders { get; set; }

    }
}
