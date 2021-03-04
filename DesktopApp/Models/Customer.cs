using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public TipoDocumento? Document_type { get; set; }
        
        public string Document_nro { get; set; }

        public string Customer_name { get; set; }

        public string Address { get; set; }
        
        public string Phone { get; set; }

        public string Email { get; set; }

        public Estado Estado { get; set; }

        public ICollection<Order> Orders { get; set; }
    }

    public enum TipoDocumento
    {
        DNI,
        LIBRETA_ENROLAMIENTO
    }
}
