using DesktopApp.Pages;
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

namespace DesktopApp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new HomePage();
        }

        private void Button_Click_Home_page(object sender, RoutedEventArgs e)
        {
            Main.Content = new HomePage();
        }

        private void Button_Click_Customers_page(object sender, RoutedEventArgs e)
        {
            Main.Content = new CustomersPage();
        }

        private void Button_Click_Orders_page(object sender, RoutedEventArgs e)
        {
            // Main.Content = new OrdersPage();
            MessageBox.Show("Vista no disponible actualemnte.");
        }

        private void Button_Click_Products_page(object sender, RoutedEventArgs e)
        {
            // Main.Content = new ProductsPage();
            MessageBox.Show("Vista no disponible actualemnte.");
        }
    }
}
