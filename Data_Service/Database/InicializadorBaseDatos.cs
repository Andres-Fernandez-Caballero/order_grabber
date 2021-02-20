using Data_Service.Models;
using System;
using System.Collections.Generic;

namespace Data_Service.Database
{
    /***    Esta clase la cree con la idea de que herede de los metodos de sembrado de datos del entity framework
     *      pero no pude hacerlo andar con el metodo Database.SetInitializer(new InicializadorBaseDatos()),
     *      por lo que para darle algo de orden al codigo genero los datos de prueba en unos metodos estaticos
     *      y los cargo en el metodo seed de la clase configuration de las migraciones.
     * ***/
    public class InicializadorBaseDatos : System.Data.Entity.DropCreateDatabaseIfModelChanges<ContextGrabber>
    {
        public static List<Customer> GetCustomers()
        {
            var Customers = new List<Customer>
            {
                new Customer { Customer_name = "Andres", Address = "Guardia nacional 566", Document_type = TipoDocumento.DNI, Document_nro = "32.47.57.60", Email = "andres.fernandezcaballero@davinci.edu.ar", Phone = "1136759311", Estado = Estado.ACTIVO },
                new Customer { Customer_name = "Ornella", Address = "Escalada 150", Document_type = TipoDocumento.DNI, Document_nro = "98.879.972", Email = "ornecurio@gmail.com", Phone = "11697845", Estado = Estado.ACTIVO },
                new Customer { Customer_name = "Gerardo", Address = "Hipolito Irigoyen 469", Document_type = TipoDocumento.DNI, Document_nro = "33.56.45.69", Email = "meyclan@gmail.com", Phone = "1136759311", Estado = Estado.ACTIVO }
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
                new Product{Product_code = "m-001", Product_name = "Cinta falletina", Cost_price = 50, Gain = 100, Estado = Estado.ACTIVO },
                new Product{Product_code = "m-002", Product_name = "Cinta Raso", Cost_price = 60, Gain = 100, Estado = Estado.ACTIVO },
                new Product{Product_code = "m-003", Product_name = "Cono 4000 mts", Cost_price = 200, Gain = 100, Estado = Estado.ACTIVO },
                new Product{Product_code = "m-004", Product_name = "hilo mediano", Cost_price = 30, Gain = 100, Estado = Estado.ACTIVO },
                new Product{Product_code = "m-005", Product_name = "hilo chico", Cost_price = 10, Gain = 100, Estado = Estado.ACTIVO },
                new Product{Product_code = "m-006", Product_name = "rollo elastico ancho", Cost_price = 200, Gain = 100, Estado = Estado.ACTIVO },
                new Product{Product_code = "m-007", Product_name = "rollo elastico mediano", Cost_price = 200, Gain = 100, Estado = Estado.ACTIVO },
                new Product{Product_code = "m-008", Product_name = "rollo elastico fino", Cost_price = 100, Gain = 100, Estado = Estado.ACTIVO },
                new Product{Product_code = "m-009", Product_name = "paquete aguja x 10", Cost_price = 40, Gain = 100, Estado = Estado.ACTIVO },
                new Product{Product_code = "m-010", Product_name = "cinta navideña", Cost_price = 60, Gain = 100, Estado = Estado.ACTIVO }
            };

            return Products;
        }

        protected override void Seed(ContextGrabber context)
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
