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

namespace AnimalShelterDesctopApp
{
    /// <summary>
    /// Logic for class AnimalShelterClients.xaml
    /// </summary>
    public partial class AnimalShelterClients : Page
    {
        private readonly AnimalShelterDatabaseEntities _databaseEntities = new AnimalShelterDatabaseEntities();
        /// <summary>
        /// Constructor for class AnimalShelterClients.xaml
        /// </summary>
        public AnimalShelterClients()
        {
            InitializeComponent();
            this.UpdateClients();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AnimalShelterClientsAddClientsPage animalShelterClientsAddClientsPage =
                new AnimalShelterClientsAddClientsPage();
            NavigationService?.Navigate(animalShelterClientsAddClientsPage);
        }

        private void UpdateClients()
        {
            var databaseData = from row in _databaseEntities.Clients select row;
            this.clientsDataGrid.ItemsSource = databaseData.ToList();
        }
    }
}
