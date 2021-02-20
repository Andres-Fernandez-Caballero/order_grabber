using System.Runtime.Serialization;

namespace Data_Service.Models
{
    [DataContract]
    public enum Estado
    {
        [EnumMember]
        ACTIVO,
        [EnumMember]
        INACTIVO,
        [EnumMember]
        PENDIENTE,
        [EnumMember]
        SIN_STOCK
    }
}
