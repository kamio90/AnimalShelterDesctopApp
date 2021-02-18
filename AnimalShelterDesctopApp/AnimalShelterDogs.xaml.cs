using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Logic for class AnimalShelterDogs
    /// </summary>
    public partial class AnimalShelterDogs : Page
    {
        private readonly AnimalShelterDatabaseEntities _databaseEntities = new AnimalShelterDatabaseEntities();

        /// <summary>
        /// Constructor of class AnimalShelterDogs
        /// </summary>
        public AnimalShelterDogs()
        {
            InitializeComponent();
            this.UpdateDogs();
        }

        private void AddDogButtonClick(object sender, RoutedEventArgs e)
        {
            AnimalShelterAddDogPage animalShelterAddDogPage = new AnimalShelterAddDogPage();
            this.NavigationService?.Navigate(animalShelterAddDogPage);
        }

        private void UpdateDogs()
        {
            var databaseData = from row in _databaseEntities.Dogs select row;
            this.dogsDataGrid.ItemsSource = databaseData.ToList();
        }
    }
}