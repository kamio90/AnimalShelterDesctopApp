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
    /// Logika interakcji dla klasy AnimalShelterDogs.xaml
    /// </summary>
    public partial class AnimalShelterDogs : Page
    {
        private AnimalShelterDatabaseDataSet _databaseEntities = new AnimalShelterDatabaseDataSet();

        public AnimalShelterDogs()
        {
            InitializeComponent();
            MessageBox.Show(_databaseEntities.Dogs.NameColumn.ToString());
        }

        private void AddDogButtonClick(object sender, RoutedEventArgs e)
        {
            AnimalShelterAddDogPage animalShelterAddDogPage = new AnimalShelterAddDogPage();
            this.NavigationService?.Navigate(animalShelterAddDogPage);
        }
    }
}