using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Data_Service.Models
{
    [DataContract]
    public class Customer
    {
        // Clave Primaria
        [DataMember]
        public int CustomerID { get; set; }

        // tipo de documento 
        [DataMember]
        public TipoDocumento? Document_type { get; set; }

        // Numero de documento
        [StringLength(20), Required]
        [DataMember]
        public string Document_nro { get; set; }

        // Nombre completo del cliente
        [StringLength(255), Required]
        [DataMember]
        public string Customer_name { get; set; }

        // Direccion Fiscal del cliente
        [StringLength(255), Required]
        [DataMember]
        public string Address { get; set; }

        // Telefono de contacto del cliente
        [StringLength(100)]
        [DataMember]
        public string Phone { get; set; }

        // Email del cliente
        [StringLength(255), Required]
        [DataMember]
        public string Email { get; set; }

        // Estado del cliente respecto a la empresa
        [DataMember]
        public Estado? Estado { get; set; }

        // Ordenes
        [DataMember]
        public ICollection<Order> Orders { get; set; }

    }

    [DataContract]
    public enum TipoDocumento
    {
        [EnumMember]
        DNI,
        [EnumMember]
        LIBRETA_ENROLAMIENTO
    }
}
