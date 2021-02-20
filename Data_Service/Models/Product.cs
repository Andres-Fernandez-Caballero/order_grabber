using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Data_Service.Models

{
    [DataContract]
    public class Product
    {
        // Clave Primaria
        [DataMember]
        public int ProductID { get; set; }

        // Codigo del producto para reconocimiento interno
        [StringLength(50), Required]
        [DataMember]
        public string Product_code { get; set; }

        // Nombre del producto
        [StringLength(100), Required]
        [DataMember]
        public string Product_name { get; set; }

        // valor de compra del producto
        [DataMember]
        public double Cost_price { get; set; }

        // porcentaje de ganancia sobre el costo del producto
        [DataMember]
        public double Gain { get; set; }

        // Estado del producto en referencia a la disponibilidad
        [DataMember]
        public Estado Estado { get; set; }
    }
}
