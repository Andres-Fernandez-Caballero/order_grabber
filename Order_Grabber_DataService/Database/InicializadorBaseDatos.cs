using Order_Grabber_DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Grabber_DataService.Database
{
    /***    Esta clase la cree con la idea de que herede de los metodos de sembrado de datos del entity framework
     *      pero no pude hacerlo andar con el metodo Database.SetInitializer(new InicializadorBaseDatos()),
     *      por lo que para darle algo de orden al codigo genero los datos de prueba en unos metodos estaticos
     *      y los cargo en el metodo seed de la clase configuration de las migraciones.
     * ***/
    public class InicializadorBaseDatos: System.Data.Entity.DropCreateDatabaseIfModelChanges<ModelContext>
    {
        public static List<Customer> GetCustomers()
        {
            var Customers = new List<Customer>
            {
                new Customer { Customer_name = "Andres", Address = "Guardia nacional 566", Document_type = TipoDocumento.DNI, Document_nro = "32.47.57.60", Email = "andres.fernandezcaballero@davinci.edu.ar", Phone = "1136759311", Estado = Estado.ACTIVO }
            };

            return Customers;
        }

        public static List<Order> GetOrders()
        {
            var Orders = new List<Order>
            {
                new Order{CustomerID = 1, Estado = Estado.ACTIVO, Order_date = DateTime.Now}
            };
            return Orders;
        }

        public static List<Product> GetProducts()
        {
            var Products = new List<Product>
            {
                new Product{Product_code = "m-001", Product_name = "Cinta falletina", Cost_price = 50, Gain = 100, Estado = Estado.ACTIVO }
            };

            return Products;
        }

        protected override void Seed(ModelContext context)
        {
            var Customers = new List<Customer>
            {
                new Customer {CustomerID = 1, Customer_name = "Andres", Address = "Guardia nacional 566", Document_type = TipoDocumento.DNI, Document_nro = "32.47.57.60", Email = "andres.fernandezcaballero@davinci.edu.ar", Phone = "1136759311", Estado = Estado.ACTIVO }
            };


            Customers.ForEach(c => context.Customers.Add(c));
            //context.SaveChanges();

            base.Seed(context);
        }
    }
}
