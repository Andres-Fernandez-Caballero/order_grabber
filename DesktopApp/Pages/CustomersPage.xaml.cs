using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DesktopApp.Controllers;
using DesktopApp.Models;

namespace DesktopApp.Pages
{
    /// <summary>
    /// Lógica de interacción para CustomersPage.xaml
    /// </summary>
    public partial class CustomersPage : Page
    {
        public CustomersPage()
        {
            InitializeComponent();
            var customerController = new CustomerController();
            var customers = customerController.GetAll();
            CustomersList.ItemsSource = customers;

            // cargo los ComboBox con una lista de enumerados posibles.
            Estado_list.ItemsSource = GetListEstados();
            TipoDocumentoList.ItemsSource = GetListTipoDocumentos();

            TipoDocumentoList.Text = TipoDocumento.DNI.ToString(); // valor por defecto al crear

            SetCamposCustomer(null);
            SetModo(Modo.LECTURA);
        }

        /// <summary>
        /// Evento al seleccionar un intem de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            SetModo(Modo.LECTURA);

            this.Botonera_acciones.Visibility = Visibility.Visible;
            this.TEstado.Visibility = Visibility.Visible;

            var customer = CustomersList.SelectedItem as Customer;

            if(customer != null)
            {
                //poblar campos de texto
                SetCamposCustomer(customer);
            }
        }

        private void Button_Click_Add_Customer(object sender, RoutedEventArgs e)
        {
            SetModo(Modo.CREACION);             
        }

        private void Button_Click_Edit_Customer(object sender, RoutedEventArgs e)
        {
            SetModo(Modo.EDICION);
        }

        private void Button_Click_Delete_Customer(object sender, RoutedEventArgs e)
        {
            var customer = CustomersList.SelectedItem as Customer;
            var result = MessageBox.Show
                (
                    "Realmente deseas eliminar a " + customer.Customer_name + "?" // mensaje a mostrar
                    ,"Eliminar" //Titulo del mensaje
                    ,MessageBoxButton.YesNo 
                    ,MessageBoxImage.Question // icono que representa la accion en el mensaje
                );

            

            if (result == MessageBoxResult.Yes)
            {
                var customerController = new CustomerController();
                customerController.Delete(customer.CustomerID);
                MessageBox.Show("El cliente fue eliminado correctamente");

                CustomersList.ItemsSource = customerController.GetAll();
                CustomersList.Items.Refresh();
                SetModo(Modo.LECTURA);
                SetCamposCustomer(null);
            }
        }

        private void Button_Click_Save_Customer(object sender, RoutedEventArgs e)
        {
            if (
                   TCustomer_name.Text.Equals("")
                || TAddress.Text.Equals("")
                || TDocument_nro.Equals("")
                || TEmail.Text.Equals("")
                || TPhone.Text.Equals("")
               )
            {
                MessageBox.Show("Deben completarse todos los campos!");
            }
            else
            {
                var customer = GetCamposCustomer(); // leo y cargo todos los valores de los campos en un objeto Customer
                var customerController = new CustomerController();

                if (this.TCustomerID.Text.Equals(Modo.CREACION.ToString()))
                {
                    customerController.Create(customer);
                }
                else
                {
                    customerController.Edit(customer);
                }
                
                
                CustomersList.ItemsSource = customerController.GetAll();    //vuelvo a cargar todos los customers
                MessageBox.Show("Cliente Guardado!!!");
                CustomersList.Items.Refresh();
                SetModo(Modo.LECTURA);
                SetCamposCustomer(customer);
            }
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            SetModo(Modo.LECTURA);
            SetCamposCustomer(null);
            
        }

        private List<Estado> GetListEstados() 
        {
            return new List<Estado> { Estado.ACTIVO, Estado.INACTIVO };
        }

        private List<TipoDocumento> GetListTipoDocumentos()
        {
            return new List<TipoDocumento> { TipoDocumento.DNI, TipoDocumento.LIBRETA_ENROLAMIENTO };
        }

        private Customer GetCamposCustomer()
        {
            var customer = new Customer();
            if (!TCustomerID.Text.Equals(Modo.CREACION.ToString()))
            {
                customer.CustomerID = int.Parse(TCustomerID.Text);
            }
            customer.Customer_name = TCustomer_name.Text;
            customer.Address = TAddress.Text;
            customer.Document_nro = TDocument_nro.Text;
            customer.Email = TEmail.Text;
            customer.Phone = TPhone.Text;

            if (this.TipoDocumentoList.Text.Equals(TipoDocumento.DNI.ToString()))
            {
                customer.Document_type = TipoDocumento.DNI;
            }
            else
            {
                customer.Document_type = TipoDocumento.LIBRETA_ENROLAMIENTO;
            }

            if (this.Estado_list.Text.Equals(Estado.ACTIVO.ToString()))
            {
                customer.Estado = Estado.ACTIVO;
            }
            else
            {
                customer.Estado = Estado.INACTIVO;
            }
            return customer;
            
        }

        /// <summary>
        /// Recibe un objeto customer y completa los campos
        /// si recibe un customer = null los campos se mostraran vacios
        /// esto permite el reciclaje de codigo
        /// </summary>
        /// <param name="customer"></param>
        private void SetCamposCustomer(Customer customer) {
            
            if(customer != null)
            {
                if(customer.CustomerID > 0)
                {
                    this.TCustomerID.Text = customer.CustomerID.ToString();
                }
                this.TCustomer_name.Text = customer.Customer_name;
                this.TDocument_type.Text = customer.Document_type.ToString();
                this.TDocument_nro.Text = customer.Document_nro;
                this.TAddress.Text = customer.Address;
                this.TEmail.Text = customer.Email;
                this.TPhone.Text = customer.Phone;

                if (customer.Estado.Equals(Estado.ACTIVO))
                {
                    this.TEstado.Foreground = new SolidColorBrush(Colors.Green);
                }
                else
                {
                    this.TEstado.Foreground = new SolidColorBrush(Colors.Red);
                }
                this.TEstado.Text = customer.Estado.ToString();
            }
            else
            {
                this.TCustomerID.Text = Modo.CREACION.ToString();
                this.TCustomer_name.Text = "";
                this.TDocument_type.Text = "";
                this.TDocument_nro.Text = "";
                this.TAddress.Text = "";
                this.TEmail.Text = "";
                this.TPhone.Text = "";
                this.TEstado.Text = "";
            }
        }

        private void SetModo(Modo modo)
        {
            switch (modo) {
                case Modo.CREACION:

                    // gestion de contenido visible y oculto.
                    this.Button_Add.Visibility = Visibility.Collapsed;  // oculto el boton crear
                    this.Button_Save.Visibility = Visibility.Visible;   // muestro el boton guardar
                    this.Botonera_acciones.Visibility = Visibility.Hidden; // oculto toda la botonera de acciones
                    this.CampoEstado.Visibility = Visibility.Hidden; // oculto todo el campo de estado
                    this.Button_Cancel.Visibility = Visibility.Visible; // muestro el boton cancelar

                    // habilito la edicion de campos
                    CamposEditables(true);
                    this.TipoDocumentoList.Text = TipoDocumento.DNI.ToString(); // pongo como valor por defecto

                    // limpio los contenedores TODO: hacer un metodo para limpiarlos...
                    SetCamposCustomer(null);
                    break;

                case Modo.EDICION:

                    // gestion de contenido visible y oculto
                    this.Button_Add.Visibility = Visibility.Collapsed; // oculto el boton agregar
                    this.Button_Save.Visibility = Visibility.Visible; // muestro el boton guardar
                    this.Button_Cancel.Visibility = Visibility.Visible; // muestro el boton cancelar

                    this.Botonera_acciones.Visibility = Visibility.Collapsed;

                    CamposEditables(true);

                    var customerSelected = (this.CustomersList.SelectedItem as Customer);
                    this.Estado_list.Text =customerSelected.Estado.ToString();
                    this.TipoDocumentoList.Text = customerSelected.Document_type.ToString();
                    break;
                    
                case Modo.LECTURA:
                    
                    this.Button_Add.Visibility = Visibility.Visible;
                    this.Button_Save.Visibility = Visibility.Collapsed;
                    this.Button_Cancel.Visibility = Visibility.Collapsed;
                   
                    this.Botonera_acciones.Visibility = Visibility.Collapsed;
                    this.CampoEstado.Visibility = Visibility.Visible;

                    CamposEditables(false);
                    break;
            }
        }

        private void CamposEditables(bool isEnable)
        {
            bool Estado = !isEnable;

            TCustomer_name.IsReadOnly = Estado;
            TDocument_nro.IsReadOnly = Estado;
            TAddress.IsReadOnly = Estado;
            TPhone.IsReadOnly = Estado;
            TEmail.IsReadOnly = Estado;

            if (isEnable)
            {
                TDocument_type.Visibility = Visibility.Collapsed;
                TipoDocumentoList.Visibility = Visibility.Visible;

                TEstado.Visibility = Visibility.Collapsed;
                Estado_list.Visibility = Visibility.Visible;
            }
            else
            {
                TDocument_type.Visibility = Visibility.Visible;
                TipoDocumentoList.Visibility = Visibility.Collapsed;

                TEstado.Visibility = Visibility.Visible;
                Estado_list.Visibility = Visibility.Collapsed;
            }
        }

        private enum Modo
        {
            CREACION, EDICION, LECTURA
        }

    }
}

